namespace Bridge.Sanatorium.Services.Implement;

public class SanatoriumService : ISanatoriumService
{
    private readonly SemaphoreSlim _semaphore = new(1);

    private readonly IControl<ServiceBusOptions, BridgeEnvironment> _control;

    private readonly IEventBusService<PostingRequest> _eventBusService;

    private IEndpointInstance? _endpointInstance;

    private CancellationTokenSource _cancellationTokenSource = new();

    private CancellationToken _cancellationToken;

    public BridgeEnvironment Environment => _control.Environment;

    public SanatoriumService(IControl<ServiceBusOptions, BridgeEnvironment> control, IEventBusService<PostingRequest> eventBusService)
    {
        _control = control;
        _eventBusService = eventBusService;
        _cancellationToken = _cancellationTokenSource.Token;
        Connect(_control.Options);
    }

    public Task ChangedOptionsHandleAsync(ServiceBusOptions options)
    {
        Connect(options);
        throw new Exception("Restarting the service.");
    }

    public Task ChangedEnvironmentHandleAsync(BridgeEnvironment current, BridgeEnvironment previous) => Task.CompletedTask;

    private void Connect(ServiceBusOptions options) => new Thread(async () =>
    {
        _cancellationTokenSource.Cancel();

        await _semaphore.WaitAsync();

        if (_endpointInstance != null)
        {
            try
            {
                await _endpointInstance.Stop();
            }
            catch (Exception ex)
            {
                _control.Unactive(ex);
            }
        }

        if (_cancellationToken.IsCancellationRequested)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
        }

        try
        {
            await Task.Delay(TimeSpan.FromSeconds(Math.Max(options.ConnectionDelay, 0)), _cancellationToken);

            var endpointConfiguration = new EndpointConfiguration(options.Endpoint);
            endpointConfiguration.AssemblyScanner().ExcludeAssemblies("Logus.HMS.Messages");
            if (!string.IsNullOrEmpty(options.License))
                endpointConfiguration.License(options.License);
            endpointConfiguration.SendFailedMessagesTo("error");
            endpointConfiguration.AuditProcessedMessagesTo("audit");
            endpointConfiguration.UseSerialization<XmlSerializer>();
            var transport = endpointConfiguration.UseTransport(new SqlServerTransport(options.ConnectionString));
            if (!string.IsNullOrEmpty(options.ServerEndpoint))
                transport.RouteToEndpoint(typeof(PostTransactionsResponse), options.ServerEndpoint);
            endpointConfiguration.UsePersistence<NHibernatePersistence>().ConnectionString(options.ConnectionString);
            endpointConfiguration.PurgeOnStartup(false);
            endpointConfiguration.EnableInstallers();
            endpointConfiguration.DefineCriticalErrorAction((error, token) =>
            {
                _control.Unactive(error.Exception);
                Connect(options);
                return Task.CompletedTask;
            });

            endpointConfiguration.RegisterComponents(services => services
                .AddSingleton(_control)
                .AddSingleton(_eventBusService)); 

            _endpointInstance = await Task
                .Run(async () => await Endpoint.Start(endpointConfiguration, _cancellationToken))
                .WaitAsync(_cancellationToken);

            _control.Active();
        }
        catch (OperationCanceledException ex)
        {
            _control.Unactive(ex);
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
			Connect(options);
        }
        finally
        {
            _semaphore.Release();
        }
    }).Start();

    public void Exec(Action<IEndpointInstance?> action)
    {
        ArgumentNullException.ThrowIfNull(action, nameof(action));

        try
        {
            action.Invoke(_endpointInstance);
            _control.Active();
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
            throw;
        }
    }

    public T Exec<T>(Func<IEndpointInstance?, T> func)
    {
        ArgumentNullException.ThrowIfNull(func, nameof(func));

        try
        {
            var result = func.Invoke(_endpointInstance);
            _control.Active();
            return result;
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
            throw;
        }
    }
}

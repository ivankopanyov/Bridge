namespace Bridge.Services.Control;

public abstract class ServiceControl<TOptions> : IOptinable where TOptions : class, new()
{
    private protected readonly string _host;

    private protected readonly string _name;

    private protected readonly ServiceHost.ServiceHostClient _serviceHostClient;

    private protected readonly ILogger _logger;

    private CancellationTokenSource _cancellationTokenSource;

    private CancellationToken _cancellationToken;

    private Exception? _ex;

    private bool _isActive;

    private Exception? _currentException;
    private static TOptions DefaultOptions => Activator.CreateInstance<TOptions>();

    public TOptions Options { get; protected set; } = DefaultOptions;

    protected ServiceControl(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceOptions options, ILogger logger)
    {
        _host = options.Host;
        _name = options.Name;
        _serviceHostClient = serviceHostClient;
        _logger = logger;
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;

        eventService.GetServicesEvent += () => ToServiceInfo();

        eventService.SetOptionsEvent += async (options) =>
        {
            if (options.ServiceName != _name)
                return null;

            var response = new SetOptionsResponse();

            if (string.IsNullOrWhiteSpace(options.JsonOptions))
            {
                response.Ok = false;
                response.Error = "Options is null";
                return response;
            }

            try
            {
                var newOptions = JsonConvert.DeserializeObject<TOptions>(options.JsonOptions);
                if (newOptions != null)
                {
                    Options = newOptions;
                    await SetOptionsHandleAsync();

                    response.Ok = true;
                    response.Service = ToServiceInfo();
                }
                else
                {
                    response.Ok = false;
                    response.Error = "Options is null";
                }
            }
            catch (Exception ex)
            {
                response.Ok = false;
                response.Error = ex.Message;
            }

            return response;
        };
    }

    public async Task ActiveAsync()
    {
        if (_isActive && _currentException == null)
            return;

        _isActive = true;
        _currentException = null;
        _logger.LogActive(_name);
        await ChangeStateAsync();
    }

    public async Task UnactiveAsync(string error)
    {
        if (!_isActive && _currentException != null && _currentException.Message == error && _currentException.StackTrace == null)
            return;

        _isActive = false;
        _currentException = new Exception(error);
        _logger.LogUnactive(_name, _currentException.Message, _currentException);
        await ChangeStateAsync();
    }

    public async Task UnactiveAsync(Exception ex)
    {
        if (!_isActive && _currentException != null && _currentException.Message == ex.Message && _currentException.StackTrace == ex.StackTrace)
            return;

        _isActive = false;
        _currentException = ex;
        _logger.LogUnactive(_name, ex.Message, ex);
        await ChangeStateAsync();
    }

    private protected ServiceInfo ToServiceInfo()
    {
        var serviceInfo = new ServiceInfo()
        {
            Name = _name,
            HostName = _host,
            State = new ServiceState
            {
                IsActive = _isActive
            }
        };

        if (_currentException?.Message is string error)
            serviceInfo.State.Error = error;

        if (_currentException?.StackTrace is string stackTrace)
            serviceInfo.State.StackTrace = stackTrace; 
        
        try
        {
            var result = JsonConvert.SerializeObject(Options);
            if (result != null)
                serviceInfo.JsonOptions = result;
        }
        catch { }

        return serviceInfo;
    }

    private async Task ChangeStateAsync()
    {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;

        try
        {
            await SendServiceAsync(ToServiceInfo(), _cancellationToken);
        }
        catch (OperationCanceledException ex)
        {
            _logger.LogUnactive(_name, ex.Message, ex);
        }
    }

    private async Task SendServiceAsync(ServiceInfo service, CancellationToken cancellationToken) => await Task.Run(async () =>
    {
        try
        {
            await _serviceHostClient.SetServiceAsync(service);
            _ex = null;
        }
        catch (Exception ex)
        {
            if (_ex == null || _ex.Message != ex.Message || _ex.StackTrace != ex.StackTrace)
                _ex = ex;

            await Task.Delay(1000);
            await SendServiceAsync(service, cancellationToken);
        }
    }, cancellationToken).ConfigureAwait(false);

    async Task IOptinable.GetOptionsAsync() => await GetOptionsAsync(ToServiceInfo(), null);

    private async Task GetOptionsAsync(ServiceInfo service, Exception? currentExeption = null) => await Task.Run(async () =>
    {
        try
        {
            var options = await _serviceHostClient.GetOptionsAsync(service);

            if (options == null)
                Options = DefaultOptions;
            else
                try
                {
                    Options = JsonConvert.DeserializeObject<TOptions>(options.JsonOptions) ?? DefaultOptions;
                }
                catch
                {
                    Options = DefaultOptions;
                }

            await SetOptionsHandleAsync();
        }
        catch (Exception ex)
        {
            if (currentExeption == null || currentExeption.Message != ex.Message || currentExeption.StackTrace != ex.StackTrace)
                currentExeption = ex;

            await Task.Delay(1000);
            await GetOptionsAsync(service, currentExeption);
        }
    }).ConfigureAwait(false);

    protected virtual Task SetOptionsHandleAsync() => Task.CompletedTask;
}
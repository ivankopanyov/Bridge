namespace Bridge.Services.Control.Services.Implement;

internal class ControlStarter<TService, TOptions> : StarterBase where TService : IService<TOptions> where TOptions : class, new()
{
    private static readonly Lazy<ServiceControlSerializerSettings> _serializerSettings = new(() => new());

    private readonly ILogger _logger;

    private readonly IControl<TOptions> _control;

    private readonly string _hostName;

    private readonly string _serviceName;

    private protected readonly IServiceScopeFactory _serviceScopeFactory;

    private protected readonly IProducer _producer;

    private protected readonly string _queueName;

    private protected readonly object _lock = new();

    private bool _isActive;

    private Exception? _currentException;

    public ControlStarter(IServiceScopeFactory serviceScopeFactory, IControl<TOptions> control,
        ServiceOptions<TOptions> options, IEventBusFactory eventBusFactory, ILogger<TService> logger)
    {
        _serviceScopeFactory = serviceScopeFactory;
        _logger = logger;
        _control = control;
        _hostName = options.HostName;
        _serviceName = options.ServiceName;
        _queueName = GetQueueName(_hostName, _serviceName);

        _producer = eventBusFactory.CreateProducer();

        _control.ActiveEvent += Active;
        _control.UnactiveEvent += (error, ex) => Unactive(ex ?? new Exception(error));

        var serviceOptionsConsumer = eventBusFactory.CreateConsumer<Options>(_queueName);
        serviceOptionsConsumer.MessageEvent += async (request, args) => await SetOptionsAsync(request);
        serviceOptionsConsumer.RecieveStart();

        var reloadServiceConsumer = eventBusFactory.CreateConsumer<Reload>(_queueName);
        reloadServiceConsumer.MessageEvent += async (options, args) => await ChangedOptionsHandleAsync(_control.Options);
        reloadServiceConsumer.RecieveStart();

        var serviceControllerStartedConsumer = eventBusFactory.CreateConsumer<ServiceControllerStarted, TService>();
        serviceControllerStartedConsumer.MessageEvent += (request, args) =>
        {
            lock (_lock)
                SendOptions(updateOptions: false);

            return Task.CompletedTask;
        };
        serviceControllerStartedConsumer.RecieveStart();
    }

    public void Active()
    {
        lock (_lock)
        {
            if (_isActive && _currentException == null)
                return;

            _isActive = true;
            _currentException = null;
            _logger.LogActive(_serviceName);
            SendOptions(updateOptions: false);
        }
    }

    public void Unactive(Exception ex)
    {
        lock (_lock)
        {
            if (!_isActive && _currentException != null && _currentException.Message == ex.Message)
                return;

            _isActive = false;
            _currentException = ex;
            _logger.LogUnactive(_serviceName, ex.Message, ex);
            SendOptions(updateOptions: false);
        }
    }

    private async Task SetOptionsAsync(Options configuration)
    {
        if (configuration.JsonOptions == null)
        {
            SendOptions("Options is null.", false);
            return;
        }

        try
        {
            if (JsonConvert.DeserializeObject<TOptions>(configuration.JsonOptions, _serializerSettings.Value) is not TOptions options)
            {
                SendOptions("Failed to deserialize options.", false);
                return;
            }

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(options, new ValidationContext(options), results, true))
            {
                SendOptions(string.Join(' ', results.Select(result => result.ErrorMessage)), false);
                return;
            }

            bool equals;

            lock (_lock)
            {
                equals = _control.Options.Equals(options);
                _control.Options = options;
                SendOptions();
            }

            if (!equals)
                await ChangedOptionsHandleAsync(options);
        }
        catch (Exception ex)
        {
            lock (_lock)
                SendOptions(ex.Message, false);
        }
    }

    private protected virtual void SendOptions(string? info = null, bool updateOptions = true)
    {
        var serviceInfo = new UpdatedServiceInfo();
        WriteServiceInfo(serviceInfo, updateOptions, info);
        _producer.Publish(serviceInfo, true);
    }

    private protected void WriteServiceInfo(UpdatedServiceInfo serviceInfo, bool updateOptions, string? info = null)
    {
        try
        {
            serviceInfo.JsonOptions = JsonConvert.SerializeObject(_control.Options, _serializerSettings.Value);
        }
        catch (Exception ex)
        {
            if (info == null)
                info = ex.Message;
            else
                info += $" {ex.Message}";
        }

        serviceInfo.HostName = _hostName;
        serviceInfo.Name = _serviceName;
        serviceInfo.UpdateOptions = updateOptions;
        serviceInfo.State = new()
        {
            IsActive = _isActive,
            Error = _currentException?.Message,
            StackTrace = _currentException?.StackTrace,
            Info = info
        };
    }

    private protected async Task ChangedOptionsHandleAsync(TOptions options)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var service = scope.ServiceProvider.GetRequiredService<TService>();

        try
        {
            await service.ChangedOptionsHandleAsync(options);
            _control.Active();
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        lock (_lock)
            SendOptions(updateOptions: false);

        await ChangedOptionsHandleAsync(_control.Options);
    }
}

internal class ControlStarter<TService, TOptions, TEnvironment> : ControlStarter<TService, TOptions>
    where TService : IService<TOptions, TEnvironment> where TOptions : class, new() where TEnvironment : class, new()
{
    private readonly IControl<TOptions, TEnvironment> _control;

    public ControlStarter(IServiceScopeFactory serviceScopeFactory, IControl<TOptions, TEnvironment> control, ServiceOptions<TOptions> options,
        IEventBusFactory eventBusFactory, ILogger<TService> logger)
        : base(serviceScopeFactory, control, options, eventBusFactory, logger)
    {
        _control = control;

        var setEnvironmentGeneralConsumer = eventBusFactory.CreateConsumer<TEnvironment, TService>();
        setEnvironmentGeneralConsumer.MessageEvent += async (request, args) => await ChangeEnvironmentHandleAsync(request);
        setEnvironmentGeneralConsumer.RecieveStart();

        var setEnvironmentConsumer = eventBusFactory.CreateConsumer<TEnvironment>(_queueName);
        setEnvironmentConsumer.MessageEvent += async (request, args) => await ChangeEnvironmentHandleAsync(request);
        setEnvironmentConsumer.RecieveStart();
    }

    private async Task ChangeEnvironmentHandleAsync(TEnvironment environment)
    {
        var previous = _control.Environment;
        _control.Environment = environment;

        using var scope = _serviceScopeFactory.CreateScope();
        var service = scope.ServiceProvider.GetRequiredService<TService>();

        try
        {
            await service.ChangedEnvironmentHandleAsync(environment, previous);
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
        }
    }

    private protected override void SendOptions(string? info = null, bool updateOptions = true)
    {
        var serviceInfo = new UpdatedServiceInfoEnvironment();
        WriteServiceInfo(serviceInfo, updateOptions, info);
        _producer.Publish(serviceInfo, true);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        lock (_lock)
        {
            var serviceInfo = new UpdatedServiceInfoEnvironment
            {
                RequestEnvironment = true
            };
            WriteServiceInfo(serviceInfo, false);
            _producer.Publish(serviceInfo, true);
        }

        await ChangedOptionsHandleAsync(_control.Options);
    }
}

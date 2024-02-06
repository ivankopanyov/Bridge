namespace Bridge.Services.Control;

public abstract class ServiceNode : BackgroundService
{
    private protected readonly string _host;

    private protected readonly string _name;

    private readonly bool _useRestart;

    private protected readonly ServiceHost.ServiceHostClient _serviceHostClient;

    private protected readonly ILogger _logger;

    private CancellationTokenSource _cancellationTokenSource;

    private CancellationToken _cancellationToken;

    private Exception? _ex;

    private bool _isActive;

    private Exception? _currentException;

    public ServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceNodeOptions options, ILogger logger)
    {
        _host = options.Host;
        _name = options.Name;
        _useRestart = options.UseRestart;
        _serviceHostClient = serviceHostClient;
        _logger = logger;
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;
        eventService.GetServicesEvent += () => ToServiceInfo();
    }

    public async Task ActiveAsync()
    {
        if (_isActive)
            return;

        _isActive = true;
        _currentException = null; 
        await ChangeStateAsync();
    }

    public async Task UnactiveAsync(Exception? ex = null)
    {
        if (!_isActive && ((ex == null && _currentException == null)
            || (ex != null && _currentException != null && ex.Message == _currentException.Message
            && ex.StackTrace == _currentException.StackTrace)))
            return;

        _isActive = false;
        _currentException = ex; 
        await ChangeStateAsync();
    }

    private protected virtual ServiceInfo ToServiceInfo()
    {
        var serviceInfo = new ServiceInfo()
        {
            Name = _name,
            UseRestart = _useRestart,
            State = new ServiceState
            {
                IsActive = _isActive
            }
        };

        if (_currentException?.Message is string error)
            serviceInfo.State.Error = error;

        if (_currentException?.StackTrace is string stackTrace)
            serviceInfo.State.StackTrace = stackTrace;

        return serviceInfo;
    }

    public override int GetHashCode() => _name.GetHashCode();

    public override bool Equals(object? obj) => obj is ServiceNode other && _name == other._name;

    private async Task ChangeStateAsync()
    {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;

        try
        {
            await SendServiceAsync(new Service
            {
                Host = _host,
                Service_ = ToServiceInfo()
            }, _cancellationToken);
        }
        catch (OperationCanceledException ex)
        {
            _logger.Info(_name, ex.Message);
        }
        catch (Exception ex)
        {
            _logger.Error(_name, ex);
        }
    }

    private async Task SendServiceAsync(Service service, CancellationToken cancellationToken) => await Task.Run(async () =>
    {
        try
        {
            await _serviceHostClient.SetServiceAsync(service);
            _ex = null;
        }
        catch (Exception ex)
        {
            if (_ex == null || _ex.Message != ex.Message || _ex.StackTrace != ex.StackTrace)
            {
                _ex = ex;
                _logger.Error(_name, ex);
            }

            await Task.Delay(1000);
            await SendServiceAsync(service, cancellationToken);
        }
    }, cancellationToken).ConfigureAwait(false);
}

public abstract class ServiceNode<T> : ServiceNode where T : class, new()
{
    public T? Options { get; protected set; }

    public ServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceNodeOptions options,
        ILogger logger) : base(serviceHostClient, eventService, options, logger)
    {
        eventService.SetOptionsEvent += (serviceName, serviceOptions) =>
        {
            if (serviceName != _name)
                return null;

            try 
            {
                Options = serviceOptions != null && JsonConvert.DeserializeObject<T>(serviceOptions) is T newOptions
                    ? newOptions : null;
            }
            catch (Exception ex)
            {
                Options = null;
                _logger.Error(_name, ex);
            }

            SetOptionsHandle();
            return ToServiceInfo();
        };
    }

    protected override sealed async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await GetOptionsAsync(new Service
        {
            Host = _host,
            Service_ = ToServiceInfo()
        });
    }

    private async Task GetOptionsAsync(Service service, Exception? currentExeption = null) => await Task.Run(async () =>
    {
        try
        {
            var options = await _serviceHostClient.GetOptionsAsync(service);

            if (options?.Options?.Options == null)
                Options = null;
            else
                try
                {
                    Options = JsonConvert.DeserializeObject<T>(options.Options.Options);
                }
                catch (Exception ex)
                {
                    _logger.Error(_name, ex);
                    Options = null;
                }

            SetOptionsHandle();
        }
        catch (Exception ex)
        {
            if (currentExeption == null || currentExeption.Message != ex.Message || currentExeption.StackTrace != ex.StackTrace)
            {
                currentExeption = ex;
                _logger.Error(_name, ex);
            }

            await Task.Delay(1000);
            await GetOptionsAsync(service, currentExeption);
        }
    }).ConfigureAwait(false);

    protected virtual void SetOptionsHandle() { }

    private protected override ServiceInfo ToServiceInfo()
    {
        var serviceInfo = base.ToServiceInfo();
        serviceInfo.Options = new ServiceOptions();

        if (Options == null)
            return serviceInfo;

        try
        {
            var result = JsonConvert.SerializeObject(Options);
            if (result != null)
                serviceInfo.Options.Options = result;
        }
        catch (Exception ex)
        {
            _logger.Error(_name, ex);
        }

        return serviceInfo;
    }
}

    
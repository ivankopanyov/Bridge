namespace Bridge.Services.Control;

public abstract class ServiceNodeBase
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

    private protected ServiceNodeBase(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceNodeOptions options, ILogger logger)
    {
        _host = options.Host;
        _name = options.Name;
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

    public async Task UnactiveAsync(string error)
    {
        if (!_isActive && (_currentException == null || _currentException.Message != error))
            return;

        _isActive = false;
        _currentException = new Exception(error);
        await ChangeStateAsync();
    }

    public async Task UnactiveAsync(Exception ex)
    {
        if (!_isActive && (_currentException == null || _currentException.Message != ex.Message || _currentException.StackTrace != ex.StackTrace))
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

    public override bool Equals(object? obj) => obj is ServiceNodeBase other && _name == other._name;

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
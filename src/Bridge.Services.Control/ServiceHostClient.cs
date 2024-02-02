namespace Bridge.Services.Control;

internal class ServiceHostClient : IServiceHostClient
{
    private static readonly string _serviceName = nameof(ServiceHostClient);

    private readonly string _host;

    private readonly string _serviceHost;

    private readonly ILogger _logger;

    private readonly HashSet<ServiceNode> _services;

    private CancellationTokenSource _tokenSource;

    private CancellationToken _token;

    private Exception? _ex;

    public ServiceHostClient(IOptions<ServiceHostClientOptions> options, ILogger<ServiceHostClient> logger)
    {
        var optionsValue = options.Value;
        _host = optionsValue.Host;
        _serviceHost = optionsValue.ServiceHost;
        _logger = logger;
        _services = [];
        _tokenSource = new();
        _token = _tokenSource.Token;
    }

    public async Task SetServiceAsync(ServiceNode service)
    {
        RefreshToken();
        if (!_services.Add(service))
        {
            _services.Remove(service);
            _services.Add(service);
        }

        var request = new Services
        {
            Host = _host
        };

        request.Services_.AddRange(_services.Select(s => s.ToServiceInfo()));

        try
        {
            await Task.Run(async () =>
            {
                try
                {
                    await SendServicesAsync(request);
                    _services.Clear();
                    _ex = null;
                }
                catch (Exception ex)
                {
                    await Task.Delay(1000, _token);
                    await SendServicesAsync(request);

                    if (_ex == null || _ex.Message != ex.Message)
                    {
                        _logger.Error(_serviceName, ex);
                        _ex = ex;
                    }
                }
            }, _token);
        }
        catch (OperationCanceledException ex)
        {
            _logger.Info(_serviceName, ex.Message);
        }
    }

    private async Task SendServicesAsync(Services services)
    {
        using var channel = GrpcChannel.ForAddress(_serviceHost);
        var client = new ServiceHost.ServiceHostClient(channel);
        await client.SetServicesAsync(services);
    }

    private void RefreshToken()
    {
        _tokenSource.Cancel();
        _tokenSource = new CancellationTokenSource();
        _token = _tokenSource.Token;
    }
}

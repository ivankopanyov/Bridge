namespace Bridge.HostApi.Services;

public class BridgeServiceHost(IServiceControlClient serviceControlClient, ILogger<BridgeServiceHost> logger) : ServiceHost.ServiceHostBase
{
    private readonly IServiceControlClient _serviceControlClient = serviceControlClient;

    private readonly ILogger _logger = logger;

    public override async Task<Empty> SetServices(Bridge.Services.Control.Services request, ServerCallContext context)
    {
        return new Empty();
    }
}

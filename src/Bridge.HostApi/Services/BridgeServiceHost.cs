namespace Bridge.HostApi.Services;

public class BridgeServiceHost : ServiceHost.ServiceHostBase
{
    private readonly IServiceRepository _serviceRepository;

    public BridgeServiceHost(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public override async Task<Options> GetOptions(ServiceInfo request, ServerCallContext context)
    {
        var response = new Options
        {
            ServiceName = request.Name
        };

        var serviceNodeInfo = await _serviceRepository.UpdateServiceAsync(request, false);

        if (serviceNodeInfo.JsonOptions != null)
            response.JsonOptions = serviceNodeInfo.JsonOptions;

        // Update service event

        return response;
    }

    public override async Task<Empty> SetService(ServiceInfo request, ServerCallContext context)
    {
        var serviceNodeInfo = await _serviceRepository.UpdateServiceAsync(request, true);

        // Update service event

        return new Empty();
    }
}

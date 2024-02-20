namespace Bridge.HostApi.Services;

public class BridgeServiceHost(IUpdateService updateService, IServiceRepository serviceRepository) : ServiceHost.ServiceHostBase
{
    private readonly IUpdateService _updateService = updateService;

    private readonly IServiceRepository _serviceRepository = serviceRepository;

    public override async Task<Options> GetOptions(ServiceInfo request, ServerCallContext context)
    {
        var response = new Options
        {
            ServiceName = request.Name
        };

        var serviceNodeInfo = await _serviceRepository.UpdateServiceAsync(request, false);

        if (serviceNodeInfo.JsonOptions != null)
            response.JsonOptions = serviceNodeInfo.JsonOptions;

        await _updateService.SendUpdateAsync(serviceNodeInfo);

        return response;
    }

    public override async Task<Empty> SetService(ServiceInfo request, ServerCallContext context)
    {
        var serviceNodeInfo = await _serviceRepository.UpdateServiceAsync(request, true);
        await _updateService.SendUpdateAsync(serviceNodeInfo);
        return new Empty();
    }
}

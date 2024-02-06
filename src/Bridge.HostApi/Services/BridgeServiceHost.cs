namespace Bridge.HostApi.Services;

public class BridgeServiceHost : ServiceHost.ServiceHostBase
{
    private readonly IServiceRepository _serviceRepository;

    public BridgeServiceHost(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public override async Task<OptionsResponse> GetOptions(Bridge.Services.Control.Service request, ServerCallContext context)
    {
        var response = new OptionsResponse();
        if (await _serviceRepository.GetOptionsAsync(request) is ServiceOptions options)
            response.Options = options;

        return response;
    }

    public override async Task<Empty> SetService(Bridge.Services.Control.Service request, ServerCallContext context)
    {
        await _serviceRepository.SetServiceStateAsync(request);
        return new Empty();
    }
}

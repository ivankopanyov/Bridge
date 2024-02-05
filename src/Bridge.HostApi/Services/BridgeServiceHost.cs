using Bridge.HostApi.Models;
using Bridge.HostApi.Repositories.Abstract;

namespace Bridge.HostApi.Services;

public class BridgeServiceHost : ServiceHost.ServiceHostBase
{
    private readonly IServiceRepository _serviceRepository;

    private readonly ILogger<BridgeServiceHost> _logger;

    public BridgeServiceHost(IServiceRepository serviceRepository, ILogger<BridgeServiceHost> logger)
    {
        _serviceRepository = serviceRepository;
        _logger = logger;
    }

    public override async Task<OptionsResponse> GetOptions(Service request, ServerCallContext context)
    {
        var response = new OptionsResponse();
        if (await _serviceRepository.GetOptionsAsync(request) is ServiceOptions options)
            response.Options = options;

        return response;
    }

    public override async Task<Empty> SetService(Service request, ServerCallContext context)
    {
        await _serviceRepository.SetServiceAsync(request);
        return new Empty();
    }
}

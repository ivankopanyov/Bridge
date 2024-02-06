namespace Bridge.Services.Control;

internal class ServiceController(IEventService eventService, ServiceControlOptions options) : ServiceControl.ServiceControlBase
{
    private readonly IEventService _eventService = eventService;

    private readonly string _host = options.Host;

    public override Task<SetOptionsResponse> SetOptions(SetOptionsRequest request, ServerCallContext context)
    { 
        var response = new SetOptionsResponse();
        if (_eventService.SetOptions(request.ServiceName, request.Options) is ServiceInfo service)
            response.Service = service;

        return Task.FromResult(response);
    }

    public override sealed Task<Services> GetServices(Empty request, ServerCallContext context)
    {
        var services = _eventService.GetServices();
        var response = new Services
        {
            Host = _host
        };

        response.Services_.AddRange(services);
        return Task.FromResult(response);
    }
}

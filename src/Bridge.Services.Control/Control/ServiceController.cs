namespace Bridge.Services.Control;

internal class ServiceController(IEventService eventService, ServiceControlOptions options) : ServiceControl.ServiceControlBase
{
    private readonly IEventService _eventService = eventService;

    private readonly string _host = options.Host;

    public override async Task<SetOptionsResponse> SetOptions(Options request, ServerCallContext context) =>
        await _eventService.SetOptionsAsync(request) is SetOptionsResponse service ? service : new();

    public override sealed Task<HostInfo> GetServices(Empty request, ServerCallContext context)
    {
        var services = _eventService.GetServices();
        var response = new HostInfo
        {
            Name = _host
        };

        response.Services.AddRange(services);
        return Task.FromResult(response);
    }
}

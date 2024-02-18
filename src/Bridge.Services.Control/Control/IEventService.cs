namespace Bridge.Services.Control;

internal delegate ServiceInfo GetServicesHandle();

internal delegate Task<SetOptionsResponse?> SetOptionsHandleAsync(Options options);

public interface IEventService
{
    internal event GetServicesHandle? GetServicesEvent;

    internal event SetOptionsHandleAsync? SetOptionsEvent;

    internal IEnumerable<ServiceInfo> GetServices();

    internal Task<SetOptionsResponse?> SetOptionsAsync(Options options);
}

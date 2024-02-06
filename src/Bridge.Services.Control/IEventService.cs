namespace Bridge.Services.Control;

internal delegate ServiceInfo GetServicesHandle();

internal delegate ServiceInfo? SetOptionsHandle(string serviceName, string? options);

public interface IEventService
{
    internal event GetServicesHandle? GetServicesEvent;

    internal event SetOptionsHandle? SetOptionsEvent;

    internal IEnumerable<ServiceInfo> GetServices();

    internal ServiceInfo? SetOptions(string serviceName, ServiceOptions options);
}

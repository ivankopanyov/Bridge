namespace Bridge.Services.Control;

internal class EventService : IEventService
{
    public event GetServicesHandle? GetServicesEvent;

    public event SetOptionsHandle? SetOptionsEvent;

    public IEnumerable<ServiceInfo> GetServices() => GetServicesEvent?
        .GetInvocationList().Select(i => ((GetServicesHandle)i)()) ?? Enumerable.Empty<ServiceInfo>();

    public ServiceOptions? SetOptions(string serviceName, ServiceOptions options)
    {
        if (SetOptionsEvent == null)
            return null;

        foreach (var d in SetOptionsEvent.GetInvocationList())
            if (((SetOptionsHandle)d)(serviceName, options.Options) is ServiceOptions result)
                return result;

        return null;
    }
}

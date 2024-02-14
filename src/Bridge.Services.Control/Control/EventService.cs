namespace Bridge.Services.Control;

internal class EventService : IEventService
{
    public event GetServicesHandle? GetServicesEvent;

    public event SetOptionsHandleAsync? SetOptionsEvent;

    public IEnumerable<ServiceInfo> GetServices() => GetServicesEvent?
        .GetInvocationList().Select(i => ((GetServicesHandle)i)()) ?? Enumerable.Empty<ServiceInfo>();

    public async Task<SetOptionsResponse?> SetOptionsAsync(string serviceName, ServiceOptions options)
    {
        if (SetOptionsEvent == null)
            return null;

        foreach (var d in SetOptionsEvent.GetInvocationList())
            if (await ((SetOptionsHandleAsync)d)(serviceName, options.Options) is SetOptionsResponse result)
                return result;

        return null;
    }
}

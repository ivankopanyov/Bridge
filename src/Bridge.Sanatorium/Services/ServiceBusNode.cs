namespace Bridge.Sanatorium.Services;

public delegate Task SetOptionsHandleAsync();

public class ServiceBusNode : ServiceNode<ServiceBusOptions>
{
    public event SetOptionsHandleAsync? SetOptionsEvent;

    public ServiceBusNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceNodeOptions<ServiceBusNode, ServiceBusOptions> options, ILogger<ServiceBusNode> logger)
        : base(serviceHostClient, eventService, options, logger) { }

    protected override Task SetOptionsHandleAsync()
    {
        SetOptionsEvent?.Invoke();
        return Task.CompletedTask;
    }
}

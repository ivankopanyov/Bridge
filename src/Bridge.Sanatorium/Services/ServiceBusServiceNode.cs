namespace Bridge.Sanatorium.Services;

public class ServiceBusServiceNode : ServiceNode<ServiceBusOptions>
{
    public ServiceBusServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceNodeOptions<ServiceBusServiceNode, ServiceBusOptions> options, ILogger<ServiceBusServiceNode> logger)
        : base(serviceHostClient, eventService, options, logger) { }

    protected override Task SetOptionsHandleAsync()
    {
        return Task.CompletedTask;
    }
}

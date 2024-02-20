namespace Bridge.Sanatorium.Services;

public class ServiceBusServiceNode : ServiceNode<ServiceBusOptions>
{
    private readonly ILogger _logger;

    public ServiceBusServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceNodeOptions<ServiceBusServiceNode, ServiceBusOptions> options, ILogger<ServiceBusServiceNode> logger)
        : base(serviceHostClient, eventService, options, logger)
    {
        _logger = logger;
    }

    protected override Task SetOptionsHandleAsync()
    {
        _logger.Info(nameof(ServiceBusServiceNode), Options.ToString());
        return Task.CompletedTask;
    }
}

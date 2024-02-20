namespace Bridge.EventBus.Services;

internal class RabbitMqServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceNodeOptions<RabbitMqServiceNode, RabbitMqOptions> options, ILogger<RabbitMqServiceNode> logger)
    : ServiceNode<RabbitMqOptions>(serviceHostClient, eventService, options, logger)
{
    public ChangeOptionsHandle? ChangeRabbitMqOptionsEvent;

    protected override Task SetOptionsHandleAsync()
    {
        ChangeRabbitMqOptionsEvent?.Invoke();
        return Task.CompletedTask;
    }
}

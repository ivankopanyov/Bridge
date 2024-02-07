namespace Bridge.EventBus.Services;

internal delegate void ChangeRabbitMqOptionsHandle();

internal class RabbitMqServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceNodeOptions<RabbitMqServiceNode, RabbitMqOptions> options, ILogger<RabbitMqServiceNode> logger)
    : ServiceNode<RabbitMqOptions>(serviceHostClient, eventService, options, logger)
{
    public ChangeRabbitMqOptionsHandle? ChangeRabbitMqOptionsEvent;

    protected override Task SetOptionsHandleAsync()
    {
        ChangeRabbitMqOptionsEvent?.Invoke();
        return Task.CompletedTask;
    }
}

namespace Bridge.EventBus.Services;

internal class ElasticSearchServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, 
    ServiceNodeOptions<ElasticSearchServiceNode, ElasticSearchOptions> options, ILogger<ElasticSearchServiceNode> logger)
    : ServiceNode<ElasticSearchOptions>(serviceHostClient, eventService, options, logger)
{
    public ChangeOptionsHandle? ChangeElasticSearchOptionsEvent;

    protected override Task SetOptionsHandleAsync()
    {
        ChangeElasticSearchOptionsEvent?.Invoke();
        return Task.CompletedTask;
    }
}

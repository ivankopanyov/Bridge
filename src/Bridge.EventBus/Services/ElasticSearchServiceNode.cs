namespace Bridge.EventBus.Services;

internal class ElasticSearchServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, 
    ServiceNodeOptions<ElasticSearchServiceNode, ElasticSearchOptions> options, ILogger<ElasticSearchServiceNode> logger)
    : ServiceNode<ElasticSearchOptions>(serviceHostClient, eventService, options, logger)
{

    protected override Task SetOptionsHandleAsync()
    {
        return Task.CompletedTask;
    }
}

namespace Bridge.EventBus.Services.Abstract;

internal interface IElasticSearchService
{
    Task SendAsync(ElasticLog log);
}

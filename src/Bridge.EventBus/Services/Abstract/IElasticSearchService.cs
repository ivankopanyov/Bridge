namespace Bridge.EventBus.Services.Abstract;

internal interface IElasticSearchService : IOptinable
{
    Task SendAsync(ElasticLog log);
}

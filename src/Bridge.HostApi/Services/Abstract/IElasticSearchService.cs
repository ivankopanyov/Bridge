namespace Bridge.HostApi.Services.Abstract;

public interface IElasticSearchService : IService<ElasticSearchOptions, BridgeEnvironment>
{
    void Exec(Action<ElasticsearchClient, string> action);

    T Exec<T>(Func<ElasticsearchClient, string, T> func);
}

namespace Bridge.HostApi.Services.Implement;

public class ElasticSearchService(IControl<ElasticSearchOptions, BridgeEnvironment> control) : IElasticSearchService
{
    private ElasticsearchClient Client => new(new Uri(control.Options.Endpoint ?? string.Empty));

    public async Task ChangedOptionsHandleAsync(ElasticSearchOptions options)
    {
        if (!string.IsNullOrWhiteSpace(control.Options.Index))
            ArgumentException.ThrowIfNullOrWhiteSpace(control.Options.Index, nameof(control.Options.Index));

        var response = await Client.PingAsync();
        if (!response.IsSuccess())
            throw new Exception(response.DebugInformation);
    }

    public Task ChangedEnvironmentHandleAsync(BridgeEnvironment current, BridgeEnvironment previous) => Task.CompletedTask;

    public void Exec(Action<ElasticsearchClient, string> action)
    {
        ArgumentNullException.ThrowIfNull(action, nameof(action));

        try
        {
            action.Invoke(Client, control.Options.Index);
            control.Active();
        }
        catch (Exception ex)
        {
            control.Unactive(ex);
            throw;
        }
    }

    public T Exec<T>(Func<ElasticsearchClient, string, T> func)
    {
        ArgumentNullException.ThrowIfNull(func, nameof(func));

        try
        {
            var result = func.Invoke(Client, control.Options.Index);
            control.Active();
            return result;
        }
        catch (Exception ex)
        {
            control.Unactive(ex);
            throw;
        }
    }
}

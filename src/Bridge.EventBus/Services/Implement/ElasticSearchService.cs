namespace Bridge.EventBus.Services.Implement;

internal class ElasticSearchService : IElasticSearchService
{
    private readonly ElasticSearchServiceNode _elasticSearchServiceNode;

    private readonly ILogger _logger;

    private ElasticsearchClient NewElasticsearchClient
    {
        get
        {
            var uri = new Uri(_elasticSearchServiceNode.Options.Url);
            return new ElasticsearchClient(uri);
        }
    }

    public ElasticSearchService(ElasticSearchServiceNode elasticSearchServiceNode, ILogger<ElasticSearchService> logger)
    {
        _elasticSearchServiceNode = elasticSearchServiceNode;
        _logger = logger;
        _elasticSearchServiceNode.ChangeElasticSearchOptionsEvent += async () => 
        {
            try
            {
                var response = await NewElasticsearchClient.PingAsync();
                if (response.IsSuccess())
                    await _elasticSearchServiceNode.ActiveAsync();
                else
                    await _elasticSearchServiceNode.UnactiveAsync(response.DebugInformation);
            }
            catch (Exception ex) 
            { 
                await _elasticSearchServiceNode.UnactiveAsync(ex);
            }
        };
    }

    public async Task SendAsync(ElasticLog log) => await SendAsync(log, null);

    private async Task SendAsync(ElasticLog log, Exception? currentException) => await Task.Run(async () =>
    {
        try
        {
            _logger.LogEvent(log);
            var response = await NewElasticsearchClient.IndexAsync(log, _elasticSearchServiceNode.Options.Index ?? string.Empty);

            if (response.IsSuccess())
                await _elasticSearchServiceNode.ActiveAsync();
            else
            {
                var ex = new Exception(response.DebugInformation);
                if (currentException == null || currentException.Message != ex.Message)
                    currentException = ex;

                await _elasticSearchServiceNode.UnactiveAsync(currentException);
                await Task.Delay(TimeSpan.FromSeconds(1));
                await SendAsync(log, currentException);
            }
        }
        catch (Exception ex)
        {
            if (currentException == null || currentException.Message != ex.Message || currentException.StackTrace != ex.StackTrace)
                currentException = ex;

            await _elasticSearchServiceNode.UnactiveAsync(currentException);
            await Task.Delay(TimeSpan.FromSeconds(1));
            await SendAsync(log, currentException);
        }
    });
}

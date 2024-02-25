namespace Bridge.EventBus.Services.Implement;

internal class ElasticSearchService(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceOptions<ElasticSearchService, ElasticSearchOptions> options, ILogger<ElasticSearchService> logger)
    : ServiceControl<ElasticSearchOptions>(serviceHostClient, eventService, options, logger), IElasticSearchService
{
    private ElasticsearchClient NewElasticsearchClient => new ElasticsearchClient(new Uri(Options.Url));

    protected override async Task SetOptionsHandleAsync()
    {
        try
        {
            var response = await NewElasticsearchClient.PingAsync();
            if (response.IsSuccess())
                await ActiveAsync();
            else
                await UnactiveAsync(response.DebugInformation);
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
        }
    }

    public async Task SendAsync(ElasticLog log) => await SendAsync(log, null);

    private async Task SendAsync(ElasticLog log, Exception? currentException) => await Task.Run(async () =>
    {
        try
        {
            logger.LogEvent(log);
            var response = await NewElasticsearchClient.IndexAsync(log, Options.Index ?? string.Empty);

            if (response.IsSuccess())
                await ActiveAsync();
            else
            {
                var ex = new Exception(response.DebugInformation);
                if (currentException == null || currentException.Message != ex.Message)
                    currentException = ex;

                await UnactiveAsync(currentException);
                await Task.Delay(TimeSpan.FromSeconds(1));
                await SendAsync(log, currentException);
            }
        }
        catch (Exception ex)
        {
            if (currentException == null || currentException.Message != ex.Message || currentException.StackTrace != ex.StackTrace)
                currentException = ex;

            await UnactiveAsync(currentException);
            await Task.Delay(TimeSpan.FromSeconds(1));
            await SendAsync(log, currentException);
        }
    });
}

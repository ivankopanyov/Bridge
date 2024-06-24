namespace Bridge.HostApi.Handlers;

public class ElasticSearchHandler(ILogRepository logRepository,
    ISearchArgsRepository searchArgsRepository, IHubContext<SearchArgsHub> hubContext) : LogHandler
{
    protected override async Task HandleAsync(EventLog @in)
    {
        await logRepository.AddAsync(@in);

        if (@in.TaskName != null && await searchArgsRepository.UpdateAsync(@in.TaskName) is SearchArgs searchArgs)
            await hubContext.SendToAllAsync("SearchArgs", searchArgs);
    }
}

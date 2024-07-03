namespace Bridge.HostApi.Handlers;

public class ElasticSearchHandler(ILogRepository logRepository,
    ISearchArgsRepository searchArgsRepository, IHubContext<SearchArgsHub> hubContext) : LogHandler
{
    protected override async Task HandleAsync(EventLog @in)
    {
        await logRepository.AddAsync(@in);

        if (@in.TaskName != null && await searchArgsRepository.UpdateAsync(new() {
            Id = @in.TaskName,
            DateTime = @in.DateTime 
        }) is SearchArgs searchArgs)
            await hubContext.Clients.All.SendAsync("SearchArgs", searchArgs);
    }
}

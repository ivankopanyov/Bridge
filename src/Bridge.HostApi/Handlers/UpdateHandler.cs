namespace Bridge.HostApi.Handlers;

public class UpdateHandler(IHubContext<LogHub> hubContext) : LogHandler
{
    protected override async Task HandleAsync(EventLog @in)
    {
        @in.Data = null;
        await hubContext.Clients.All.SendAsync("Log", @in);
    }
}

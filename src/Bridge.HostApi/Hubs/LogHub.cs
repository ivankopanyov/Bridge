namespace Bridge.HostApi.Hubs;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class LogHub(ILogRepository logRepository) : Hub
{
    public async Task Tasks(int size) => await SendAsync(new SearchFilter
    {
        Size = size
    });

    public async Task Update(DateTime from) => await SendAsync(new SearchFilter
    {
        From = from
    }, true);

    private async Task SendAsync(SearchFilter filter, bool update = false) =>
        await Clients.Client(Context.ConnectionId).SendAsync("Logs", await logRepository.FindAsync(filter), update);
}

namespace Bridge.HostApi.Hubs;

public class EnvironmentHub(IEnvironmentRepository environmentRepository) : Hub
{
    public async Task Environment() => await Clients.Client(Context.ConnectionId)
        .SendAsync("Environment", await environmentRepository.GetAsync() ?? new BridgeEnvironment());
}

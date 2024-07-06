namespace Bridge.HostApi.Hubs;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class EnvironmentHub(IEnvironmentRepository environmentRepository) : Hub
{
    public async Task Environment() => await Clients.Client(Context.ConnectionId)
        .SendAsync("Environment", JsonConvert.SerializeObject(await environmentRepository.GetAsync() ?? new(), new JsonSerializerSettings()
        {
            ContractResolver = new DescriptionContractResolver()
        }));
}

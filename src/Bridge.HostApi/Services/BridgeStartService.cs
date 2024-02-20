namespace Bridge.HostApi.Services;

public class BridgeStartService(IUpdateService updateService, IServiceControlClient serviceControlClient) : BackgroundService
{
    private readonly IUpdateService _updateService = updateService;

    private readonly IServiceControlClient _serviceControlClient = serviceControlClient;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var context = new BridgeDbContext();
        await context.Database.EnsureCreatedAsync();

        var repository = new ServiceRepository(context);
        var hosts = await context.Hosts.AsNoTracking().Include(h => h.Services).ToListAsync();

        foreach (var host in hosts)
        {
            try
            {
                var hostInfo = await _serviceControlClient.GetServicesAsync(host.Name);
                foreach (var serviceInfo in hostInfo.Services)
                {
                    var serviceNodeInfo = await repository.UpdateServiceAsync(serviceInfo, false);
                    if (host.Services.FirstOrDefault(s => s.ServiceName == serviceNodeInfo.Name) is Service service)
                        host.Services.Remove(service);

                    await _updateService.SendUpdateAsync(serviceNodeInfo);
                }

                foreach (var s in host.Services)
                {
                    context.Services.Remove(s);
                    await _updateService.SendRemoveServiceAsync(new()
                    {
                        Name = s.ServiceName,
                        HostName = s.HostName
                    });
                }
            }
            catch (RpcException)
            {
                context.Hosts.Remove(host);
                await _updateService.SendRemoveHostAsync(new()
                {
                    Name = host.Name
                });
            }
        }

        await context.SaveChangesAsync();
    }
}

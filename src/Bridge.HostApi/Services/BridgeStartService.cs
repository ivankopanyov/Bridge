namespace Bridge.HostApi.Services;

public class BridgeStartService(IServiceControlClient serviceControlClient, ILogger<BridgeStartService> logger) : BackgroundService
{
    private static readonly string _name = typeof(BridgeStartService).Name;

    private readonly IServiceControlClient _serviceControlClient = serviceControlClient;

    private readonly ILogger _logger = logger;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var context = new BridgeDbContext();
        await context.Database.EnsureCreatedAsync();
        var hosts = (await context.Hosts.AsNoTracking().ToListAsync()).Select(h => h.Name);
        var repository = new ServiceRepository(context);
        foreach (var host in hosts)
        {
            var services = await _serviceControlClient.GetServicesAsync(host);
            foreach (var serviceInfo in services)
                try
                {
                    await repository.SetServiceAsync(new Service
                    {
                        Host = host,
                        Service_ = serviceInfo
                    });
                }
                catch (Exception ex)
                {
                    _logger.Error(_name, ex);
                }
        }
    }
}

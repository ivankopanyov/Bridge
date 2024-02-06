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

        var repository = new ServiceRepository(context);
        var hosts = await repository.GetHostNamesAsync();
        var servicesSet = new HashSet<Bridge.Services.Control.Services>();

        foreach (var host in hosts)
        {
            try
            {
                var services = await _serviceControlClient.GetServicesAsync(host);
                servicesSet.Add(services);
            }
            catch (Exception ex)
            {
                _logger.Error(_name, ex);
            }
        }

        await repository.UpdateServicesAsync(servicesSet);
    }
}

 namespace Bridge.HostApi.Services.Hosted;

public class BridgeStartService : BackgroundService
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    private readonly IServiceController<BridgeEnvironment> _serviceController;

    public BridgeStartService(IServiceScopeFactory serviceScopeFactory, IServiceController<BridgeEnvironment> serviceController)
    {
        _serviceScopeFactory = serviceScopeFactory;
        _serviceController = serviceController;

        _serviceController.ChangedOptionsEvent += async (serviceInfo) => await HandleAsync(serviceInfo);
    }

    private async Task HandleAsync(UpdatedServiceInfo serviceInfo)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var serviceRepository = scope.ServiceProvider.GetRequiredService<IServiceRepository>();
        var hubContext = scope.ServiceProvider.GetRequiredService<IHubContext<ServiceHub>>();

        var result = await serviceRepository.UpdateAsync(serviceInfo, serviceInfo.UpdateOptions);
        await hubContext.Clients.All.SendAsync("Service", result);

        if (!serviceInfo.UpdateOptions && serviceInfo.JsonOptions != result.JsonOptions)
            _serviceController.SetOptions(serviceInfo.HostName, serviceInfo.Name, new Bridge.Services.Control.Options
            {
                JsonOptions = result.JsonOptions 
            });
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var environmentRepository = scope.ServiceProvider.GetRequiredService<IEnvironmentRepository>();

        if (await environmentRepository.GetAsync() is BridgeEnvironment environment)
            _serviceController.SetEnvironment(environment);
    }
}

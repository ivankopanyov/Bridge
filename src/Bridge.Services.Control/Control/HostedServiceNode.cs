namespace Bridge.Services.Control;

internal class HostedServiceNode<T, TOptions>(T serviceNode) : BackgroundService 
    where T : ServiceNode<TOptions> where TOptions : class, new()
{
    private readonly T _serviceNode = serviceNode;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken) => await _serviceNode.GetOptionsAsync();
}

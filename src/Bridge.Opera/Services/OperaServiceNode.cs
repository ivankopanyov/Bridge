namespace Bridge.Opera.Services;

public class OperaServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceNodeOptions<OperaServiceNode, OperaOptions> options, ILogger<OperaServiceNode> logger) : ServiceNode<OperaOptions>(serviceHostClient, eventService, options, logger)
{
    protected override async Task SetOptionsHandleAsync() => await Task.Run(async () => 
    {
        using var context = new OperaDbContext();
        try
        {
            await context.ReservationNames.AsNoTracking().AnyAsync();
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
        }
    }).ConfigureAwait(false);
}

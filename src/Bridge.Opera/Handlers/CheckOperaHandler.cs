namespace Bridge.Opera.Handlers;

internal class CheckOperaHandler : BackgroundService
{
    private readonly OperaServiceNode _operaService;

    public CheckOperaHandler(OperaServiceNode operaService)
    {
        _operaService = operaService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            using var context = new OperaDbContext();
            await context.ReservationNames.AsNoTracking().AnyAsync(cancellationToken: stoppingToken);
            await _operaService.ActiveAsync();
        }
        catch (Exception ex)
        {
            await _operaService.UnactiveAsync(ex);
        }
    }
}

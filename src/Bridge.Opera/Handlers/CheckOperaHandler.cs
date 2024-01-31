namespace Bridge.Opera.Handlers;

internal class CheckOperaHandler : BackgroundService
{
    private readonly IOperaService _operaService;

    public CheckOperaHandler(IOperaService operaService)
    {
        _operaService = operaService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            using var context = new OperaDbContext();
            await context.ReservationNames.AsNoTracking().AnyAsync(cancellationToken: stoppingToken);
            _operaService.Active();
        }
        catch (Exception ex)
        {
            _operaService.Unactive(ex);
        }
    }
}

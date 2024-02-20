namespace Bridge.Fias.Handlers;

internal class FiasStateHandler : BackgroundService
{
    private readonly IFiasService _fiasService;

    public FiasStateHandler(IFiasService fiasService, ILogger<FiasStateHandler> logger)
    {
        _fiasService = fiasService;

        fiasService.FiasLinkStartEvent += FiasLinkStartHandleAsync;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }

    private Task FiasLinkStartHandleAsync(FiasLinkStart message)
    {
        try
        {
            var linkDescription = new FiasLinkDescription()
            {
                DateTime = DateTime.Now,
                VendorSystemsVersion = "1.0.3.0",
                InterfaceFamily = FiasInterfaceTypes.PayTV
            }.ToString();

            _fiasService.Send(linkDescription);

            var guestCheckInOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckInOptions>()!).ToString();
            _fiasService.Send(guestCheckInOptions);

            var guestCheckOutOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckOutOptions>()!).ToString();
            _fiasService.Send(guestCheckOutOptions);

            var guestChangeOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestChangeOptions>()!).ToString();
            _fiasService.Send(guestChangeOptions);

            var linkAlive = new FiasLinkAlive() { DateTime = DateTime.Now }.ToString();
            _fiasService.Send(linkAlive);
        }
        catch (Exception ex)
        {
            //_logger.Error(SERVICE, ex);
        }

        return Task.CompletedTask;
    }
}

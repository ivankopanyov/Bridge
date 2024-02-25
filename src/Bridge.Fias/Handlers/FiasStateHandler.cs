namespace Bridge.Fias.Handlers;

internal class FiasStateHandler : BackgroundService
{
    private readonly IFias _fiasService;

    public FiasStateHandler(IFias fiasService)
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

            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckInOptions>()!).ToString());
            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckOutOptions>()!).ToString());
            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestChangeOptions>()!).ToString());
            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasPostingRequestOptions>()!).ToString());
            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasPostingSimpleOptions>()!).ToString());
            _fiasService.Send(new FiasLinkRecord(Entities.FiasOptions.All<FiasPostingAnswerOptions>()!).ToString());

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

namespace Bridge.Fias.Handlers;

internal class FiasStateHandler : BackgroundService
{
    private const string SERVICE = "FIAS";

    private readonly IFiasService _fiasService;

    private readonly ILogger<FiasStateHandler> _logger;

    public FiasStateHandler(IFiasService fiasService, ILogger<FiasStateHandler> logger)
    {
        _fiasService = fiasService;
        _logger = logger;

        fiasService.FiasLinkStartEvent += FiasLinkStartHandleAsync;
        fiasService.FiasLinkAliveEvent += FiasLinkAliveHandleAsync;
        fiasService.FiasLinkEndEvent += FiasLinkEndHandleAsync;
        fiasService.ChangeStateEvent += ChangeStateHandle;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }

    private Task FiasLinkStartHandleAsync(FiasLinkStart message)
    {
        try
        {
            _logger.Info(SERVICE, $"--> {message.Source}");

            var linkDescription = new FiasLinkDescription()
            {
                DateTime = DateTime.Now,
                VendorSystemsVersion = "1.0.3.0",
                InterfaceFamily = FiasInterfaceTypes.PayTV
            }.ToString();

            _fiasService.Send(linkDescription);
            _logger.Info(SERVICE, $"<-- {linkDescription}");

            var guestCheckInOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckInOptions>()!).ToString();
            _fiasService.Send(guestCheckInOptions);
            _logger.Info(SERVICE, $"<-- {guestCheckInOptions}");

            var guestCheckOutOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestCheckOutOptions>()!).ToString();
            _fiasService.Send(guestCheckOutOptions);
            _logger.Info(SERVICE, $"<-- {guestCheckOutOptions}");

            var guestChangeOptions = new FiasLinkRecord(Entities.FiasOptions.All<FiasGuestChangeOptions>()!).ToString();
            _fiasService.Send(guestChangeOptions);
            _logger.Info(SERVICE, $"<-- {guestChangeOptions}");

            var linkAlive = new FiasLinkAlive() { DateTime = DateTime.Now }.ToString();
            _fiasService.Send(linkAlive);
            _logger.Info(SERVICE, $"<-- {linkAlive}");
        }
        catch (Exception ex)
        {
            _logger.Error(SERVICE, ex);
        }

        return Task.CompletedTask;
    }

    private Task FiasLinkAliveHandleAsync(FiasLinkAlive message)
    {
        _logger.Info(SERVICE, $"--> {message.Source}");
        return Task.CompletedTask;
    }

    private Task FiasLinkEndHandleAsync(FiasLinkEnd message)
    {
        _logger.Info(SERVICE, $"--> {message.Source}");
        return Task.CompletedTask;
    }

    private Task ChangeStateHandle(bool isActive, Exception? ex)
    {
        if (isActive)
            _logger.Info(SERVICE, $"Fias connected successfull.");
        else
            _logger.Error(SERVICE, ex!);

        return Task.CompletedTask;
    }
}

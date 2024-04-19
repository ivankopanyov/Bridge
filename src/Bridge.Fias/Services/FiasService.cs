namespace Bridge.Fias.Services;

public class FiasService : ServiceControl<FiasServiceOptions>, IFias
{
    private readonly IFiasService _fiasService;

    public event FiasMessageHandle<FiasLinkStart>? FiasLinkStartEvent;
    public event FiasMessageHandle<FiasLinkAlive>? FiasLinkAliveEvent;
    public event FiasMessageHandle<FiasLinkEnd>? FiasLinkEndEvent;
    public event FiasMessageHandle<FiasGuestChange>? FiasGuestChangeEvent;
    public event FiasMessageHandle<FiasGuestCheckIn>? FiasGuestCheckInEvent;
    public event FiasMessageHandle<FiasGuestCheckOut>? FiasGuestCheckOutEvent;
    public event FiasMessageHandle<FiasLinkConfiguration>? FiasLinkConfigurationEvent;
    public event FiasMessageHandle<FiasPostingAnswer>? FiasPostingAnswerEvent;
    public event FiasMessageHandle<FiasPostingList>? FiasPostingListEvent;

    public IDictionary<string, bool> TaxCodes => Options.TaxCodes;

    public FiasService(IFiasService fiasService, ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceOptions<FiasService, FiasServiceOptions> options, ILogger<FiasService> logger)
        : base(serviceHostClient, eventService, options, logger)
    {
        _fiasService = fiasService;

        _fiasService.ChangeStateEvent += async (isActive, ex) =>
        {
            if (isActive)
                await ActiveAsync();
            else
                await UnactiveAsync(ex);
        };

        _fiasService.FiasLinkStartEvent += message => FiasLinkStartEvent?.Invoke(message)!;
        _fiasService.FiasLinkAliveEvent += message => FiasLinkAliveEvent?.Invoke(message)!;
        _fiasService.FiasLinkEndEvent += message => FiasLinkEndEvent?.Invoke(message)!;
        _fiasService.FiasGuestChangeEvent += message => FiasGuestChangeEvent?.Invoke(message)!;
        _fiasService.FiasGuestCheckInEvent += message => FiasGuestCheckInEvent?.Invoke(message)!;
        _fiasService.FiasGuestCheckOutEvent += message => FiasGuestCheckOutEvent?.Invoke(message)!;
        _fiasService.FiasLinkConfigurationEvent += message => FiasLinkConfigurationEvent?.Invoke(message)!;
        _fiasService.FiasPostingAnswerEvent += message => FiasPostingAnswerEvent?.Invoke(message)!;
        _fiasService.FiasPostingListEvent += message => FiasPostingListEvent?.Invoke(message)!;

        Options = new FiasServiceOptions
        {
            Host = _fiasService.Hostname!,
            Port = _fiasService.Port
        };
    }

    protected override Task SetOptionsHandleAsync()
    {
        _fiasService.SetFiasOptions(new Interface.FiasOptions
        {
            Host = Options.Host,
            Port = Options.Port
        });

        return Task.CompletedTask;
    }

    public void Send(string message) => _fiasService.Send(message);
}

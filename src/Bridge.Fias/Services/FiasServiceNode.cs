namespace Bridge.Fias.Services;

public class FiasServiceNode : ServiceNode<FiasServiceOptions>
{
    private readonly IFiasService _fiasService;

    public FiasServiceNode(IFiasService fiasService, ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceNodeOptions<FiasServiceNode> options, ILogger<FiasServiceNode> logger) : base(serviceHostClient, eventService, options, logger)
    {
        _fiasService = fiasService;
        _fiasService.ChangeStateEvent += async (isActive, ex) =>
        {
            if (isActive)
                await ActiveAsync();
            else
                await UnactiveAsync(ex);
        };

        Options = new FiasServiceOptions
        {
            Host = _fiasService.Hostname,
            Port = _fiasService.Port
        };
    }

    protected override void SetOptionsHandle() => _fiasService.SetFiasOptions(new Interface.FiasOptions
    {
        Host = Options?.Host,
        Port = Options?.Port
    });
}

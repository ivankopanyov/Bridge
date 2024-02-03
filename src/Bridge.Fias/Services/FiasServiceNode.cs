namespace Bridge.Fias.Services;

public class FiasServiceNode : ServiceNode<FiasServiceOptions>
{
    private readonly IFiasService _fiasService;

    public FiasServiceNode(IFiasService fiasService, IServiceHostClient serviceHostClient,
        ServiceNodeOptions<FiasServiceNode> options, ILogger<FiasServiceNode> logger) : base(serviceHostClient, options, logger)
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

    public override async Task SetOptionsAsync(FiasServiceOptions? options)
    {
        await base.SetOptionsAsync(options);
        _fiasService.SetFiasOptions(new Interface.FiasOptions
        {
            Host = options?.Host,
            Port = options?.Port
        });
    }
}

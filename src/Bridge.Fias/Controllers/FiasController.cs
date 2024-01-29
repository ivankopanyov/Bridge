namespace Bridge.Fias.Controllers;

[ApiController]
[Route("fias")]
public class FiasController : ControllerBase
{
    private readonly IFiasService _fiasService;

    public FiasController(IFiasService fiasService)
    {
        _fiasService = fiasService;
    }

    [HttpGet("state")]
    [ProducesResponseType(typeof(FiasState), (int)HttpStatusCode.OK)]
    public ActionResult<FiasState> GetState() => Ok(new FiasState()
    {
        Host = _fiasService.Hostname,
        Port = _fiasService.Port,
        IsActive = _fiasService.IsActive,
        ErrorMessage = _fiasService.CurrentException?.Message,
        StackTrace = _fiasService.CurrentException?.StackTrace
    });

    [HttpPut("state")]
    [ProducesResponseType(typeof(FiasState), (int)HttpStatusCode.OK)]
    public ActionResult<FiasState> UpdateState(Interface.FiasOptions? fiasOptions)
    {
        _fiasService.SetFiasOptions(fiasOptions);
        return Ok(new FiasState()
        {
            Host = _fiasService.Hostname,
            Port = _fiasService.Port,
            IsActive = _fiasService.IsActive,
            ErrorMessage = _fiasService.CurrentException?.Message,
            StackTrace = _fiasService.CurrentException?.StackTrace
        });
    }
}

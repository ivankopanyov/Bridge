namespace Bridge.Fias.Controllers;

[ApiController]
[Route("fias")]
public class FiasController : ControllerBase
{
    private readonly FiasServiceNode _fiasService;

    public FiasController(FiasServiceNode fiasService)
    {
        _fiasService = fiasService;
    }

    [HttpPut("state")]
    public async Task<IActionResult> SetOptionsAsync([FromBody] FiasServiceOptions options)
    {
        await _fiasService.SetOptionsAsync(new FiasServiceOptions
        {
            Host = options.Host,
            Port = options.Port
        });
        return Ok();
    }
}


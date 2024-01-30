using Bridge.EventBus.Messages;
using Bridge.Opera.Dto;
using Bridge.Opera.Infrastructure;
using Bridge.Opera.Options;
namespace Bridge.Opera.Controllers;

[ApiController]
[Route("opera")]
public class OperaController : ControllerBase
{
    private readonly IOperaService _operaService;

    private readonly OperaDbContext _context;

    public OperaController(IOperaService operaService, OperaDbContext context)
    {
        _operaService = operaService;
        _context = context;
    }

    [HttpGet("state")]
    [ProducesResponseType(typeof(OperaState), (int)HttpStatusCode.OK)]
    public IActionResult GetAsync()
    {
        return Ok(new OperaState
        {
            ConnectionString = OperaService.ConnectionString,
            IsActive = _operaService.IsActive,
            ErrorMessagen = _operaService.CurrentException?.Message,
            StackTrace = _operaService.CurrentException?.StackTrace
        });
    }

    [HttpPut("state")]
    [ProducesResponseType(typeof(OperaState), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<OperaState>> UpdateAndCheckAsync(OperaOptions? operaOptions)
    {
        _operaService.SetOperaOptions(operaOptions);

        try
        {
            await _context.ReservationNames.AsNoTracking().FirstOrDefaultAsync();
            _operaService.Active();
        }
        catch (Exception ex)
        {
            _operaService.Unactive(ex);
        }

        return Ok(new OperaState
        {
            ConnectionString = OperaService.ConnectionString,
            IsActive = _operaService.IsActive,
            ErrorMessagen = _operaService.CurrentException?.Message,
            StackTrace = _operaService.CurrentException?.StackTrace
        });
    }

    [HttpGet("check")]
    public async Task<ActionResult<OperaState>> CheckAsync()
    {
        try
        {
            await _context.ReservationNames.AsNoTracking().FirstOrDefaultAsync();
            _operaService.Active();
        }
        catch (Exception ex)
        {
            _operaService.Unactive(ex);
        }

        return Ok(new OperaState
        {
            ConnectionString = OperaService.ConnectionString,
            IsActive = _operaService.IsActive,
            ErrorMessagen = _operaService.CurrentException?.Message,
            StackTrace = _operaService.CurrentException?.StackTrace
        });
    }
}

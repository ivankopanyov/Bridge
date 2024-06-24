namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0")]
public class HomeController(ILogRepository logRepository) : ControllerBase
{
    [HttpPost("")]
    [ProducesResponseType<IEnumerable<IEnumerable<EventLog>>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult<IEnumerable<IEnumerable<EventLog>>>> PostAsync([Required][FromBody] UpdateRequest updateRequest) => Ok(await logRepository.FindAsync(new()
    {
        Size = updateRequest.Size,
        From = updateRequest.From
    }));
}

namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/logs")]
public class LogController(ILogRepository logRepository) : ControllerBase
{
    [HttpPost("")]
    [ProducesResponseType<IEnumerable<EventLog>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult<IEnumerable<EventLog>>> PostAsync([Required][FromBody] SearchFilter filter) =>
        Ok(await logRepository.FindAsync(filter));

    [HttpGet("{id}")]
    [ProducesResponseType<IEnumerable<EventLog>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public async Task<ActionResult<IEnumerable<EventLog>>> GetAsync([Required][FromRoute] string id)
    {
        if (await logRepository.GetAsync(id) is not IEnumerable<EventLog> logs)
            return NotFound($"Task {id} not found.");

        return Ok(logs.Select(log =>
        {
            log.Data = null;
            return log;
        }));
    }

    [HttpGet("{taskId}/{eventId}")]
    [ProducesResponseType<EventData>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public async Task<ActionResult<EventData>> GetEventAsync([Required][FromRoute] string taskId, [Required][FromRoute] string eventId)
    {
        if (await logRepository.GetAsync(taskId) is not IEnumerable<EventLog> logs)
            return NotFound($"Task {taskId} not found.");
        
        return logs?.FirstOrDefault(e => e.Id == eventId) is EventLog eventLog
            ? Ok(eventLog.Data) : NotFound($"Event {eventId} not found.");
    }
}

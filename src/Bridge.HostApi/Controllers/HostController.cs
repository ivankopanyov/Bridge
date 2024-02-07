namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/hosts")]
public class HostController : ControllerBase
{
    private readonly IServiceRepository _serviceRepository;

    private readonly IServiceControlClient _serviceControlClient;

    public HostController(IServiceRepository serviceRepository, IServiceControlClient serviceControlClient)
    {
        _serviceRepository = serviceRepository;
        _serviceControlClient = serviceControlClient;
    }

    [HttpGet("")]
    [ProducesResponseType<IReadOnlyDictionary<string, HashSet<ServiceNodeInfo>>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.Forbidden)]
    public ActionResult<IReadOnlyDictionary<string, HashSet<ServiceNodeInfo>>> GetHosts() => _serviceRepository.Hosts == null
        ? Forbid("Services have not yet been loaded.")
        : Ok(_serviceRepository.Hosts);

    [HttpPut("{hostName}/{serviceName}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.Forbidden)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> SetOptionsAsync([FromRoute] string hostName, [FromRoute] string serviceName, [FromBody] Dto.ServiceNodeOptions options)
    {
        if (hostName == null)
            return BadRequest("Hostname is required.");

        if (serviceName == null)
            return BadRequest("Servicename is required.");

        if (options == null)
            return BadRequest("Options is required.");

        if (_serviceRepository.Hosts == null)
            return Forbid("Services have not yet been loaded.");

        try
        {
            var result = await _serviceControlClient.SetOptionsAsync(hostName, new SetOptionsRequest
            {
                ServiceName = serviceName,
                Options = options.ToServiceOptions()
            });

            if (result.Service == null)
                return NotFound($"Service {serviceName} not found on host {hostName}.");

            await _serviceRepository.SetServiceOptionsAsync(new Bridge.Services.Control.Service
            {
                Host = hostName,
                Service_ = result.Service
            });

            return Ok();
        }
        catch
        {
            return NotFound($"Host {hostName} not found.");
        }
    }
}

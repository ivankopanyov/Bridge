namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/hosts")]
public class HostController(IServiceRepository serviceRepository, IServiceControlClient serviceControlClient, ILogger<HostController> logger) : ControllerBase
{
    private readonly IServiceRepository _serviceRepository = serviceRepository;

    private readonly IServiceControlClient _serviceControlClient = serviceControlClient;

    private readonly ILogger _logger = logger;

    [HttpGet("")]
    [ProducesResponseType<IEnumerable<HostNode>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public ActionResult<IEnumerable<HostNode>> GetHosts() => _serviceRepository.Hosts == null
        ? NotFound("Searching for services.")
        : Ok(_serviceRepository.Hosts.Select(keyValue => new HostNode
        {
            Name = keyValue.Key,
            Services = keyValue.Value
        }));

    [HttpPut("{hostName}/{serviceName}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
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
            return NotFound("Services have not yet been loaded.");

        try
        {
            var result = await _serviceControlClient.SetOptionsAsync(hostName, new SetOptionsRequest
            {
                ServiceName = serviceName,
                Options = options.ToServiceOptions()
            });

            if (result.Error != null)
                return BadRequest(result.Error);

            if (result.Service == null)
                return NotFound($"Service {serviceName} not found on host {hostName}.");

            await _serviceRepository.SetServiceOptionsAsync(new Bridge.Services.Control.Service
            {
                Host = hostName,
                Service_ = result.Service
            });

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.Error(nameof(HostController), ex);
            return NotFound(ex.Message);
        }
    }
}

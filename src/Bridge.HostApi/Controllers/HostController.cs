namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/hosts")]
public class HostController(IUpdateService updateService, IServiceRepository serviceRepository, IServiceControlClient serviceControlClient) : ControllerBase
{
    private readonly IUpdateService _updateService = updateService;

    private readonly IServiceRepository _serviceRepository = serviceRepository;

    private readonly IServiceControlClient _serviceControlClient = serviceControlClient;

    [HttpGet("")]
    [ProducesResponseType<IEnumerable<HostNode>>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public ActionResult<IEnumerable<HostNode>> GetHosts() => _serviceRepository.Hosts == null
        ? NotFound("Searching for services.")
        : Ok(_serviceRepository.Hosts);

    [HttpPut("{hostName}/{serviceName}")]
    [ProducesResponseType<ServiceNodeInfo>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    public async Task<ActionResult<ServiceNodeInfo>> SetOptionsAsync([FromRoute] string hostName, [FromRoute] string serviceName, [FromBody] OptionsDto options)
    {
        if (string.IsNullOrWhiteSpace(hostName))
            return BadRequest("Hostname is required.");

        if (string.IsNullOrWhiteSpace(serviceName))
            return BadRequest("Servicename is required.");

        if (options == null)
            return BadRequest("Options is required.");

        if (string.IsNullOrWhiteSpace(options.JsonOptions))
            return BadRequest("JsonOptions is required.");

        try
        {
            var result = await _serviceControlClient.SetOptionsAsync(hostName, new Options
            {
                ServiceName = serviceName,
                JsonOptions = options.JsonOptions
            });

            if (!result.Ok)
                return BadRequest(result.Error);

            if (result.Service == null)
                return NotFound($"Service {serviceName} not found on host {hostName}.");

            var serviceNodeInfo = await _serviceRepository.UpdateServiceAsync(result.Service, true);

            await _updateService.SendUpdateAsync(serviceNodeInfo);

            return Ok(new ServiceNodeInfo(result.Service));
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
}

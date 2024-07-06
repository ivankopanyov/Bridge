namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/services")]
public class ServiceController(IServiceRepository serviceRepository, IServiceController<BridgeEnvironment> serviceController, IHubContext<ServiceHub> hubContext) : ControllerBase
{
    [HttpGet("")]
    [ProducesResponseType<IEnumerable<ServiceInfo>>((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<IEnumerable<ServiceInfo>>> GetAllAsync() => Ok(await serviceRepository.GetAllAsync());

    [HttpGet("{hostName}/{serviceName}")]
    [ProducesResponseType<ServiceInfo>((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<ServiceInfo>> GetAsync([Required][FromRoute] string hostName, [Required][FromRoute] string serviceName) =>
        await serviceRepository.GetAsync(hostName, serviceName) is ServiceInfo serviceInfo ? Ok(serviceInfo) : NotFound();

    [HttpGet("reload/{hostName}/{serviceName}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult Reload([Required][FromRoute] string hostName, [Required][FromRoute] string serviceName)
    {
        serviceController.Reload(hostName, serviceName);
        return Ok();
    }

    [HttpPut("{hostName}/{serviceName}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult Update([Required][FromRoute] string hostName, [Required][FromRoute] string serviceName, [Required][FromBody] Bridge.Services.Control.Options options)
    {
        if (string.IsNullOrWhiteSpace(options.JsonOptions))
            return BadRequest("Options is required.");

        serviceController.SetOptions(hostName, serviceName, options);
        return Ok();
    }

    [HttpDelete("{hostName}/{serviceName}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> DeleteAsync([Required][FromRoute] string hostName, [Required][FromRoute] string serviceName)
    {
        if (await serviceRepository.RemoveAsync(hostName, serviceName) is ServiceInfo serviceInfo)
        {
            await hubContext.Clients.All.SendAsync("RemoveService", new RemoveService
            {
                HostName = hostName,
                Name = serviceName
            });

            serviceController.SetOptions(hostName, serviceName, new Bridge.Services.Control.Options
            {
                JsonOptions = serviceInfo.JsonOptions
            });

            return Ok();
        }

        return NotFound();
    }
}

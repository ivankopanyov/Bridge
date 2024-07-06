namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/environment")]
public class EnvironmentController(IEnvironmentRepository environmentRepository,
    IServiceController<BridgeEnvironment> serviceController, IHubContext<EnvironmentHub> hubContext) : ControllerBase
{
    [HttpGet("")]
    [ProducesResponseType<BridgeEnvironment>((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<BridgeEnvironment>> GetAsync() => 
        Ok(await environmentRepository.GetAsync() ?? new BridgeEnvironment());

    [HttpPut("")]
    [ProducesResponseType<BridgeEnvironment>((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<BridgeEnvironment>> UpdateAsync([Required][FromBody] BridgeEnvironment environment)
    {
        if (await environmentRepository.UpdateAsync(environment))
        {
            serviceController.SetEnvironment(environment);
            await hubContext.Clients.All.SendAsync("Environment", environment);
        }

        return Ok(environment);
    }
}

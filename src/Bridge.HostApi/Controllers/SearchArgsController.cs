namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/args")]
public class SearchArgsController(ISearchArgsRepository searchArgsRepository) : ControllerBase
{
    [HttpGet("")]
    [ProducesResponseType<BridgeEnvironment>((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<SearchArgs>> GetSearchArgsAsync() =>
        Ok(await searchArgsRepository.GetAsync() ?? new SearchArgs());
}

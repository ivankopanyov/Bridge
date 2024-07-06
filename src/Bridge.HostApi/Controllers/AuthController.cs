namespace Bridge.HostApi.Controllers;

[ApiController]
[Route("api/v1.0/auth")]
public class AuthController(UserManager<User> userManager, BridgeDbContext context, ITokenService tokenService,
    IConnectionRepository connectionRepository, IOptions<JwtOptions> options) : ControllerBase
{
    private static readonly SemaphoreSlim _semaphore = new(1);

    private readonly int _tokenLifetime = options.Value.RefreshTokenExpirationDays;

    protected long? UserId => long.TryParse(HttpContext.User.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value, out long userId)
        ? userId : null;

    [HttpGet("")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetStateAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            return await context.Users.AsNoTracking().AnyAsync() ? Ok() : NotFound();
        }
        finally
        {
            _semaphore.Release();
        }
    }

    [HttpPost("signup")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> SignUpAsync([Required][FromBody] Login login)
    {
        await _semaphore.WaitAsync();

        try
        {
            if (await context.Users.AsNoTracking().AnyAsync())
                return StatusCode(StatusCodes.Status403Forbidden);

            var user = new User
            {
                UserName = login.Username.Trim().ToLower(),
                CanModified = false
            };

            var result = await userManager.CreateAsync(user, login.Password);

            return result.Succeeded
                ? await SetCookieAsync(user.Id)
                : BadRequest(string.Join(' ', result.Errors.Select(e => e.Description)));
        }
        finally
        {
            _semaphore.Release();
        }
    }

    [HttpPost("signin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType<string>((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType<string>((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    public async Task<IActionResult> SignInAsync([Required][FromBody] Login login)
    {
        if (await userManager.FindByNameAsync(login.Username) is not User user)
        {
            return await userManager.Users.AsNoTracking().AnyAsync()
                ? NotFound("The username or password is incorrect")
                : StatusCode(StatusCodes.Status403Forbidden);
        }

        if (!await userManager.CheckPasswordAsync(user, login.Password))
            return NotFound("The username or password is incorrect");

        return await SetCookieAsync(user.Id);
    }

    [HttpGet("refresh")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = "Refresh")]
    public async Task<IActionResult> RefreshAsync()
    {
        var refreshToken = HttpContext.Request.Cookies["Refresh"];
        if (string.IsNullOrEmpty(refreshToken) || UserId is not long id ||
            !await connectionRepository.RemoveAsync(refreshToken, id))
        {
            RemoveCookie();
            return Unauthorized();
        }

        return await SetCookieAsync(id);
    }

    [HttpDelete("signout")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> SignOutAsync()
    {
        RemoveCookie();

        var refreshToken = Request.Cookies["Refresh"];
        if (string.IsNullOrEmpty(refreshToken) || UserId is not long id)
            return Unauthorized();

        await connectionRepository.RemoveAsync(refreshToken, id);
        return Ok();
    }

    private async Task<IActionResult> SetCookieAsync(long id)
    {
        var expiration = TimeSpan.FromDays(_tokenLifetime);
        var accessToken = tokenService.AccessToken(id);
        var refreshToken = tokenService.RefreshToken();

        await connectionRepository.PushAsync(refreshToken, id, expiration);
        var cookieExpiration = expiration.TotalSeconds;

        Response.Headers.Append("Set-Cookie", $"Authorization={accessToken}; Max-Age={cookieExpiration}; Path=/; HttpOnly");
        Response.Headers.Append("Set-Cookie", $"Refresh={refreshToken}; Max-Age={cookieExpiration}; Path=/api/v1.0/auth/refresh; HttpOnly");

        return Ok();
    }

    private void RemoveCookie()
    {
        Response.Headers.Append("Set-Cookie", "Authorization=; Max-Age=-1; Path=/; HttpOnly");
        Response.Headers.Append("Set-Cookie", "Refresh=; Max-Age=-1; Path=/api/v1.0/auth/refresh; HttpOnly");
    }
}

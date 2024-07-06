namespace Bridge.HostApi.Services.Implement;

public class JwtService(IOptions<JwtBearerOptions> options, IOptions<JwtOptions> tokenOptions) : ITokenService
{
    public string AccessToken(long userId)
    {
        var claims = new Claim[] { new(ClaimTypes.NameIdentifier, userId.ToString()) };
        var signingCredentials = new SigningCredentials(options.Value.TokenValidationParameters.IssuerSigningKey, SecurityAlgorithms.HmacSha256);
        var expiration = DateTime.UtcNow.AddMinutes(tokenOptions.Value.AccessTokenExpirationMinutes);
        var token = new JwtSecurityToken(claims: claims, expires: expiration, signingCredentials: signingCredentials);
        var tokenHandler = new JwtSecurityTokenHandler();

        return tokenHandler.WriteToken(token);
    }

    public string RefreshToken()
    {
        var randomNumber = new byte[32];
        Random.Shared.NextBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}

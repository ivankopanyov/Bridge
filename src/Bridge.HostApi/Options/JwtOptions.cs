namespace Bridge.HostApi.Options;

public class JwtOptions
{
    public const string SectionName = "Jwt";

    public int AccessTokenExpirationMinutes { get; set; }

    public int RefreshTokenExpirationDays { get; set; }
}

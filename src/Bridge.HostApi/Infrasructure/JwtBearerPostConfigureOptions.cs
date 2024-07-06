namespace Bridge.HostApi.Infrasructure;

public class JwtBearerPostConfigureOptions(IServiceScopeFactory serviceScopeFactory) : IPostConfigureOptions<JwtBearerOptions>
{
    private const string KEY = "JWT";

    private SymmetricSecurityKey Key
    {
        get
        {
            using var scope = serviceScopeFactory.CreateScope();
            var cacheService = scope.ServiceProvider.GetRequiredService<ICacheService>();
            if (cacheService.GetAsync<Jwt>(KEY).Result?.Bytes is not byte[] bytes)
            {
                bytes = new byte[256];
                Random.Shared.NextBytes(bytes);
                cacheService.PushAsync(KEY, new Jwt
                {
                    Bytes = bytes
                });
            }

            return new(bytes);
        }
    }

    public void PostConfigure(string? name, JwtBearerOptions options)
    {
        options.TokenValidationParameters.ClockSkew = TimeSpan.Zero;
        options.TokenValidationParameters.RequireAudience = false;
        options.TokenValidationParameters.ValidateAudience = false;
        options.TokenValidationParameters.ValidateIssuer = false;

        if (name == "Refresh")
            options.TokenValidationParameters.ValidateLifetime = false;

        options.Events = new()
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Cookies["Authorization"];
                if (!string.IsNullOrEmpty(accessToken))
                    context.Token = accessToken;

                return Task.CompletedTask;
            }
        };

        options.TokenValidationParameters.IssuerSigningKey = Key;
    }
}

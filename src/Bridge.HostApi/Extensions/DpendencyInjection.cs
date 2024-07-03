namespace Bridge.HostApi.Extensions;

public static class DpendencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services) => services
        .AddTransient<ILogRepository, LogRepository>()
        .AddScoped<IServiceRepository, ServiceRepository>()
        .AddScoped<IEnvironmentRepository, EnvironmentRepository>()
        .AddScoped<ISearchArgsRepository, SearchArgsRepository>();

    public static WebApplication MapHubs(this WebApplication app)
    {
        app.MapHub<LogHub>("/logs");
        app.MapHub<ServiceHub>("/services");
        app.MapHub<EnvironmentHub>("/environment");
        app.MapHub<SearchArgsHub>("/searchArgs");
        return app;
    }
}

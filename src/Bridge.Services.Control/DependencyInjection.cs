namespace Bridge.Services.Control;

public static class DependencyInjection
{
    private const string OUTPUT_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {" 
        + Extensions.LoggerExtensions.SERVICE + "} {Message}{NewLine}";

    private const string OUTPUT_FILE_TEMPLATE = OUTPUT_CONSOLE_TEMPLATE + "{Exception}{NewLine}";

    public static IServiceControlBuilder AddServiceControl(this IServiceCollection services, Action<ServiceControlOptions> action)
    {
        var options = new ServiceControlOptions();
        action.Invoke(options);

        options.LoggerConfiguration?.WriteTo.Logger(config => config
            .Filter.ByIncludingOnly(e => e.Properties.Keys.Contains(Extensions.LoggerExtensions.SERVICE))
            .WriteTo.Console(outputTemplate: OUTPUT_CONSOLE_TEMPLATE)
            .WriteTo.File(options.LogFileName ?? $"logs/{options.Host}_services_.log", outputTemplate: OUTPUT_FILE_TEMPLATE, rollingInterval: RollingInterval.Day));

        services.AddSingleton(options);
        services.AddSingleton<IEventService, EventService>();
        services.AddGrpc();
        services.AddGrpcClient<ServiceHost.ServiceHostClient>(opt => opt.Address = new Uri(options.ServiceHost));
        return new ServiceControlBuilder(services, options.Host);
    }

    public static WebApplication MapServiceControl(this WebApplication webApplication)
    {
        webApplication.MapGrpcService<ServiceController>();
        return webApplication;
    }

    public static IServiceCollection AddServiceHost(this IServiceCollection services, Action<ServiceHostOptions> action)
    {
        var options = new ServiceHostOptions();
        action.Invoke(options);
        services.AddSingleton(options);
        services.AddGrpc();
        services.AddSingleton<IServiceControlClient, ServiceControlClient>();
        return services;
    }

    public static WebApplication MapServiceHost<TService>(this WebApplication webApplication) where TService : ServiceHost.ServiceHostBase
    {
        webApplication.MapGrpcService<TService>();
        return webApplication;
    }
}

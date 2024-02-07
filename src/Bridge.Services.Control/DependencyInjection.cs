namespace Bridge.Services.Control;

public static class DependencyInjection
{
    public static IServiceControlBuilder AddServiceControl(this IServiceCollection services, Action<ServiceControlOptions> action)
    {
        var options = new ServiceControlOptions();
        action.Invoke(options);
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

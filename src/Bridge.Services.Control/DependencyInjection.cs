namespace Bridge.Services.Control;

public static class DependencyInjection
{
    public static IServiceRegistrator AddServiceHostClinet(this IServiceCollection services, Action<ServiceHostClientOptions> action)
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceHostClientOptions();
        action.Invoke(options);
        services.AddSingleton(options);
        services.AddSingleton<IServiceHostClient, ServiceHostClient>();
        return new ServiceRegistrator(services);
    }

    public static IServiceCollection AddServiceControlClient(this IServiceCollection services)
    {
        services.AddSingleton<IServiceControlClient, ServiceControlClient>();
        return services;
    }
}

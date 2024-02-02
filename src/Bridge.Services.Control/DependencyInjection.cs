namespace Bridge.Services.Control;

public static class DependencyInjection
{
    public static IServiceRegistrator AddServiceHostClinet(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<ServiceHostClientOptions>().Bind(configuration.GetSection(ServiceHostClientOptions.SectionName));
        services.AddSingleton<IServiceHostClient, ServiceHostClient>();
        return new ServiceRegistrator(services);
    }

    public static IServiceCollection AddServiceControlClient(this IServiceCollection services)
    {
        services.AddSingleton<IServiceControlClient, ServiceControlClient>();
        return services;
    }
}

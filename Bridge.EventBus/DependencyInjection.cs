namespace Bridge.EventBus;

public static class DependencyInjection
{
    public static IHandlersRegistrator AddEventBus(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<EventBusOptions>().Bind(configuration.GetSection(EventBusOptions.SectionName));
        services.AddScoped<IEventBusService, EventBusService>();
        return new HandlersRegistrator(services);
    }
}


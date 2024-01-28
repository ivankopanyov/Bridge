namespace Bridge.EventBus;

public static class DependencyInjection
{
    public static IHandlersRegistrator AddEventBus(this IServiceCollection services, Action<EventBusOptions>? optionsAction = null)
    {
        var options = new EventBusOptions();
        optionsAction?.Invoke(options);
        services.AddSingleton(options);
        services.AddSingleton<IEventBusService, EventBusService>();
        return new HandlersRegistrator(services);
    }
}


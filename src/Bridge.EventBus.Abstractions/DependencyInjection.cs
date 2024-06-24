namespace Bridge.EventBus.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddEventBusFactory<TTransport, TOptions>(this IServiceCollection services, TOptions options)
        where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase
    {
        services.AddSingleton(options);
        services.AddSingleton<ITransport<TOptions>, TTransport>();
        services.AddSingleton<IEventBusFactory, EventBusFactory<TOptions>>();

        return services;
    }
    public static IServiceCollection AddEventBusFactory<TTransport, TOptions, TContractResolver>(this IServiceCollection services, TOptions options)
        where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase
    {
        services.AddSingleton(options);
        services.AddSingleton<ITransport<TOptions>, TTransport>();
        services.AddSingleton<IEventBusFactory, EventBusFactory<TOptions>>();

        return services;
    }
}

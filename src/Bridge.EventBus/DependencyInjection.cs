namespace Bridge.EventBus;

public static class DependencyInjection
{
    public static IServiceControlBuilder AddEventBus(this IServiceControlBuilder builder, Action<IEventBusBuilder> action)
    {
        builder.Services.AddSingleton<IEventBusService, EventBusService>();

        builder
            .AddService<RabbitMqServiceNode, RabbitMqOptions>(options => options.Name = "RabbitMq")
            .AddService<ElasticSearchServiceNode, ElasticSearchOptions>(options => options.Name = "ElasticSearch");

        var handlerBuilder = new EventBusBuilder(builder.Services);
        action.Invoke(handlerBuilder);
        return builder;
    }
}


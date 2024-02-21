using Serilog.Events;

namespace Bridge.EventBus;

public static class DependencyInjection
{
    private const string OUTPUT_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {"
        + Extensions.LoggerExtensions.QUEUE + "} {" + Extensions.LoggerExtensions.HANDLER + "} {"
        + Extensions.LoggerExtensions.TASK + "} {Message}{NewLine}";

    private const string OUTPUT_FILE_TEMPLATE = OUTPUT_CONSOLE_TEMPLATE + "{Exception}{NewLine}";

    public static IServiceControlBuilder AddEventBus(this IServiceControlBuilder builder, Action<IEventBusBuilder> action)
    {
        builder.Services.AddSingleton<IEventBusService, EventBusService>();

        builder
            .AddService<RabbitMqServiceNode, RabbitMqOptions>(options => options.Name = "RabbitMQ")
            .AddService<ElasticSearchServiceNode, ElasticSearchOptions>(options => options.Name = "Elasticsearch");

        var handlerBuilder = new EventBusBuilder(builder.Services);
        action.Invoke(handlerBuilder);

        handlerBuilder.LoggerConfiguration?.WriteTo.Logger(config => config
            .Filter.ByIncludingOnly(e =>
                e.Properties.Keys.Contains(Extensions.LoggerExtensions.QUEUE) &&
                e.Properties.Keys.Contains(Extensions.LoggerExtensions.HANDLER) &&
                e.Properties.Keys.Contains(Extensions.LoggerExtensions.TASK))
            .WriteTo.Console(outputTemplate: OUTPUT_CONSOLE_TEMPLATE)
            .WriteTo.File(handlerBuilder.LogFileName ?? $"logs/events_.log", outputTemplate: OUTPUT_FILE_TEMPLATE, rollingInterval: RollingInterval.Day));

        builder.Services.AddSingleton<IRabbitMqService, RabbitMqService>();
        builder.Services.AddSingleton<IElasticSearchService, ElasticSearchService>();

        return builder;
    }
}


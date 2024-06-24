namespace Bridge.EventBus;

public static class DependencyInjection
{
    private const string OUTPUT_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {"
        + Extensions.LoggerExtensions.QUEUE + "} {" + Extensions.LoggerExtensions.HANDLER + "} {"
        + Extensions.LoggerExtensions.TASK + "} {Message}{NewLine}";

    private const string OUTPUT_FILE_TEMPLATE = OUTPUT_CONSOLE_TEMPLATE + "{Exception}{NewLine}";
    
    public static IEventBusBuilder AddEventBus<TTransport, TOptions>(this IServiceCollection services, Action<TOptions> transportOptionsAction,
        Action<EventBusOptions>? eventBusOptionsAction = null) where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase, new()
    {
        var options = new TOptions();
        transportOptionsAction.Invoke(options);
        services.AddEventBusFactory<TTransport, TOptions>(options);

        if (eventBusOptionsAction != null)
        {
            var eventBusOptions = new EventBusOptions();
            eventBusOptionsAction.Invoke(eventBusOptions);

            eventBusOptions.LoggerConfiguration?.WriteTo.Logger(config => config
                .Filter.ByIncludingOnly(e =>
                    e.Properties.Keys.Contains(Extensions.LoggerExtensions.QUEUE) &&
                    e.Properties.Keys.Contains(Extensions.LoggerExtensions.HANDLER) &&
                    e.Properties.Keys.Contains(Extensions.LoggerExtensions.TASK))
                .WriteTo.Console(outputTemplate: OUTPUT_CONSOLE_TEMPLATE)
                .WriteTo.File(eventBusOptions.LogFileName ?? $"logs/events_.log", outputTemplate: OUTPUT_FILE_TEMPLATE, rollingInterval: RollingInterval.Day));
        }

        return new EventBusBuilder(services, options.HostId);
    }
}


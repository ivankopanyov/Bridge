namespace Bridge.Services.Control;

public static class DependencyInjection
{
    private const string OUTPUT_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {"
        + Extensions.Logging.LoggerExtensions.SERVICE + "} {Message}{NewLine}";

    private const string OUTPUT_FILE_TEMPLATE = OUTPUT_CONSOLE_TEMPLATE + "{Exception}{NewLine}";

    public static IServiceControlBuilder AddServiceControl<TTransport, TOptions>(this IServiceCollection services, Action<TOptions> transportOptionsAction, Action<HostOptions> hostOptionsAction)
        where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase, new()
    {
        var hostName = AddControl<TTransport, TOptions>(services, transportOptionsAction, hostOptionsAction);
        return new ServiceControlBuilder(services, hostName);
    }

    public static IServiceControlBuilder<TEnvironment> AddServiceControl<TTransport, TOptions, TEnvironment>(this IServiceCollection services, Action<TOptions> transportOptionsAction, Action<HostOptions> hostOptionsAction)
        where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase, new() where TEnvironment : class, new()
    {
        var hostName = AddControl<TTransport, TOptions>(services, transportOptionsAction, hostOptionsAction);
        return new ServiceControlBuilder<TEnvironment>(services, hostName);
    }

    private static string AddControl<TTransport, TOptions>(IServiceCollection services, Action<TOptions> transportOptionsAction, Action<HostOptions> hostOptionsAction)
        where TTransport : class, ITransport<TOptions> where TOptions : EventBusOptionsBase, new()
    {
        var transportOptions = new TOptions();
        transportOptionsAction.Invoke(transportOptions);
        services
            .AddEventBusFactory<TTransport, TOptions>(transportOptions)
            .AddSingleton<ServiceControlSerializerSettings>();

        var hostOptions = new HostOptions();
        hostOptionsAction.Invoke(hostOptions);

        hostOptions.LoggerConfiguration?.WriteTo.Logger(config => config
            .Filter.ByIncludingOnly(e => e.Properties.Keys.Contains(Extensions.Logging.LoggerExtensions.SERVICE))
            .WriteTo.Console(outputTemplate: OUTPUT_CONSOLE_TEMPLATE)
            .WriteTo.File(hostOptions.LogFileName ?? $"logs/{hostOptions.HostName}_services_.log", outputTemplate: OUTPUT_FILE_TEMPLATE, rollingInterval: RollingInterval.Day));

        return hostOptions.HostName;
    }
}

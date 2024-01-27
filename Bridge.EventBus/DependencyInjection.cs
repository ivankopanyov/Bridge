using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using LoggerExtensions = Bridge.EventBus.Extensions.LoggerExtensions;

namespace Bridge.EventBus;

public static class DependencyInjection
{
    private const string OUTLINE_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3} {"
        + LoggerExtensions.QUEUE + "} {" + LoggerExtensions.HANDLER + "} {" + LoggerExtensions.TASK
        + "} {Message}{NewLine}";

    public static IHandlersRegistrator AddEventBus(this IServiceCollection services, Action<EventBusOptions>? optionsAction = null)
    {
        var options = new EventBusOptions();
        optionsAction?.Invoke(options);
        services.AddSingleton(options);
        services.AddScoped<IEventBusService, EventBusService>();

        var loggerConfiguration = new LoggerConfiguration();
        loggerConfiguration.WriteTo.Console(outputTemplate: OUTLINE_CONSOLE_TEMPLATE, theme: AnsiConsoleTheme.Code);

        services.AddSerilog(loggerConfiguration.CreateLogger());

        return new HandlersRegistrator(services);
    }
}


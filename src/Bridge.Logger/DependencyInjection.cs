namespace Bridge.Logger;

public static class DependencyInjection
{
    private const string OUTPUT_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {"
        + LoggerExtensions.QUEUE + "} {" + LoggerExtensions.HANDLER + "} {"
        + LoggerExtensions.TASK + "} {" + LoggerExtensions.SERVICE + "} {Message}{NewLine}";

    private const string OUTPUT_FILE_TEMPLATE = OUTPUT_CONSOLE_TEMPLATE + "{Exception}{NewLine}";

    public static IServiceCollection AddLogger(this IServiceCollection services)
    {
        var loggerConfiguration = new LoggerConfiguration();

        loggerConfiguration.WriteTo.Console(outputTemplate: OUTPUT_CONSOLE_TEMPLATE, theme: AnsiConsoleTheme.Code);
        loggerConfiguration.WriteTo.File("logs/.log", outputTemplate: OUTPUT_FILE_TEMPLATE, rollingInterval: RollingInterval.Day);

        services.AddSerilog(loggerConfiguration.CreateLogger());

        return services;
    }
}

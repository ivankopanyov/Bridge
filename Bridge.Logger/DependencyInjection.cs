namespace Bridge.Logger;

public static class DependencyInjection
{
    private const string OUTLINE_CONSOLE_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3} {#if "
        + LoggerExtensions.QUEUE + " is not null}({" + LoggerExtensions.QUEUE + "} {" + LoggerExtensions.HANDLER
        + "} {" + LoggerExtensions.TASK + "}){#end}{#if " + LoggerExtensions.SERVICE + " is not null}("
        + LoggerExtensions.SERVICE + "){#end}{Message}{NewLine}";

    private const string OUTLINE_FILE_TEMPLATE = OUTLINE_CONSOLE_TEMPLATE + " {Exception}{NewLine}";

    private static readonly ExpressionTemplate _outlineConsoleTemplate = new(OUTLINE_CONSOLE_TEMPLATE);

    private static readonly ExpressionTemplate _outlineFileTemplate = new(OUTLINE_FILE_TEMPLATE);

    public static IServiceCollection AddLogger(this IServiceCollection services)
    {
        var loggerConfiguration = new LoggerConfiguration();

        loggerConfiguration.WriteTo.Console(_outlineConsoleTemplate);
        loggerConfiguration.WriteTo.File(_outlineFileTemplate, "logs/app-.log", rollingInterval: RollingInterval.Day);

        services.AddSerilog(loggerConfiguration.CreateLogger());

        return services;
    }
}

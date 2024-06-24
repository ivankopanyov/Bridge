namespace Bridge.Extensions.Logging;

public static class LoggerExtensions
{
    public const string SERVICE = "ServiceName";

    public static void LogActive(this ILogger logger, string serviceName)
    {
        var state = new Dictionary<string, object>()
        {
            { SERVICE, serviceName ?? string.Empty }
        };

        using (logger.BeginScope(state))
        {
            logger.LogInformation("Active.");
        };
    }

    public static void LogUnactive(this ILogger logger, string serviceName, string? message = null, Exception? ex = null)
    {
        var state = new Dictionary<string, object>()
        {
            { SERVICE, serviceName ?? string.Empty }
        };

        using (logger.BeginScope(state))
        {
            logger.LogError(ex, $"Unactive: {message ?? ex?.Message ?? "No message."}");
        };
    }

    public static void LogWarning(this ILogger logger, string serviceName, string? message = null, Exception? ex = null)
    {
        var state = new Dictionary<string, object>()
        {
            { SERVICE, serviceName ?? string.Empty }
        };

        using (logger.BeginScope(state))
        {
            logger.LogWarning(ex, $"Warning: {message ?? ex?.Message ?? "No message."}");
        };
    }
}


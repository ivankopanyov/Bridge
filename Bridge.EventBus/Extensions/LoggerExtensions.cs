namespace Bridge.EventBus.Extensions;

internal static class LoggerExtensions
{
    private const string UNKNOWN_QUEUE = "UNKNOWN_QUEUE";

    private const string UNKNOWN_HANDLER = "UNKNOWN_HANDLER";

    private const string UNKNOWN_TASK = "\"UNKNOWN_TASK\"";

    private const string NO_MESSAGE = "No message.";

    public static void Successful(this ILogger logger, string? queueName, string? handlerName, string? taskId)
    {
        logger.LogCritical($"{FixQueueName(queueName)} {FixHandlerName(handlerName)} {FixTaskId(taskId)} Successful");
    }

    public static void Error(this ILogger logger, string? queueName, string? handlerName, string? taskId, Exception ex)
    {
        logger.LogCritical(ex, $"{FixQueueName(queueName)} {FixHandlerName(handlerName)} {FixTaskId(taskId)} {ex.Message}");
    }

    public static void Critical(this ILogger logger, string? handlerName, string? message)
    {
        logger.LogCritical($"{UNKNOWN_QUEUE} {FixHandlerName(handlerName)} {UNKNOWN_TASK} {FixMessage(message)}");
    }

    public static void Critical(this ILogger logger, string? handlerName, Exception ex)
    {
        logger.LogCritical(ex, $"{UNKNOWN_QUEUE} {FixHandlerName(handlerName)} {UNKNOWN_TASK} {ex.Message}");
    }

    private static string FixQueueName(string? queueName)
    {
        queueName = queueName?.Trim();
        return string.IsNullOrEmpty(queueName) ? UNKNOWN_QUEUE : queueName;
    }

    private static string FixHandlerName(string? handlerName)
    {
        handlerName = handlerName?.Trim();
        return string.IsNullOrEmpty(handlerName) ? UNKNOWN_HANDLER : handlerName;
    }

    private static string FixTaskId(string? taskId) 
        => string.IsNullOrEmpty(taskId) ? UNKNOWN_TASK : $"\"{taskId}\"";

    private static string FixMessage(string? message)
    {
        message = message?.Trim();
        return string.IsNullOrEmpty(message) ? NO_MESSAGE : message;
    }
}

namespace Bridge.Extensions.Logging;

public static class LoggerExtensions
{
    public const string QUEUE = "QueueName";

    public const string HANDLER = "HandlerName";

    public const string TASK = "TaskId";

    public const string SERVICE = "ServiceName";

    private const string UNKNOWN_QUEUE = "UNKNOWN_QUEUE";

    private const string UNKNOWN_HANDLER = "UNKNOWN_HANDLER";

    private const string UNKNOWN_TASK = "\"UNKNOWN_TASK\"";

    private const string UNKNOWN_SERVICE = "UNKNOWN_SERVICE";

    private const string NO_MESSAGE = "No message.";

    public static void Successful(this ILogger logger, string? queueName, string? handlerName, string? taskId, string? @in)
    {
        var log = "Complete task!";

        if (@in != null)
            log += $"\n\t-->{FixInOut(@in)}";

        logger.Log(LogLevel.Information, log, queueName, handlerName, taskId); 
    }

    public static void Successful(this ILogger logger, string? queueName, string? handlerName, string? taskId, string? @in, string? @out)
    {
        var log = "Succesful send message!";

        if (@in != null)
            log += $"\n\t-->{FixInOut(@in)}";

        if (@out != null)
            log += $"\n\t<--{FixInOut(@out)}";

        logger.Log(LogLevel.Information, log, queueName, handlerName, taskId); 
    }

    public static void Info(this ILogger logger, string? sericeName, string? message)
        => logger.Log(LogLevel.Error, message, sericeName, null);

    public static void Error(this ILogger logger, string? sericeName, Exception ex)
        => logger.Log(LogLevel.Error, ex?.Message, sericeName, ex);

    public static void Error(this ILogger logger, string? sericeName, string? message)
        => logger.Log(LogLevel.Error, message, sericeName, null);

    public static void Error(this ILogger logger, string? queueName, string? handlerName, string? taskId, string? @in, Exception ex)
    {
        var log = FixMessage(ex?.Message);

        if (@in != null)
            log += $"\n\t-->{FixInOut(@in)}";

        logger.Log(LogLevel.Error, log, queueName, handlerName, taskId, ex); 
    }

    public static void Critical(this ILogger logger, string? handlerName, string? message)
        => logger.Log(LogLevel.Critical, message, handlerName: handlerName);

    public static void Critical(this ILogger logger, string? handlerName, Exception ex)
        => logger.Log(LogLevel.Critical, ex?.Message, handlerName: handlerName, ex: ex);

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

    private static string FixServiceName(string? serviceName)
    {
        serviceName = serviceName?.Trim();
        return string.IsNullOrEmpty(serviceName) ? UNKNOWN_SERVICE : serviceName;
    }

    private static string FixTaskId(string? taskId)
        => string.IsNullOrEmpty(taskId) ? UNKNOWN_TASK : $"\"{taskId}\"";

    private static string FixMessage(string? message)
    {
        message = message?.Trim();
        return string.IsNullOrEmpty(message) ? NO_MESSAGE : message;
    }

    private static string FixInOut(string inOut) => inOut.Replace("\n", "\n\t   ");

    private static void Log(this ILogger logger, LogLevel level, string? message, string? queueName = null, string? handlerName = null, string? taskId = null, Exception? ex = null)
    {
        var state = new Dictionary<string, object>()
        {
            { QUEUE, FixQueueName(queueName) },
            { HANDLER, FixHandlerName(handlerName) },
            { TASK, FixTaskId(taskId) }
        };

        using (logger.BeginScope(state))
        {
            logger.Log(level, ex, message);
        };
    }

    private static void Log(this ILogger logger, LogLevel level, string? message, string? serviceName, Exception? ex)
    {
        var state = new Dictionary<string, object>()
        {
            { SERVICE, FixServiceName(serviceName) }
        };

        using (logger.BeginScope(state))
        {
            logger.Log(level, ex, message);
        };
    }
}


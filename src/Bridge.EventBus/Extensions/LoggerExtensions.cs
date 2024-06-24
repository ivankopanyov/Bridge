namespace Bridge.EventBus.Extensions;

internal static class LoggerExtensions
{
    public const string QUEUE = "QueueName";

    public const string HANDLER = "HandlerName";

    public const string TASK = "TaskId";

    public static void LogEvent(this ILogger logger, EventLog eventLog, Exception? ex = null)
    {
        var state = new Dictionary<string, object>()
        {
            { QUEUE, FixLog(eventLog.TaskName, "UNKNOWN_QUEUE") },
            { HANDLER, FixLog(eventLog.HandlerName, "UNKNOWN_HANDLER") },
            { TASK, FixLog(eventLog.TaskId, "\"UNKNOWN_TASK\"") }
        };

        LogLevel logLevel = LogLevel.Information;
        if (eventLog.IsError)
            logLevel = eventLog.IsEnd ? LogLevel.Critical : LogLevel.Error;

        using (logger.BeginScope(state))
        {
            logger.Log(logLevel, ex, FixLog(eventLog.Message, "No message."));
        };
    }

    private static string FixLog(string? value, string defaultLog)
    {
        value = value?.Trim();
        return string.IsNullOrEmpty(value) ? defaultLog : value;
    }
}

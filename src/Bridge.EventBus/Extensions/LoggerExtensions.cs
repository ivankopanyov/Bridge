namespace Bridge.EventBus.Extensions;

internal static class LoggerExtensions
{
    public const string QUEUE = "QueueName";

    public const string HANDLER = "HandlerName";

    public const string TASK = "TaskId";

    public static void LogEvent(this ILogger logger, ElasticLog elasticLog, string? message = null, Exception? ex = null)
    {
        var state = new Dictionary<string, object>()
        {
            { QUEUE, FixLog(elasticLog.QueueName, "UNKNOWN_QUEUE") },
            { HANDLER, FixLog(elasticLog.HandlerName, "UNKNOWN_HANDLER") },
            { TASK, FixLog(elasticLog.TaskId, "\"UNKNOWN_TASK\"") }
        };

        string log = message ?? ex?.Message ?? "No message."; 
        
        if (elasticLog.In != null)
            log += $"\n\t--> {elasticLog.In}";

        if (elasticLog.Out != null)
            log += $"\n\t<-- {elasticLog.Out}";

        using (logger.BeginScope(state))
        {
            logger.Log(elasticLog.LogLevel, ex, FixLog(message ?? ex?.Message, "No message."));
        };
    }

    private static string FixLog(string? value, string defaultLog)
    {
        value = value?.Trim();
        return string.IsNullOrEmpty(value) ? defaultLog : value;
    }
}

namespace Bridge.EventBus;

internal class ElasticLog
{
    public string? QueueName { get; set; }

    public string? HandlerName { get; set; }

    public string? TaskId { get; set; }

    public LogLevel LogLevel { get; set; }

    public string? Error { get; set; }

    public string? StackTrace { get; set; }

    public DateTime DateTime { get; set; } = DateTime.Now;

    public object? In { get; set; }

    public object? Out { get; set; }
}

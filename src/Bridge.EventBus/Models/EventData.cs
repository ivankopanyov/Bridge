namespace Bridge.EventBus;

public class EventData
{
    public string LogId { get; set; }

    public string TaskId { get; set; }

    public string? Error { get; set; }

    public string? StackTrace { get; set; }

    public string? InputObjectJson { get; set; }
}

namespace Bridge.EventBus;

public class EventLog : IComparable<EventLog>
{
    public string Id { get; set; }

    public string TaskId { get; set; }

    public string? TaskName { get; set; }

    public string? HandlerName { get; set; }

    [JsonConverter(typeof(DateTimeConverter))]
    public DateTime DateTime { get; set; } = DateTime.Now.Trim(TimeSpan.TicksPerMillisecond);

    public bool IsError { get; set; }

    public bool IsEnd { get; set; }

    public string? Message { get; set; }

    public EventData? Data { get; set; }

    public int CompareTo(EventLog? other) => -DateTime.Compare(DateTime, other?.DateTime ?? DateTime.MinValue);
}


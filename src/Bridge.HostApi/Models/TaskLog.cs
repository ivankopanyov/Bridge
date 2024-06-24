namespace Bridge.HostApi.Models;

public class TaskLog
{
    [JsonIgnore]
    private EventLog _first;

    public string Id => _first.TaskId;

    public string? TaskName => _first.TaskName;

    public string? HandlerName => _first.HandlerName;

    public DateTime DateTime => _first.DateTime;

    public bool IsError => _first.IsError;

    public bool IsEnd => _first.IsEnd;

    public string? Message => _first.Message;

    public SortedSet<EventLog> Logs { get; set; } = [];

    public TaskLog AddLog(EventLog eventLog)
    {
        if (eventLog != null)
            Logs.Add(eventLog);

        _first = Logs.First();

        return this;
    }
}

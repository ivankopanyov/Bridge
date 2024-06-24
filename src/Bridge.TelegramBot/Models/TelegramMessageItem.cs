namespace Bridge.TelegramBot.Models;

public class TelegramMessageItem : IComparable<TelegramMessageItem>
{
    private const int MAX_LENGTH_INFO = 100;

    public DateTime DateTime { get; set; }

    public string? TaskName { get; set; }

    public string? HandlerName { get; set; }

    public string? Message { get; set; }

    public bool IsError { get; set; }

    public string? Error { get; set; }

    public bool IsEnd { get; set; }

    public static implicit operator TelegramMessageItem(EventLog eventLog) => new()
    {
        DateTime = eventLog.DateTime,
        TaskName = eventLog.TaskName,
        HandlerName = eventLog.HandlerName,
        Message = eventLog.Message,
        IsError = eventLog.IsError,
        Error = eventLog.Data?.Error,
        IsEnd = eventLog.IsEnd
    };

    public int CompareTo(TelegramMessageItem? other) => -DateTime.Compare(DateTime, other?.DateTime ?? DateTime.MinValue);

    public override string ToString() => new StringBuilder()
        .AppendLine($"🖥 {HandlerName ?? "UNKNOWN"}\n📅 {DateTime:dd.MM.yyyy HH:mm:ss}")
        .AppendLineSubstring(Message, MAX_LENGTH_INFO, "💬 ")
        .AppendLineSubstring(Error, MAX_LENGTH_INFO, "⚠️ ")
        .ToString();
}

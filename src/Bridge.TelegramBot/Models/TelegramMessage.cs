namespace Bridge.TelegramBot.Models;

public class TelegramMessage
{   
    private const int TASK_NAME_MAX_LENGTH = 20;

    private const int BODY_MAX_LENGTH = 4070;

    public long ChatId { get; set; }

    public int MessageId { get; set; }

    public SortedSet<TelegramMessageItem> Items { get; set; } = [];

    public override string ToString() => Items.FirstOrDefault() is not TelegramMessageItem item ? string.Empty : new StringBuilder()
        .Append(!item.IsEnd ? "⏳" : string.Empty)
        .Append(item.IsError ? "❌" : "✅")
        .Append(' ')
        .AppendLineSubstring(item.TaskName, TASK_NAME_MAX_LENGTH, defaultValue: "UNKNOWN")
        .AppendLine()
        .AppendSubstring(string.Join('\n', Items), BODY_MAX_LENGTH)
        .ToString();
}

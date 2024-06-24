namespace Bridge.TelegramBot.Models;

public class TelegramChat
{
    public long Id { get; set; }

    public int? MessageThreadId { get; set; }

    public bool OnlyError { get; set; }

    public override string ToString()
    {
        var result = Id.ToString();

        if (MessageThreadId != null)
            result += $"/{MessageThreadId}";

        return result;
    }
}

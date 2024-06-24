namespace Bridge.DefaultServices;

public class BridgeEnvironment
{
    [Description("Синхронизировать изменения в бронированиях.")]
    public bool UseReservation { get; set; }

    [Description("Синхронизировать платежные начисления.")]
    public bool UsePosting { get; set; }

    [Description("Сохранять чеки в базу данных MICROS.")]
    public bool UseCheckDatabase { get; set; } = true;

    [Required(AllowEmptyStrings = true), Description("Код отеля в базе данных OPERA.")]
    public string ResortCode { get; set; } = string.Empty;

    public decimal Rvc { get; set; }

    [Required, MaxLength(10)]
    public Dictionary<string, bool> TaxCodes { get; set; } = [];

    [Required]
    public HashSet<string> TrxCodes { get; set; } = [];

    [Required, Description("Альтернативные коды типов документов.")]
    public Dictionary<string, string> DocumentTypeAliases { get; set; } = [];

    [Required, EnumerableRegularExpression(@"^-?\d{1,19}(/-?\d{1,10})?$")]
    [Description("ID Telegram-чатов в формате chat_id/message_thread_id для отправки логов.\nОтметьте галочкой чаты, в которые нужно отправлять только сообщения об ошибках.")]
    public Dictionary<string, bool> TelegramChats { get; set; } = [];

    public override int GetHashCode() =>
        HashCode.Combine(UseReservation, UsePosting, UseCheckDatabase, ResortCode, Rvc, TaxCodes, TrxCodes, DocumentTypeAliases);

    public override bool Equals(object? obj)
    {
        if (obj is not BridgeEnvironment other
            || UseReservation != other.UseReservation
            || UsePosting != other.UsePosting
            || UseCheckDatabase != other.UseCheckDatabase
            || ResortCode != other.ResortCode
            || Rvc != other.Rvc
            || !TaxCodes.Keys.ToHashSet().SetEquals(other.TaxCodes.Keys)
            || !TrxCodes.SetEquals(other.TrxCodes)
            || !DocumentTypeAliases.Keys.ToHashSet().SetEquals(other.DocumentTypeAliases.Keys)
            || !TelegramChats.Keys.ToHashSet().SetEquals(other.TelegramChats.Keys))
            return false;

        foreach (var key in TaxCodes.Keys)
            if (TaxCodes[key] != other.TaxCodes[key])
                return false;

        foreach (var key in DocumentTypeAliases.Keys)
            if (DocumentTypeAliases[key] != other.DocumentTypeAliases[key])
                return false;

        foreach (var key in TelegramChats.Keys)
            if (TelegramChats[key] != other.TelegramChats[key])
                return false;

        return true;
    }
}

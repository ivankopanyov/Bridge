namespace Bridge.EventBus.Shared;

public class PostRequestInfo
{
    public Dictionary<string, string> Headers { get; set; }

    public string CorrelationId { get; set; }

    public string? ReservationGuestId { get; set; }

    public string InvoiceGenericNo { get; set; }

    public string? FolioGenericNo { get; set; }

    public ISet<TransactionInfo> Transactions { get; set; }
}

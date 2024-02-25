namespace Bridge.EventBus.Shared;

public class PostRequestInfo
{
    public string? ReservationGuestId { get; set; }

    public string InvoiceGenericNo { get; set; }

    public string? FolioGenericNo { get; set; }

    public int Rvc { get; set; }

    public ISet<TransactionInfo> Transactions { get; set; }
}

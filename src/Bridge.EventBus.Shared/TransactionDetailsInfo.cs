namespace Bridge.EventBus.Shared;

public class TransactionDetailsInfo
{
    public int ItemKind { get; set; }

    public string Name { get; set; }

    public decimal Amount { get; set; }

    public string ServiceItemCode { get; set; }

    public decimal Count { get; set; }

    public string TransactionCode { get; set; }
}

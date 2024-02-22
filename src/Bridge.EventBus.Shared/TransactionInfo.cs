namespace Bridge.EventBus.Shared;

public class TransactionInfo
{
    public DateTime? ScheduleDate { get; set; }

    public string TransactionCode { get; set; }

    public string Name { get; set; }

    public ISet<TransactionDetailsInfo> Items { get; set; }
}

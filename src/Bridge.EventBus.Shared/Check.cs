namespace Bridge.EventBus.Shared;

public class Check
{
    public Dictionary<string, string> Headers { get; set; }

    public string CorrelationId { get; set; }

    public DateTime DateTime { get; set; }

    public string Total { get; set; }

    public IEnumerable<FiscalCheckItem> Details { get; set; }
}

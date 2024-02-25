namespace Bridge.EventBus.Shared;

public class Check
{
    public int Rvc { get; set; }

    public int CheckNumber { get; set; }

    public DateTime DateTime { get; set; }

    public string Total { get; set; }

    public IEnumerable<FiscalCheckItem> Details { get; set; }
}

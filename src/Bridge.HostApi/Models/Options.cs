namespace Bridge.HostApi.Models;

public class Options
{
    public string HostName { get; set; }

    public string ServiceName { get; set; }

    public string? Value { get; set; }

    public virtual Service Service { get; set; }

    public virtual Host Host { get; set; }
}

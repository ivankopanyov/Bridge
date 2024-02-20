namespace Bridge.HostApi.Models;

public class Service
{
    public string ServiceName { get; set; }

    public string HostName { get; set; }

    public string? JsonOptions { get; set; }

    public virtual Host Host { get; set; }
}

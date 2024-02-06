namespace Bridge.HostApi.Models;

public class Service
{
    public string ServiceName { get; set; }

    public string HostName { get; set; }

    public virtual Options? Options { get; set; }

    public virtual Host Host { get; set; }
}

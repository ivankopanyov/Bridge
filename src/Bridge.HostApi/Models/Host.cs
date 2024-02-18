namespace Bridge.HostApi.Models;

public class Host
{
    public string Name { get; set; }

    public virtual ICollection<Service> Services { get; set; }

    public Host()
    {
        Services = new HashSet<Service>();
    }
}

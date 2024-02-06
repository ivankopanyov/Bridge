namespace Bridge.HostApi.Models;

public class Host
{
    public string Name { get; set; }

    public virtual ICollection<Service> Services { get; set; }

    public virtual ICollection<Options> Options { get; set; }

    public Host()
    {
        Services = new HashSet<Service>();
        Options = new HashSet<Options>();
    }
}

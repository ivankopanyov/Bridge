namespace Bridge.HostApi.Models;

public class Host
{
    public string Name { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();
}

namespace Bridge.HostApi.Dto;

public class HostNode
{
    public string Name { get; set; }

    public ISet<ServiceNodeInfo> Services { get; set; } = new HashSet<ServiceNodeInfo>();

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object? obj) => obj is HostNode other && Name == other.Name;
}

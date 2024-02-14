namespace Bridge.HostApi.Dto;

public class HostNode
{
    public string Name { get; set; }

    public IEnumerable<ServiceNodeInfo> Services { get; set; }
}

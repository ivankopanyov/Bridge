namespace Bridge.HostApi.Dto;

public class ServiceNodeInfo(ServiceInfo serviceInfo)
{
    public string Name { get; init; } = serviceInfo.Name;

    public ServiceNodeState State { get; set; } = new ServiceNodeState(serviceInfo.State);

    public ServiceNodeOptions? Options { get; set; } = serviceInfo.Options != null
        ? new ServiceNodeOptions(serviceInfo.Options)
        : null;

    public ServiceInfo ToServiceInfo()
    {
        var serviceInfo = new ServiceInfo()
        {
            Name = Name,
            State = State.ToServiceState()
        };

        if (Options != null)
            serviceInfo.Options = Options.ToServiceOptions();

        return serviceInfo;
    }

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object? obj) => obj is ServiceNodeInfo other && other.Name == Name;
}

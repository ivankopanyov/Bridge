namespace Bridge.HostApi.Dto;

public class ServiceNodeInfo
{
    public string Name { get; init; }

    public string HostName { get; init; }

    public ServiceNodeState State { get; set; }

    public string? JsonOptions { get; set; }

    public ServiceNodeInfo(ServiceInfo serviceInfo)
    {
        Name = serviceInfo.Name;
        HostName = serviceInfo.HostName;
        State = new ServiceNodeState(serviceInfo.State);
        JsonOptions = serviceInfo.JsonOptions;
    }

    public ServiceInfo ToServiceInfo()
    {
        var serviceInfo = new ServiceInfo()
        {
            Name = Name,
            HostName = HostName,
            State = State.ToServiceState()
        }; 
        
        if (JsonOptions != null)
            serviceInfo.JsonOptions = JsonOptions;

        return serviceInfo;
    }

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object? obj) => obj is ServiceNodeInfo other && Name == other.Name;
}

namespace Bridge.HostApi.Models;

public class ServiceNodeInfo(ServiceInfo serviceInfo)
{
    public string Name { get; init; } = serviceInfo.Name;

    public bool UseRestart { get; init; } = serviceInfo.UseRestart;

    public ServiceState State { get; init; } = serviceInfo.State;

    public ServiceOptions? Options { get; init; } = serviceInfo.Options;

    public ServiceInfo ToServiceInfo()
    {
        var serviceInfo = new ServiceInfo()
        {
            Name = Name,
            UseRestart = UseRestart,
            State = State,
            Options = Options
        };

        if (Options != null)
            serviceInfo.Options = Options;

        return serviceInfo;
    }

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object? obj) => obj is ServiceNodeInfo other && other.Name == Name;
}

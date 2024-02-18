namespace Bridge.HostApi.Repositories.Abstract;

public interface IServiceRepository
{
    IReadOnlySet<HostNode>? Hosts { get; }

    Task<ServiceNodeInfo> UpdateServiceAsync(ServiceInfo serviceInfo, bool updateOptions);
}

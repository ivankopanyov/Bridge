namespace Bridge.HostApi.Repositories.Abstract;

public interface IServiceRepository
{
    Task<IEnumerable<ServiceInfo>> GetAllAsync();

    Task<ServiceInfo?> GetAsync(string hostName, string serviceName);

    Task<bool> AddAsync(ServiceInfo serviceInfo);

    Task<ServiceInfo> UpdateAsync(ServiceInfo serviceInfo, bool updateOptions);

    Task<ServiceInfo?> RemoveAsync(string hostName, string serviceName);
}

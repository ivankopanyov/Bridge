 namespace Bridge.HostApi.Repositories.Implement;

public class ServiceRepository(ICacheService cache) : IServiceRepository
{
    private static readonly Lazy<SemaphoreSlim> _semaphore = new(() => new(1));

    private static SemaphoreSlim Semaphore => _semaphore.Value;

    public async Task<IEnumerable<ServiceInfo>> GetAllAsync() => await cache.GetAllAsync<ServiceInfo>();

    public async Task<ServiceInfo?> GetAsync(string hostName, string serviceName)
    {
        ArgumentNullException.ThrowIfNull(hostName, nameof(hostName));
        ArgumentNullException.ThrowIfNull(serviceName, nameof(serviceName));

        var key = GetKey(hostName, serviceName);

        await Semaphore.WaitAsync();

        try
        {
            return await cache.GetAsync<ServiceInfo>(key);
        }
        finally
        {
            Semaphore.Release();
        }
    }

    public async Task<bool> AddAsync(ServiceInfo serviceInfo)
    {
        ArgumentNullException.ThrowIfNull(serviceInfo?.HostName, nameof(serviceInfo.HostName));
        ArgumentNullException.ThrowIfNull(serviceInfo?.Name, nameof(serviceInfo.Name));

        var key = GetKey(serviceInfo);

        await Semaphore.WaitAsync();

        try
        {
            var isExists = await cache.ExistsAsync<ServiceInfo>(key);
            if (!isExists)
                await cache.PushAsync(key, serviceInfo);

            return !isExists;
        }
        finally
        {
            Semaphore.Release();
        }
    }

    public async Task<ServiceInfo> UpdateAsync(ServiceInfo serviceInfo, bool updateOptions)
    {
        ArgumentNullException.ThrowIfNull(serviceInfo?.HostName, nameof(serviceInfo.HostName));
        ArgumentNullException.ThrowIfNull(serviceInfo?.Name, nameof(serviceInfo.Name));

        var info = serviceInfo.Clone();

        await Semaphore.WaitAsync();

        try
        {
            var key = GetKey(info);
            if (await cache.PopAsync<ServiceInfo>(key) is ServiceInfo s)
            {
                info.State ??= s.State;

                if (!updateOptions)
                    info.JsonOptions = s.JsonOptions;
            }

            await cache.PushAsync(key, info);

            return info;
        }
        finally
        {
            Semaphore.Release();
        }
    }

    public async Task<ServiceInfo?> RemoveAsync(string hostName, string serviceName)
    {
        ArgumentNullException.ThrowIfNull(hostName, nameof(hostName));
        ArgumentNullException.ThrowIfNull(serviceName, nameof(serviceName));

        await Semaphore.WaitAsync();

        try
        {
            return await cache.PopAsync<ServiceInfo>(GetKey(hostName, serviceName));
        }
        finally
        {
            Semaphore.Release();
        }
    }

    private static string GetKey(ServiceInfo serviceInfo) => GetKey(serviceInfo.HostName, serviceInfo.Name);

    private static string GetKey(string hostName, string serviceName) => $"{hostName}/{serviceName}";
}

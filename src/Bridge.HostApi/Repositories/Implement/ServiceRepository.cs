namespace Bridge.HostApi.Repositories.Implement;

public class ServiceRepository(BridgeDbContext context, ICacheService cache) : IServiceRepository
{
    private const string KEY = "services";

    private static readonly Lazy<SemaphoreSlim> _semaphore = new(() => new(1));

    private static SemaphoreSlim Semaphore => _semaphore.Value;

    public async Task<IEnumerable<ServiceInfo>> GetAllAsync()
    {
        await Semaphore.WaitAsync();

        try
        {
            if (await GetAllUsedAsync())
                return await cache.GetAllAsync<ServiceInfo>();

            var services = await context.Services.AsNoTracking().Select(s => new ServiceInfo
            {
                HostName = s.HostName,
                Name = s.ServiceName,
                JsonOptions = s.JsonOptions
            }).ToListAsync();

            foreach (var service in services)
                if (!await cache.ExistsAsync<ServiceInfo>(GetKey(service)))
                    await cache.PushAsync(GetKey(service), service);

            await UseGetAllAsync();
            return services;
        }
        finally
        {
            Semaphore.Release();
        }
    }

    public async Task<ServiceInfo?> GetAsync(string hostName, string serviceName)
    {
        ArgumentNullException.ThrowIfNull(hostName, nameof(hostName));
        ArgumentNullException.ThrowIfNull(serviceName, nameof(serviceName));

        var key = GetKey(hostName, serviceName);

        await Semaphore.WaitAsync();

        try
        {
            if (await cache.GetAsync<ServiceInfo>(key) is ServiceInfo serviceInfo)
                return serviceInfo;

            if (await context.Services.AsNoTracking()
                .FirstOrDefaultAsync(s => s.HostName == hostName && s.ServiceName == s.ServiceName) is Service service)
            {
                var info = new ServiceInfo
                {
                    HostName = hostName,
                    Name = serviceName,
                    JsonOptions = service.JsonOptions
                };

                await cache.PushAsync(key, info);
                return info;
            }

            return null;
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
            if (!await cache.ExistsAsync<ServiceInfo>(key))
            {
                if (!await GetAllUsedAsync())
                {
                    var host = await context.Hosts
                        .AsNoTracking()
                        .Include(h => h.Services)
                        .FirstOrDefaultAsync(h => h.Name == serviceInfo.HostName);

                    if (host?.Services.FirstOrDefault(s => s.ServiceName == serviceInfo.Name) is Service s)
                    {
                        await cache.PushAsync(key, new ServiceInfo
                        {
                            HostName = s.HostName,
                            Name = s.ServiceName,
                            JsonOptions = s.JsonOptions
                        });

                        return false;
                    }

                    var service = new Service()
                    {
                        HostName = serviceInfo.HostName,
                        ServiceName = serviceInfo.Name,
                        JsonOptions = serviceInfo.JsonOptions
                    };

                    if (host == null)
                        await context.Hosts.AddAsync(new()
                        {
                            Name = serviceInfo.HostName,
                            Services = [service]
                        });
                    else
                        await context.Services.AddAsync(service);

                    await context.SaveChangesAsync();
                }

                await cache.PushAsync(key, serviceInfo);
                return true;
            }

            return false;
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
            var host = await context.Hosts
                .Include(h => h.Services)
                .FirstOrDefaultAsync(h => h.Name == serviceInfo.HostName);

            if (host?.Services.FirstOrDefault(s => s.ServiceName == serviceInfo.Name) is not Service s)
            {
                var service = new Service()
                {
                    HostName = serviceInfo.HostName,
                    ServiceName = serviceInfo.Name,
                    JsonOptions = serviceInfo.JsonOptions
                };

                if (host == null)
                    await context.Hosts.AddAsync(new()
                    {
                        Name = serviceInfo.HostName,
                        Services = [service]
                    });
                else
                    await context.Services.AddAsync(service);

                await context.SaveChangesAsync();
            }
            else if (updateOptions)
            {
                s.JsonOptions = serviceInfo.JsonOptions;
                await context.SaveChangesAsync();
            }

            var key = GetKey(info);

            if (await cache.PopAsync<ServiceInfo>(key) is ServiceInfo cachedService)
            {
                info.State ??= cachedService.State;

                if (!updateOptions)
                    info.JsonOptions = cachedService.JsonOptions;
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
            var result = await cache.PopAsync<ServiceInfo>(GetKey(hostName, serviceName));

            var host = await context.Hosts
                .Include(h => h.Services)
                .FirstOrDefaultAsync(h => h.Name == hostName);

            if (host?.Services.FirstOrDefault(s => s.ServiceName == serviceName) is Service service)
            {
                if (host.Services.Count > 1)
                    context.Services.Remove(service);
                else
                    host.Services.Remove(service);

                await context.SaveChangesAsync();

                result ??= new()
                {
                    HostName = service.HostName,
                    Name = service.ServiceName,
                    JsonOptions = service.JsonOptions
                };
            }

            return result;
        }
        finally
        {
            Semaphore.Release();
        }
    }

    private async Task<bool> GetAllUsedAsync() => await cache.ExistsAsync<object>(KEY);

    private async Task UseGetAllAsync() => await cache.PushAsync(KEY, new object());

    private static string GetKey(ServiceInfo serviceInfo) => GetKey(serviceInfo.HostName, serviceInfo.Name);

    private static string GetKey(string hostName, string serviceName) => $"{hostName}/{serviceName}";
}

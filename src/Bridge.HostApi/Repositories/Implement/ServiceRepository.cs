namespace Bridge.HostApi.Repositories.Implement;

public class ServiceRepository(BridgeDbContext context) : IServiceRepository
{
    private static HashSet<HostNode> _hosts = [];

    private readonly BridgeDbContext _context = context;

    public IReadOnlySet<HostNode> Hosts => _hosts;

    public async Task<ServiceNodeInfo> UpdateServiceAsync(ServiceInfo serviceInfo, bool updateOptions)
    {
        var serviceNodeInfo = new ServiceNodeInfo(serviceInfo);

        var host = await (from h in _context.Hosts
                          select new Models.Host
                          {
                              Name = h.Name,
                              Services = h.Services.Where(s => s.ServiceName == serviceInfo.Name).ToHashSet()
                          }).FirstOrDefaultAsync(h => h.Name == serviceInfo.HostName);

        if (host == null)
            await _context.AddAsync(new Models.Host
            {
                Name = serviceNodeInfo.HostName,
                Services = new HashSet<Service>()
                    {
                        new()
                        {
                            HostName = serviceNodeInfo.HostName,
                            ServiceName = serviceNodeInfo.Name,
                            JsonOptions = serviceNodeInfo.JsonOptions
                        }
                    }
            });
        else if (host.Services.FirstOrDefault(s => s.ServiceName == serviceInfo.Name) is not Service service)
            await _context.Services.AddAsync(new Service
            {
                HostName = serviceNodeInfo.HostName,
                ServiceName = serviceNodeInfo.Name,
                JsonOptions = serviceNodeInfo.JsonOptions
            });
        else if (updateOptions)
            service.JsonOptions = serviceNodeInfo.JsonOptions;
        else
            serviceNodeInfo.JsonOptions = service.JsonOptions;

        await _context.SaveChangesAsync();

        if (_hosts.FirstOrDefault(h => h.Name == serviceInfo.HostName) is not HostNode hostNode)
            _hosts.Add(new HostNode
            {
                Name = serviceNodeInfo.HostName,
                Services = new HashSet<ServiceNodeInfo> { serviceNodeInfo }
            });
        else if (hostNode.Services.FirstOrDefault(s => s.Name == serviceInfo.Name) is not ServiceNodeInfo serviceNode)
            hostNode.Services.Add(serviceNodeInfo);
        else
        {
            serviceNode.State = serviceNodeInfo.State;
            if (updateOptions)
                serviceNode.JsonOptions = serviceNodeInfo.JsonOptions;

            return serviceNode;
        }

        return serviceNodeInfo;
    }
}

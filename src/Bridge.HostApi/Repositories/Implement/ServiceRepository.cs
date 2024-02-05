namespace Bridge.HostApi.Repositories.Implement;

public class ServiceRepository(BridgeDbContext context) : IServiceRepository
{
    private static readonly Dictionary<string, HashSet<ServiceNodeInfo>> _services = [];

    private readonly BridgeDbContext _context = context;

    public async Task<ServiceOptions?> GetOptionsAsync(Service service)
    {
        if (!_services.ContainsKey(service.Host))
        {
            _services.Add(service.Host, []);
            await _context.AddAsync(new Models.Host
            {
                Name = service.Host
            });
            await _context.SaveChangesAsync();
        }

        var serviceInfo = new ServiceNodeInfo(service.Service_);
        return _services[service.Host].Add(serviceInfo)
            ? serviceInfo.Options
            : _services[service.Host].First(s => s.Name == service.Service_.Name).Options;
    }

    public async Task SetServiceAsync(Service service)
    {
        if (!_services.ContainsKey(service.Host))
        {
            _services.Add(service.Host, []);
            await _context.AddAsync(new Models.Host
            {
                Name = service.Host
            });
            await _context.SaveChangesAsync();
        }

        var serviceInfo = new ServiceNodeInfo(service.Service_);
        _services[service.Host].Add(serviceInfo);
    }
}

namespace Bridge.HostApi.Repositories.Implement;

public class ServiceRepository(BridgeDbContext context) : IServiceRepository
{
    private static Dictionary<string, HashSet<ServiceNodeInfo>>? _services;

    private readonly BridgeDbContext _context = context;

    public IReadOnlyDictionary<string, HashSet<ServiceNodeInfo>>? Hosts => _services;

    public async Task<IEnumerable<string>> GetHostNamesAsync() => _services != null
        ? _services.Select(s => s.Key).ToHashSet()
        : await (from h in _context.Hosts.AsNoTracking()
                 select h.Name).ToListAsync();

    public async Task UpdateServicesAsync(ISet<Bridge.Services.Control.Services> services)
    {
        var temp = new Dictionary<string, HashSet<ServiceNodeInfo>>();
        var hosts = await _context.Hosts
            .Include(h => h.Services)
            .ThenInclude(s => s.Options)
            .ToListAsync();

        foreach (var host in hosts)
        {
            if (services.FirstOrDefault(s => s.Host == host.Name) is not Bridge.Services.Control.Services s)
            {
                _context.Hosts.Remove(host);
                continue;
            }
            else
                services.Remove(s);

            temp.Add(host.Name, []);
            var serviceList = s.Services_.ToHashSet();

            foreach (var service in host.Services)
            {
                if (serviceList.FirstOrDefault(s => s.Name == service.ServiceName) is not ServiceInfo serviceInfo)
                {
                    _context.Services.Remove(service);
                    continue;
                }

                serviceList.Remove(serviceInfo);
                var serviceNodeInfo = new ServiceNodeInfo(serviceInfo);
                if (service.Options == null && serviceNodeInfo.Options != null)
                    await _context.Options.AddAsync(new Options
                    {
                        HostName = host.Name,
                        ServiceName = service.ServiceName,
                        Value = serviceNodeInfo.Options.Options 
                    });
                else if (service.Options != null && serviceNodeInfo.Options == null)
                    _context.Options.Remove(service.Options);
                else if (service.Options != null && serviceNodeInfo.Options != null)
                {
                    var serviceOptions = new ServiceOptions();
                    if (service.Options.Value != null)
                        serviceOptions.Options = service.Options.Value;

                    serviceNodeInfo.Options = new Dto.ServiceNodeOptions(serviceOptions);
                }

                temp[host.Name].Add(serviceNodeInfo);
            }

            foreach (var service in serviceList)
                if (temp[host.Name].Add(new ServiceNodeInfo(service)))
                    await _context.Services.AddAsync(new Models.Service
                    {
                        HostName = host.Name,
                        ServiceName = service.Name,
                        Options = service.Options != null
                            ? new Options
                            {
                                HostName = host.Name,
                                ServiceName = service.Name,
                                Value = service.Options.Options 
                            }
                            : null
                    });
        }

        foreach (var host in services)
        {
            temp.Add(host.Host, host.Services_.Select(s => new ServiceNodeInfo(s)).ToHashSet());
            await _context.Hosts.AddAsync(new Models.Host
            {
                Name = host.Host,
                Services = host.Services_.Select(s => new Models.Service
                {
                    HostName = host.Host,
                    ServiceName = s.Name,
                    Options = s.Options != null
                        ? new Options
                        {
                            HostName = host.Host,
                            ServiceName = s.Name,
                            Value = s.Options.Options,
                        }
                        : null
                }).ToHashSet()
            });
        }

        await _context.SaveChangesAsync();

        _services = temp;
    }

    public async Task<ServiceOptions?> GetOptionsAsync(Bridge.Services.Control.Service service)
    {
        if (_services == null)
            throw new InvalidOperationException("Services have not yet been loaded.");

        if (!_services.ContainsKey(service.Host))
        {
            _services.Add(service.Host, []);
            await _context.AddAsync(new Models.Host
            {
                Name = service.Host
            });
            await _context.SaveChangesAsync();
        }

        if (!_services[service.Host].Add(new ServiceNodeInfo(service.Service_)))
        {
            var current = _services[service.Host].First(s => s.Name == service.Service_.Name);

            current.UseRestart = service.Service_.UseRestart;
            current.State = new ServiceNodeState(service.Service_.State);

            if (current.Options == null && service.Service_.Options != null)
            {
                current.Options = new Dto.ServiceNodeOptions(service.Service_.Options);
                await _context.Options.AddAsync(new Options
                {
                    HostName = service.Host,
                    ServiceName = service.Service_.Name,
                    Value = service.Service_.Options.Options
                });
                await _context.SaveChangesAsync(); 
            }
            else if (current.Options != null && service.Service_.Options == null)
            {
                current.Options = null;
                var options = await _context.Options.FirstAsync(o => o.HostName == service.Host && o.ServiceName == service.Service_.Name);
                _context.Options.Remove(options);
                await _context.SaveChangesAsync();
            }

            return current.Options?.ToServiceOptions();
        }

        await _context.Services.AddAsync(new Models.Service
        {
            HostName = service.Host,
            ServiceName = service.Service_.Name,
            Options = service.Service_.Options != null
                ? new Options
                { 
                    HostName = service.Host,
                    ServiceName = service.Service_.Name,
                    Value = service.Service_.Options.Options 
                }
                : null
        });

        await _context.SaveChangesAsync();

        return service.Service_.Options;
    }

    public async Task SetServiceStateAsync(Bridge.Services.Control.Service service) => await GetOptionsAsync(service);

    public async Task SetServiceOptionsAsync(Bridge.Services.Control.Service service)
    {
        if (_services == null)
            throw new InvalidOperationException("Services have not yet been loaded.");

        if (!_services.ContainsKey(service.Host))
        {
            _services.Add(service.Host, []);
            await _context.AddAsync(new Models.Host
            {
                Name = service.Host
            });
            await _context.SaveChangesAsync();
        }

        if (!_services[service.Host].Add(new ServiceNodeInfo(service.Service_)))
        {
            var current = _services[service.Host].First(s => s.Name == service.Service_.Name);

            current.UseRestart = service.Service_.UseRestart;
            current.State = new ServiceNodeState(service.Service_.State);

            if (current.Options != null)
            {
                current.Options = null;
                var options = await _context.Options.FirstAsync(o => o.HostName == service.Host && o.ServiceName == service.Service_.Name);
                _context.Options.Remove(options);
                await _context.SaveChangesAsync();
            }

            if (service.Service_.Options != null)
            {
                current.Options = new Dto.ServiceNodeOptions(service.Service_.Options);
                await _context.Options.AddAsync(new Options
                {
                    HostName = service.Host,
                    ServiceName = service.Service_.Name,
                    Value = service.Service_.Options.Options
                });
                await _context.SaveChangesAsync();
            }
        }
        else
        {
            await _context.Services.AddAsync(new Models.Service
            {
                HostName = service.Host,
                ServiceName = service.Service_.Name,
                Options = service.Service_.Options != null
                    ? new Options
                    {
                        HostName = service.Host,
                        ServiceName = service.Service_.Name,
                        Value = service.Service_.Options.Options
                    }
                    : null
            });
        }
    }
}

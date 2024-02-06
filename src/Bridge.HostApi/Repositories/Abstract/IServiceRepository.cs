using Bridge.HostApi.Dto;

namespace Bridge.HostApi.Repositories.Abstract;

public interface IServiceRepository
{
    IReadOnlyDictionary<string, HashSet<ServiceNodeInfo>>? Hosts { get; }

    Task<IEnumerable<string>> GetHostNamesAsync();

    Task UpdateServicesAsync(ISet<Bridge.Services.Control.Services> services);

    Task<ServiceOptions?> GetOptionsAsync(Bridge.Services.Control.Service service);
        
    Task SetServiceStateAsync(Bridge.Services.Control.Service service);

    Task SetServiceOptionsAsync(Bridge.Services.Control.Service service);
}

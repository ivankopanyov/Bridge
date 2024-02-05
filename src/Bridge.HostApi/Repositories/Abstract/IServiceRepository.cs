namespace Bridge.HostApi.Repositories.Abstract;

public interface IServiceRepository
{
    Task<ServiceOptions?> GetOptionsAsync(Service service);

    Task SetServiceAsync(Service service);
}

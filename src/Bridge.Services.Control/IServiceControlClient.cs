namespace Bridge.Services.Control;

public interface IServiceControlClient
{
    Task<IEnumerable<ServiceInfo>> GetServicesAsync(string host);

    Task<string?> SetOptionsAsync(string host, string serviceName, ServiceOptions options);
}

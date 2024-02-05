namespace Bridge.Services.Control;

public interface IServiceControlClient
{
    Task<IEnumerable<ServiceInfo>> GetServicesAsync(string host);

    Task<OptionsResponse> SetOptionsAsync(string host, SetOptionsRequest request);
}

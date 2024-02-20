namespace Bridge.Services.Control;

public interface IServiceControlClient
{
    Task<HostInfo> GetServicesAsync(string host);

    Task<SetOptionsResponse> SetOptionsAsync(string host, Options request);
}

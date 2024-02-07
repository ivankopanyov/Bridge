namespace Bridge.Services.Control;

public interface IServiceControlClient
{
    Task<Services> GetServicesAsync(string host);

    Task<SetOptionsResponse> SetOptionsAsync(string host, SetOptionsRequest request);
}

namespace Bridge.Services.Control;

internal class ServiceControlClient(ServiceHostOptions options) : IServiceControlClient
{
    private readonly int _http2Port = options.Http2Port;

    public async Task<IEnumerable<ServiceInfo>> GetServicesAsync(string host)
    {
        using var channel = GrpcChannel.ForAddress(GetHost(host));
        var client = new ServiceControl.ServiceControlClient(channel);
        var response = await client.GetServicesAsync(new Empty());
        return response.Services_.ToHashSet();
    }

    public async Task<OptionsResponse> SetOptionsAsync(string host, SetOptionsRequest request)
    {
        using var channel = GrpcChannel.ForAddress(GetHost(host));
        var client = new ServiceControl.ServiceControlClient(channel);
        return await client.SetOptionsAsync(request);
    }

    private string GetHost(string host) => $"http://{host}:{_http2Port}";
}

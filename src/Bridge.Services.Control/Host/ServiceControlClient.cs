namespace Bridge.Services.Control;

internal class ServiceControlClient(ServiceHostOptions options) : IServiceControlClient
{
    private readonly int _http2Port = options.Http2Port;

    public async Task<HostInfo> GetServicesAsync(string host)
    {
        using var channel = GrpcChannel.ForAddress(GetHost(host));
        var client = new ServiceControl.ServiceControlClient(channel);
        return await client.GetServicesAsync(new Empty());
    }

    public async Task<SetOptionsResponse> SetOptionsAsync(string host, Options request)
    {
        using var channel = GrpcChannel.ForAddress(GetHost(host));
        var client = new ServiceControl.ServiceControlClient(channel);
        return await client.SetOptionsAsync(request);
    }

    private string GetHost(string host) => $"http://{host}:{_http2Port}";
}

namespace Bridge.Services.Control;

internal class ServiceControlClient : IServiceControlClient
{
    public async Task<IEnumerable<ServiceInfo>> GetServicesAsync(string host)
    {
        using var channel = GrpcChannel.ForAddress(host);
        var client = new ServiceControl.ServiceControlClient(channel);
        var response = await client.GetServicesAsync(new Empty());
        return response.Services_;
    }

    public async Task<string?> SetOptionsAsync(string host, string serviceName, ServiceOptions options)
    {
        using var channel = GrpcChannel.ForAddress(host);
        var client = new ServiceControl.ServiceControlClient(channel);
        var response = await client.SetOptionsAsync(new SetOptionsRequest
        {
            ServiceName = serviceName,
            Options = options
        });

        return response.Message;
    }
}

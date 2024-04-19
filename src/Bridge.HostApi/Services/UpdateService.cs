namespace Bridge.HostApi.Services;

public class UpdateService(IHubContext<UpdateHub> updateHubContext, ILogger<UpdateService> logger) : IUpdateService
{
    private readonly IHubContext<UpdateHub> _updateHubContext = updateHubContext;

    private readonly ILogger _logger = logger;

    private static readonly JsonSerializerSettings _jsonSerializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        }
    };

    public async Task SendLogAsync(LogDto log)
    {
        try
        {
            if (JsonConvert.SerializeObject(log, _jsonSerializerSettings) is not string message)
            {
                _logger.LogError("Log is null");
                return;
            }

            await _updateHubContext.Clients.All.SendAsync("Log", message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    public async Task SendUpdateAsync(ServiceNodeInfo service)
    {
        try
        {
            if (JsonConvert.SerializeObject(service, _jsonSerializerSettings) is not string message)
            {
                _logger.LogError("Service is null");
                return;
            }

            await _updateHubContext.Clients.All.SendAsync("Update", message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    public async Task SendRemoveHostAsync(RemoveHost host)
    {
        try
        {
            if (JsonConvert.SerializeObject(host, _jsonSerializerSettings) is not string message)
            {
                _logger.LogError("Service is null");
                return;
            }

            await _updateHubContext.Clients.All.SendAsync("RemoveHost", message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    public async Task SendRemoveServiceAsync(RemoveService service)
    {
        try
        {
            if (JsonConvert.SerializeObject(service, _jsonSerializerSettings) is not string message)
            {
                _logger.LogError("Service is null");
                return;
            }

            await _updateHubContext.Clients.All.SendAsync("RemoveService", message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }
}

namespace Bridge.HostApi.Extensions;

public static class HubContextExtensions
{
    public static async Task SendToAllAsync<THub, TMessage>(this IHubContext<THub> hubContext, string method, TMessage message, ILogger? logger = null)
        where THub : Hub where TMessage : class, new()
    {
        try
        {
            if (JsonConvert.SerializeObject(message, new ServiceControlSerializerSettings()) is string json)
                await hubContext.Clients.All.SendAsync(method, json);
            else
                logger?.LogError("Message is null");
        }
        catch (Exception ex)
        {
            logger?.LogError(ex, ex.Message);
        }
    }
}

namespace Bridge.HostApi.Repositories.Implement;

public class ConnectionRepository(ICacheService cacheService) : IConnectionRepository
{
    public async Task PushAsync(string id, long userId, TimeSpan expiration)
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));
        await cacheService.PushAsync<Connection>(GetKey(id, userId), new());
    }

    public async Task<bool> RemoveAsync(string id, long userId)
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));
        return await cacheService.PopAsync<Connection>(GetKey(id, userId)) != null;
    }

    private static string GetKey(string id, long userId) => $"{userId}_{id}";
}

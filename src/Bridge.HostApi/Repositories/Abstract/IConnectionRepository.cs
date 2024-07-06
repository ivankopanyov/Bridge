namespace Bridge.HostApi.Repositories.Abstract;

public interface IConnectionRepository
{
    Task PushAsync(string id, long userId, TimeSpan expiration);

    Task<bool> RemoveAsync(string id, long userId);
}

namespace Bridge.Cache.Services;

public interface ICache : IOptinable
{
    Task<bool> PushAsync<T>(string key, T value) where T : class, new();

    Task<T?> PopAsync<T>(string key) where T : class, new();
}

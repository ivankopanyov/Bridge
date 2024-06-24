namespace Bridge.HostApi.Repositories.Implement;

public class EnvironmentRepository(ICacheService cache) : IEnvironmentRepository
{
    private const string KEY = "environment";

    private static readonly Lazy<SemaphoreSlim> _semaphore = new(() => new(1));

    private static SemaphoreSlim Semaphore => _semaphore.Value;

    public async Task<BridgeEnvironment?> GetAsync()
    {
        await Semaphore.WaitAsync();

        try
        {
            return await cache.GetAsync<BridgeEnvironment>(KEY);
        }
        finally
        {
            Semaphore.Release();
        }
    }

    public async Task<bool> UpdateAsync(BridgeEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        await Semaphore.WaitAsync();

        try
        {
            var env = await cache.PopAsync<BridgeEnvironment>(KEY);
            await cache.PushAsync(KEY, environment);

            return env == null || !environment.Equals(env);
        }
        finally
        {
            Semaphore.Release();
        }
    }
}

namespace Bridge.HostApi.Repositories.Implement;

public class EnvironmentRepository(BridgeDbContext context, ICacheService cache) : IEnvironmentRepository
{
    private const string KEY = "environment";

    private static readonly SemaphoreSlim _semaphore = new(1);

    public async Task<BridgeEnvironment?> GetAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            if (await cache.GetAsync<BridgeEnvironment>(KEY) is BridgeEnvironment environment)
                return environment;

            if (await context.Options.AsNoTracking().FirstOrDefaultAsync(o => o.Id == KEY) is AppOptions options)
            {
                if (JsonConvert.DeserializeObject<BridgeEnvironment>(options.Value) is not BridgeEnvironment bridgeEnvironment)
                {
                    context.Options.Remove(options);
                    await context.SaveChangesAsync();
                    return null;
                }

                await cache.PushAsync(KEY, bridgeEnvironment);
                return bridgeEnvironment;
            }

            return null;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<bool> UpdateAsync(BridgeEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        await _semaphore.WaitAsync();

        try
        {
            var options = await context.Options.FirstOrDefaultAsync(o => o.Id == KEY);
            BridgeEnvironment? env = null;
            if (options != null)
            {
                env = JsonConvert.DeserializeObject<BridgeEnvironment>(options.Value);
                if (env == null)
                {
                    context.Options.Remove(options);
                    await context.SaveChangesAsync();
                    options = null;
                }
            }

            var result = env == null || !environment.Equals(env);

            if (result)
            {
                if (options != null)
                    options.Value = JsonConvert.SerializeObject(environment);
                else
                    await context.Options.AddAsync(new()
                    {
                        Id = KEY,
                        Value = JsonConvert.SerializeObject(environment)
                    });

                await context.SaveChangesAsync();
                await cache.PushAsync(KEY, environment);
            }

            return result;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

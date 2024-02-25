namespace Bridge.Cache.Services;

internal class Cache(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceOptions<Cache, RedisOptions> options, ILogger<Cache> logger)
    : ServiceControl<RedisOptions>(serviceHostClient, eventService, options, logger), ICache
{
    private RedisCache CacheService => new(new RedisCacheOptions
    {
        Configuration = Options.Host,
        InstanceName = "Bridge"
    });

    protected override async Task SetOptionsHandleAsync()
    {
        try
        {
            using var cache = CacheService;
            await cache.GetStringAsync("test");
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
        }
    }

    public async Task<bool> PushAsync<T>(string key, T value) where T : class, new()
    {
        if (key == null || value == null)
            return false;

        string json;

        try
        {
            json = JsonConvert.SerializeObject(value);
        }
        catch
        {
            return false;
        }

        try
        {
            using var cache = CacheService;
            await cache.SetStringAsync(GetKey<T>(key), json);
            await ActiveAsync();
            return true;
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
            throw;
        }
    }

    public async Task<T?> PopAsync<T>(string key) where T : class, new()
    {
        key = GetKey<T>(key);

        try
        {
            using var cache = CacheService;
            if (await cache.GetStringAsync(key) is not string value)
                return null;

            await cache.RemoveAsync(key);
            await ActiveAsync();

            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
            throw;
        }
    }

    private static string GetKey<T>(string key) where T : class, new() => $"{typeof(T).FullName}#{key}";
}

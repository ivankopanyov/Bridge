namespace Bridge.Cache.Services;

internal class Cache(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceOptions<Cache, RedisOptions> options, ILogger<Cache> logger)
    : ServiceControl<RedisOptions>(serviceHostClient, eventService, options, logger), ICache
{
    private const string INSTANCE_NAME = "Bridge";

    private RedisCache? _cache;

    protected override async Task SetOptionsHandleAsync()
    {
        _cache?.Dispose();
        _cache = NewRedisCache(Options.Host);

        try
        {
            await _cache.GetStringAsync("test");
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
        }

        _cache = NewRedisCache(Options.Host);
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
            await _cache!.SetStringAsync(GetKey<T>(key), json);
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
            if (await _cache!.GetStringAsync(key) is not string value)
                return null;

            await _cache.RemoveAsync(key);
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

    private static RedisCache NewRedisCache(string host) => new(new RedisCacheOptions
    {
        Configuration = host,
        InstanceName = INSTANCE_NAME
    });
}

namespace Bridge.Cache.Redis;

public class RedisService(RedisOptions options, ILogger<RedisService> logger) : CacheServiceBase<RedisOptions>, ICacheService
{
    private const string SERVICE_NAME = "Redis";

    private readonly string _configuration = $"{options.Host}:{options.Port}";

    private readonly SemaphoreSlim _semaphore = new(1);

    public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
    {
        await _semaphore.WaitAsync();

        try
        {
            using var multiplexer = await ConnectionMultiplexer.ConnectAsync(_configuration);
            IDatabase database = multiplexer.GetDatabase();
            EndPoint endPoint = multiplexer.GetEndPoints().First();
            var keys = multiplexer.GetServer(endPoint).Keys(pattern: $"{GetKey<T>()}*");
            var result = new List<T>();

            foreach (var key in keys)
            {
                var value = await database.StringGetAsync(key);
                if (!value.HasValue)
                    await database.KeyDeleteAsync(key);
                else
                {
                    try
                    {
                        if (JsonConvert.DeserializeObject<T>(value.ToString(), options.JsonSerializerSettings) is not T obj)
                            await database.KeyDeleteAsync(key);
                        else
                            result.Add(obj);
                    }
                    catch
                    {
                        await database.KeyDeleteAsync(key);
                    }
                }
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.LogUnactive(SERVICE_NAME, ex.Message, ex);
            throw;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<T?> GetAsync<T>(string key) where T : class
    {
        key = GetKey<T>(key);
        await _semaphore.WaitAsync();

        try
        {
            using var multiplexer = await ConnectionMultiplexer.ConnectAsync(_configuration);
            IDatabase database = multiplexer.GetDatabase();

            var value = await database.StringGetAsync(key);
            if (!value.HasValue)
                return null;

            try
            {
                return JsonConvert.DeserializeObject<T>(value.ToString(), options.JsonSerializerSettings);
            }
            catch (Exception ex)
            {
                logger.LogWarning(SERVICE_NAME, ex.Message, ex);
                await database.KeyDeleteAsync(key);
                return null;
            }
        }
        catch (Exception ex)
        {
            logger.LogUnactive(SERVICE_NAME, ex.Message, ex);
            throw;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task PushAsync<T>(string key, T value, TimeSpan? expiry = null) where T : class
    {
        ArgumentNullException.ThrowIfNull(key, nameof(key));
        ArgumentNullException.ThrowIfNull(value, nameof(value));

        string json;

        try
        {
            json = JsonConvert.SerializeObject(value, options.JsonSerializerSettings);
        }
        catch (Exception ex)
        {
            logger.LogWarning(SERVICE_NAME, ex.Message, ex);
            return;
        }

        await _semaphore.WaitAsync();

        try
        {
            using var multiplexer = await ConnectionMultiplexer.ConnectAsync(_configuration);
            IDatabase database = multiplexer.GetDatabase();
            await database.StringSetAsync(GetKey<T>(key), json, expiry);
        }
        catch (Exception ex)
        {
            logger.LogUnactive(SERVICE_NAME, ex.Message, ex);
            throw;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<T?> PopAsync<T>(string key) where T : class
    {
        key = GetKey<T>(key);
        await _semaphore.WaitAsync();

        try
        {
            using var multiplexer = await ConnectionMultiplexer.ConnectAsync(_configuration);
            IDatabase database = multiplexer.GetDatabase();

            var value = await database.StringGetAsync(key);
            if (!value.HasValue)
                return null;

            await database.KeyDeleteAsync(key);

            try
            {
                return JsonConvert.DeserializeObject<T>(value.ToString(), options.JsonSerializerSettings);
            }
            catch (Exception ex)
            {
                logger.LogWarning(SERVICE_NAME, ex.Message, ex);
                return null;
            }
        }
        catch (Exception ex)
        {
            logger.LogUnactive(SERVICE_NAME, ex.Message, ex);
            throw;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<bool> ExistsAsync<T>(string key) where T : class
    {
        key = GetKey<T>(key);
        await _semaphore.WaitAsync();

        try
        {
            using var multiplexer = await ConnectionMultiplexer.ConnectAsync(_configuration);
            IDatabase database = multiplexer.GetDatabase();
            var result = await database.KeyExistsAsync(key);
            return result;
        }
        catch (Exception ex)
        {
            logger.LogUnactive(SERVICE_NAME, ex.Message, ex);
            throw;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private static string GetKey<T>(string? key = null) where T : class => $"{typeof(T).FullName}#{key}";
}

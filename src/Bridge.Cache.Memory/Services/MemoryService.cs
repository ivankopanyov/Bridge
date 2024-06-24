namespace Bridge.Cache.Memory;

public class MemoryService(ILogger<MemoryService> logger) : CacheServiceBase<MemoryOptions>, ICacheService
{
    private readonly Dictionary<Type, Dictionary<string, (CancellationTokenSource, object)>> _objects = [];

    private readonly object _lock = new();

    public Task<IEnumerable<T>> GetAllAsync<T>() where T : class
    {
        lock (_lock)
            return Task.FromResult(!_objects.TryGetValue(typeof(T), out Dictionary<string, (CancellationTokenSource, object)>? result) || result == null
                ? Enumerable.Empty<T>()
                : result.Values
                    .Select(value => value.Item2 is T obj ? obj : null)
                    .Where(value => value != null))!;
    }

    public Task<T?> GetAsync<T>(string key) where T : class
    {
        ArgumentNullException.ThrowIfNull(key, nameof(key));

        lock (_lock)
            return Task.FromResult(!_objects.TryGetValue(typeof(T), out Dictionary<string, (CancellationTokenSource, object)>? objects) || objects == null
                || !objects.TryGetValue(key, out (CancellationTokenSource, object) obj) || obj.Item2 is not T result ? null : result);
    }

    public Task PushAsync<T>(string key, T value, TimeSpan? expiry = null) where T : class
    {
        ArgumentNullException.ThrowIfNull(key, nameof(key));
        ArgumentNullException.ThrowIfNull(value, nameof(value));

        lock (_lock)
        {
            if (!_objects.TryGetValue(typeof(T), out Dictionary<string, (CancellationTokenSource, object)>? objects))
            {
                objects = [];
                _objects.Add(typeof(T), objects);
            }
            else if (objects == null)
            {
                objects = [];
                _objects[typeof(T)] = objects;
            }

            var cancellationTokenSource = new CancellationTokenSource();

            if (!objects.TryAdd(key, (cancellationTokenSource, value)))
                objects[key] = (cancellationTokenSource, value);

            if (expiry is TimeSpan timeSpan)
            {
                new Thread(async () =>
                {
                    try
                    {
                        await Task.Delay(timeSpan, cancellationTokenSource.Token);

                        lock (_lock)
                        {
                            if (_objects.TryGetValue(typeof(T), out objects))
                            {
                                objects?.Remove(key);
                                if (objects == null || objects.Count == 0)
                                    _objects.Remove(typeof(T));
                            }
                        }
                    }
                    catch (TaskCanceledException ex)
                    {
                        logger.LogInformation(ex.Message);
                    }

                }).Start();
            }
        }

        return Task.CompletedTask;
    }

    public Task<T?> PopAsync<T>(string key) where T : class
    {
        ArgumentNullException.ThrowIfNull(key, nameof(key));

        lock (_lock)
        {
            if (_objects.TryGetValue(typeof(T), out Dictionary<string, (CancellationTokenSource, object)>? objects))
            {
                if (objects == null || objects.Count == 0)
                {
                    _objects.Remove(typeof(T));
                    return Task.FromResult<T?>(null);
                }

                if (objects.TryGetValue(key, out (CancellationTokenSource, object) obj))
                {
                    obj.Item1?.Cancel();
                    objects.Remove(key);

                    if (objects.Count == 0)
                        _objects.Remove(typeof(T));

                    return Task.FromResult(obj.Item2 is T result ? result : null);
                }
            }
        }
        
        return Task.FromResult<T?>(null);
    }

    public Task<bool> ExistsAsync<T>(string key) where T : class
    {
        ArgumentNullException.ThrowIfNull(key, nameof(key));

        lock (_lock)
            return Task.FromResult(_objects.TryGetValue(typeof(T), out Dictionary<string, (CancellationTokenSource, object)>? objects)
                && objects != null && objects.ContainsKey(key));
    }
}

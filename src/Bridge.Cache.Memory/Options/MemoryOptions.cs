namespace Bridge.Cache.Memory;

public class MemoryOptions : ICacheOptions
{
    public ServiceLifetime Lifetime => ServiceLifetime.Singleton;
}

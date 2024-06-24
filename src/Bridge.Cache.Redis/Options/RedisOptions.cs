namespace Bridge.Cache.Redis;

public class RedisOptions : ICacheOptions
{
    public string Host { get; set; }

    public int Port { get; set; }

    public JsonSerializerSettings JsonSerializerSettings { get; } = new();

    public ServiceLifetime Lifetime => ServiceLifetime.Scoped;
}

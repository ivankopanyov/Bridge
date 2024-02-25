namespace Bridge.Cache.Options;

internal class RedisOptions
{
    private string _host = "redis";

    public string Host
    {
        get => _host; 
        set => _host = value ?? string.Empty;
    }
}

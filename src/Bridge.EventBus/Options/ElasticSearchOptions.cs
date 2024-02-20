namespace Bridge.EventBus.Options;

internal class ElasticSearchOptions
{
    private string _host = "elasticsearch";

    private int _port = 9200;

    private string _index = "Bridge";

    public string? Host
    {
        get => _host;
        set => _host = value ?? string.Empty;
    }

    public int? Port
    {
        get => _port;
        set => _port = value ?? 0;
    }

    public string? Index
    {
        get => _index;
        set => _index = value ?? string.Empty;
    }
}

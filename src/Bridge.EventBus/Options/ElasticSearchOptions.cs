namespace Bridge.EventBus.Options;

internal class ElasticSearchOptions
{
    private string _url = "http://elasticsearch:9200";

    private string _index = "Bridge";

    public string Url
    {
        get => _url;
        set => _url = value ?? string.Empty;
    }

    public string Index
    {
        get => _index;
        set => _index = value ?? string.Empty;
    }
}

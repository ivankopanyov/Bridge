namespace Bridge.Sanatorium.Options;

public class ServiceBusOptions
{
    private string _connectionString = string.Empty;

    private string _endpointName = string.Empty;

    private string _license = string.Empty;

    private decimal _rvc;

    public string ConnectionString
    {
        get => _connectionString;
        set => _connectionString = value ?? string.Empty;
    }

    public string EndpointName
    {
        get => _endpointName;
        set => _endpointName = value ?? string.Empty;
    }

    public string License
    {
        get => _license;
        set => _license = value ?? string.Empty;
    }

    public decimal? Rvc
    {
        get => _rvc;
        set => _rvc = value ?? 0;
    }
}

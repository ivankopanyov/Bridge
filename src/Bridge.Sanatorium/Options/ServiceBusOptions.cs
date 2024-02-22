namespace Bridge.Sanatorium.Options;

public class ServiceBusOptions
{
    private string _connectionString = string.Empty;

    private string _endpointName = string.Empty;

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
}

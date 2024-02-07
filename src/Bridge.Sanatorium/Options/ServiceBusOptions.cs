namespace Bridge.Sanatorium.Options;

public class ServiceBusOptions
{
    private string _connectionString = string.Empty;

    public string? ConnectionString
    {
        get => _connectionString;
        set => _connectionString = value ?? string.Empty;
    }
}

namespace Bridge.Sanatorium.Options;

public class ServiceBusOptions
{
    [Required(AllowEmptyStrings = true)]
    public string ConnectionString { get; set; } = "Data Source=localhost;Initial Catalog=servicebus;User Id=;Password=;Min Pool Size=1;Connection Timeout=10;";

    [Required(AllowEmptyStrings = true)]
    public string Endpoint { get; set; } = "Bridge";

    [Required(AllowEmptyStrings = true)]
    public string ServerEndpoint { get; set; } = "Sanatorium.Server";

    [Required(AllowEmptyStrings = true)]
    public string License { get; set; } = string.Empty;

    [Range(0, int.MaxValue), Description("Время ожидания в секундах перед попыткой установления подключения.")]
    public int ConnectionDelay { get; set; } = 1;

    public override int GetHashCode() => HashCode.Combine(ConnectionString, ServerEndpoint, Endpoint, License);

    public override bool Equals(object? obj) => obj is ServiceBusOptions other 
        && ConnectionString == other.ConnectionString
        && Endpoint == other.Endpoint
        && ServerEndpoint == other.ServerEndpoint
        && License == other.License;
}

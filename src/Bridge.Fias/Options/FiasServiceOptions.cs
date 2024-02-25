namespace Bridge.Fias.Options;

public class FiasServiceOptions
{
    private string _host = string.Empty;

    private int _port;

    private IDictionary<string, bool> _taxCodes { get; set; } = new Dictionary<string, bool>();

    public string Host
    {
        get => _host;
        set => _host = value ?? string.Empty;
    }

    public int? Port 
    {
        get => _port;
        set => _port = value ?? 0;
    }

    public IDictionary<string, bool> TaxCodes
    {
        get => _taxCodes;
        set => _taxCodes = value ?? new Dictionary<string, bool>();
    }
}

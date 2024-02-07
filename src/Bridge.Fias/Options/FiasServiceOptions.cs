namespace Bridge.Fias.Options;

public class FiasServiceOptions
{
    private string _host = string.Empty;

    private int _port;

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
}

namespace Bridge.Fiscal.Options;

public class CheckDbOptions
{
    private string _host = string.Empty;

    public string Host
    {
        get => _host;
        set => _host = value ?? string.Empty;
    }
}

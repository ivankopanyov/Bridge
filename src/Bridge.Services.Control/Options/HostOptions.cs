namespace Bridge.Services.Control;

public class HostOptions
{
    public string HostName { get; set; }

    public LoggerConfiguration? LoggerConfiguration { get; set; }

    public string? LogFileName { get; set; }
}

namespace Bridge.Services.Control;

public class ServiceControlOptions
{
    public string Host { get; set; }

    public string ServiceHost { get; set; }

    public string LogFileName { get; set; }

    public LoggerConfiguration? LoggerConfiguration { get; set; }
}

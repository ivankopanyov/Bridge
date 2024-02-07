namespace Bridge.EventBus.Options;

internal class RabbitMqOptions
{
    private string _host = "rabbitmq";

    private int _port = 5672;

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

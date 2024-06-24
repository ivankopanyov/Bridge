namespace Bridge.EventBus.RabbitMq;

public class RabbitMqOptions : EventBusOptionsBase
{
    public string Host { get; set; }

    public int Port { get; set; }

    public JsonSerializerSettings JsonSerializerSettings { get; } = new();
}

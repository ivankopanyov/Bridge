namespace Bridge.EventBus;

public class EventBusOptions
{
    public string RabbitMqHostName { get; set; } = "rabbitmq";

    public string LogstashHostName { get; set; } = "logstash";

    public string? LogFileName { get; set; }
}

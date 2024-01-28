namespace Bridge.EventBus;

public class EventBusOptions
{
    public string RabbitMqHost { get; set; } = "rabbitmq";

    public int RabbitMqPort { get; set; } = 5672;

    public string ElasticSearchHost { get; set; } = "elasticsearch";

    public int ElasticSearchPort { get; set; } = 9200;
}

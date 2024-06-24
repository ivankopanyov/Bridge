namespace Bridge.EventBus.RabbitMq;

public class RabbitMqTransport(RabbitMqOptions options, ILogger<RabbitMqTransport>? logger = null) : ITransport<RabbitMqOptions>
{
    public IConsumer<TExchange> CreateConsumer<TExchange>() => new RabbitMqConsumer<TExchange>(options, logger);

    public IConsumer<TExchange> CreateConsumer<TExchange, TQueue>() => new RabbitMqConsumer<TExchange>(options, typeof(TQueue), logger);

    public IConsumer<TMessage> CreateConsumer<TMessage>(string queueName) => new RabbitMqConsumer<TMessage>(options, queueName, logger);

    public IProducer CreateProducer() => new RabbitMqProducer(options, logger);
}

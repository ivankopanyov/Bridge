namespace Bridge.EventBus.Abstractions;

public interface IEventBusFactory
{
    IConsumer<TExchange> CreateConsumer<TExchange>();

    IConsumer<TExchange> CreateConsumer<TExchange, TQueue>();

    IConsumer<TMessage> CreateConsumer<TMessage>(string queueName);

    IProducer CreateProducer();
}

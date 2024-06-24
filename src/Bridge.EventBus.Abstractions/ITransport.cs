namespace Bridge.EventBus.Abstractions;

public interface ITransport<TOptions> where TOptions : EventBusOptionsBase
{
    IConsumer<TExchange> CreateConsumer<TExchange>();

    IConsumer<TExchange> CreateConsumer<TExchange, TQueue>();

    IConsumer<TMessage> CreateConsumer<TMessage>(string queueName);

    IProducer CreateProducer();
}

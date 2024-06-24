namespace Bridge.EventBus.Abstractions;

internal class EventBusFactory<TOptions>(ITransport<TOptions> transport) : IEventBusFactory where TOptions : EventBusOptionsBase
{
    public IConsumer<TExchange> CreateConsumer<TExchange>() => transport.CreateConsumer<TExchange>();

    public IConsumer<TExchange> CreateConsumer<TExchange, TQueue>() => transport.CreateConsumer<TExchange, TQueue>();

    public IConsumer<TMessage> CreateConsumer<TMessage>(string queueName) => transport.CreateConsumer<TMessage>(queueName);

    public IProducer CreateProducer() => transport.CreateProducer();
}

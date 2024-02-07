namespace Bridge.EventBus;

public interface IEventBusService
{
    internal RabbitMqServiceNode RabbitMqService { get; }

    internal ElasticSearchServiceNode ElasticSearchService { get; }

    internal IConnectionFactory ConnectionFactory { get; }

    Task SendAsync<T>(string? queueName, T message) where T : class, new();

    internal Task SendAsync<T>(Event<T> @event) where T : class, new();
}

namespace Bridge.EventBus;

internal class EventBusService(EventBusOptions options) : IEventBusService
{
    private readonly EventBusOptions _options = options;

    public async Task SendAsync<T>(string? queueName, T? message) where T : Message, new()
        => await SendAsync<T>(new()
        {
            QueueName = queueName,
            TaskId = Guid.NewGuid().ToString(),
            Message = message
        });

    public Task SendAsync<T>(Event<T> @event) where T : class, new()
    {
        var queueName = typeof(T).Name;
        var factory = new ConnectionFactory { HostName = "rabbitmq" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: queueName,
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

        var json = JsonConvert.SerializeObject(@event, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });

        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: "",
                        routingKey: queueName,
                        basicProperties: null,
                        body: body);

        return Task.CompletedTask;
    }

    public IModel OpenChannel()
    {
        var factory = new ConnectionFactory
        {
            HostName = _options.RabbitMqHost
        };
        using var connection = factory.CreateConnection();
        return connection.CreateModel();
    }
}

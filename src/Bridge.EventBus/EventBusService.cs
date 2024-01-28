namespace Bridge.EventBus;

internal class EventBusService : IEventBusService
{
    private readonly ConnectionFactory _connectionFactory;

    public IConnectionFactory ConnectionFactory => _connectionFactory;

    public EventBusService(EventBusOptions options)
    {
        _connectionFactory = new()
        {
             HostName = options.RabbitMqHost,
             Port = options.RabbitMqPort
        };
    }

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
        using var connection = ConnectionFactory.CreateConnection();
        using var model = connection.CreateModel();

        model.QueueDeclare(queue: queueName,
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

        var json = JsonConvert.SerializeObject(@event, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });

        var body = Encoding.UTF8.GetBytes(json);

        model.BasicPublish(exchange: "",
                        routingKey: queueName,
                        basicProperties: null,
                        body: body);

        return Task.CompletedTask;
    }
}

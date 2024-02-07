namespace Bridge.EventBus;

internal class EventBusService(RabbitMqServiceNode rabbitMqService, ElasticSearchServiceNode elasticSearchService) : IEventBusService
{
    public RabbitMqServiceNode RabbitMqService { get; private init; } = rabbitMqService;

    public ElasticSearchServiceNode ElasticSearchService { get; private init; } = elasticSearchService;

    public IConnectionFactory ConnectionFactory => new ConnectionFactory
    {
        HostName = RabbitMqService.Options.Host,
        Port = RabbitMqService.Options.Port ?? 0
    };

    public async Task SendAsync<T>(string? queueName, T message) where T : class, new() => await SendAsync<T>(new()
    {
        QueueName = queueName,
        TaskId = Guid.NewGuid().ToString(),
        Message = message
    });

    public Task SendAsync<T>(Event<T> @event) where T : class, new()
    {
        var queueName = typeof(T).AssemblyQualifiedName;
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

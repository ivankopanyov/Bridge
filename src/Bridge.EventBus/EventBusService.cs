namespace Bridge.EventBus;

internal class EventBusService : IEventBusService
{
    public async Task SendAsync<T>(string? queuName, T? message) where T : Message
        => await SendAsync<T>(new()
        {
            QueueName = queuName,
            TaskId = Guid.NewGuid().ToString(),
            Message = message
        });

    public Task SendAsync<T>(Event<T> @event) where T : Message
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
}

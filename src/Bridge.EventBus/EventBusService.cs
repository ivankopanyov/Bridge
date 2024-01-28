namespace Bridge.EventBus;

internal class EventBusService : IEventBusService
{
    private readonly ConnectionFactory _connectionFactory;

    private bool _isActive = false;

    private Exception? _currentException = null;

    public event ChangeStateServiceBusHandle? ChangeStateEvent;

    public IConnectionFactory ConnectionFactory => _connectionFactory;

    public bool IsActive => _isActive;

    public Exception? CurrentException => _currentException;

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

    public void Active()
    {
        if (_isActive)
            return;

        _isActive = true;
        _currentException = null;
        ChangeStateEvent?.Invoke(true, null);
    }

    public void Unactive(Exception ex)
    {
        if (!_isActive && _currentException != null && ex?.Message == _currentException.Message)
            return;

        _isActive = false;
        _currentException = ex;
        ChangeStateEvent?.Invoke(false, ex);
    }
}

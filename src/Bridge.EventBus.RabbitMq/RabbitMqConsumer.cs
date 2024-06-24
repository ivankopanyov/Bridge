namespace Bridge.EventBus.RabbitMq;

internal class RabbitMqConsumer<T> : RabbitMqBase, IConsumer<T>
{
    private readonly ILogger? _logger;

    private readonly string _exchangeName;

    private readonly string _queueName;

    private readonly object _lock = new();

    public event MessageHandleAsync<T>? MessageEvent; 
    
    public RabbitMqConsumer(RabbitMqOptions options, ILogger? logger = null) : base(options)
    {
        _logger = logger;
        _exchangeName = GetName<T>();
        _queueName = _exchangeName;
    }

    public RabbitMqConsumer(RabbitMqOptions options, Type queue, ILogger? logger = null) : base(options)
    {
        ArgumentNullException.ThrowIfNull(nameof(queue));

        _logger = logger;
        _exchangeName = GetName<T>();
        _queueName = GetName<T>(queue);
    }

    public RabbitMqConsumer(RabbitMqOptions options, string queueName, ILogger? logger = null) : base(options)
    {
        ArgumentNullException.ThrowIfNull(nameof(queueName));

        _logger = logger;
        _exchangeName = GetName<T>(queueName);
        _queueName = _exchangeName;
    }

    public void RecieveStart() => Recieve(true);

    private void Recieve(bool log)
    {
        try
        {
            var connection = NewConnection;
            var channel = connection.CreateModel();
            channel.ExchangeDeclare(_exchangeName, ExchangeType.Direct);
            channel.QueueDeclare(queue: _queueName, durable: true, exclusive: false, autoDelete: false);
            channel.QueueBind(_queueName, _exchangeName, string.Empty);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var args = new EventArgs();

                try
                {
                    if (e.Body.ToArray() is byte[] bytes && Encoding.UTF8.GetString(bytes) is string json &&
                        JsonConvert.DeserializeObject<T>(json, JsonSerializerSettings) is T message && message != null)
                        MessageEvent?.Invoke(message, args);
                }
                catch (Exception ex)
                {
                    _logger?.LogWarning(SERVICE_NAME, ex.Message, ex);
                }

                try
                {
                    if (args.Requeue)
                        channel.BasicReject(e.DeliveryTag, true);
                    else
                        channel.BasicAck(e.DeliveryTag, false);
                }
                catch (Exception ex)
                {
                    _logger?.LogUnactive(SERVICE_NAME, ex.Message, ex);
                }
            };

            connection.ConnectionShutdown += (sender, e) => RecieveStart();
            channel.BasicConsume(_queueName, false, consumer);
        }
        catch (Exception ex)
        {
            if (log)
                _logger?.LogUnactive(SERVICE_NAME, ex.Message, ex);

            Recieve(false);
        }
    }
}

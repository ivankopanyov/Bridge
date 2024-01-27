namespace Bridge.EventBus;

public abstract class EventHandlerBase<TIn> : BackgroundService where TIn : Message
{
    private readonly string _queueName;
    private readonly EventBusOptions _options;
    private protected readonly ILogger _logger;

    protected virtual string HandlerName => GetType().Name;

    private protected EventHandlerBase(string queueName, EventBusOptions options, ILogger logger)
    {
        _queueName = queueName;
        _options = options;
        _logger = logger;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var factory = new ConnectionFactory 
        { 
            HostName = _options.RabbitMqHostName 
        };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += async (sender, e) =>
        {
            try
            {
                if (e.Body.ToArray() is not byte[] bytes)
                {
                    _logger.Critical(HandlerName, "Event body is null.");
                    channel.BasicReject(e.DeliveryTag, false);
                    return;
                }

                if (Encoding.UTF8.GetString(bytes) is not string json)
                {
                    _logger.Critical(HandlerName, "Event encoding failed.");
                    channel.BasicReject(e.DeliveryTag, false);
                    return;
                }

                if (JsonConvert.DeserializeObject<Event<TIn>>(json) is not Event<TIn> @event)
                {
                    _logger.Critical(HandlerName, "Event deserialize failed.");
                    channel.BasicReject(e.DeliveryTag, false);
                    return;
                }

                try
                {
                    await HandleProcessAsync(@event); 
                    channel.BasicAck(e.DeliveryTag, false);
                    _logger.Successful(@event.QueueName, HandlerName, @event.TaskId);
                }
                catch (Exception ex)
                {
                    if (!e.Redelivered)
                        _logger.Error(@event.QueueName, HandlerName, @event.TaskId, ex);

                    channel.BasicReject(e.DeliveryTag, true);
                }
            }
            catch (Exception ex)
            {
                _logger.Critical(HandlerName, ex);
                channel.BasicReject(e.DeliveryTag, false);
            }
        };

        channel.BasicConsume(_queueName, false, consumer);
        return Task.CompletedTask;
    }

    private protected abstract Task HandleProcessAsync(Event<TIn> @event);
}

public abstract class EventHandler<TIn>(EventBusOptions options, ILogger logger)
    : EventHandlerBase<TIn>(typeof(TIn).Name, options, logger) where TIn : Message
{
    private protected override async Task HandleProcessAsync(Event<TIn> @event)
        => await HandleAsync(@event.Message);

    protected abstract Task HandleAsync(TIn? @in);
}

public abstract class EventHandler<TIn, TOut>(EventBusOptions options, ILogger logger) 
    : EventHandlerBase<TIn>(typeof(TIn).Name, options, logger) where TIn : Message where TOut : Message
{
    private protected override async Task HandleProcessAsync(Event<TIn> @event)
    {
        var @out = await HandleAsync(@event.Message);
        var eventBusService = new EventBusService();
        await eventBusService.SendAsync(new Event<TOut>
        {
            QueueName = @event.QueueName,
            TaskId = @event.TaskId,
            Message = @out
        });
    }

    protected abstract Task<TOut?> HandleAsync(TIn? @in);
}

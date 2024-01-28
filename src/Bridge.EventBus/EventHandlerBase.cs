namespace Bridge.EventBus;

public abstract class EventHandlerBase<TIn> : BackgroundService where TIn : class, new()
{
    private protected ILogger Logger { get; init; }

    private protected IEventBusService EventBusService { get; init; }

    protected virtual string HandlerName => GetType().Name;

    private protected EventHandlerBase(IEventBusService eventBusService, ILogger logger)
    {
        EventBusService = eventBusService;
        Logger = logger;
    }

    protected override sealed Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var queueName = typeof(TIn).Name;

        using var connection = EventBusService.ConnectionFactory.CreateConnection();
        using var model = connection.CreateModel();
        model.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var consumer = new EventingBasicConsumer(model);
        consumer.Received += async (sender, e) =>
        {
            try
            {
                if (e.Body.ToArray() is not byte[] bytes)
                {
                    Logger.Critical(HandlerName, "Event body is null.");
                    model.BasicReject(e.DeliveryTag, false);
                    return;
                }

                if (Encoding.UTF8.GetString(bytes) is not string json)
                {
                    Logger.Critical(HandlerName, "Event encoding failed.");
                    model.BasicReject(e.DeliveryTag, false);
                    return;
                }

                if (JsonConvert.DeserializeObject<Event<TIn>>(json) is not Event<TIn> @event)
                {
                    Logger.Critical(HandlerName, "Event deserialize failed.");
                    model.BasicReject(e.DeliveryTag, false);
                    return;
                }

                try
                {
                    await HandleProcessAsync(@event);
                    model.BasicAck(e.DeliveryTag, false);
                }
                catch (Exception ex)
                {
                    if (!e.Redelivered)
                        Logger.Error(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), ex);

                    model.BasicReject(e.DeliveryTag, true);
                }
            }
            catch (Exception ex)
            {
                Logger.Critical(HandlerName, ex);
                model.BasicReject(e.DeliveryTag, false);
            }
        };

        model.BasicConsume(queueName, false, consumer);
        return Task.CompletedTask;
    }

    protected virtual string? InputLog(TIn? @in) => null;

    private protected abstract Task HandleProcessAsync(Event<TIn> @event);
}

public abstract class EventHandlerBase<TIn, TOut>(IEventBusService eventBusService, ILogger logger)
    : EventHandlerBase<TIn>(eventBusService, logger) where TIn : class, new() where TOut : Message, new()
{
    private protected override sealed async Task HandleProcessAsync(Event<TIn> @event)
    {
        var @out = await HandleAsync(@event.Message);
        Logger.Successful(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), OutputLog(@out));
        await EventBusService.SendAsync(new Event<TOut>
        {
            QueueName = @event.QueueName,
            TaskId = @event.TaskId,
            Message = @out
        });
    }

    protected abstract Task<TOut?> HandleAsync(TIn? @in);

    protected virtual string? OutputLog(TOut? @out) => null;
}

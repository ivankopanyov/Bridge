using RabbitMQ.Client;

namespace Bridge.EventBus;

public abstract class EventHandlerBase<TIn> : BackgroundService where TIn : class, new()
{
    private IConnection? _connection;

    private IModel? _model;

    private protected ILogger Logger { get; init; }

    private protected IEventBusService EventBusService { get; init; }

    protected virtual string HandlerName => GetType().Name;

    private protected EventHandlerBase(IEventBusService eventBusService, ILogger logger)
    {
        EventBusService = eventBusService;
        Logger = logger;
    }

    protected override sealed async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await ConnectAsync();
    }

    private protected async Task ConnectAsync()
    {
        _model?.Dispose();
        _connection?.Dispose();

        var queueName = typeof(TIn).Name;
        var connect = false;
        while (!connect)
            await Task.Run(async () =>
            {
                try
                {
                    _connection = EventBusService.ConnectionFactory.CreateConnection();
                    _model = _connection.CreateModel();
                    _model.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                    var consumer = new EventingBasicConsumer(_model);
                    consumer.Received += async (sender, e) => await BasicEventHandleAsync(e, _model);

                    _model.BasicConsume(queueName, false, consumer);
                    EventBusService.Active();
                    connect = true;
                }
                catch (Exception ex)
                {
                    EventBusService.Unactive(ex);
                    await Task.Delay(1000);
                }
            }).ConfigureAwait(false);
    }

    private async Task BasicEventHandleAsync(BasicDeliverEventArgs e, IModel model)
    {
        try
        {
            if (e.Body.ToArray() is not byte[] bytes)
            {
                Logger.Critical(HandlerName, "Event body is null.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false));
                return;
            }

            if (Encoding.UTF8.GetString(bytes) is not string json)
            {
                Logger.Critical(HandlerName, "Event encoding failed.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false));
                return;
            }

            if (JsonConvert.DeserializeObject<Event<TIn>>(json) is not Event<TIn> @event)
            {
                Logger.Critical(HandlerName, "Event deserialize failed.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false));
                return;
            }

            try
            {
                if (!await HandleProcessAsync(@event))
                    return;

                await TryBasicAnswerAsync(() => model.BasicAck(e.DeliveryTag, false));
            }
            catch (Exception ex)
            {
                if (!e.Redelivered)
                    Logger.Error(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), ex);

                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, true));
            }
        }
        catch (Exception ex)
        {
            Logger.Critical(HandlerName, ex); 
            await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false));
        }
    }

    protected virtual string? InputLog(TIn? @in) => null;

    private protected abstract Task<bool> HandleProcessAsync(Event<TIn> @event);

    private async Task TryBasicAnswerAsync(Action action)
    {
        try
        {
            action.Invoke();
            EventBusService.Active();
        }
        catch (Exception ex)
        {
            EventBusService.Unactive(ex);
            await Task.Run(ConnectAsync);
        }
    }

    public override void Dispose()
    {
        base.Dispose();
        _model?.Dispose();
        _connection?.Dispose();
    }
}

public abstract class EventHandlerBase<TIn, TOut>(IEventBusService eventBusService, ILogger logger)
    : EventHandlerBase<TIn>(eventBusService, logger) where TIn : class, new() where TOut : Message, new()
{
    private protected override sealed async Task<bool> HandleProcessAsync(Event<TIn> @event)
    {
        var @out = await HandleAsync(@event.Message);
        Logger.Successful(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), OutputLog(@out));

        try
        {
            await EventBusService.SendAsync(new Event<TOut>
            {
                QueueName = @event.QueueName,
                TaskId = @event.TaskId,
                Message = @out
            });

            EventBusService.Active();
            return true;
        }
        catch (Exception ex) 
        {
            EventBusService.Unactive(ex);
            await Task.Run(ConnectAsync);
            return false;
        }
    }

    protected abstract Task<TOut?> HandleAsync(TIn? @in);

    protected virtual string? OutputLog(TOut? @out) => null;
}

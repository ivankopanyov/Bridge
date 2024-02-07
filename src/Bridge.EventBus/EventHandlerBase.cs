namespace Bridge.EventBus;

public abstract class EventHandlerBase<TIn> : BackgroundService where TIn : class, new()
{
    private IConnection? _connection;

    private IModel? _model;

    private protected ILogger Logger { get; init; }

    private protected IEventBusService EventBusService { get; init; }

    private CancellationTokenSource _cancellationTokenSource;

    private CancellationToken _cancellationToken;

    protected virtual string HandlerName => GetType().Name;

    private protected EventHandlerBase(IEventBusService eventBusService, ILogger logger)
    {
        EventBusService = eventBusService; 
        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;
        EventBusService.RabbitMqService.ChangeRabbitMqOptionsEvent += () => RefreshCancellationToken();
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

        var queueName = typeof(TIn).AssemblyQualifiedName;
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

                    _connection.ConnectionShutdown += async (sender, e) => await ConnectAsync();

                    _model.BasicConsume(queueName, false, consumer);
                    await EventBusService.RabbitMqService.ActiveAsync();
                    connect = true;
                }
                catch (Exception ex)
                {
                    await EventBusService.RabbitMqService.UnactiveAsync(ex);
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

            if (@event.Message == null)
            {
                Logger.Critical(HandlerName, "Event message is null.");
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

    protected virtual string? InputLog(TIn @in) => null;

    protected async Task InputDataAsync(string? queueName, TIn @in)
    {
        if (@in == null)
        {
            Logger.Critical(HandlerName, "Input data is null.");
            return;
        }

        var @event = new Event<TIn>
        {
            QueueName = queueName,
            TaskId = Guid.NewGuid().ToString(),
            Message = @in
        };

        try
        {
            await HandleProcessAsync(@event);
        }
        catch (Exception ex)
        {
            Logger.Error(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), ex);
            await TrySendAsync(async () => await EventBusService.SendAsync(@event));
        }
    }

    private async Task TrySendAsync(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception ex)
        {
            await EventBusService.RabbitMqService.UnactiveAsync(ex);
            await Task.Run(async () =>
            {
                await ConnectAsync();
                await TrySendAsync(action);
            }).ConfigureAwait(false);
        }
    }

    private protected abstract Task<bool> HandleProcessAsync(Event<TIn> @event);

    private async Task TryBasicAnswerAsync(Action action)
    {
        try
        {
            action.Invoke();
            await EventBusService.RabbitMqService.ActiveAsync();
        }
        catch (Exception ex)
        {
            await EventBusService.RabbitMqService.UnactiveAsync(ex);
            await Task.Run(ConnectAsync);
        }
    }

    private void RefreshCancellationToken()
    {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;
    }

    public override void Dispose()
    {
        base.Dispose();
        _model?.Dispose();
        _connection?.Dispose();
    }
}


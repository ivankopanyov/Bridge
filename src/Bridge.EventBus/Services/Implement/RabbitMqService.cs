namespace Bridge.EventBus.Services.Implement;

internal delegate Task CloseConnectionHandle();

internal class RabbitMqService(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceOptions<RabbitMqService, RabbitMqOptions> options, ILogger<RabbitMqService> logger)
    : ServiceControl<RabbitMqOptions>(serviceHostClient, eventService, options, logger), IRabbitMqService
{
    private static readonly JsonSerializerSettings _jsonSerializerSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore
    };

    private IConnection? _connection;

    private IConnection NewConnection => new ConnectionFactory
    {
        HostName = Options.Host,
        Port = Options.Port ?? 0
    }.CreateConnection();

    private event CloseConnectionHandle? CloseConnectionEvent;

    public event CriticalHandleAsync? CriticalEvent;

    public event ErrorHandleAsync? ErrorEvent;

    protected override async Task SetOptionsHandleAsync()
    {
        if (_connection != null && _connection.IsOpen)
        {
            _connection.Close();
            await UnactiveAsync("Connection close.");
        }

        CloseConnectionEvent?.Invoke();
    }

    public async Task PublishAsync<T>(Event<T> @event, Action? successAction = null) where T : class, new()
    {
        var queueName = typeof(T).AssemblyQualifiedName;
        byte[] body;

        try
        {
            var json = JsonConvert.SerializeObject(@event, _jsonSerializerSettings);
            body = Encoding.UTF8.GetBytes(json);
        }
        catch
        {
            body = [];
        }

        await PublishAsync(queueName ?? string.Empty, body, successAction);
    }

    public async Task RecieveAsync<T>(string handlerName, Action<Event<T>, Action?> handleAction) where T : class, new() => await Task.Run(async () =>
    {
        var queueName = typeof(T).AssemblyQualifiedName;

        try
        {
            var _connection = NewConnection;
            var _model = _connection.CreateModel();
            _model.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(_model);
            consumer.Received += async (sender, e) => await BasicEventHandleAsync(e, _model, handleAction, handlerName);

            _connection.ConnectionShutdown += async (sender, e) =>
            {
                await UnactiveAsync("Connection shutdown.");
                await RecieveAsync(handlerName, handleAction);
            };

            _model.BasicConsume(queueName, false, consumer);
            await ActiveAsync();
            CloseConnectionEvent += async () => await RecieveAsync(handlerName, handleAction);
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
            await Task.Delay(1000);
            await RecieveAsync(handlerName, handleAction);
        }
    });

    private async Task PublishAsync(string queueName, ReadOnlyMemory<byte> body, Action? successAction = null, Exception? currentException = null) => await Task.Run(async () => 
    { 
        try
        {
            using var connection = NewConnection;
            using var model = connection.CreateModel();
            model.QueueDeclare(queue: queueName, exclusive: false, autoDelete: false);
            model.BasicPublish(exchange: string.Empty, routingKey: queueName, body: body);
            successAction?.Invoke();
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            if (currentException == null || currentException.Message != ex.Message)
            {
                currentException = ex;
                await UnactiveAsync(currentException);
            }

            await Task.Delay(TimeSpan.FromSeconds(1));
            await PublishAsync(queueName, body, successAction, currentException);
        }
    }).ConfigureAwait(false);

    private async Task BasicEventHandleAsync<T>(BasicDeliverEventArgs e, IModel model, Action<Event<T>, Action?> handleAction, string handlerName) where T : class, new()
    {
        try
        {
            if (e.Body.ToArray() is not byte[] bytes)
            {
                CriticalEvent?.Invoke(null, handlerName, null, null, "Event body is null.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false), handleAction, handlerName);
                return;
            }

            if (Encoding.UTF8.GetString(bytes) is not string json)
            {
                CriticalEvent?.Invoke(null, handlerName, null, null, "Event encoding failed.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false), handleAction, handlerName);
                return;
            }

            if (JsonConvert.DeserializeObject<Event<T>>(json) is not Event<T> @event)
            {
                CriticalEvent?.Invoke(null, handlerName, null, null, "Event deserialize failed.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false), handleAction, handlerName);
                return;
            }

            if (@event.Message == null)
            {
                CriticalEvent?.Invoke(@event.QueueName, handlerName, @event.TaskId, null, "Event message is null.");
                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false), handleAction, handlerName);
                return;
            }

            try
            {
                handleAction.Invoke(@event, async () => await TryBasicAnswerAsync(() => model.BasicAck(e.DeliveryTag, false), handleAction, handlerName));
            }
            catch (Exception ex)
            {
                if (!e.Redelivered)
                    ErrorEvent?.Invoke(@event.QueueName, handlerName, @event.TaskId, null, @event.Message, ex.Message, ex.StackTrace);

                await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, true), handleAction, handlerName);
            }
        }
        catch (Exception ex)
        {
            CriticalEvent?.Invoke(null, handlerName, null, ex.Message, ex.StackTrace);
            await TryBasicAnswerAsync(() => model.BasicReject(e.DeliveryTag, false), handleAction, handlerName);
        }
    }

    private async Task TryBasicAnswerAsync<T>(Action basicAction, Action<Event<T>, Action?> handleAction, string handlerName) where T : class, new() => await Task.Run(async () => 
    {
        try
        {
            basicAction.Invoke();
            await ActiveAsync();
        }
        catch
        {
            if (_connection != null && _connection.IsOpen)
            {
                _connection.Close();
                await UnactiveAsync("Connection close.");
            }

            await RecieveAsync(handlerName, handleAction);
        }
    }).ConfigureAwait(false);
}

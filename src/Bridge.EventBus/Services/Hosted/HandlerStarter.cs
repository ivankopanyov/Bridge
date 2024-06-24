namespace Bridge.EventBus.Services.Hosted;

internal class HandlerStarter<THandler, TIn> : BackgroundService where THandler : HandlerBase<TIn>
{
    private static readonly string _queueName = typeof(THandler).FullName ?? typeof(THandler).Name;

    private readonly IServiceScopeFactory _serviceScopeFactory;

    private readonly ILogger? _logger;

    private readonly IProducer _producer;

    private readonly string _taskName;

    private readonly string _handlerName;

    private readonly bool _useEventLogging;

    private readonly bool _useLogging;

    private readonly int _hostId;

    private readonly object _lock = new();

    private DateTime _dateTime = DateTime.Now.Trim(TimeSpan.TicksPerSecond);

    private int _counter;

    public HandlerStarter(IServiceScopeFactory serviceScopeFactory, IEventBusService<TIn> eventBusService,
        EventHandlerOptions<THandler, TIn> options, IEventBusFactory eventBusFactory, ILogger<THandler> logger)
    {
        _serviceScopeFactory = serviceScopeFactory;

        eventBusService.PublishEvent += async (@in) => await HandleAsync(new Event<TIn>
        {   
            Id = GenerateId(),
            TaskId = GenerateId(),
            TaskName = _taskName,
            Message = @in
        });

        _handlerName = options.HandlerName ?? GetType().Name;
        _taskName = options.TaskName;
        _logger = logger;
        _useEventLogging = options.UseEventLogging;
        _useLogging = _useEventLogging || _logger != null;
        _hostId = Math.Max(Math.Min(options.HostId, 99), 0);

        _producer = eventBusFactory.CreateProducer();

        var generalConsumer = eventBusFactory.CreateConsumer<Event<TIn>, THandler>();
        generalConsumer.MessageEvent += HandleAsync;
        generalConsumer.RecieveStart();

        var consumer = eventBusFactory.CreateConsumer<Event<TIn>>(_queueName);
        consumer.MessageEvent += HandleAsync;
        consumer.RecieveStart();
    }

    private async Task HandleAsync(Event<TIn> @event, EventArgs? args = null)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<THandler>();

        if (@event.Message == null)
        {
            if (_useLogging)
                Log(new EventLog
                {
                    Id = @event.Id,
                    TaskId = @event.TaskId,
                    TaskName = @event.TaskName,
                    HandlerName = _handlerName,
                    IsError = true,
                    IsEnd = true,
                    Data = new()
                    {
                        LogId = @event.Id,
                        TaskId = @event.TaskId,
                        Error = "Input object is null"
                    }
                });

            return;
        }

        string? inputObjectJson = null;

        if (_useLogging)
        {
            try
            {
                inputObjectJson = JsonConvert.SerializeObject(@event.Message);
            }
            catch (Exception ex)
            {
                inputObjectJson = ex.Message;
            }
        }

        try
        {
            var context = new EventContext();
            await handler.ProcessHandleAsync(@event.Message, context);

            if (_useLogging)
                Log(new EventLog
                {
                    Id = @event.Id,
                    TaskId = @event.TaskId,
                    TaskName = @event.TaskName,
                    HandlerName = _handlerName,
                    Message = handler.Message(@event.Message),
                    IsEnd = !context.Events.Any(),
                    Data = new()
                    {
                        LogId = @event.Id,
                        TaskId = @event.TaskId,
                        InputObjectJson = inputObjectJson,
                    }
                });

            foreach (var @out in context.Events)
            {
                @out.Id = GenerateId();
                @out.TaskId = @event.TaskId;
                @out.TaskName = @event.TaskName;
                @out.Publish(_producer);
            }
        }
        catch (TaskCriticalException ex)
        {
            if (_useLogging)
                Log(new EventLog
                {
                    Id = @event.Id,
                    TaskId = @event.TaskId,
                    TaskName = @event.TaskName,
                    HandlerName = _handlerName,
                    Message = handler.Message(@event.Message),
                    IsError = true,
                    IsEnd = true,
                    Data = new()
                    {
                        LogId = @event.Id,
                        TaskId = @event.TaskId,
                        Error = ex.Message,
                        StackTrace = ex.StackTrace,
                        InputObjectJson = inputObjectJson,
                    }
                }, ex);
        }
        catch (Exception ex)
        {
            if (@event.Error == null || @event.Error != ex.Message)
            {
                @event.Id = GenerateId();
                @event.Error = ex.Message;
                @event.StackTrace = ex.StackTrace;

                if (_useLogging)
                    Log(new EventLog
                    {
                        Id = @event.Id,
                        TaskName = @event.TaskName,
                        HandlerName = _handlerName,
                        TaskId = @event.TaskId,
                        Message = handler.Message(@event.Message),
                        IsError = true,
                        Data = new()
                        {
                            LogId = @event.Id,
                            TaskId = @event.TaskId,
                            Error = @event.Error,
                            StackTrace = @event.StackTrace,
                            InputObjectJson = inputObjectJson,
                        }
                    }, ex);

                @event.Publish(_producer, _queueName);
            }
            else if (args != null)
                args.Requeue = true;
        }
    }

    private void Log(EventLog eventLog, Exception? ex = null)
    {
        _logger?.LogEvent(eventLog, ex);

        if (_useEventLogging)
            _producer.Publish(new Event<EventLog>
            {
                Id = GenerateId(),
                Message = eventLog
            });
    }

    protected override sealed Task ExecuteAsync(CancellationToken stoppingToken) => Task.CompletedTask;

    private string GenerateId()
    {
        lock(_lock)
        {
            var now = DateTime.Now.Trim(TimeSpan.TicksPerSecond);
            if (_dateTime != now)
            {
                _dateTime = now;
                _counter = 0;
            }

            return $"{_dateTime:yyMMddHHmmss}{_hostId.ToString().PadLeft(2, '0')}{(++_counter).ToString().PadLeft(2, '0')}";
        }
    }
}


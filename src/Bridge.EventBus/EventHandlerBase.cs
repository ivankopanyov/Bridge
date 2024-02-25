namespace Bridge.EventBus;

public abstract class EventHandlerBase<TIn> : BackgroundService where TIn : class, new()
{
    private protected readonly IEventBusService _eventBusService;

    protected virtual string HandlerName => GetType().Name;

    private protected EventHandlerBase(IEventBusService eventBusService)
    {
        _eventBusService = eventBusService;
    }

    protected override sealed async Task ExecuteAsync(CancellationToken stoppingToken)
        => await _eventBusService.RecieveAsync<TIn>(HandlerName, async (@event, action) => await HandleProcessAsync(@event, action));

    protected async Task InputDataAsync(string? queueName, TIn @in, string? taskId = null)
    {
        if (@in == null)
        {
            await _eventBusService.CriticalAsync(queueName, HandlerName, null, "Input data is null.");
            return;
        }

        var @event = new Event<TIn>
        {
            QueueName = queueName,
            TaskId = taskId ?? Guid.NewGuid().ToString(),
            Message = @in
        };

        try
        {
            await HandleProcessAsync(@event);
        }
        catch (Exception ex)
        {
            await _eventBusService.ErrorAsync(@event.QueueName, HandlerName, @event.TaskId, @event.Message, ex.Message, ex.StackTrace);
            await _eventBusService.PublishAsync(@event);
        }
    }

    private protected abstract Task HandleProcessAsync(Event<TIn> @event, Action? action = null);
}


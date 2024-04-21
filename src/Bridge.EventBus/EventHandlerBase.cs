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
    {
        await _eventBusService.RecieveAsync<TIn>(HandlerName, async (@event, action) =>
        {
            try
            {
                await HandleProcessAsync(@event);
            }
            catch (Exception ex)
            {
                await _eventBusService.ErrorAsync(@event.QueueName, HandlerName, @event.TaskId, ErrorLog(@event.Message, ex), @event.Message, ex.Message, ex.StackTrace);
                await _eventBusService.PublishAsync(@event);
            }
        });
    }

    protected async Task InputDataAsync(string? queueName, TIn @in, string? taskId = null)
    {
        if (@in == null)
        {
            await _eventBusService.CriticalAsync(queueName, HandlerName, null, CriticalLog(), "Input data is null.");
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
            await _eventBusService.ErrorAsync(@event.QueueName, HandlerName, @event.TaskId, ErrorLog(@in, ex), @event.Message, ex.Message, ex.StackTrace);
            await _eventBusService.PublishAsync(@event);
        }
    }

    private protected abstract Task HandleProcessAsync(Event<TIn> @event, Action? action = null);

    protected virtual string? CriticalLog() => null;

    protected virtual string? ErrorLog(TIn @in, Exception ex) => null;
}


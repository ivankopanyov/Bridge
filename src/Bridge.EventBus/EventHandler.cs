namespace Bridge.EventBus;

public abstract class EventHandler<TIn> : EventHandlerBase<TIn> where TIn : class, new()
{
    protected EventHandler(IEventBusService eventBusService) : base(eventBusService) { } 

    private protected override sealed async Task HandleProcessAsync(Event<TIn> @event, Action? action = null)
    { 
        await HandleAsync(@event.Message, @event.TaskId);
        action?.Invoke();
        await _eventBusService.SuccessfulAsync(@event.QueueName, HandlerName, @event.TaskId, SuccessfulLog(@event.Message), @event.Message);
    }

    protected abstract Task HandleAsync(TIn @in, string? taskId);

    protected virtual string? SuccessfulLog(TIn @in) => null;
}

public abstract class EventHandler<TIn, TOut> : EventHandlerBase<TIn> where TIn : class, new() where TOut : class, new()
{
    protected EventHandler(IEventBusService eventBusService) : base(eventBusService) { }

    private protected override sealed async Task HandleProcessAsync(Event<TIn> @event, Action? successAction = null)
    {
        if (await HandleAsync(@event.Message, @event.TaskId) is not TOut @out)
        {
            await _eventBusService.CriticalAsync(@event.QueueName, HandlerName, @event.TaskId, CriticalLog(), "Output data is null.");
            return;
        }

        await _eventBusService.SuccessfulAsync(@event.QueueName, HandlerName, @event.TaskId, SuccessfulLog(@event.Message, @out), @event.Message, @out);
        await _eventBusService.PublishAsync(new Event<TOut>
        {
            QueueName = @event.QueueName,
            TaskId = @event.TaskId,
            Message = @out
        }, successAction);
    }

    protected abstract Task<TOut> HandleAsync(TIn @in, string? taskId);

    protected virtual string? SuccessfulLog(TIn @in, TOut @out) => null;
}
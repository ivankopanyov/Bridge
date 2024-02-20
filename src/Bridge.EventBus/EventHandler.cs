namespace Bridge.EventBus;

public abstract class EventHandler<TIn> : EventHandlerBase<TIn> where TIn : class, new()
{
    protected EventHandler(IEventBusService eventBusService) : base(eventBusService) { }

    private protected override sealed async Task HandleProcessAsync(Event<TIn> @event, Action? action = null)
    { 
        await HandleAsync(@event.Message);
        action?.Invoke();
        await _eventBusService.SuccessfulAsync(@event.QueueName, HandlerName, @event.TaskId, @event.Message);
    }

    protected abstract Task HandleAsync(TIn @in);
}

public abstract class EventHandler<TIn, TOut> : EventHandlerBase<TIn> where TIn : class, new() where TOut : class, new()
{
    protected EventHandler(IEventBusService eventBusService) : base(eventBusService) { }

    private protected override sealed async Task HandleProcessAsync(Event<TIn> @event, Action? successAction = null)
    {
        if (await HandleAsync(@event.Message) is not TOut @out)
        {
            await _eventBusService.CriticalAsync(@event.QueueName, HandlerName, @event.TaskId, "Output data is null.");
            return;
        }

        await _eventBusService.SuccessfulAsync(@event.QueueName, HandlerName, @event.TaskId, @event.Message, @out);
        await _eventBusService.PublishAsync(new Event<TOut>
        {
            QueueName = @event.QueueName,
            TaskId = @event.TaskId,
            Message = @out
        }, successAction);
    }

    protected abstract Task<TOut> HandleAsync(TIn @in);
}
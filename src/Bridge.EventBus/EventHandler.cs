namespace Bridge.EventBus;

public abstract class EventHandler<TIn> : EventHandlerBase<TIn> where TIn : Message, new()
{
    protected EventHandler(IEventBusService eventBusService, ILogger logger) : base(eventBusService, logger) { }

    private protected override sealed async Task<bool> HandleProcessAsync(Event<TIn> @event)
    { 
        await HandleAsync(@event.Message);
        Logger.Successful(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message));
        return true;
    }

    protected abstract Task HandleAsync(TIn @in);
}

public abstract class EventHandler<TIn, TOut> : EventHandlerBase<TIn, TOut> where TIn : Message, new() where TOut : Message, new()
{
    protected EventHandler(IEventBusService eventBusService, ILogger logger) : base(eventBusService, logger) { }
}

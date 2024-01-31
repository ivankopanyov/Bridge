namespace Bridge.EventBus;

public abstract class EventHandler<TIn> : EventHandlerBase<TIn> where TIn : class, new()
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

public abstract class EventHandler<TIn, TOut> : EventHandlerBase<TIn> where TIn : class, new() where TOut : class, new()
{
    protected EventHandler(IEventBusService eventBusService, ILogger logger) : base(eventBusService, logger) { }

    private protected override sealed async Task<bool> HandleProcessAsync(Event<TIn> @event)
    {
        if (await HandleAsync(@event.Message) is not TOut @out)
        {
            Logger.Critical(HandlerName, "Output data is null.");
            return false;
        }

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

    protected abstract Task<TOut> HandleAsync(TIn @in);

    protected virtual string? OutputLog(TOut @out) => null;
}
namespace Bridge.EventBus.Handlers;

public abstract class HandlerBase<TIn>
{
    internal protected HandlerBase()
    {
    }

    internal abstract Task ProcessHandleAsync(TIn @in, IEventContext context);

    internal protected virtual string? Message(TIn @in) => null;
}

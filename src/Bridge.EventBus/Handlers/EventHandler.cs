namespace Bridge.EventBus;

public abstract class Handler<TIn> : HandlerBase<TIn>
{
    internal sealed override async Task ProcessHandleAsync(TIn @in, IEventContext context) =>
        await HandleAsync(@in, context);

    internal protected abstract Task HandleAsync(TIn @in, IEventContext context);
}

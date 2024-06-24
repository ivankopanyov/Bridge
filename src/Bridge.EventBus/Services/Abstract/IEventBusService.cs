namespace Bridge.EventBus;

internal delegate Task PublishHandleAsync<TIn>(TIn @in);

public interface IEventBusService<TIn>
{
    internal event PublishHandleAsync<TIn>? PublishEvent;

    void Publish(TIn @in);
}

namespace Bridge.EventBus.Services.Implement;

internal class EventBusService<TIn> : IEventBusService<TIn>
{
    public event PublishHandleAsync<TIn>? PublishEvent;

    public void Publish(TIn @in) => PublishEvent?.Invoke(@in);
}

namespace Bridge.EventBus;

public interface IEventBusBuilder
{
    IEventBusBuilder AddEventHandler<THandler, TIn>(Action<EventHandlerOptions>? action = null) where THandler : Handler<TIn>;

    IEventBusBuilder AddLogHandler<THandler>() where THandler : LogHandler;
}

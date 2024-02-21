namespace Bridge.EventBus;

public interface IEventBusBuilder
{
    IEventBusBuilder AddHandler<THandler, TIn>() where THandler : EventHandlerBase<TIn> where TIn : class, new();

    IEventBusBuilder AddLogger(LoggerConfiguration? loggerConfiguration, string? logFileName = null);
}

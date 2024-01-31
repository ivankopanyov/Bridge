namespace Bridge.EventBus;

public interface IHandlersRegistrator
{
    IHandlersRegistrator Register<THandler, TIn>() where THandler : EventHandlerBase<TIn> where TIn : class, new();
}

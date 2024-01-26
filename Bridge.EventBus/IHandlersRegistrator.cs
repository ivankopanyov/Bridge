namespace Bridge.EventBus;

public interface IHandlersRegistrator
{
    IHandlersRegistrator Register<THandler, TIn>() where THandler : EventBusListenerBase<TIn> where TIn : Message;
}

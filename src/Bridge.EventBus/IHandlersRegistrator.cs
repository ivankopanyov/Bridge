namespace Bridge.EventBus;

public interface IHandlersRegistrator
{
    IHandlersRegistrator Register<THandler, TIn>() 
        where THandler : EventHandler<TIn> where TIn : Message, new();

    IHandlersRegistrator Register<THandler, TIn, TOut>() 
        where THandler : EventHandler<TIn, TOut> where TIn : Message, new() where TOut : Message, new();
    
    IHandlersRegistrator RegisterStart<THandler, TIn, TOut>() 
        where THandler : StartEventHandler<TIn, TOut> where TIn : class, new() where TOut : Message, new();
}

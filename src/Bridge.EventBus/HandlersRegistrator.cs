namespace Bridge.EventBus;

internal class HandlersRegistrator(IServiceCollection services) : IHandlersRegistrator
{
    private readonly IServiceCollection _services = services;

    public IHandlersRegistrator Register<THandler, TIn>()
        where THandler : EventHandler<TIn> where TIn : Message, new()
        => RegisterHandler<THandler, TIn>();

    public IHandlersRegistrator Register<THandler, TIn, TOut>() where THandler
        : EventHandler<TIn, TOut> where TIn : Message, new() where TOut : Message, new()
        => RegisterHandler<THandler, TIn>();

    public IHandlersRegistrator RegisterStart<THandler, TIn, TOut>()
        where THandler : StartEventHandler<TIn, TOut> where TIn : class, new() where TOut : Message, new()
        => RegisterHandler<THandler, TIn>();

    private HandlersRegistrator RegisterHandler<THandler, TIn>()
        where THandler : EventHandlerBase<TIn> where TIn : class, new()
    {
        _services.AddHostedService<THandler>();
        return this;
    }
}

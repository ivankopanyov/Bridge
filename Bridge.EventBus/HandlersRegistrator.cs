namespace Bridge.EventBus;

internal class HandlersRegistrator(IServiceCollection services) : IHandlersRegistrator
{
    private readonly IServiceCollection _services = services;

    public IHandlersRegistrator Register<THandler, TIn>() where THandler : EventBusListenerBase<TIn> where TIn : Message
    {
        _services.AddHostedService<THandler>();
        return this;
    }
}

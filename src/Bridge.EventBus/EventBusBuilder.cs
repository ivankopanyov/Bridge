namespace Bridge.EventBus;

internal class EventBusBuilder(IServiceCollection services) : IEventBusBuilder
{
    private readonly IServiceCollection _services = services;

    public IEventBusBuilder AddHandler<THandler, TIn>() where THandler : EventHandlerBase<TIn> where TIn : class, new()
    {
        _services.AddHostedService<THandler>();
        return this;
    }
}

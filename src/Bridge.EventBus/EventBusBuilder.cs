namespace Bridge.EventBus;

internal class EventBusBuilder(IServiceCollection services, int hostId) : IEventBusBuilder
{
    public IEventBusBuilder AddEventHandler<THandler, TIn>(Action<EventHandlerOptions>? action = null) where THandler : Handler<TIn>
    {
        ArgumentNullException.ThrowIfNull(action);
        var options = new EventHandlerOptions<THandler, TIn>()
        {
            UseEventLogging = true
        };
        action.Invoke(options);

        return AddHandler(options);
    }

    public IEventBusBuilder AddLogHandler<THandler>() where THandler : LogHandler => 
        AddHandler(new EventHandlerOptions<THandler, EventLog>());

    private IEventBusBuilder AddHandler<THandler, TIn>(EventHandlerOptions<THandler, TIn> options) where THandler : HandlerBase<TIn>
    {
        options.HostId = hostId;

        services
            .AddTransient<THandler>()
            .AddSingleton<IEventBusService<TIn>, EventBusService<TIn>>()
            .AddSingleton(options)
            .AddHostedService<HandlerStarter<THandler, TIn>>();

        return this;
    }
}

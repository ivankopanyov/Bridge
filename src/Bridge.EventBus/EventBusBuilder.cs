namespace Bridge.EventBus;

internal class EventBusBuilder(IServiceCollection services) : IEventBusBuilder
{
    private readonly IServiceCollection _services = services;

    internal LoggerConfiguration? LoggerConfiguration { get; private set; }

    internal string? LogFileName { get; private set; }

    public IEventBusBuilder AddHandler<THandler, TIn>() where THandler : EventHandlerBase<TIn> where TIn : class, new()
    {
        _services.AddHostedService<THandler>();
        return this;
    }
    public IEventBusBuilder AddLogger(LoggerConfiguration? loggerConfiguration, string? logFileName = null)
    {
        LoggerConfiguration = loggerConfiguration;
        LogFileName = logFileName;
        return this;
    }
}

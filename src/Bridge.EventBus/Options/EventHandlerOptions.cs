namespace Bridge.EventBus.Options;

public abstract class EventHandlerOptions
{
    internal int HostId { get; set; }

    public string TaskName { get; set; }

    public string HandlerName { get; set; }

    internal bool UseEventLogging { get; set; }
}

public class EventHandlerOptions<THandler, TIn> : EventHandlerOptions where THandler : HandlerBase<TIn> { }
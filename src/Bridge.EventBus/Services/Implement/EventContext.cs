namespace Bridge.EventBus.Services.Implement;

internal class EventContext : IEventContext
{
    private readonly List<Event> _events = [];

    public IEnumerable<Event> Events => _events;

    public void Send<TIn>(TIn @in)
    {
        if (@in != null)
            _events.Add(new Event<TIn>
            {
                Message = @in
            });
    }

    public TOut Send<TIn, TOut>(TIn @in)
    {
        throw new NotImplementedException();
    }

    public void Break(string? message = null, Exception? innerException = null) =>
        throw new TaskCriticalException(message, innerException);
}

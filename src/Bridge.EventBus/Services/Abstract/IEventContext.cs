namespace Bridge.EventBus;

public interface IEventContext
{
    void Send<TIn>(TIn @in);

    TOut Send<TIn, TOut>(TIn @in);

    void Break(string? message = null, Exception? innerException = null);
}

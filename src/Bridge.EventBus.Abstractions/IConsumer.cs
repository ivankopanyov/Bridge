namespace Bridge.EventBus.Abstractions;

public delegate Task MessageHandleAsync<T>(T message, EventArgs args);

public interface IConsumer<T>
{
    event MessageHandleAsync<T>? MessageEvent;

    void RecieveStart();
}
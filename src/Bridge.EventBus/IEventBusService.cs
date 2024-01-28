namespace Bridge.EventBus;

public interface IEventBusService
{
    Task SendAsync<T>(string? queuName, T? message) where T : Message, new();

    internal Task SendAsync<T>(Event<T> @event) where T : class, new();

    internal IModel OpenChannel();
}

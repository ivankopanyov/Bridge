namespace Bridge.EventBus;

public interface IEventBusService
{
    Task SendAsync<T>(string? queuName, T? message) where T : Message;

    internal Task SendAsync<T>(Event<T> @event) where T : Message;
}

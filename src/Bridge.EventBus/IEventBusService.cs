namespace Bridge.EventBus;

public delegate void ChangeStateServiceBusHandle(bool isActive, Exception? ex);

public interface IEventBusService
{
    internal IConnectionFactory ConnectionFactory { get; }

    bool IsActive { get; }

    Exception? CurrentException { get; }

    event ChangeStateServiceBusHandle ChangeStateEvent;

    Task SendAsync<T>(string? queuName, T? message) where T : Message, new();

    internal Task SendAsync<T>(Event<T> @event) where T : class, new();

    internal void Active();

    internal void Unactive(Exception ex);
}

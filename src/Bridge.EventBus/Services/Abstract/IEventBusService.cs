namespace Bridge.EventBus;

public interface IEventBusService
{
    Task PublishAsync<T>(string? queueName, T message) where T : class, new();

    Task PublishAsync<T>(string? queueName, string? taskId, T message) where T : class, new();

    internal Task PublishAsync<T>(Event<T> @event, Action? successAction = null) where T : class, new();

    internal Task RecieveAsync<T>(string handlerName, Action<Event<T>, Action?> handleAction) where T : class, new();

    internal Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, string? description, object @in);

    internal Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, string? description, object @in, object @out);

    internal Task ErrorAsync(string? queueName, string? handlerName, string? taskId, string? description, object @in, string error, string? stackTrace = null);

    internal Task CriticalAsync(string? queueName, string? handlerName, string? taskId, string? description, string error, string? stackTrace = null);
}

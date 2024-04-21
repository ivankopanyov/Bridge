namespace Bridge.EventBus.Services.Abstract;

internal delegate Task ErrorHandleAsync(string? queueName, string? handlerName, string? taskId, string? description, object @in, string error, string? stackTrace = null);

internal delegate Task CriticalHandleAsync(string? queueName, string? handlerName, string? taskId, string? description, string error, string? stackTrace = null);

internal interface IRabbitMqService : IOptinable
{
    event ErrorHandleAsync? ErrorEvent;

    event CriticalHandleAsync? CriticalEvent;

    Task PublishAsync<T>(Event<T> @event, Action? successAction = null) where T : class, new();

    Task RecieveAsync<T>(string handlerName, Action<Event<T>, Action?> handleAction) where T : class, new();
}

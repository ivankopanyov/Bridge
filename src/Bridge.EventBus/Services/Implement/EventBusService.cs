using Google.Protobuf;

namespace Bridge.EventBus.Services.Implement;

internal class EventBusService : IEventBusService
{
    private readonly IRabbitMqService _rabbitMqService;

    private readonly IElasticSearchService _elasticSearchService;

    public EventBusService(IRabbitMqService rabbitMqService, IElasticSearchService elasticSearchService)
    {
        _rabbitMqService = rabbitMqService;
        _elasticSearchService = elasticSearchService;

        _rabbitMqService.ErrorEvent += ErrorAsync;
        _rabbitMqService.CriticalEvent += CriticalAsync;
    }

    public async Task PublishAsync<T>(string? queueName, T message) where T : class, new() => 
        await _rabbitMqService.PublishAsync<T>(new()
        {
            QueueName = queueName,
            TaskId = Guid.NewGuid().ToString(),
            Message = message
        });

    public async Task PublishAsync<T>(Event<T> @event, Action? successAction = null) where T : class, new() => 
        await _rabbitMqService.PublishAsync(@event, successAction);

    public async Task RecieveAsync<T>(string handlerName, Action<Event<T>, Action?> handleAction) where T : class, new() => 
        await _rabbitMqService.RecieveAsync(handlerName, handleAction);

    public async Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, object @in) =>
        await _elasticSearchService.SendAsync(new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Information,
            In = @in
        });

    public async Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, object @in, object @out) =>
        await _elasticSearchService.SendAsync(new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Information,
            In = @in,
            Out = @out
        });

    public async Task ErrorAsync(string? queueName, string? handlerName, string? taskId, object @in, string error, string? stackTrace = null) =>
        await _elasticSearchService.SendAsync(new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Error,
            Error = error,
            StackTrace = stackTrace,
            In = @in
        });

    public async Task CriticalAsync(string? queueName, string? handlerName, string? taskId, string error, string? stackTrace = null) =>
        await _elasticSearchService.SendAsync(new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Critical,
            Error = error,
            StackTrace = stackTrace
        });
}

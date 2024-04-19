namespace Bridge.EventBus.Services.Implement;

internal class EventBusService : IEventBusService
{
    private readonly IRabbitMqService _rabbitMqService;

    private readonly IElasticSearchService _elasticSearchService;

    private readonly ServiceHost.ServiceHostClient _serviceHostClient;

    private static readonly JsonSerializerSettings _jsonSerializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        }
    };

    public EventBusService(IRabbitMqService rabbitMqService, IElasticSearchService elasticSearchService,
        ServiceHost.ServiceHostClient serviceHostClient)
    {
        _rabbitMqService = rabbitMqService;
        _elasticSearchService = elasticSearchService;
        _serviceHostClient = serviceHostClient;

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

    public async Task PublishAsync<T>(string? queueName, string? taskId, T message) where T : class, new() =>
        await _rabbitMqService.PublishAsync<T>(new()
        {
            QueueName = queueName,
            TaskId = taskId,
            Message = message
        });

    public async Task PublishAsync<T>(Event<T> @event, Action? successAction = null) where T : class, new() => 
        await _rabbitMqService.PublishAsync(@event, successAction);

    public async Task RecieveAsync<T>(string handlerName, Action<Event<T>, Action?> handleAction) where T : class, new() => 
        await _rabbitMqService.RecieveAsync(handlerName, handleAction);

    public async Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, object @in)
    {
        var elasticLog = new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Information,
            In = @in
        };

        await _elasticSearchService.SendAsync(elasticLog);

        var log = CreateLog(LogStatus.Information, elasticLog.DateTime, queueName: queueName, handlerName: handlerName,
            taskId: taskId, @in: @in);

        await _serviceHostClient.AddLogAsync(log);
    }

    public async Task SuccessfulAsync(string? queueName, string? handlerName, string? taskId, object @in, object @out)
    {
        var elasticLog = new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Information,
            In = @in,
            Out = @out
        };

        await _elasticSearchService.SendAsync(elasticLog);

        var log = CreateLog(LogStatus.Information, elasticLog.DateTime, queueName: queueName, handlerName: handlerName,
            taskId: taskId, @in: @in, @out: @out);

        await _serviceHostClient.AddLogAsync(log);
    }

    public async Task ErrorAsync(string? queueName, string? handlerName, string? taskId, object @in, string error, string? stackTrace = null)
    {
        var elasticLog = new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Error,
            Error = error,
            StackTrace = stackTrace,
            In = @in
        };

        await _elasticSearchService.SendAsync(elasticLog);

        var log = CreateLog(LogStatus.Error, elasticLog.DateTime, queueName: queueName, handlerName: handlerName, taskId: taskId,
            @in: @in, error: error, stackTrace: stackTrace);

        await _serviceHostClient.AddLogAsync(log);
    }

    public async Task CriticalAsync(string? queueName, string? handlerName, string? taskId, string error, string? stackTrace = null)
    {
        var elasticLog = new ElasticLog
        {
            QueueName = queueName,
            HandlerName = handlerName,
            TaskId = taskId,
            LogLevel = LogLevel.Critical,
            Error = error,
            StackTrace = stackTrace
        };

        await _elasticSearchService.SendAsync(elasticLog);

        var log = CreateLog(LogStatus.Critical, elasticLog.DateTime, queueName: queueName, handlerName: handlerName, taskId: taskId,
            error: error, stackTrace: stackTrace);

        await _serviceHostClient.AddLogAsync(log);
    }

    private static Bridge.Services.Control.Log CreateLog(LogStatus logStatus, DateTime dateTime, string? queueName = null,
        string? handlerName = null, string? taskId = null, string? error = null, string? stackTrace = null, object? @in = null,
        object? @out = null)
    {
        var log = new Bridge.Services.Control.Log
        {
            LogLevel = logStatus,
            DateTime = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(dateTime.ToUniversalTime())
        };

        if (queueName != null)
            log.QueueName = queueName;

        if (handlerName != null)
            log.HandlerName = handlerName;

        if (taskId != null)
            log.TaskId = taskId;

        if (error != null)
            log.Error = error;

        if (stackTrace != null)
            log.StackTrace = stackTrace;

        if (@in != null)
            log.InJson = SerializeLogObject(@in);

        if (@out != null)
            log.OutJson = SerializeLogObject(@out);

        return log;
    }

    private static string SerializeLogObject(object logObject)
    {
        try
        {
            return JsonConvert.SerializeObject(logObject, _jsonSerializerSettings) is string message
                ? message : "{\"SerializeError\":\"Object is null.\"}";
        }
        catch (Exception ex)
        {
            return "{\"SerializeError\":\"" + ex.Message + "\"}";
        }
    }
}

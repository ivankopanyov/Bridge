namespace Bridge.HostApi.Dto;

public class LogDto
{
    public string? QueueName { get; set; }

    public string? HandlerName { get; set; }

    public string? TaskId { get; set; }

    public bool IsEnd { get; set; }

    public string? Description { get; set; }

    public LogLevel LogLevel { get; set; }

    public string? Error { get; set; }

    public string? StackTrace { get; set; }

    public DateTime DateTime { get; set; }

    public string? InJson { get; set; }

    public string? OutJson { get; set; }

    public LogDto(Bridge.Services.Control.Log log)
    {
        QueueName = log.QueueName;
        HandlerName = log.HandlerName;
        TaskId = log.TaskId;
        IsEnd = log.IsEnd;
        Description = log.Description;
        LogLevel = log.LogLevel switch
        {
            LogStatus.Information => LogLevel.Information,
            LogStatus.Error => LogLevel.Error,
            LogStatus.Critical => LogLevel.Critical,
            _ => LogLevel.Information
        };
        Error = log.Error;
        StackTrace = log.StackTrace;
        DateTime = log.DateTime.ToDateTime();
        InJson = log.InJson;
        OutJson = log.OutJson;
    }
}

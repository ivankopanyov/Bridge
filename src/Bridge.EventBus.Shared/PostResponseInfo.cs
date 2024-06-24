namespace Bridge.EventBus.Shared;

public class PostResponseInfo
{ 
    public Dictionary<string, string> Headers { get; set; }

    public string CorrelationId { get; set; }

    public bool Succeeded { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }
}

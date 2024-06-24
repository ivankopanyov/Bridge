namespace Bridge.Services.Control;

public class ServiceState
{
    public bool IsActive { get; set; }

    public string? Error { get; set; }

    public string? StackTrace { get; set; }

    public string? Info { get; set; }

    public ServiceState Clone() => (ServiceState)MemberwiseClone();
}

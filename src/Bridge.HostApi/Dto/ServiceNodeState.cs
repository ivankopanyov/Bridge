namespace Bridge.HostApi.Dto;

public class ServiceNodeState(ServiceState serviceState)
{
    public bool IsActive { get; init; } = serviceState.IsActive;

    public string? Error { get; init; } = serviceState.Error;

    public string? StackTrace { get; init; } = serviceState.StackTrace;

    public ServiceState ToServiceState()
    {
        var serviceState = new ServiceState
        {
            IsActive = IsActive
        };

        if (Error != null)
            serviceState.Error = Error;

        if (StackTrace != null)
            serviceState.StackTrace = StackTrace;

        return serviceState;
    }
}

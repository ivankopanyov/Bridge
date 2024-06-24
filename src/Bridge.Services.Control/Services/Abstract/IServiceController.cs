namespace Bridge.Services.Control; 

public delegate void ChangedOptionsHandle(UpdatedServiceInfo serviceInfo);

internal delegate void SetOptionsHandle(string hostName, string serviceName, Options options);

internal delegate void ReloadHandle(string hostName, string serviceName);

internal delegate void SetEnvironmentHandle<TEnvironment>(TEnvironment environment) where TEnvironment : class, new();

public interface IServiceController
{
    event ChangedOptionsHandle? ChangedOptionsEvent;

    internal event SetOptionsHandle? SetOptionsEvent;

    internal event ReloadHandle? ReloadEvent;

    internal void ChangedOptions(UpdatedServiceInfo serviceInfo);

    void SetOptions(string hostName, string serviceName, Options options);

    void Reload(string hostName, string serviceName);
}

public interface IServiceController<TEnvironment> : IServiceController where TEnvironment : class, new()
{
    internal event SetEnvironmentHandle<TEnvironment>? SetEnvironmentEvent;

    void SetEnvironment(TEnvironment environment);
}
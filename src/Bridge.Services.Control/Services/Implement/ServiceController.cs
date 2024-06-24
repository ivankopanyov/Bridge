namespace Bridge.Services.Control.Services.Implement;

internal class ServiceController() : IServiceController
{
    public event ChangedOptionsHandle? ChangedOptionsEvent;

    public event SetOptionsHandle? SetOptionsEvent;

    public event ReloadHandle? ReloadEvent;

    public void ChangedOptions(UpdatedServiceInfo serviceInfo) => ChangedOptionsEvent?.Invoke(serviceInfo);

    public void SetOptions(string hostName, string serviceName, Options options)
        => SetOptionsEvent?.Invoke(hostName, serviceName, options);

    public void Reload(string hostName, string serviceName)
        => ReloadEvent?.Invoke(hostName, serviceName);
}

internal class ServiceController<TEnvironment>() : ServiceController(), IServiceController<TEnvironment> where TEnvironment : class, new()
{
    public event SetEnvironmentHandle<TEnvironment>? SetEnvironmentEvent;

    public void SetEnvironment(TEnvironment environment) => SetEnvironmentEvent?.Invoke(environment);
}
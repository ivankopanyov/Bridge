namespace Bridge.Services.Control;

internal class ServiceRegistrator(IServiceCollection services) : IServiceRegistrator
{
    private readonly IServiceCollection _services = services;

    private readonly HashSet<string> _serviceNames = [];

    public IServiceRegistrator Register<T>(Action<ServiceNodeOptions<T>> action) where T : ServiceNode
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceNodeOptions<T>();
        action.Invoke(options);

        if (string.IsNullOrWhiteSpace(options.Name))
            throw new ArgumentException("Service name is null or withespace.", nameof(options.Name));

        if (_serviceNames.Contains(options.Name))
            throw new ArgumentException($"service named {options.Name} has already been registered.", nameof(options.Name));

        _services.AddSingleton(options);
        _services.AddSingleton<T>();
        return this;
    }
}

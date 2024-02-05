namespace Bridge.Services.Control;

internal class ServiceRegistrator(IServiceCollection services, string host) : IServiceRegistrator
{
    private readonly IServiceCollection _services = services;

    private readonly string _host = host;

    private readonly HashSet<string> _serviceNames = [];

    public IServiceRegistrator Register<T>(Action<ServiceNodeOptions> action) where T : ServiceNode
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceNodeOptions();
        action.Invoke(options);

        if (string.IsNullOrWhiteSpace(options.Name))
            throw new ArgumentException("Service name is null or withespace.", nameof(options.Name));

        if (_serviceNames.Contains(options.Name))
            throw new ArgumentException($"Service named {options.Name} has already been registered.", nameof(options.Name));

        _services.AddSingleton(new ServiceNodeOptions<T>
        {
            Host = _host,
            Name = options.Name,
            UseRestart = options.UseRestart
        });
        _services.AddHostedService<T>();
        return this;
    }
}

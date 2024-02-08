namespace Bridge.Services.Control;

internal class ServiceControlBuilder(IServiceCollection services, string host) : IServiceControlBuilder
{
    private readonly string _host = host;

    private readonly HashSet<string> _serviceNames = [];

    public IServiceCollection Services { get; private init; } = services;

    public IServiceControlBuilder AddService<T>(Action<ServiceNodeOptions> action) where T : ServiceNode
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceNodeOptions();
        action.Invoke(options);

        if (string.IsNullOrWhiteSpace(options.Name))
            throw new ArgumentException("Service name is null or withespace.", nameof(options.Name));

        if (_serviceNames.Contains(options.Name))
            throw new ArgumentException($"Service named {options.Name} has already been registered.", nameof(options.Name));

        Services.AddSingleton(new ServiceNodeOptions<T>
        {
            Host = _host,
            Name = options.Name
        });
        Services.AddSingleton<T>();
        return this;
    }

    public IServiceControlBuilder AddService<T, TOptions>(Action<ServiceNodeOptions> action)
        where T : ServiceNode<TOptions> where TOptions : class, new()
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceNodeOptions();
        action.Invoke(options);

        if (string.IsNullOrWhiteSpace(options.Name))
            throw new ArgumentException("Service name is null or withespace.", nameof(options.Name));

        if (_serviceNames.Contains(options.Name))
            throw new ArgumentException($"Service named {options.Name} has already been registered.", nameof(options.Name));

        Services.AddSingleton(new ServiceNodeOptions<T, TOptions>
        {
            Host = _host,
            Name = options.Name
        });
        Services.AddSingleton<T>();
        Services.AddHostedService<HostedServiceNode<T, TOptions>>();
        return this;
    }
}

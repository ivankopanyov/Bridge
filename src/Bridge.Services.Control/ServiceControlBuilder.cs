namespace Bridge.Services.Control;

internal class ServiceControlBuilder(IServiceCollection services, string host) : IServiceControlBuilder
{
    private readonly string _host = host;

    private readonly HashSet<string> _serviceNames = [];

    public IServiceCollection Services { get; private init; } = services;

    public IServiceControlBuilder AddService<TAbstract, TImplement, TOptions>(Action<ServiceOptions> action)
        where TAbstract : class, IOptinable where TImplement : ServiceControl<TOptions>, TAbstract where TOptions : class, new()
    {
        ArgumentNullException.ThrowIfNull(action);

        var options = new ServiceOptions();
        action.Invoke(options);

        if (string.IsNullOrWhiteSpace(options.Name))
            throw new ArgumentException("Service name is null or withespace.", nameof(options.Name));

        if (_serviceNames.Contains(options.Name))
            throw new ArgumentException($"Service named {options.Name} has already been registered.", nameof(options.Name));

        Services.AddSingleton(new ServiceOptions<TImplement, TOptions>
        {
            Host = _host,
            Name = options.Name
        });

        Services.AddSingleton<TAbstract, TImplement>();
        Services.AddHostedService<OptionService<TAbstract>>();
        return this;
    }
}

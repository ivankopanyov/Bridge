namespace Bridge.Services.Control.Services.Implement;

internal class ServiceControlBuilder(IServiceCollection services, string host) : IServiceControlBuilder
{
    private readonly HashSet<string> _serviceNames = [];

    private bool _serviceController;
    public IServiceCollection Services { get; private init; } = services;

    public IServiceControlBuilder AddTransient<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddTransient<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder AddScoped<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddScoped<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder AddSingleton<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddSingleton<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder AddServiceController()
    {
        if (_serviceController)
            return this;

        _serviceController = true;

        Services
            .AddSingleton<IServiceController, ServiceController>()
            .AddHostedService<ServiceControllerStarter>();

        return this;
    }

    private void AddControl<TService, TOptions>(Action<ServiceOptions> options)
        where TService : class, IService<TOptions> where TOptions : class, new()
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));

        var serviceOptions = new ServiceOptions();
        options.Invoke(serviceOptions);

        ArgumentException.ThrowIfNullOrWhiteSpace(serviceOptions.ServiceName, nameof(serviceOptions.ServiceName));

        if (_serviceNames.Contains(serviceOptions.ServiceName))
            throw new ArgumentException($"Service named {serviceOptions.ServiceName} has already been registered.", nameof(serviceOptions.ServiceName));

        _serviceNames.Add(serviceOptions.ServiceName);

        Services
            .AddHostedService<ControlStarter<TService, TOptions>>()
            .AddSingleton<IControl<TOptions>, Control<TOptions>>();

        Services.AddSingleton(new ServiceOptions<TOptions>
        {
            HostName = host,
            ServiceName = serviceOptions.ServiceName
        });
    }
}

internal class ServiceControlBuilder<TEnvironment>(IServiceCollection services, string host)
    : IServiceControlBuilder<TEnvironment> where TEnvironment : class, new()
{
    private readonly HashSet<string> _serviceNames = [];

    private bool _serviceController;
    public IServiceCollection Services { get; private init; } = services;

    public IServiceControlBuilder<TEnvironment> AddTransient<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddTransient<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder<TEnvironment> AddScoped<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddScoped<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder<TEnvironment> AddSingleton<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new()
    {
        Services.AddSingleton<TAbstract, TImplement>();
        AddControl<TAbstract, TOptions>(options);
        return this;
    }

    public IServiceControlBuilder<TEnvironment> AddServiceController()
    {
        if (_serviceController)
            return this;

        _serviceController = true;

        Services
            .AddSingleton<IServiceController<TEnvironment>, ServiceController<TEnvironment>>()
            .AddHostedService<ServiceControllerStarter<TEnvironment>>();

        return this;
    }

    private void AddControl<TService, TOptions>(Action<ServiceOptions> options)
        where TService : class, IService<TOptions, TEnvironment> where TOptions : class, new()
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));

        var serviceOptions = new ServiceOptions();
        options.Invoke(serviceOptions);

        ArgumentException.ThrowIfNullOrWhiteSpace(serviceOptions.ServiceName, nameof(serviceOptions.ServiceName));

        if (_serviceNames.Contains(serviceOptions.ServiceName))
            throw new ArgumentException($"Service named {serviceOptions.ServiceName} has already been registered.", nameof(serviceOptions.ServiceName));

        _serviceNames.Add(serviceOptions.ServiceName);

        Services
            .AddHostedService<ControlStarter<TService, TOptions, TEnvironment>>()
            .AddSingleton<IControl<TOptions, TEnvironment>, Control<TOptions, TEnvironment>>();

        Services.AddSingleton(new ServiceOptions<TOptions>
        {
            HostName = host,
            ServiceName = serviceOptions.ServiceName
        });
    }
}

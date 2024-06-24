namespace Bridge.Services.Control;

public interface IServiceControlBuilder
{
    IServiceCollection Services { get; }

    IServiceControlBuilder AddTransient<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder AddScoped<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder AddSingleton<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder AddServiceController();
}

public interface IServiceControlBuilder<TEnvironment> where TEnvironment : class, new()
{
    IServiceCollection Services { get; }

    IServiceControlBuilder<TEnvironment> AddTransient<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder<TEnvironment> AddScoped<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder<TEnvironment> AddSingleton<TAbstract, TImplement, TOptions>(Action<ServiceOptions> options)
        where TAbstract : class, IService<TOptions, TEnvironment> where TImplement : class, TAbstract where TOptions : class, new();

    IServiceControlBuilder<TEnvironment> AddServiceController();
}

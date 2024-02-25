namespace Bridge.Services.Control;

public interface IServiceControlBuilder
{
    IServiceCollection Services { get; }

    IServiceControlBuilder AddService<TAbstract, TImplement, TOptions>(Action<ServiceOptions> action)
        where TAbstract : class, IOptinable where TImplement : ServiceControl<TOptions>, TAbstract where TOptions : class, new();
}

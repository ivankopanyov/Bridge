namespace Bridge.Services.Control;

public interface IServiceControlBuilder
{
    IServiceCollection Services { get; }

    IServiceControlBuilder AddService<T>(Action<ServiceNodeOptions> action) where T : ServiceNode;

    IServiceControlBuilder AddService<T, TOptions>(Action<ServiceNodeOptions> action)
        where T : ServiceNode<TOptions> where TOptions : class, new();
}

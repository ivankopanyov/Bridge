namespace Bridge.Services.Control;

public interface IServiceRegistrator
{
    IServiceRegistrator Register<T>(Action<ServiceNodeOptions> action) where T : ServiceNode;

    IServiceRegistrator Register<T, TOptions>(Action<ServiceNodeOptions> action)
        where T : ServiceNode<TOptions> where TOptions : class, new();
}

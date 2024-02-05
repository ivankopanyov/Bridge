namespace Bridge.Services.Control;

public interface IServiceRegistrator
{
    IServiceRegistrator Register<T>(Action<ServiceNodeOptions> action) where T : ServiceNode;
}

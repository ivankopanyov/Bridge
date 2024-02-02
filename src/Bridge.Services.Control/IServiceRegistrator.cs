namespace Bridge.Services.Control;

public interface IServiceRegistrator
{
    IServiceRegistrator Register<T>(Action<ServiceNodeOptions<T>> action) where T : ServiceNode;
}

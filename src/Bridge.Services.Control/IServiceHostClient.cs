namespace Bridge.Services.Control;

public interface IServiceHostClient
{
    Task SetServiceAsync(ServiceNode service);
}

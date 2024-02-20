namespace Bridge.HostApi.Services;

public interface IUpdateService
{
    Task SendUpdateAsync(ServiceNodeInfo service);

    Task SendRemoveHostAsync(RemoveHost host);

    Task SendRemoveServiceAsync(RemoveService service);
}

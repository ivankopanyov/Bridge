namespace Bridge.HostApi.Services;

public interface IUpdateService
{
    Task SendLogAsync(LogDto log);

    Task SendUpdateAsync(ServiceNodeInfo service);

    Task SendRemoveHostAsync(RemoveHost host);

    Task SendRemoveServiceAsync(RemoveService service);
}

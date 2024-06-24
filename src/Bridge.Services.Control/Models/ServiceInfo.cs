namespace Bridge.Services.Control;

public class ServiceInfo : Options
{
    public string HostName { get; set; }

    public string Name { get; set; }

    public ServiceState? State { get; set; }

    public ServiceInfo Clone()
    {
        var serviceInfo = (ServiceInfo)MemberwiseClone();
        if (State != null)
            serviceInfo.State = State.Clone();

        return serviceInfo;
    }
}

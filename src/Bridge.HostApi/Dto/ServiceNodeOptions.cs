namespace Bridge.HostApi.Dto;

public class ServiceNodeOptions
{
    public string? Options { get; set; }

    public ServiceNodeOptions() { }

    public ServiceNodeOptions(ServiceOptions serviceOptions)
    {
        Options = serviceOptions.Options;
    }

    public ServiceOptions ToServiceOptions()
    {
        var serviceOptions = new ServiceOptions();

        if (Options != null)
            serviceOptions.Options = Options;

        return serviceOptions;
    }
}

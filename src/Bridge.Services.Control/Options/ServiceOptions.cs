namespace Bridge.Services.Control;

public class ServiceOptions
{
    internal string HostName { get; set; }

    public string ServiceName { get; set; }
}

public class ServiceOptions<TOptions> : ServiceOptions where TOptions : class, new()
{
}

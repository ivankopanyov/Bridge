namespace Bridge.Services.Control;

public class ServiceOptions
{
    internal string Host { get; set; }

    public string Name { get; set; }
}

public class ServiceOptions<T, TOptions> : ServiceOptions where T : ServiceControl<TOptions> where TOptions : class, new() { }

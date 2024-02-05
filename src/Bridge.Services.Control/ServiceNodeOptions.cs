namespace Bridge.Services.Control;

public class ServiceNodeOptions
{
    internal string Host { get; set; }

    public string Name { get; set; }

    public bool UseRestart { get; set; }
}

public class ServiceNodeOptions<T> : ServiceNodeOptions where T : ServiceNode { }

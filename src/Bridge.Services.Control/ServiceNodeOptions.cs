namespace Bridge.Services.Control;

public class ServiceNodeOptions
{
    public string Name { get; set; }

    public bool UseRestart { get; set; }

    private protected ServiceNodeOptions() { }
}

public class ServiceNodeOptions<T> : ServiceNodeOptions where T : ServiceNode { }

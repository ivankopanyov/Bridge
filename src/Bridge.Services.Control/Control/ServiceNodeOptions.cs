namespace Bridge.Services.Control;

public class ServiceNodeOptions
{
    internal string Host { get; set; }

    public string Name { get; set; }
}

public class ServiceNodeOptions<T> : ServiceNodeOptions where T : ServiceNode { }

public class ServiceNodeOptions<T, TOptions> : ServiceNodeOptions where T : ServiceNode<TOptions> where TOptions : class, new() { }

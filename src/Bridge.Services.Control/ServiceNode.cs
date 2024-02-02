namespace Bridge.Services.Control;

public abstract class ServiceNode(IServiceHostClient serviceHostClient, ServiceNodeOptions options, ILogger logger)
{
    private readonly bool _useRestart = options.UseRestart;

    protected string Name { get; init; } = options.Name;

    protected IServiceHostClient ServiceHostClient { get; init; } = serviceHostClient;

    protected ILogger Logger { get; init; } = logger;

    protected bool IsActive { get; private set; }

    protected Exception? CurrentException { get; private set; }

    public async Task ActiveAsync()
    {
        if (IsActive)
            return;

        IsActive = true;
        CurrentException = null; 
        await ServiceHostClient.SetServiceAsync(this);
    }

    public async Task UnactiveAsync(Exception? ex = null)
    {
        if (!IsActive && ((ex == null && CurrentException == null)
            || (ex != null && CurrentException != null && ex.Message == CurrentException.Message
            && ex.StackTrace == CurrentException.StackTrace)))
            return;

        IsActive = false;
        CurrentException = ex; 
        await ServiceHostClient.SetServiceAsync(this);
    }

    public virtual ServiceInfo ToServiceInfo() => new()
    {
        Name = Name,
        UseRestart = _useRestart,
        State = new ServiceState
        {
            IsActive = IsActive,
            Error = CurrentException?.Message,
            StackTrace = CurrentException?.StackTrace
        }
    };

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object? obj) => obj is ServiceNode other && Name == other.Name;
}

public abstract class ServiceNode<T>(IServiceHostClient serviceHostClient, ServiceNodeOptions options, ILogger logger) 
    : ServiceNode(serviceHostClient, options, logger) where T : Options, new()
{
    private T _options = DefaultOptions;

    private static T DefaultOptions => (T)Activator.CreateInstance(typeof(T))!;

    public T Options => _options;

    public virtual async Task SetOptionsAsync(T options, Action? action = null)
    {
        _options = options ?? DefaultOptions;
        action?.Invoke();

        try
        {
            await ServiceHostClient.SetServiceAsync(this);
        }
        catch (Exception ex)
        {
            Logger.Error(Name, ex);
        }
    }

    public override ServiceInfo ToServiceInfo()
    {
        var serviceInfo = base.ToServiceInfo();
        serviceInfo.Options = Options.ToServiceOptions();
        return serviceInfo;
    }
}

    
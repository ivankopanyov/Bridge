namespace Bridge.Services.Control.Services.Implement;

internal class Control<TOptions> : IControl<TOptions> where TOptions : class, new()
{
    private TOptions _options = new();

    public TOptions Options
    {
        get => _options;
        set => _options = value ?? new();
    }

    public event ActiveHandle? ActiveEvent;

    public event UnactiveHandle? UnactiveEvent;

    public void Active() => ActiveEvent?.Invoke();

    public void Unactive(string error) => UnactiveEvent?.Invoke(error);

    public void Unactive(Exception ex) => UnactiveEvent?.Invoke(ex.Message, ex);
}

internal class Control<TOptions, TEnvironment> : Control<TOptions>, IControl<TOptions, TEnvironment> 
    where TOptions : class, new() where TEnvironment : class, new()
{
    private TEnvironment _environment = new();

    public TEnvironment Environment
    {
        get => _environment;
        set => _environment = value ?? new();
    }
}

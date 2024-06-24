namespace Bridge.Services.Control;

internal delegate void ActiveHandle();

internal delegate void UnactiveHandle(string error, Exception? ex = null);

public interface IControl<TOptions> where TOptions : class, new()
{
    internal event ActiveHandle? ActiveEvent;

    internal event UnactiveHandle? UnactiveEvent;

    TOptions Options { get; internal set; }

    void Active();

    void Unactive(string error);

    void Unactive(Exception ex);
}

public interface IControl<TOptions, TEnvironment> : IControl<TOptions> where TOptions : class, new() where TEnvironment : class, new()
{
    TEnvironment Environment { get; internal set; }
}

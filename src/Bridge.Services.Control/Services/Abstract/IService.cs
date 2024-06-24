namespace Bridge.Services.Control;

public interface IService<TOptions> where TOptions : class, new()
{
    Task ChangedOptionsHandleAsync(TOptions options);
}

public interface IService<TOptions, TEnvironmrnt> : IService<TOptions> where TOptions : class, new() where TEnvironmrnt : class, new()
{
    Task ChangedEnvironmentHandleAsync(TEnvironmrnt current, TEnvironmrnt previous);
}

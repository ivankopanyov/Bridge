namespace Bridge.Opera.Services.Abstract;

public interface IOperaService : IService<OperaOptions, BridgeEnvironment>
{
    BridgeEnvironment Environment { get; }

    void Exec(Action<OperaDbContext> action);

    T Exec<T>(Func<OperaDbContext, T> func);
}

namespace Bridge.Fiscal.Services.Abstract;

public interface IFiscalService : IService<CheckDbOptions, BridgeEnvironment>
{
    BridgeEnvironment Environment { get; }

    void Exec(Action<CheckDBClient> action);

    T Exec<T>(Func<CheckDBClient, T> func);
}

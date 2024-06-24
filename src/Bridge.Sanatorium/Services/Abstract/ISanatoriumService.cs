namespace Bridge.Sanatorium.Services.Abstract;

public interface ISanatoriumService : IService<ServiceBusOptions, BridgeEnvironment>
{
    BridgeEnvironment Environment { get; }

    void Exec(Action<IEndpointInstance?> action);

    T Exec<T>(Func<IEndpointInstance?, T> func);
}

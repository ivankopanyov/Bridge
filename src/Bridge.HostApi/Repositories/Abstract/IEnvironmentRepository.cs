namespace Bridge.HostApi.Repositories.Abstract;

public interface IEnvironmentRepository
{
    Task<BridgeEnvironment?> GetAsync();

    Task<bool> UpdateAsync(BridgeEnvironment environment);
}

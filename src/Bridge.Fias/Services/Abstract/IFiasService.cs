namespace Bridge.Fias.Services.Abstract;

public interface IFiasService : IService<FiasServiceOptions, BridgeEnvironment>
{
    bool UseCheckDatabase { get; }

    IDictionary<string, bool> TaxCodes { get; }

    Task<FiasPostingAnswer> SendPostingAsync(FiasPostingSimple message, int timeoutSeconds = 60);

    Task<FiasPostingAnswer> SendPostingAsync(FiasPostingRequest message, int timeoutSeconds = 60);
}

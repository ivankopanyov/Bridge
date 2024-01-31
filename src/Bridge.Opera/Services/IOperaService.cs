namespace Bridge.Opera;

public delegate Task ChangeStateOperaHandle(bool isActive, Exception? ex);

public interface IOperaService
{
    event ChangeStateOperaHandle? ChangeStateEvent;

    bool IsActive { get; }

    Exception? CurrentException { get; }

    IReadOnlySet<string>? TrxCodes { get; }

    IReadOnlyDictionary<string, string>? DocumentTypeAliases { get; }

    void SetOperaOptions(OperaOptions? options);
    
    void Active();
    
    void Unactive(Exception ex);
}

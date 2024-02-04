namespace Bridge.Opera.Services;

public class OperaService : IOperaService
{
    public static string? ConnectionString { get; private set; }

    public bool IsActive { get; private set; }

    public Exception? CurrentException { get; private set; }

    public IReadOnlySet<string>? TrxCodes { get; private set; }

    public IReadOnlyDictionary<string, string>? DocumentTypeAliases { get; private set; }

    public event ChangeStateOperaHandle? ChangeStateEvent;

    public void SetOperaOptions(OperaOptions? options)
    {
        ConnectionString = options?.ConnectionString;
        TrxCodes = options?.TrxCodes;
        DocumentTypeAliases = options?.DocumentTypeAliases;
    }

    public void Active()
    {
        if (IsActive)
            return;

        IsActive = true;
        CurrentException = null;
        ChangeStateEvent?.Invoke(true, null);
    }

    public void Unactive(Exception ex)
    {
        if (!IsActive && CurrentException != null && ex?.Message == CurrentException.Message)
            return;

        IsActive = false;
        CurrentException = ex;
        ChangeStateEvent?.Invoke(false, ex);
    }
}

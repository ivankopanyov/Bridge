namespace Bridge.Opera.Options;

public class OperaOptions
{
    private string _connectionString = string.Empty;

    private HashSet<string> _trxCodes = [];

    private Dictionary<string, string> _documentTypeAliases = [];

    public string ConnectionString 
    {
        get => _connectionString; 
        set => _connectionString = value ?? string.Empty;
    }

    public HashSet<string> TrxCodes
    {
        get => _trxCodes;
        init => _trxCodes = value ?? [];
    }

    public Dictionary<string, string> DocumentTypeAliases
    {
        get => _documentTypeAliases;
        set => _documentTypeAliases = value ?? [];
    }
}

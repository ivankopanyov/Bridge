namespace Bridge.Opera.Options;

public class OperaOptions
{
    public const string SectionName = "Opera";

    public string? ConnectionString { get; set; }

    public HashSet<string>? TrxCodes { get; set; }

    public Dictionary<string, string>? DocumentTypeAliases { get; set; }
}

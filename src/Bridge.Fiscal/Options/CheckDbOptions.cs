namespace Bridge.Fiscal.Options;

public class CheckDbOptions
{
    [Required(AllowEmptyStrings = true)]
    public string Endpoint { get; set; } = "http://localhost/FiscalService/CheckDB";

    public override int GetHashCode() => HashCode.Combine(Endpoint);

    public override bool Equals(object? obj) => obj is CheckDbOptions other
        && Endpoint == other.Endpoint;
}

namespace Bridge.Fias.Interface;

public class FiasOptions
{
    public const string SectionName = "Fias";

    public string? Host { get; set; }

    public int? Port { get; set; }
}

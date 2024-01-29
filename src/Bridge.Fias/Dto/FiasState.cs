namespace Bridge.Fias.Dto;

public class FiasState
{
    public string? Host { get; set; }

    public int? Port { get; set; }

    public bool IsActive { get; set; }

    public string? ErrorMessage { get; set; }

    public string? StackTrace { get; set; }
}

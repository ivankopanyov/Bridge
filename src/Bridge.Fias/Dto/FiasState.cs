namespace Bridge.Fias.Dto;

public class FiasState
{
    public bool IsActive { get; set; }

    public string? ErrorMessage { get; set; }

    public string? StackTrace { get; set; }

    public Interface.FiasOptions Options { get; set; }
}

namespace Bridge.Opera.Dto;

public class OperaState
{
    public bool IsActive { get; set; }

    public string? ErrorMessagen { get; set; }

    public string? StackTrace { get; set; }

    public OperaOptions Options { get; set; }
}

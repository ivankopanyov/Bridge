namespace Bridge.Opera.Dto;

public class OperaState
{
    public string? ConnectionString { get; set; }

    public bool IsActive { get; set; }

    public string? ErrorMessagen { get; set; }

    public string? StackTrace { get; set; }
}

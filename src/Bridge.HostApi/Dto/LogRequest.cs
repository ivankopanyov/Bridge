namespace Bridge.HostApi.Dto;

public class LogRequest
{
    [Required]
    public int Size { get; set; }

    [Required]
    public DateTime To { get; set; }
}

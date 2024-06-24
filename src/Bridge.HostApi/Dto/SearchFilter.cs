namespace Bridge.HostApi.Dto;

public class SearchFilter
{
    public int? Size { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public bool? IsError { get; set; }

    public bool? IsEnd { get; set; }

    public ISet<string>? TaskNames { get; set; }

    public string? Pattern { get; set; }
}

namespace Bridge.HostApi.Options;

public class ElasticSearchOptions
{
    [Required(AllowEmptyStrings = true)]
    public string Endpoint { get; set; } = "http://elasticsearch:9200";

    [Required(AllowEmptyStrings = true)]
    public string Index { get; set; } = "bridge";

    public override int GetHashCode() => HashCode.Combine(Endpoint, Index);

    public override bool Equals(object? obj) => obj is ElasticSearchOptions other
        && Endpoint == other.Endpoint
        && Index == other.Index;
}

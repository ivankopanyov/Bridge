namespace Bridge.EventBus.Shared;

public class TimelineInfo
{
    public DateTime DateTimeFrom { get; set; }

    public DateTime DateTimeTo { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public decimal StayPriceLocalCurrencyAmount { get; set; }

    public string? RoomTypeCode { get; set; }

    public string? RateName { get; set; }

    public string? RoomCode { get; set; }

    public ISet<PackageInfo> Packages { get; set; }
}

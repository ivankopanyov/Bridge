namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTurnawayStats
{
    public DateTime? ArrivalDate { get; set; }
    public string? MarketCode { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Rooms { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomType { get; set; }
    public string? Description { get; set; }
    public string? RateCode { get; set; }
    public string? TurnawayCode { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? Adults { get; set; }
    public string? DayTypeCode { get; set; }
    public string? PropertyCode { get; set; }
    public decimal? PropertyCurrencyDecimals { get; set; }
    public string? PropertyCurrencyCode { get; set; }
    public decimal? TrxCounter { get; set; }
    public decimal? ReservationCounter { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public DateTime? TruncCreatedDate { get; set; }
    public string? Resort { get; set; }
    public string? RateCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTurnawayStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TURNAWAY_STATS");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayTypeCode)
                .HasColumnName("DAY_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyCode)
                .HasColumnName("PROPERTY_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyDecimals)
                .HasColumnName("PROPERTY_CURRENCY_DECIMALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationCounter)
                .HasColumnName("RESERVATION_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncCreatedDate)
                .HasColumnName("TRUNC_CREATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxCounter)
                .HasColumnName("TRX_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TurnawayCode)
                .IsRequired()
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

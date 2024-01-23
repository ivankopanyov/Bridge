namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxDailyRates
{
    public DateTime DailyRateDate { get; set; }
    public string RateCode { get; set; }
    public decimal? NumberDays { get; set; }
    public decimal? LocalRateAmount { get; set; }
    public decimal? CentralRateAmount { get; set; }
    public string CurrencyCode { get; set; }
    public string MarketCode { get; set; }
    public decimal MembershipTrxLinkId { get; set; }
    public string RoomNumber { get; set; }
    public decimal? ShareNights { get; set; }
    public string Resort { get; set; }
    public string ResourceId { get; set; }
    public string RoomLabel { get; set; }
    public string PseudoYn { get; set; }
    public string BookedRoomLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxDailyRates>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxLinkId, e.RateCode, e.DailyRateDate })
                .HasName("MEMBERSHIP_TRX_DAILY_RATES_PK");

            entity.ToTable("MEMBERSHIP_TRX_DAILY_RATES");

            entity.HasIndex(e => e.MembershipTrxLinkId)
                .HasName("MEMBERSHIP_RATE_LINK_IND");

            entity.HasIndex(e => e.RateCode)
                .HasName("MEMBERSHIP_TRX_DAILY_RATE_IND3");

            entity.HasIndex(e => new { e.ResourceId, e.DailyRateDate, e.RoomNumber, e.Resort })
                .HasName("MEMBERSHIP_TRX_DAILY_RATE_IND4");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DailyRateDate)
                .HasColumnName("DAILY_RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedRoomLabel)
                .HasColumnName("BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CentralRateAmount)
                .HasColumnName("CENTRAL_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocalRateAmount)
                .HasColumnName("LOCAL_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberDays)
                .HasColumnName("NUMBER_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareNights)
                .HasColumnName("SHARE_NIGHTS")
                .HasColumnType("NUMBER");
        });
	}
}

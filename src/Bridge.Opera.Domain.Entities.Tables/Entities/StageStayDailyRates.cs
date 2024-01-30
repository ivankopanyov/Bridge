namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayDailyRates
{
    public decimal? StageStayRecordId { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? RateCode { get; set; }
    public decimal? RateAmount { get; set; }
    public string? MarketCode { get; set; }
    public string? ValidYn { get; set; }
    public decimal? NumberDays { get; set; }
    public string? CurrencyCode { get; set; }
    public string? RoomNumber { get; set; }
    public string? ResourceId { get; set; }
    public string? RoomLabel { get; set; }
    public string? PseudoYn { get; set; }
    public string? BookedRoomLabel { get; set; }

    public virtual StageStayRecords StageStayRecord { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayDailyRates>(entity =>
        {
            entity.HasKey(e => new { e.StageStayRecordId, e.TrxDate, e.RateCode })
                .HasName("STAGE_STAY_DAILY_RATES_PK");

            entity.ToTable("STAGE_STAY_DAILY_RATES");

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomLabel)
                .HasColumnName("BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageStayRecords)))
				entity.Ignore(e => e.StageStayRecord);
			else
	            entity.HasOne(d => d.StageStayRecord)
	                .WithMany(p => p.StageStayDailyRates)
	                .HasForeignKey(d => d.StageStayRecordId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_STAY_DAILY_RATES_FK");
        });
	}
}

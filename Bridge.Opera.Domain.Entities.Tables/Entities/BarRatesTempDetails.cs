namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BarRatesTempDetails
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public DateTime RateDate { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? RateableValue { get; set; }
    public decimal? BaseAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BarRatesTempDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomCategory, e.RateCode, e.RateDate })
                .HasName("BAR_RATES_TEMP_DTL_PK");

            entity.ToTable("BAR_RATES_TEMP_DETAILS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDate)
                .HasColumnName("RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BaseAmount)
                .HasColumnName("BASE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");
        });
	}
}

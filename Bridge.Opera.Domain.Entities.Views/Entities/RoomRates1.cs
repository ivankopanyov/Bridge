namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomRates1
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal RatecodeId { get; set; }
    public string RateCode { get; set; }
    public decimal? Rate { get; set; }
    public string DefaultYn { get; set; }
    public string RevenueType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string HourlyYn { get; set; }
    public string RateType { get; set; }
    public string MinimumRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomRates1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_RATES");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MinimumRevenueYn)
                .HasColumnName("MINIMUM_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Rate)
                .HasColumnName("RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RatecodeId)
                .HasColumnName("RATECODE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}

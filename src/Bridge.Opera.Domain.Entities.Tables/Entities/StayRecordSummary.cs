namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StayRecordSummary
{
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public decimal Month { get; set; }
    public decimal Year { get; set; }
    public decimal? NumberStays { get; set; }
    public decimal? NumberNights { get; set; }
    public decimal? NumberCancels { get; set; }
    public decimal? NumberNoShows { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? MiscRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FbRevenueTax { get; set; }
    public decimal? MiscRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public string GroupRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StayRecordSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAY_RECORD_SUMMARY");

            entity.HasIndex(e => new { e.Year, e.Resort })
                .HasName("STAY_RECORD_SUMMARY_IND2");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.Month, e.Year })
                .HasName("STAY_RECORD_SUMMARY_UK")
                .IsUnique();

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueTax)
                .HasColumnName("FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRevenueYn)
                .HasColumnName("GROUP_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MiscRevenue)
                .HasColumnName("MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscRevenueTax)
                .HasColumnName("MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Month)
                .HasColumnName("MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberCancels)
                .HasColumnName("NUMBER_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNights)
                .HasColumnName("NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNoShows)
                .HasColumnName("NUMBER_NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberStays)
                .HasColumnName("NUMBER_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER");
        });
	}
}

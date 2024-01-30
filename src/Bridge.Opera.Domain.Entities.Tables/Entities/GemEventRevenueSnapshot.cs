namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemEventRevenueSnapshot
{
    public decimal? SnapshotId { get; set; }
    public decimal? EventId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public string? RevType { get; set; }
    public string? RevGroup { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? BilledRevenue { get; set; }
    public string? IgnoreForecastYn { get; set; }
    public string? FlatYn { get; set; }
    public string? CustomYn { get; set; }
    public decimal? ExpectedCost { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? BilledCost { get; set; }
    public DateTime? SnapshotDate { get; set; }
    public string? SnapshotName { get; set; }
    public decimal? ExpectedAttendees { get; set; }
    public decimal? GuaranteedAttendees { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string? EventStatus { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CatQuoteCurr { get; set; }
    public string? PkgRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEventRevenueSnapshot>(entity =>
        {
            entity.HasKey(e => e.SnapshotId)
                .HasName("GEREVSS_PK");

            entity.ToTable("GEM$EVENT_REVENUE_SNAPSHOT");

            entity.HasIndex(e => new { e.BookId, e.Resort, e.EventId })
                .HasName("GEREVSS_GE_FKI");

            entity.HasIndex(e => new { e.BookId, e.Resort, e.EventId, e.SnapshotDate, e.SnapshotName, e.RevType, e.PkgRevenueYn })
                .HasName("GEREVSS_UK")
                .IsUnique();

            entity.Property(e => e.SnapshotId)
                .HasColumnName("SNAPSHOT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledCost)
                .HasColumnName("BILLED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenue)
                .HasColumnName("BILLED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatQuoteCurr)
                .HasColumnName("CAT_QUOTE_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomYn)
                .IsRequired()
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpectedAttendees)
                .HasColumnName("EXPECTED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatYn)
                .HasColumnName("FLAT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedAttendees)
                .HasColumnName("GUARANTEED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IgnoreForecastYn)
                .HasColumnName("IGNORE_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRevenueYn)
                .HasColumnName("PKG_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SnapshotName)
                .HasColumnName("SNAPSHOT_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

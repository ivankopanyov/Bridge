namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BarRatesTemp
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? FirstAmount { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? Status { get; set; }
    public decimal? FcFirstAmount { get; set; }
    public string? GroupCode { get; set; }
    public decimal? AdultCharge { get; set; }
    public decimal? ChildrenCharge { get; set; }
    public string? PackageYn { get; set; }
    public string? SameRateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BarRatesTemp>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomCategory, e.RateCode })
                .HasName("BAR_RATES_TEMP_PK");

            entity.ToTable("BAR_RATES_TEMP");

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

            entity.Property(e => e.AdultCharge)
                .HasColumnName("ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcFirstAmount)
                .HasColumnName("FC_FIRST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstAmount)
                .HasColumnName("FIRST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PackageYn)
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SameRateYn)
                .HasColumnName("SAME_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}

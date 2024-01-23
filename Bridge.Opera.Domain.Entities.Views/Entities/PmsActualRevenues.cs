namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsActualRevenues
{
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFoodRevenue { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFoodTax { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? PackageNonRevenue { get; set; }
    public decimal? TotalNonRevenueTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsActualRevenues>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_ACTUAL_REVENUES");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFoodRevenue)
                .HasColumnName("PACKAGE_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageNonRevenue)
                .HasColumnName("PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenue)
                .HasColumnName("PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenue)
                .HasColumnName("PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFoodTax)
                .HasColumnName("TOTAL_FOOD_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonRevenueTax)
                .HasColumnName("TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTax)
                .HasColumnName("TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTax)
                .HasColumnName("TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");
        });
	}
}

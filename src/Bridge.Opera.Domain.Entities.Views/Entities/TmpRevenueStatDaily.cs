namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TmpRevenueStatDaily
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FromResvId { get; set; }
    public decimal? NameId { get; set; }
    public string? RoomClass { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? RateCode { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFoodRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? PackageNonRevenue { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFoodTax { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalNonRevenueTax { get; set; }
    public decimal? CompRoomRevenue { get; set; }
    public decimal? CashRoomRevenue { get; set; }
    public decimal? CompRoomNts { get; set; }
    public decimal? CashRoomNts { get; set; }
    public decimal? AdvRoomRevenue { get; set; }
    public decimal? AdvFoodRevenue { get; set; }
    public decimal? AdvOtherRevenue { get; set; }
    public decimal? AdvTotalRevenue { get; set; }
    public decimal? AdvNonRevenue { get; set; }
    public decimal? AdvTotalRoomTax { get; set; }
    public decimal? AdvTotalFoodTax { get; set; }
    public decimal? AdvTotalOtherTax { get; set; }
    public decimal? AdvTotalTax { get; set; }
    public decimal? AdvTotalNonRevenueTax { get; set; }
    public decimal? FlgdRoomRevenue { get; set; }
    public decimal? FlgdFoodRevenue { get; set; }
    public decimal? FlgdOtherRevenue { get; set; }
    public decimal? FlgdTotalRevenue { get; set; }
    public decimal? FlgdNonRevenue { get; set; }
    public decimal? FlgdTotalRoomTax { get; set; }
    public decimal? FlgdTotalFoodTax { get; set; }
    public decimal? FlgdTotalOtherTax { get; set; }
    public decimal? FlgdTotalTax { get; set; }
    public decimal? FlgdTotalNonRevenueTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TmpRevenueStatDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TMP_REVENUE_STAT_DAILY");

            entity.Property(e => e.AdvFoodRevenue)
                .HasColumnName("ADV_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvNonRevenue)
                .HasColumnName("ADV_NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvOtherRevenue)
                .HasColumnName("ADV_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvRoomRevenue)
                .HasColumnName("ADV_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalFoodTax)
                .HasColumnName("ADV_TOTAL_FOOD_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalNonRevenueTax)
                .HasColumnName("ADV_TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalOtherTax)
                .HasColumnName("ADV_TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalRevenue)
                .HasColumnName("ADV_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalRoomTax)
                .HasColumnName("ADV_TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvTotalTax)
                .HasColumnName("ADV_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomNts)
                .HasColumnName("CASH_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomRevenue)
                .HasColumnName("CASH_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomRevenue)
                .HasColumnName("COMP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdFoodRevenue)
                .HasColumnName("FLGD_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdNonRevenue)
                .HasColumnName("FLGD_NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdOtherRevenue)
                .HasColumnName("FLGD_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdRoomRevenue)
                .HasColumnName("FLGD_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalFoodTax)
                .HasColumnName("FLGD_TOTAL_FOOD_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalNonRevenueTax)
                .HasColumnName("FLGD_TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalOtherTax)
                .HasColumnName("FLGD_TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalRevenue)
                .HasColumnName("FLGD_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalRoomTax)
                .HasColumnName("FLGD_TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlgdTotalTax)
                .HasColumnName("FLGD_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
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

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

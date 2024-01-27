namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResCountryStat
{
    public string Resort { get; set; }
    public string Country { get; set; }
    public DateTime BusinessDate { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? PackageTotalRevenue { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFoodRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? RoomTax { get; set; }
    public decimal? FoodTax { get; set; }
    public decimal? OtherTax { get; set; }
    public decimal? StayRoomsMtd { get; set; }
    public decimal? StayPersonsMtd { get; set; }
    public decimal? TotalRevenueMtd { get; set; }
    public decimal? RoomRevenueMtd { get; set; }
    public decimal? FoodRevenueMtd { get; set; }
    public decimal? OtherRevenueMtd { get; set; }
    public decimal? PackageTotalRevenueMtd { get; set; }
    public decimal? PackageRoomRevenueMtd { get; set; }
    public decimal? PackageFoodRevenueMtd { get; set; }
    public decimal? PackageOtherRevenueMtd { get; set; }
    public decimal? TotalTaxMtd { get; set; }
    public decimal? RoomTaxMtd { get; set; }
    public decimal? FoodTaxMtd { get; set; }
    public decimal? OtherTaxMtd { get; set; }
    public decimal? StayRoomsYtd { get; set; }
    public decimal? StayPersonsYtd { get; set; }
    public decimal? TotalRevenueYtd { get; set; }
    public decimal? RoomRevenueYtd { get; set; }
    public decimal? FoodRevenueYtd { get; set; }
    public decimal? OtherRevenueYtd { get; set; }
    public decimal? PackageTotalRevenueYtd { get; set; }
    public decimal? PackageRoomRevenueYtd { get; set; }
    public decimal? PackageFoodRevenueYtd { get; set; }
    public decimal? PackageOtherRevenueYtd { get; set; }
    public decimal? TotalTaxYtd { get; set; }
    public decimal? RoomTaxYtd { get; set; }
    public decimal? FoodTaxYtd { get; set; }
    public decimal? OtherTaxYtd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResCountryStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RES_COUNTRY_STAT");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueMtd)
                .HasColumnName("FOOD_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueYtd)
                .HasColumnName("FOOD_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodTax)
                .HasColumnName("FOOD_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodTaxMtd)
                .HasColumnName("FOOD_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodTaxYtd)
                .HasColumnName("FOOD_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueMtd)
                .HasColumnName("OTHER_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueYtd)
                .HasColumnName("OTHER_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTax)
                .HasColumnName("OTHER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxMtd)
                .HasColumnName("OTHER_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxYtd)
                .HasColumnName("OTHER_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFoodRevenue)
                .HasColumnName("PACKAGE_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFoodRevenueMtd)
                .HasColumnName("PACKAGE_FOOD_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFoodRevenueYtd)
                .HasColumnName("PACKAGE_FOOD_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenue)
                .HasColumnName("PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenueMtd)
                .HasColumnName("PACKAGE_OTHER_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenueYtd)
                .HasColumnName("PACKAGE_OTHER_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenue)
                .HasColumnName("PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenueMtd)
                .HasColumnName("PACKAGE_ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenueYtd)
                .HasColumnName("PACKAGE_ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageTotalRevenue)
                .HasColumnName("PACKAGE_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageTotalRevenueMtd)
                .HasColumnName("PACKAGE_TOTAL_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageTotalRevenueYtd)
                .HasColumnName("PACKAGE_TOTAL_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueMtd)
                .HasColumnName("ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueYtd)
                .HasColumnName("ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTax)
                .HasColumnName("ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTaxMtd)
                .HasColumnName("ROOM_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTaxYtd)
                .HasColumnName("ROOM_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersonsMtd)
                .HasColumnName("STAY_PERSONS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersonsYtd)
                .HasColumnName("STAY_PERSONS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsMtd)
                .HasColumnName("STAY_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsYtd)
                .HasColumnName("STAY_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueMtd)
                .HasColumnName("TOTAL_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueYtd)
                .HasColumnName("TOTAL_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxMtd)
                .HasColumnName("TOTAL_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxYtd)
                .HasColumnName("TOTAL_TAX_YTD")
                .HasColumnType("NUMBER");
        });
	}
}

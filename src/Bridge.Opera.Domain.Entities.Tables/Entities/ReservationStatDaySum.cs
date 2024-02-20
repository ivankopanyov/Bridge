namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationStatDaySum
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketMainGroup { get; set; }
    public string? SourceCode { get; set; }
    public string? SourceMainGroup { get; set; }
    public string? Channel { get; set; }
    public string? RateCode { get; set; }
    public string? RateCategory { get; set; }
    public string? Country { get; set; }
    public string? RegionCode { get; set; }
    public string? PsuedoRoomYn { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? StayAdults { get; set; }
    public decimal? StayChildren { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? DepRooms { get; set; }
    public decimal? DepPersons { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? CancelledRooms { get; set; }
    public decimal? CancelledPersons { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomTax { get; set; }
    public decimal? FoodTax { get; set; }
    public decimal? OtherTax { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFoodRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? PackageTotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? PackageNonRevenue { get; set; }
    public decimal? NonRevenueTax { get; set; }
    public decimal? CashRoomNts { get; set; }
    public decimal? CompRoomNts { get; set; }
    public decimal? CashRoomRevenue { get; set; }
    public decimal? CompRoomRevenue { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? AdvFoodRevenue { get; set; }
    public decimal? AdvNonRevenue { get; set; }
    public decimal? AdvOtherRevenue { get; set; }
    public decimal? AdvRoomRevenue { get; set; }
    public decimal? AdvTotalFoodTax { get; set; }
    public decimal? AdvTotalNonRevenueTax { get; set; }
    public decimal? AdvTotalOtherTax { get; set; }
    public decimal? AdvTotalRevenue { get; set; }
    public decimal? AdvTotalRoomTax { get; set; }
    public decimal? AdvTotalTax { get; set; }
    public decimal? FlgdRoomRevenue { get; set; }
    public decimal? FlgdFoodRevenue { get; set; }
    public decimal? FlgdNonRevenue { get; set; }
    public decimal? FlgdOtherRevenue { get; set; }
    public decimal? FlgdTotalRoomTax { get; set; }
    public decimal? FlgdTotalFoodTax { get; set; }
    public decimal? FlgdTotalNonRevenueTax { get; set; }
    public decimal? FlgdTotalOtherTax { get; set; }
    public decimal? FlgdTotalRevenue { get; set; }
    public decimal? FlgdTotalTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationStatDaySum>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_STAT_DAY_SUM");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.RoomCategory })
                .HasName("RESERVATION_STAT_DAY_SUM_IND1");

            entity.HasIndex(e => new { e.Resort, e.MarketCode, e.RoomCategory, e.BusinessDate })
                .HasName("RESERVATION_STAT_DAY_SUM_IND2");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.RoomCategory, e.BusinessDate })
                .HasName("RESERVATION_STAT_DAY_SUM_IND4");

            entity.HasIndex(e => new { e.Resort, e.SourceCode, e.RoomCategory, e.BusinessDate })
                .HasName("RESERVATION_STAT_DAY_SUM_IND3");

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledPersons)
                .HasColumnName("CANCELLED_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRooms)
                .HasColumnName("CANCELLED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomNts)
                .HasColumnName("CASH_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomRevenue)
                .HasColumnName("CASH_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenTaxFree)
                .HasColumnName("CHILDREN_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomRevenue)
                .HasColumnName("COMP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepPersons)
                .HasColumnName("DEP_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepRooms)
                .HasColumnName("DEP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
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

            entity.Property(e => e.FoodTax)
                .HasColumnName("FOOD_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainGroup)
                .IsRequired()
                .HasColumnName("MARKET_MAIN_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueTax)
                .HasColumnName("NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTax)
                .HasColumnName("OTHER_TAX")
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

            entity.Property(e => e.PackageTotalRevenue)
                .HasColumnName("PACKAGE_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PsuedoRoomYn)
                .IsRequired()
                .HasColumnName("PSUEDO_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTax)
                .HasColumnName("ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .IsRequired()
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceMainGroup)
                .IsRequired()
                .HasColumnName("SOURCE_MAIN_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayAdults)
                .HasColumnName("STAY_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayChildren)
                .HasColumnName("STAY_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");
        });
	}
}

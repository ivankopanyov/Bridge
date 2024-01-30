namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ForecastSummary
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public string? EventType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketMainGroup { get; set; }
    public string? SourceCode { get; set; }
    public string? RateCode { get; set; }
    public string? RateCategory { get; set; }
    public string? RegionCode { get; set; }
    public decimal? GroupId { get; set; }
    public string? ResvType { get; set; }
    public string? ResvInvType { get; set; }
    public string? PsuedoRoomYn { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? NoGuests { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? GrossRate { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public string? BlockStatus { get; set; }
    public string? BookingStatus { get; set; }
    public decimal? ExtraRevenue { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? DepRooms { get; set; }
    public decimal? DepPersons { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? RemainingBlockRooms { get; set; }
    public decimal? PickedupBlockRooms { get; set; }
    public decimal? WlRooms { get; set; }
    public decimal? WlPersons { get; set; }
    public decimal? WlGrossRate { get; set; }
    public decimal? WlNetRoomRevenue { get; set; }
    public decimal? WlExtraRevenue { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? DayUseGrossRate { get; set; }
    public decimal? DayUseNetRoomRevenue { get; set; }
    public decimal? DayUseExtraRevenue { get; set; }
    public string? SourceMainGroup { get; set; }
    public string? Channel { get; set; }
    public string? Country { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FoodRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? NonRevenueTax { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForecastSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FORECAST_SUMMARY");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockStatus)
                .HasColumnName("BLOCK_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseExtraRevenue)
                .HasColumnName("DAY_USE_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseGrossRate)
                .HasColumnName("DAY_USE_GROSS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseNetRoomRevenue)
                .HasColumnName("DAY_USE_NET_ROOM_REVENUE")
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

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraRevenue)
                .HasColumnName("EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueTax)
                .HasColumnName("FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossRate)
                .HasColumnName("GROSS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainGroup)
                .HasColumnName("MARKET_MAIN_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoGuests)
                .HasColumnName("NO_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueTax)
                .HasColumnName("NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickedupBlockRooms)
                .HasColumnName("PICKEDUP_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PsuedoRoomYn)
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

            entity.Property(e => e.RemainingBlockRooms)
                .HasColumnName("REMAINING_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvInvType)
                .HasColumnName("RESV_INV_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvType)
                .HasColumnName("RESV_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceMainGroup)
                .HasColumnName("SOURCE_MAIN_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlExtraRevenue)
                .HasColumnName("WL_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlGrossRate)
                .HasColumnName("WL_GROSS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlNetRoomRevenue)
                .HasColumnName("WL_NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlPersons)
                .HasColumnName("WL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlRooms)
                .HasColumnName("WL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}

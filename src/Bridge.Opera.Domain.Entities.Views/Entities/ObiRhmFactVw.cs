namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRhmFactVw
{
    public string? Resort { get; set; }
    public string? MonthId { get; set; }
    public string? MarketCode { get; set; }
    public string? RoomType { get; set; }
    public string? Country { get; set; }
    public string? RateCode { get; set; }
    public string? SourceCode { get; set; }
    public string? Rtc { get; set; }
    public string? Channel { get; set; }
    public string? ResInsertSource { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? StayAdults { get; set; }
    public decimal? StayChildren { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? NoStays { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? Nights { get; set; }
    public decimal? CancelResv { get; set; }
    public decimal? CancelRooms { get; set; }
    public decimal? CancelPersons { get; set; }
    public decimal? NoShowResv { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? LeadDays { get; set; }
    public decimal? UpsoldAmount { get; set; }
    public decimal? CRateAmount { get; set; }
    public decimal? CRoomRevenue { get; set; }
    public decimal? CFoodRevenue { get; set; }
    public decimal? CTotalRevenue { get; set; }
    public decimal? COtherRevenue { get; set; }
    public decimal? CNonRevenue { get; set; }
    public decimal? CUpsoldAmount { get; set; }
    public decimal? BudgetAmount { get; set; }
    public decimal? CBudgetAmount { get; set; }
    public decimal? BudgetRooms { get; set; }
    public decimal? UpsoldRoom { get; set; }
    public decimal? UpgradeRoom { get; set; }
    public decimal? RegularRoom { get; set; }
    public decimal? CompanyRoom { get; set; }
    public decimal? TravelRoom { get; set; }
    public decimal? GroupRoom { get; set; }
    public decimal? SourceRoom { get; set; }
    public decimal? GuestRevenue { get; set; }
    public decimal? CompanyRevenue { get; set; }
    public decimal? TravelRevenue { get; set; }
    public decimal? GroupRevenue { get; set; }
    public decimal? SourceRevenue { get; set; }
    public decimal? GuestRoomRevenue { get; set; }
    public decimal? CompanyRoomRevenue { get; set; }
    public decimal? TravelRoomRevenue { get; set; }
    public decimal? GroupRoomRevenue { get; set; }
    public decimal? SourceRoomRevenue { get; set; }
    public decimal? GuestFbRevenue { get; set; }
    public decimal? CompanyFbRevenue { get; set; }
    public decimal? TravelFbRevenue { get; set; }
    public decimal? GroupFbRevenue { get; set; }
    public decimal? SourceFbRevenue { get; set; }
    public decimal? CGuestRevenue { get; set; }
    public decimal? CCompanyRevenue { get; set; }
    public decimal? CTravelRevenue { get; set; }
    public decimal? CGroupRevenue { get; set; }
    public decimal? CSourceRevenue { get; set; }
    public decimal? CGuestRoomRevenue { get; set; }
    public decimal? CCompanyRoomRevenue { get; set; }
    public decimal? CTravelRoomRevenue { get; set; }
    public decimal? CGroupRoomRevenue { get; set; }
    public decimal? CSourceRoomRevenue { get; set; }
    public decimal? CGuestFbRevenue { get; set; }
    public decimal? CCompanyFbRevenue { get; set; }
    public decimal? CTravelFbRevenue { get; set; }
    public decimal? CGroupFbRevenue { get; set; }
    public decimal? CSourceFbRevenue { get; set; }
    public decimal? Rcnt { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? ArrAdults { get; set; }
    public decimal? ArrChildren { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRhmFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RHM_FACT_VW");

            entity.Property(e => e.ArrAdults)
                .HasColumnName("ARR_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrChildren)
                .HasColumnName("ARR_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAmount)
                .HasColumnName("BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRooms)
                .HasColumnName("BUDGET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBudgetAmount)
                .HasColumnName("C_BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyFbRevenue)
                .HasColumnName("C_COMPANY_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyRevenue)
                .HasColumnName("C_COMPANY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyRoomRevenue)
                .HasColumnName("C_COMPANY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFoodRevenue)
                .HasColumnName("C_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupFbRevenue)
                .HasColumnName("C_GROUP_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupRevenue)
                .HasColumnName("C_GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupRoomRevenue)
                .HasColumnName("C_GROUP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGuestFbRevenue)
                .HasColumnName("C_GUEST_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGuestRevenue)
                .HasColumnName("C_GUEST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGuestRoomRevenue)
                .HasColumnName("C_GUEST_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNonRevenue)
                .HasColumnName("C_NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenue)
                .HasColumnName("C_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRateAmount)
                .HasColumnName("C_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomRevenue)
                .HasColumnName("C_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CSourceFbRevenue)
                .HasColumnName("C_SOURCE_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CSourceRevenue)
                .HasColumnName("C_SOURCE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CSourceRoomRevenue)
                .HasColumnName("C_SOURCE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenue)
                .HasColumnName("C_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTravelFbRevenue)
                .HasColumnName("C_TRAVEL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTravelRevenue)
                .HasColumnName("C_TRAVEL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTravelRoomRevenue)
                .HasColumnName("C_TRAVEL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CUpsoldAmount)
                .HasColumnName("C_UPSOLD_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPersons)
                .HasColumnName("CANCEL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelResv)
                .HasColumnName("CANCEL_RESV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRooms)
                .HasColumnName("CANCEL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .IsUnicode(false);

            entity.Property(e => e.CompanyFbRevenue)
                .HasColumnName("COMPANY_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRevenue)
                .HasColumnName("COMPANY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRoom)
                .HasColumnName("COMPANY_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRoomRevenue)
                .HasColumnName("COMPANY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupFbRevenue)
                .HasColumnName("GROUP_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRevenue)
                .HasColumnName("GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoom)
                .HasColumnName("GROUP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoomRevenue)
                .HasColumnName("GROUP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFbRevenue)
                .HasColumnName("GUEST_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestRevenue)
                .HasColumnName("GUEST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestRoomRevenue)
                .HasColumnName("GUEST_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MonthId)
                .HasColumnName("MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowResv)
                .HasColumnName("NO_SHOW_RESV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoStays)
                .HasColumnName("NO_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegularRoom)
                .HasColumnName("REGULAR_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Rtc)
                .HasColumnName("RTC")
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SourceFbRevenue)
                .HasColumnName("SOURCE_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRevenue)
                .HasColumnName("SOURCE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRoom)
                .HasColumnName("SOURCE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRoomRevenue)
                .HasColumnName("SOURCE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayAdults)
                .HasColumnName("STAY_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayChildren)
                .HasColumnName("STAY_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelFbRevenue)
                .HasColumnName("TRAVEL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelRevenue)
                .HasColumnName("TRAVEL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelRoom)
                .HasColumnName("TRAVEL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelRoomRevenue)
                .HasColumnName("TRAVEL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpgradeRoom)
                .HasColumnName("UPGRADE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsoldAmount)
                .HasColumnName("UPSOLD_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsoldRoom)
                .HasColumnName("UPSOLD_ROOM")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiResvHistoryFactVw
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string MarketCode { get; set; }
    public string RoomType { get; set; }
    public string Country { get; set; }
    public string RateCode { get; set; }
    public string SourceCode { get; set; }
    public string Rtc { get; set; }
    public string Channel { get; set; }
    public string ResInsertSource { get; set; }
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
    public decimal? LeadCount { get; set; }
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
    public decimal? ForecastAmount { get; set; }
    public decimal? CForecastAmount { get; set; }
    public decimal? ForecastRooms { get; set; }
    public decimal? UpsoldRoom { get; set; }
    public decimal? UpgradeRoom { get; set; }
    public decimal? RegularRoom { get; set; }
    public decimal? TotalRevenueNdd { get; set; }
    public decimal? CTotalRevenueNdd { get; set; }
    public decimal? LosA { get; set; }
    public decimal? LosB { get; set; }
    public decimal? LosC { get; set; }
    public decimal? Rcnt { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? ArrAdults { get; set; }
    public decimal? ArrChildren { get; set; }
    public decimal? ArrGuest { get; set; }
    public decimal? ArrResv { get; set; }
    public decimal? AvlRooms { get; set; }
    public decimal? Children { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiResvHistoryFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RESV_HISTORY_FACT_VW");

            entity.Property(e => e.ArrAdults)
                .HasColumnName("ARR_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrChildren)
                .HasColumnName("ARR_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrGuest)
                .HasColumnName("ARR_GUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrResv)
                .HasColumnName("ARR_RESV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvlRooms)
                .HasColumnName("AVL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAmount)
                .HasColumnName("BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRooms)
                .HasColumnName("BUDGET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CBudgetAmount)
                .HasColumnName("C_BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFoodRevenue)
                .HasColumnName("C_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastAmount)
                .HasColumnName("C_FORECAST_AMOUNT")
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

            entity.Property(e => e.CTotalRevenue)
                .HasColumnName("C_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueNdd)
                .HasColumnName("C_TOTAL_REVENUE_NDD")
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

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastAmount)
                .HasColumnName("FORECAST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRooms)
                .HasColumnName("FORECAST_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadCount)
                .HasColumnName("LEAD_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosA)
                .HasColumnName("LOS_A")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosB)
                .HasColumnName("LOS_B")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosC)
                .HasColumnName("LOS_C")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
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

            entity.Property(e => e.TotalRevenueNdd)
                .HasColumnName("TOTAL_REVENUE_NDD")
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

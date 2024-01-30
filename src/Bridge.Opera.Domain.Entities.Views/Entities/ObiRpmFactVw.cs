namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRpmFactVw
{
    public DateTime? SnapshotDate { get; set; }
    public string? Resort { get; set; }
    public string? StayMonth { get; set; }
    public string? MarketCode { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? EventId { get; set; }
    public decimal? StayRoomsResIndDed { get; set; }
    public decimal? StayRoomsResIndNdd { get; set; }
    public decimal? StayRoomsResBlkDed { get; set; }
    public decimal? StayRoomsResBlkNdd { get; set; }
    public decimal? StayRoomsBlkDed { get; set; }
    public decimal? StayRoomsBlkNdd { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? RoomRevenueResIndDed { get; set; }
    public decimal? RoomRevenueResIndNdd { get; set; }
    public decimal? RoomRevenueResBlkDed { get; set; }
    public decimal? RoomRevenueResBlkNdd { get; set; }
    public decimal? RoomRevenueBlkDed { get; set; }
    public decimal? RoomRevenueBlkNdd { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public decimal? BudgetAmt { get; set; }
    public decimal? BudgetRooms { get; set; }
    public decimal? ForecastAmt { get; set; }
    public decimal? ForecastRooms { get; set; }
    public decimal? LyActualRevenue { get; set; }
    public decimal? LyActualRooms { get; set; }
    public decimal? RoomsToSell { get; set; }
    public decimal? LyStayRoomsResIndDed { get; set; }
    public decimal? LyStayRoomsResIndNdd { get; set; }
    public decimal? LyStayRoomsResBlkDed { get; set; }
    public decimal? LyStayRoomsResBlkNdd { get; set; }
    public decimal? LyStayRoomsBlkDed { get; set; }
    public decimal? LyStayRoomsBlkNdd { get; set; }
    public decimal? LyArrRooms { get; set; }
    public decimal? LyRoomRevenueResIndDed { get; set; }
    public decimal? LyRoomRevenueResIndNdd { get; set; }
    public decimal? LyRoomRevenueResBlkDed { get; set; }
    public decimal? LyRoomRevenueResBlkNdd { get; set; }
    public decimal? LyRoomRevenueBlkDed { get; set; }
    public decimal? LyRoomRevenueBlkNdd { get; set; }
    public decimal? LyOoRooms { get; set; }
    public decimal? SnapshotExchangeRate { get; set; }
    public decimal? LySnapshotExchangeRate { get; set; }
    public decimal? LyStayExchangeRate { get; set; }
    public decimal? ForecastExchangeRate { get; set; }
    public decimal? BudgetExchangeRate { get; set; }
    public decimal? Crvrid { get; set; }
    public decimal? Crvrin { get; set; }
    public decimal? Crvrbd { get; set; }
    public decimal? Crvrbn { get; set; }
    public decimal? Crvbd { get; set; }
    public decimal? Crvbn { get; set; }
    public decimal? Cygrvrid { get; set; }
    public decimal? Cygrvrin { get; set; }
    public decimal? Cygrvrbd { get; set; }
    public decimal? Cygrvrbn { get; set; }
    public decimal? Cygrvbd { get; set; }
    public decimal? Cygrvbn { get; set; }
    public decimal? Caygrvrid { get; set; }
    public decimal? Caygrvrin { get; set; }
    public decimal? Caygrvrbd { get; set; }
    public decimal? Caygrvrbn { get; set; }
    public decimal? Caygrvbd { get; set; }
    public decimal? Caygrvbn { get; set; }
    public decimal? Cbdrv { get; set; }
    public decimal? Cabdrv { get; set; }
    public decimal? Cfrrv { get; set; }
    public decimal? Cafrrv { get; set; }
    public decimal? Clyacrv { get; set; }
    public decimal? Calyacrv { get; set; }
    public decimal? CompRoomNts { get; set; }
    public decimal? LyCompRoomNts { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRpmFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RPM_FACT_VW");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAmt)
                .HasColumnName("BUDGET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetExchangeRate)
                .HasColumnName("BUDGET_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRooms)
                .HasColumnName("BUDGET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cabdrv)
                .HasColumnName("CABDRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cafrrv)
                .HasColumnName("CAFRRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Calyacrv)
                .HasColumnName("CALYACRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvbd)
                .HasColumnName("CAYGRVBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvbn)
                .HasColumnName("CAYGRVBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvrbd)
                .HasColumnName("CAYGRVRBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvrbn)
                .HasColumnName("CAYGRVRBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvrid)
                .HasColumnName("CAYGRVRID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Caygrvrin)
                .HasColumnName("CAYGRVRIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cbdrv)
                .HasColumnName("CBDRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cfrrv)
                .HasColumnName("CFRRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clyacrv)
                .HasColumnName("CLYACRV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvbd)
                .HasColumnName("CRVBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvbn)
                .HasColumnName("CRVBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvrbd)
                .HasColumnName("CRVRBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvrbn)
                .HasColumnName("CRVRBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvrid)
                .HasColumnName("CRVRID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvrin)
                .HasColumnName("CRVRIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvbd)
                .HasColumnName("CYGRVBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvbn)
                .HasColumnName("CYGRVBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvrbd)
                .HasColumnName("CYGRVRBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvrbn)
                .HasColumnName("CYGRVRBN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvrid)
                .HasColumnName("CYGRVRID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cygrvrin)
                .HasColumnName("CYGRVRIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .IsUnicode(false);

            entity.Property(e => e.ForecastAmt)
                .HasColumnName("FORECAST_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastExchangeRate)
                .HasColumnName("FORECAST_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRooms)
                .HasColumnName("FORECAST_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyActualRevenue)
                .HasColumnName("LY_ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyActualRooms)
                .HasColumnName("LY_ACTUAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyArrRooms)
                .HasColumnName("LY_ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyCompRoomNts)
                .HasColumnName("LY_COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyOoRooms)
                .HasColumnName("LY_OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueBlkDed)
                .HasColumnName("LY_ROOM_REVENUE_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueBlkNdd)
                .HasColumnName("LY_ROOM_REVENUE_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueResBlkDed)
                .HasColumnName("LY_ROOM_REVENUE_RES_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueResBlkNdd)
                .HasColumnName("LY_ROOM_REVENUE_RES_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueResIndDed)
                .HasColumnName("LY_ROOM_REVENUE_RES_IND_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyRoomRevenueResIndNdd)
                .HasColumnName("LY_ROOM_REVENUE_RES_IND_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LySnapshotExchangeRate)
                .HasColumnName("LY_SNAPSHOT_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayExchangeRate)
                .HasColumnName("LY_STAY_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsBlkDed)
                .HasColumnName("LY_STAY_ROOMS_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsBlkNdd)
                .HasColumnName("LY_STAY_ROOMS_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsResBlkDed)
                .HasColumnName("LY_STAY_ROOMS_RES_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsResBlkNdd)
                .HasColumnName("LY_STAY_ROOMS_RES_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsResIndDed)
                .HasColumnName("LY_STAY_ROOMS_RES_IND_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyStayRoomsResIndNdd)
                .HasColumnName("LY_STAY_ROOMS_RES_IND_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueBlkDed)
                .HasColumnName("ROOM_REVENUE_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueBlkNdd)
                .HasColumnName("ROOM_REVENUE_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueResBlkDed)
                .HasColumnName("ROOM_REVENUE_RES_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueResBlkNdd)
                .HasColumnName("ROOM_REVENUE_RES_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueResIndDed)
                .HasColumnName("ROOM_REVENUE_RES_IND_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueResIndNdd)
                .HasColumnName("ROOM_REVENUE_RES_IND_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsToSell)
                .HasColumnName("ROOMS_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SnapshotExchangeRate)
                .HasColumnName("SNAPSHOT_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayMonth)
                .HasColumnName("STAY_MONTH")
                .HasMaxLength(49)
                .IsUnicode(false);

            entity.Property(e => e.StayRoomsBlkDed)
                .HasColumnName("STAY_ROOMS_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsBlkNdd)
                .HasColumnName("STAY_ROOMS_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsResBlkDed)
                .HasColumnName("STAY_ROOMS_RES_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsResBlkNdd)
                .HasColumnName("STAY_ROOMS_RES_BLK_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsResIndDed)
                .HasColumnName("STAY_ROOMS_RES_IND_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRoomsResIndNdd)
                .HasColumnName("STAY_ROOMS_RES_IND_NDD")
                .HasColumnType("NUMBER");
        });
	}
}

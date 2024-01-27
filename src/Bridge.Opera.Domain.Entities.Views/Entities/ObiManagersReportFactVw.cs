namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiManagersReportFactVw
{
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string RoomClass { get; set; }
    public decimal? OccRoom { get; set; }
    public decimal? CompRoom { get; set; }
    public decimal? HouseUseRoom { get; set; }
    public decimal? DayuseRoom { get; set; }
    public decimal? AvailRoom { get; set; }
    public decimal? OooRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? GuestInHouse { get; set; }
    public decimal? ArrivalRoom { get; set; }
    public decimal? ArrivalPrs { get; set; }
    public decimal? DepartureRoom { get; set; }
    public decimal? DeparturePrs { get; set; }
    public decimal? WalkinRoom { get; set; }
    public decimal? NoshowRoom { get; set; }
    public decimal? CancelReservation { get; set; }
    public decimal? CancelRooms { get; set; }
    public decimal? Reservation { get; set; }
    public decimal? FoodBevRevenue { get; set; }
    public decimal? OccWeek { get; set; }
    public decimal? OccMonth { get; set; }
    public decimal? OccYear { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? Payment { get; set; }
    public decimal? GroupRevenue { get; set; }
    public decimal? GroupRoom { get; set; }
    public decimal? VipGuest { get; set; }
    public decimal? NoOfGroup { get; set; }
    public decimal? GroupPrs { get; set; }
    public decimal? GroupRoomRev { get; set; }
    public decimal? AdultsInHouse { get; set; }
    public decimal? ChildrenInHouse { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? PhysicalRoom { get; set; }
    public decimal? SingleOccRoom { get; set; }
    public decimal? MultiOccRoom { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? FitGuestsToday { get; set; }
    public decimal? AgentRoomsToday { get; set; }
    public decimal? CompanyRoomsToday { get; set; }
    public decimal? SourceRoomsToday { get; set; }
    public decimal? CancellationsMadeToday { get; set; }
    public decimal? RoomNightsReservedToday { get; set; }
    public decimal? FitRevenueToday { get; set; }
    public decimal? MemRevenueToday { get; set; }
    public decimal? MemInhousePrsToday { get; set; }
    public decimal? BedsAvlToday { get; set; }
    public decimal? AdultsFreeToday { get; set; }
    public decimal? ChildrenFreeToday { get; set; }
    public decimal? RackRateOcc { get; set; }
    public decimal? YieldAllRooms { get; set; }
    public decimal? YieldOccRooms { get; set; }
    public decimal? RackRateAll { get; set; }
    public decimal? FitRoomsToday { get; set; }
    public decimal? GroupRoomsToday { get; set; }
    public decimal? FitMemDepRooms { get; set; }
    public decimal? MemDepRoomsToday { get; set; }
    public decimal? FitRoomRevenue { get; set; }
    public decimal? InhouseMaxOccupancy { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? OccNext31Days { get; set; }
    public decimal? OccNext365Days { get; set; }
    public decimal? OccRestOfMonth { get; set; }
    public decimal? OccRestOfYear { get; set; }
    public decimal? CompanyRoomRevenue { get; set; }
    public decimal? CompanyRoomTax { get; set; }
    public decimal? CompanyTotalRevenue { get; set; }
    public decimal? CompanyTotalTax { get; set; }
    public decimal? AgentRoomRevenue { get; set; }
    public decimal? AgentRoomTax { get; set; }
    public decimal? AgentTotalRevenue { get; set; }
    public decimal? AgentTotalTax { get; set; }
    public decimal? RepeatRooms { get; set; }
    public decimal? RepeatPersons { get; set; }
    public decimal? RepeatRoomRevenue { get; set; }
    public decimal? RepeatRoomTax { get; set; }
    public decimal? RepeatTotalRevenue { get; set; }
    public decimal? RepeatTotalTax { get; set; }
    public decimal? NoshowReservations { get; set; }
    public decimal? DayUseReservations { get; set; }
    public decimal? ArrivalReservations { get; set; }
    public decimal? RoomsCancelledToday { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }
    public decimal? PhysicalBeds { get; set; }
    public decimal? OccBeds { get; set; }
    public decimal? CompBeds { get; set; }
    public decimal? HouseUseBeds { get; set; }
    public decimal? OooBeds { get; set; }
    public decimal? OsBeds { get; set; }
    public decimal? CompAdults { get; set; }
    public decimal? CompChildren { get; set; }
    public decimal? HouseUseAdults { get; set; }
    public decimal? HouseUseChildren { get; set; }
    public decimal? CFoodBevRevenue { get; set; }
    public decimal? CRoomRevenue { get; set; }
    public decimal? CPayment { get; set; }
    public decimal? CGroupRevenue { get; set; }
    public decimal? CGroupRoomRev { get; set; }
    public decimal? COtherRevenue { get; set; }
    public decimal? CTotalRevenue { get; set; }
    public decimal? CMemRevenueToday { get; set; }
    public decimal? CRackRateAll { get; set; }
    public decimal? CFitRevenueToday { get; set; }
    public decimal? CFitRoomRevenue { get; set; }
    public decimal? CCompanyRoomRevenue { get; set; }
    public decimal? CCompanyTotalRevenue { get; set; }
    public decimal? CAgentRoomRevenue { get; set; }
    public decimal? CAgentTotalRevenue { get; set; }
    public decimal? CRepeatRoomRevenue { get; set; }
    public decimal? CRepeatTotalRevenue { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiManagersReportFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_MANAGERS_REPORT_FACT_VW");

            entity.Property(e => e.AdultsFreeToday)
                .HasColumnName("ADULTS_FREE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsInHouse)
                .HasColumnName("ADULTS_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentRoomRevenue)
                .HasColumnName("AGENT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentRoomTax)
                .HasColumnName("AGENT_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentRoomsToday)
                .HasColumnName("AGENT_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentTotalRevenue)
                .HasColumnName("AGENT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentTotalTax)
                .HasColumnName("AGENT_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalPrs)
                .HasColumnName("ARRIVAL_PRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalReservations)
                .HasColumnName("ARRIVAL_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRoom)
                .HasColumnName("ARRIVAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailRoom)
                .HasColumnName("AVAIL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BedsAvlToday)
                .HasColumnName("BEDS_AVL_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CAgentRoomRevenue)
                .HasColumnName("C_AGENT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAgentTotalRevenue)
                .HasColumnName("C_AGENT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyRoomRevenue)
                .HasColumnName("C_COMPANY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyTotalRevenue)
                .HasColumnName("C_COMPANY_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFitRevenueToday)
                .HasColumnName("C_FIT_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFitRoomRevenue)
                .HasColumnName("C_FIT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFoodBevRevenue)
                .HasColumnName("C_FOOD_BEV_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupRevenue)
                .HasColumnName("C_GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupRoomRev)
                .HasColumnName("C_GROUP_ROOM_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CMemRevenueToday)
                .HasColumnName("C_MEM_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenue)
                .HasColumnName("C_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CPayment)
                .HasColumnName("C_PAYMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRackRateAll)
                .HasColumnName("C_RACK_RATE_ALL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRepeatRoomRevenue)
                .HasColumnName("C_REPEAT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRepeatTotalRevenue)
                .HasColumnName("C_REPEAT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomRevenue)
                .HasColumnName("C_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenue)
                .HasColumnName("C_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelReservation)
                .HasColumnName("CANCEL_RESERVATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRooms)
                .HasColumnName("CANCEL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancellationsMadeToday)
                .HasColumnName("CANCELLATIONS_MADE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
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

            entity.Property(e => e.ChildrenFreeToday)
                .HasColumnName("CHILDREN_FREE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenInHouse)
                .HasColumnName("CHILDREN_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompAdults)
                .HasColumnName("COMP_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompBeds)
                .HasColumnName("COMP_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompChildren)
                .HasColumnName("COMP_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoom)
                .HasColumnName("COMP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRoomRevenue)
                .HasColumnName("COMPANY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRoomTax)
                .HasColumnName("COMPANY_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRoomsToday)
                .HasColumnName("COMPANY_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyTotalRevenue)
                .HasColumnName("COMPANY_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyTotalTax)
                .HasColumnName("COMPANY_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseReservations)
                .HasColumnName("DAY_USE_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayuseRoom)
                .HasColumnName("DAYUSE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeparturePrs)
                .HasColumnName("DEPARTURE_PRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRoom)
                .HasColumnName("DEPARTURE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitGuestsToday)
                .HasColumnName("FIT_GUESTS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitMemDepRooms)
                .HasColumnName("FIT_MEM_DEP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitRevenueToday)
                .HasColumnName("FIT_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitRoomRevenue)
                .HasColumnName("FIT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitRoomsToday)
                .HasColumnName("FIT_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodBevRevenue)
                .HasColumnName("FOOD_BEV_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupPrs)
                .HasColumnName("GROUP_PRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRevenue)
                .HasColumnName("GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoom)
                .HasColumnName("GROUP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoomRev)
                .HasColumnName("GROUP_ROOM_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoomsToday)
                .HasColumnName("GROUP_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestInHouse)
                .HasColumnName("GUEST_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseAdults)
                .HasColumnName("HOUSE_USE_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseBeds)
                .HasColumnName("HOUSE_USE_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseChildren)
                .HasColumnName("HOUSE_USE_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRoom)
                .HasColumnName("HOUSE_USE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhouseMaxOccupancy)
                .HasColumnName("INHOUSE_MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemDepRoomsToday)
                .HasColumnName("MEM_DEP_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemInhousePrsToday)
                .HasColumnName("MEM_INHOUSE_PRS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemRevenueToday)
                .HasColumnName("MEM_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccRoom)
                .HasColumnName("MULTI_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGroup)
                .HasColumnName("NO_OF_GROUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowReservations)
                .HasColumnName("NOSHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoom)
                .HasColumnName("NOSHOW_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccBeds)
                .HasColumnName("OCC_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccMonth)
                .HasColumnName("OCC_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccNext31Days)
                .HasColumnName("OCC_NEXT_31_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccNext365Days)
                .HasColumnName("OCC_NEXT_365_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccRestOfMonth)
                .HasColumnName("OCC_REST_OF_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccRestOfYear)
                .HasColumnName("OCC_REST_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccRoom)
                .HasColumnName("OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccWeek)
                .HasColumnName("OCC_WEEK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccYear)
                .HasColumnName("OCC_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooBeds)
                .HasColumnName("OOO_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooRooms)
                .HasColumnName("OOO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsBeds)
                .HasColumnName("OS_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Payment)
                .HasColumnName("PAYMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalBeds)
                .HasColumnName("PHYSICAL_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRoom)
                .HasColumnName("PHYSICAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RackRateAll)
                .HasColumnName("RACK_RATE_ALL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RackRateOcc)
                .HasColumnName("RACK_RATE_OCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatPersons)
                .HasColumnName("REPEAT_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatRoomRevenue)
                .HasColumnName("REPEAT_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatRoomTax)
                .HasColumnName("REPEAT_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatRooms)
                .HasColumnName("REPEAT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatTotalRevenue)
                .HasColumnName("REPEAT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatTotalTax)
                .HasColumnName("REPEAT_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reservation)
                .HasColumnName("RESERVATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .IsUnicode(false);

            entity.Property(e => e.RoomNightsReservedToday)
                .HasColumnName("ROOM_NIGHTS_RESERVED_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsCancelledToday)
                .HasColumnName("ROOMS_CANCELLED_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccRoom)
                .HasColumnName("SINGLE_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRoomsToday)
                .HasColumnName("SOURCE_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipGuest)
                .HasColumnName("VIP_GUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkinRoom)
                .HasColumnName("WALKIN_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldAllRooms)
                .HasColumnName("YIELD_ALL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldOccRooms)
                .HasColumnName("YIELD_OCC_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}

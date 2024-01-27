namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmManagerBudgetVw
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? RoomsOccupied { get; set; }
    public decimal? RoomsOccupiedMtd { get; set; }
    public decimal? RoomsOccupiedYtd { get; set; }
    public decimal? Adults { get; set; }
    public decimal? AdultsMtd { get; set; }
    public decimal? AdultsYtd { get; set; }
    public decimal? Children { get; set; }
    public decimal? ChildrenMtd { get; set; }
    public decimal? ChildrenYtd { get; set; }
    public decimal? Reservations { get; set; }
    public decimal? ComplimentaryRooms { get; set; }
    public decimal? ComplimentaryRoomsMtd { get; set; }
    public decimal? ComplimentaryRoomsYtd { get; set; }
    public decimal? HouseUseRooms { get; set; }
    public decimal? HouseUseRoomsMtd { get; set; }
    public decimal? HouseUseRoomsYtd { get; set; }
    public decimal? OutOfOrderRooms { get; set; }
    public decimal? OutOfOrderRoomsMtd { get; set; }
    public decimal? OutOfOrderRoomsYtd { get; set; }
    public decimal? OutOfServiceRooms { get; set; }
    public decimal? OutOfServiceRoomsMtd { get; set; }
    public decimal? OutOfServiceRoomsYtd { get; set; }
    public decimal? RoomsTotal { get; set; }
    public decimal? RoomsTotalMtd { get; set; }
    public decimal? RoomsTotalYtd { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? AgentRevenue { get; set; }
    public decimal? CompanyRevenue { get; set; }
    public decimal? MemRevenueToday { get; set; }
    public decimal? RepeatTotalRevenue { get; set; }
    public decimal? FitRevenueToday { get; set; }
    public decimal? GroupRevenue { get; set; }
    public decimal? NoshowRoom { get; set; }
    public decimal? CancelRooms { get; set; }
    public decimal? WalkinRoom { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CTotalRevenue { get; set; }
    public decimal? CAgentRevenue { get; set; }
    public decimal? CCompanyRevenue { get; set; }
    public decimal? CMemRevenueToday { get; set; }
    public decimal? CRepeatTotalRevenue { get; set; }
    public decimal? CFitRevenueToday { get; set; }
    public decimal? CGroupRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmManagerBudgetVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_MANAGER_BUDGET_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsMtd)
                .HasColumnName("ADULTS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsYtd)
                .HasColumnName("ADULTS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentRevenue)
                .HasColumnName("AGENT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CAgentRevenue)
                .HasColumnName("C_AGENT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCompanyRevenue)
                .HasColumnName("C_COMPANY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFitRevenueToday)
                .HasColumnName("C_FIT_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGroupRevenue)
                .HasColumnName("C_GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CMemRevenueToday)
                .HasColumnName("C_MEM_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRepeatTotalRevenue)
                .HasColumnName("C_REPEAT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenue)
                .HasColumnName("C_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRooms)
                .HasColumnName("CANCEL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenMtd)
                .HasColumnName("CHILDREN_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenYtd)
                .HasColumnName("CHILDREN_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyRevenue)
                .HasColumnName("COMPANY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryRooms)
                .HasColumnName("COMPLIMENTARY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryRoomsMtd)
                .HasColumnName("COMPLIMENTARY_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryRoomsYtd)
                .HasColumnName("COMPLIMENTARY_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitRevenueToday)
                .HasColumnName("FIT_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRevenue)
                .HasColumnName("GROUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRooms)
                .HasColumnName("HOUSE_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRoomsMtd)
                .HasColumnName("HOUSE_USE_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRoomsYtd)
                .HasColumnName("HOUSE_USE_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemRevenueToday)
                .HasColumnName("MEM_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoom)
                .HasColumnName("NOSHOW_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrderRooms)
                .HasColumnName("OUT_OF_ORDER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrderRoomsMtd)
                .HasColumnName("OUT_OF_ORDER_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrderRoomsYtd)
                .HasColumnName("OUT_OF_ORDER_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfServiceRooms)
                .HasColumnName("OUT_OF_SERVICE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfServiceRoomsMtd)
                .HasColumnName("OUT_OF_SERVICE_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfServiceRoomsYtd)
                .HasColumnName("OUT_OF_SERVICE_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatTotalRevenue)
                .HasColumnName("REPEAT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reservations)
                .HasColumnName("RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOccupied)
                .HasColumnName("ROOMS_OCCUPIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccupiedMtd)
                .HasColumnName("ROOMS_OCCUPIED_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccupiedYtd)
                .HasColumnName("ROOMS_OCCUPIED_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsTotal)
                .HasColumnName("ROOMS_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsTotalMtd)
                .HasColumnName("ROOMS_TOTAL_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsTotalYtd)
                .HasColumnName("ROOMS_TOTAL_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkinRoom)
                .HasColumnName("WALKIN_ROOM")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpForecastByGc
{
    public string? GuaranteeCode { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? PickupRooms { get; set; }
    public decimal? AllottedRooms { get; set; }
    public decimal? GroupRoomRevenue { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? DepRooms { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? GrossRate { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? ExtraRevenue { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? DepPersons { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? BlkDedAvailRooms { get; set; }
    public decimal? BlkDedBlockedRooms { get; set; }
    public decimal? BlkNondedAvailRooms { get; set; }
    public decimal? ResDedRooms { get; set; }
    public decimal? ResDedAdults { get; set; }
    public decimal? ResDedChildren { get; set; }
    public decimal? ResNondedRooms { get; set; }
    public decimal? ResArrRooms { get; set; }
    public decimal? ResArrPersons { get; set; }
    public decimal? ResDepRooms { get; set; }
    public decimal? ResDepPersons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpForecastByGc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_FORECAST_BY_GC");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllottedRooms)
                .HasColumnName("ALLOTTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkDedAvailRooms)
                .HasColumnName("BLK_DED_AVAIL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkDedBlockedRooms)
                .HasColumnName("BLK_DED_BLOCKED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkNondedAvailRooms)
                .HasColumnName("BLK_NONDED_AVAIL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.ExtraRevenue)
                .HasColumnName("EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossRate)
                .HasColumnName("GROSS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoomRevenue)
                .HasColumnName("GROUP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRooms)
                .HasColumnName("PICKUP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResArrPersons)
                .HasColumnName("RES_ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResArrRooms)
                .HasColumnName("RES_ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDedAdults)
                .HasColumnName("RES_DED_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDedChildren)
                .HasColumnName("RES_DED_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDedRooms)
                .HasColumnName("RES_DED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDepPersons)
                .HasColumnName("RES_DEP_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDepRooms)
                .HasColumnName("RES_DEP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResNondedRooms)
                .HasColumnName("RES_NONDED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}

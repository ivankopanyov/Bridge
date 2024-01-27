namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGdpduStat
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? TtlRoomsInHotel { get; set; }
    public decimal? RoomOcc { get; set; }
    public decimal? RoomsOoo { get; set; }
    public decimal? RoomsOos { get; set; }
    public decimal? AvailableRooms { get; set; }
    public decimal? ComplimentaryRooms { get; set; }
    public decimal? HouseUseRooms { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? InHouseAdults { get; set; }
    public decimal? InHouseChildren { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? ArrivalAdults { get; set; }
    public decimal? ArrivalChildren { get; set; }
    public decimal? DepartureRooms { get; set; }
    public decimal? DepartureAdults { get; set; }
    public decimal? DepartureChildren { get; set; }
    public decimal? TotalGrossRevenue { get; set; }
    public decimal? TotalNetRevenue { get; set; }
    public decimal? TotalPayments { get; set; }
    public decimal? TotalPaidOuts { get; set; }
    public decimal? TotalRevenueGross { get; set; }
    public decimal? TotalNonRevenueGross { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGdpduStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GDPDU_STAT");

            entity.Property(e => e.ArrivalAdults)
                .HasColumnName("ARRIVAL_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalChildren)
                .HasColumnName("ARRIVAL_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailableRooms)
                .HasColumnName("AVAILABLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ComplimentaryRooms)
                .HasColumnName("COMPLIMENTARY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureAdults)
                .HasColumnName("DEPARTURE_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureChildren)
                .HasColumnName("DEPARTURE_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRooms)
                .HasColumnName("HOUSE_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InHouseAdults)
                .HasColumnName("IN_HOUSE_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InHouseChildren)
                .HasColumnName("IN_HOUSE_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RoomOcc)
                .HasColumnName("ROOM_OCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOoo)
                .HasColumnName("ROOMS_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOos)
                .HasColumnName("ROOMS_OOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrossRevenue)
                .HasColumnName("TOTAL_GROSS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetRevenue)
                .HasColumnName("TOTAL_NET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonRevenueGross)
                .HasColumnName("TOTAL_NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPaidOuts)
                .HasColumnName("TOTAL_PAID_OUTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPayments)
                .HasColumnName("TOTAL_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueGross)
                .HasColumnName("TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TtlRoomsInHotel)
                .HasColumnName("TTL_ROOMS_IN_HOTEL")
                .HasColumnType("NUMBER");
        });
	}
}

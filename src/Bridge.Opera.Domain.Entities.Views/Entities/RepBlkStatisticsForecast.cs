namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBlkStatisticsForecast
{
    public string? Resort { get; set; }
    public string? RecType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? MarketCode { get; set; }
    public string? Bookingtype { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? NoPersons { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? DepartureRooms { get; set; }
    public decimal? ComplimentaryRooms { get; set; }
    public decimal? HouseUseRooms { get; set; }
    public string? DeductYn { get; set; }
    public string? GroupYn { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? NonRevenueTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBlkStatisticsForecast>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BLK_STATISTICS_FORECAST");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryRooms)
                .HasColumnName("COMPLIMENTARY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeductYn)
                .HasColumnName("DEDUCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupYn)
                .HasColumnName("GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseRooms)
                .HasColumnName("HOUSE_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoPersons)
                .HasColumnName("NO_PERSONS")
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

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");
        });
	}
}

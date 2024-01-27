namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempOccupancyData
{
    public string Resort { get; set; }
    public DateTime OccupancyDate { get; set; }
    public string RateCategory { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? RoomsSold { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomArrivals { get; set; }
    public decimal? RoomDepartures { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? CancelledRooms { get; set; }
    public decimal? NoShowRooms { get; set; }
    public string ResType { get; set; }
    public string MarketCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempOccupancyData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_OCCUPANCY_DATA");

            entity.HasIndex(e => new { e.OccupancyDate, e.RateCategory })
                .HasName("TEMP_OCC_DATE_IDX");

            entity.HasIndex(e => new { e.OccupancyDate, e.ResType })
                .HasName("TEMP_OCC_DATE_RESTYPE_IDX");

            entity.Property(e => e.CancelledRooms)
                .HasColumnName("CANCELLED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupancyDate)
                .HasColumnName("OCCUPANCY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomArrivals)
                .HasColumnName("ROOM_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomDepartures)
                .HasColumnName("ROOM_DEPARTURES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsSold)
                .HasColumnName("ROOMS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}

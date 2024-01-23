namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationPace
{
    public string Resort { get; set; }
    public DateTime? SnapshotDate { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? StayRoomsResIndDed { get; set; }
    public decimal? StayRoomsResIndNdd { get; set; }
    public decimal? StayRoomsResBlkDed { get; set; }
    public decimal? StayRoomsResBlkNdd { get; set; }
    public decimal? StayRoomsBlkDed { get; set; }
    public decimal? StayRoomsBlkNdd { get; set; }
    public decimal? RoomRevenueResIndDed { get; set; }
    public decimal? RoomRevenueResIndNdd { get; set; }
    public decimal? RoomRevenueResBlkDed { get; set; }
    public decimal? RoomRevenueResBlkNdd { get; set; }
    public decimal? RoomRevenueBlkDed { get; set; }
    public decimal? RoomRevenueBlkNdd { get; set; }
    public decimal? OoRooms { get; set; }
    public string MarketCode { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationPace>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_PACE");

            entity.HasIndex(e => new { e.Resort, e.StayDate, e.SnapshotDate })
                .HasName("RESERVATION_PACE_IND1");

            entity.HasIndex(e => new { e.Resort, e.SnapshotDate, e.StayDate, e.MarketCode })
                .HasName("RESERVATION_PACE_UK")
                .IsUnique();

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueBlkDed)
                .HasColumnName("ROOM_REVENUE_BLK_DED")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueBlkNdd)
                .HasColumnName("ROOM_REVENUE_BLK_NDD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueResBlkDed)
                .HasColumnName("ROOM_REVENUE_RES_BLK_DED")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueResBlkNdd)
                .HasColumnName("ROOM_REVENUE_RES_BLK_NDD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueResIndDed)
                .HasColumnName("ROOM_REVENUE_RES_IND_DED")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueResIndNdd)
                .HasColumnName("ROOM_REVENUE_RES_IND_NDD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

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

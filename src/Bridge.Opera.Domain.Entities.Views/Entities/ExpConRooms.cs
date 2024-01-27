namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConRooms
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public decimal? DefnitAvailability { get; set; }
    public decimal? TotRoomsSold { get; set; }
    public decimal? OutOfOrder { get; set; }
    public decimal? BlkRoomsAuth { get; set; }
    public decimal? BlkRoomsSold { get; set; }
    public decimal? BlkRoomsAvail { get; set; }
    public decimal? ForecastRoomsAvail { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? FlowThrough { get; set; }
    public decimal? PhysicalRoomsNextDay { get; set; }
    public decimal? OutOfOrderNextDay { get; set; }
    public string RoomCategory { get; set; }
    public string RoomType { get; set; }
    public string RoomClass { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConRooms>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_ROOMS");

            entity.Property(e => e.BlkRoomsAuth)
                .HasColumnName("BLK_ROOMS_AUTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomsAvail)
                .HasColumnName("BLK_ROOMS_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomsSold)
                .HasColumnName("BLK_ROOMS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefnitAvailability)
                .HasColumnName("DEFNIT_AVAILABILITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlowThrough)
                .HasColumnName("FLOW_THROUGH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRoomsAvail)
                .HasColumnName("FORECAST_ROOMS_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrder)
                .HasColumnName("OUT_OF_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrderNextDay)
                .HasColumnName("OUT_OF_ORDER_NEXT_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRoomsNextDay)
                .HasColumnName("PHYSICAL_ROOMS_NEXT_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotRoomsSold)
                .HasColumnName("TOT_ROOMS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}

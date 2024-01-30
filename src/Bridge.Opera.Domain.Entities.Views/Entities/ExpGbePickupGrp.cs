namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGbePickupGrp
{
    public decimal? ExportId { get; set; }
    public string? GbeType { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? BlockedRoomCount { get; set; }
    public decimal? RoomPickupCount { get; set; }
    public decimal? ArrivalCount { get; set; }
    public decimal? DepartureCount { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BlockId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGbePickupGrp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GBE_PICKUP_GRP");

            entity.Property(e => e.ArrivalCount)
                .HasColumnName("ARRIVAL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockedRoomCount)
                .HasColumnName("BLOCKED_ROOM_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureCount)
                .HasColumnName("DEPARTURE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GbeType)
                .HasColumnName("GBE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomPickupCount)
                .HasColumnName("ROOM_PICKUP_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}

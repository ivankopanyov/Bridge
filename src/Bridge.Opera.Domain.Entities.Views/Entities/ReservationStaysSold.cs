namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationStaysSold
{
    public string? Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? RoomCount { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? DeductReservationCount { get; set; }
    public decimal? InventoryNights { get; set; }
    public decimal? ReservationCount { get; set; }
    public decimal? ResvDailyElSeq { get; set; }
    public decimal? ResvNameIdMin { get; set; }
    public decimal? ResvNameIdMax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationStaysSold>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_STAYS_SOLD");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeductReservationCount)
                .HasColumnName("DEDUCT_RESERVATION_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InventoryNights)
                .HasColumnName("INVENTORY_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationCount)
                .HasColumnName("RESERVATION_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvDailyElSeq)
                .HasColumnName("RESV_DAILY_EL_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameIdMax)
                .HasColumnName("RESV_NAME_ID_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameIdMin)
                .HasColumnName("RESV_NAME_ID_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCount)
                .HasColumnName("ROOM_COUNT")
                .HasColumnType("NUMBER");
        });
	}
}

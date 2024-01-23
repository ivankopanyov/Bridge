namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationGcRoomsDef
{
    public string Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? ResvDailyElSeq { get; set; }
    public string ResvStatus { get; set; }
    public string RoomCategory { get; set; }
    public string GuaranteeCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationGcRoomsDef>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_GC_ROOMS_DEF");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvDailyElSeq)
                .HasColumnName("RESV_DAILY_EL_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

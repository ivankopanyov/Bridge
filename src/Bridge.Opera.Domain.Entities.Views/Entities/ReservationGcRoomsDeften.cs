namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationGcRoomsDeften
{
    public string? Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? Quantity { get; set; }
    public string? RoomCategory { get; set; }
    public string? GuaranteeCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationGcRoomsDeften>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_GC_ROOMS_DEFTEN");

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

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphFullPickup
{
    public string PropertyCode { get; set; }
    public string DelphiId { get; set; }
    public string ReservationId { get; set; }
    public string BookingName { get; set; }
    public string AllotmentDate { get; set; }
    public string RoomType { get; set; }
    public string NoRoomsPickup { get; set; }
    public string NoOfGuests { get; set; }
    public string SingleRoomsPickup { get; set; }
    public string DoubleRoomsPickup { get; set; }
    public string TripleRoomsPickup { get; set; }
    public string QuadRoomsPickup { get; set; }
    public string SingleRate { get; set; }
    public string DoubleRate { get; set; }
    public string TripleRate { get; set; }
    public string QuadRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphFullPickup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_FULL_PICKUP");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.BookingName)
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DelphiId)
                .HasColumnName("DELPHI_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRate)
                .HasColumnName("DOUBLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRoomsPickup)
                .HasColumnName("DOUBLE_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.NoRoomsPickup)
                .HasColumnName("NO_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.QuadRate)
                .HasColumnName("QUAD_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.QuadRoomsPickup)
                .HasColumnName("QUAD_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SingleRate)
                .HasColumnName("SINGLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.SingleRoomsPickup)
                .HasColumnName("SINGLE_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.TripleRate)
                .HasColumnName("TRIPLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.TripleRoomsPickup)
                .HasColumnName("TRIPLE_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);
        });
	}
}

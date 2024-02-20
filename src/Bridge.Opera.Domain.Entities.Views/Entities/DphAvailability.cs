namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphAvailability
{
    public string? PropertyCode { get; set; }
    public string? ReservationDate { get; set; }
    public string? RoomType { get; set; }
    public string? NonGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphAvailability>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_AVAILABILITY");

            entity.Property(e => e.NonGroup)
                .HasColumnName("NON_GROUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(60)
                .IsUnicode(false);
        });
	}
}

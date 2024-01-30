namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphHistreservations
{
    public string? PropertyCode { get; set; }
    public string? DelphiInternalId { get; set; }
    public string? ReservationId { get; set; }
    public string? BookingName { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphHistreservations>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_HISTRESERVATIONS");

            entity.Property(e => e.BookingName)
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DelphiInternalId)
                .HasColumnName("DELPHI_INTERNAL_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(45)
                .IsUnicode(false);
        });
	}
}

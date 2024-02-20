namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingByActivity
{
    public string? Type { get; set; }
    public decimal? ActId { get; set; }
    public decimal? BookingId { get; set; }
    public DateTime? BookingArrival { get; set; }
    public DateTime? BookingDeparture { get; set; }
    public string? BookingName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_BY_ACTIVITY");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingArrival)
                .HasColumnName("BOOKING_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingDeparture)
                .HasColumnName("BOOKING_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingName)
                .IsRequired()
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

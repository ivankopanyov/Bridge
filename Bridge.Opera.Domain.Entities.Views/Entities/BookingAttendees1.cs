namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingAttendees1
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal AttendeeProfileId { get; set; }
    public string AttendeeName { get; set; }
    public string VipStatus { get; set; }
    public string Preferences { get; set; }
    public string PreferencesDesc { get; set; }
    public decimal? EventsRegistered { get; set; }
    public string ActiveResType { get; set; }
    public string AttendeeFirstName { get; set; }
    public string AttendeeLastName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingAttendees1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_ATTENDEES");

            entity.Property(e => e.ActiveResType)
                .HasColumnName("ACTIVE_RES_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.AttendeeFirstName)
                .HasColumnName("ATTENDEE_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AttendeeLastName)
                .HasColumnName("ATTENDEE_LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AttendeeName)
                .HasColumnName("ATTENDEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AttendeeProfileId)
                .HasColumnName("ATTENDEE_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventsRegistered)
                .HasColumnName("EVENTS_REGISTERED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preferences)
                .HasColumnName("PREFERENCES")
                .IsUnicode(false);

            entity.Property(e => e.PreferencesDesc)
                .HasColumnName("PREFERENCES_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

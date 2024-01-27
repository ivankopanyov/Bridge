namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookingAttendees
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal AttendeeProfileId { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual Name AttendeeProfile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingAttendees>(entity =>
        {
            entity.HasKey(e => new { e.BookId, e.Resort, e.AttendeeProfileId })
                .HasName("BOOKING_ATTENDEES_PK");

            entity.ToTable("BOOKING$ATTENDEES");

            entity.HasIndex(e => e.AttendeeProfileId)
                .HasName("BOOKATT_NAME_FK");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttendeeProfileId)
                .HasColumnName("ATTENDEE_PROFILE_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.AttendeeProfile);
			else
	            entity.HasOne(d => d.AttendeeProfile)
	                .WithMany(p => p.BookingAttendees)
	                .HasForeignKey(d => d.AttendeeProfileId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BOOKATT_NAME_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.BookingAttendees)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BOOKATT_AH_FK");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventRegisteredAttendees
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public decimal AttendeeProfileId { get; set; }
    public string AllottedTable { get; set; }
    public string AllottedSeat { get; set; }

    public virtual Name AttendeeProfile { get; set; }
    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventRegisteredAttendees>(entity =>
        {
            entity.HasKey(e => new { e.EventId, e.AttendeeProfileId })
                .HasName("EV_REGISTERED_ATTENDEES_PK");

            entity.ToTable("EVENT$REGISTERED_ATTENDEES");

            entity.HasIndex(e => e.AttendeeProfileId)
                .HasName("EVREGATT_NAME_FKI");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttendeeProfileId)
                .HasColumnName("ATTENDEE_PROFILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllottedSeat)
                .HasColumnName("ALLOTTED_SEAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AllottedTable)
                .HasColumnName("ALLOTTED_TABLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.AttendeeProfile);
			else
	            entity.HasOne(d => d.AttendeeProfile)
	                .WithMany(p => p.EventRegisteredAttendees)
	                .HasForeignKey(d => d.AttendeeProfileId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EVREGATT_NAME_FK");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventRegisteredAttendees)
	                .HasForeignKey(d => d.EventId)
	                .HasConstraintName("EVREGATT_EV_FK");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventAttendeePreferences
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public decimal? AttendeeProfileId { get; set; }
    public string PreferenceType { get; set; }
    public string Preference { get; set; }

    public virtual Name AttendeeProfile { get; set; }
    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventAttendeePreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EVENT$ATTENDEE_PREFERENCES");

            entity.HasIndex(e => e.AttendeeProfileId)
                .HasName("EVATTPREF_NAME_FKI");

            entity.HasIndex(e => new { e.EventId, e.AttendeeProfileId, e.PreferenceType, e.Preference })
                .HasName("EV_ATTENDEE_PREFERENCES_UK")
                .IsUnique();

            entity.Property(e => e.AttendeeProfileId)
                .HasColumnName("ATTENDEE_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preference)
                .IsRequired()
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.AttendeeProfile);
			else
	            entity.HasOne(d => d.AttendeeProfile)
	                .WithMany()
	                .HasForeignKey(d => d.AttendeeProfileId)
	                .HasConstraintName("EVATTPREF_NAME_FK");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany()
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EVATTPREF_EV_FK");
        });
	}
}

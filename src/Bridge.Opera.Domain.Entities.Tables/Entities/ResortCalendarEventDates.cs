namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCalendarEventDates
{
    public string? Resort { get; set; }
    public DateTime? EventDate { get; set; }
    public string? EventCode { get; set; }

    public virtual ResortCalendarEvents ResortCalendarEvents { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCalendarEventDates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.EventDate, e.EventCode })
                .HasName("CALENDAR_EVENT_DATES_PK");

            entity.ToTable("RESORT_CALENDAR_EVENT_DATES");

            entity.HasIndex(e => new { e.Resort, e.EventCode })
                .HasName("RESORT_CALENDAR_EVENT_DATES_EC");

            entity.HasIndex(e => new { e.EventDate, e.EventCode, e.Resort })
                .HasName("CALENDAR_EVENTS_DATES_DATE_IDX")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventCode)
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ResortCalendarEvents)))
				entity.Ignore(e => e.ResortCalendarEvents);
			else
	            entity.HasOne(d => d.ResortCalendarEvents)
	                .WithMany(p => p.ResortCalendarEventDates)
	                .HasForeignKey(d => new { d.Resort, d.EventCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CALENDAR_EVENT_DATES_FK");
        });
	}
}

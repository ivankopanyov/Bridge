namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCalendarEventsFact
{
    public string Resort { get; set; }
    public DateTime EventDate { get; set; }
    public string EventCode { get; set; }
    public string EventNotes { get; set; }
    public decimal? Rowcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCalendarEventsFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CALENDAR_EVENTS_FACT");

            entity.Property(e => e.EventCode)
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventNotes)
                .HasColumnName("EVENT_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rowcnt)
                .HasColumnName("ROWCNT")
                .HasColumnType("NUMBER");
        });
	}
}

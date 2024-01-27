namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResortCalendarEvtDates
{
    public string Resort { get; set; }
    public DateTime EventDate { get; set; }
    public string EventCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResortCalendarEvtDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESORT_CALENDAR_EVT_DATES");

            entity.Property(e => e.EventCode)
                .IsRequired()
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

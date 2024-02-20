namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CalendarEventDates
{
    public DateTime? EventDate { get; set; }
    public string? EventCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CalendarEventDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CALENDAR_EVENT_DATES");

            entity.Property(e => e.EventCode)
                .IsRequired()
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");
        });
	}
}

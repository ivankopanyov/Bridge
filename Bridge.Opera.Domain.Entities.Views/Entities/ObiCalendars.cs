namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCalendars
{
    public string Calendar { get; set; }
    public string CalendarDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCalendars>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CALENDARS");

            entity.Property(e => e.Calendar)
                .IsRequired()
                .HasColumnName("CALENDAR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CalendarDesc)
                .HasColumnName("CALENDAR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

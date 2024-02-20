namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CalendarEvents
{
    public string? EventCode { get; set; }
    public string? EventDesc { get; set; }
    public decimal? SellSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CalendarEvents>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CALENDAR_EVENTS");

            entity.Property(e => e.EventCode)
                .IsRequired()
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventDesc)
                .IsRequired()
                .HasColumnName("EVENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}

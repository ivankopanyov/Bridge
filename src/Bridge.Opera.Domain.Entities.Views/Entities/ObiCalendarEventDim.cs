namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCalendarEventDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? EventUcode { get; set; }
    public string? EventCode { get; set; }
    public string? EventDesc { get; set; }
    public string? OrmsEventYn { get; set; }
    public string? BlackoutYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCalendarEventDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CALENDAR_EVENT_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BlackoutYn)
                .IsRequired()
                .HasColumnName("BLACKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.EventUcode)
                .HasColumnName("EVENT_UCODE")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.OrmsEventYn)
                .IsRequired()
                .HasColumnName("ORMS_EVENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

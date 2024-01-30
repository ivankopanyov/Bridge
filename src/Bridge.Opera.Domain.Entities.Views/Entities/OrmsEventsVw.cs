namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsEventsVw
{
    public string? Resort { get; set; }
    public string? EventCode { get; set; }
    public DateTime? EventDate { get; set; }
    public string? Daytype { get; set; }
    public decimal? Dayseq { get; set; }
    public string? EventDesc { get; set; }
    public decimal? SellSequence { get; set; }
    public string? BlackoutYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsEventsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_EVENTS_VW");

            entity.Property(e => e.BlackoutYn)
                .IsRequired()
                .HasColumnName("BLACKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Dayseq)
                .HasColumnName("DAYSEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Daytype)
                .HasColumnName("DAYTYPE")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.EventCode)
                .IsRequired()
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventDesc)
                .IsRequired()
                .HasColumnName("EVENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}

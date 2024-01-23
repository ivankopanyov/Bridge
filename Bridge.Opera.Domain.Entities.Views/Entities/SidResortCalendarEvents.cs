namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResortCalendarEvents
{
    public string Resort { get; set; }
    public string EventCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string EventDesc { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? SellSequence { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string BlackoutYn { get; set; }
    public string OrmsEventYn { get; set; }
    public string ShowInOperaYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResortCalendarEvents>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESORT_CALENDAR_EVENTS");

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

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsEventYn)
                .IsRequired()
                .HasColumnName("ORMS_EVENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShowInOperaYn)
                .HasColumnName("SHOW_IN_OPERA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

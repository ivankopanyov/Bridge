namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkEventsByPBrk
{
    public string? EventsPBreak { get; set; }
    public DateTime? GeStartDateNTime { get; set; }
    public string? GeEvDate { get; set; }
    public string? GeEvTime { get; set; }
    public string? GeEvName { get; set; }
    public string? GeRoom { get; set; }
    public decimal? GeGtd { get; set; }
    public decimal? EventsOnPBreak { get; set; }
    public decimal? ReportId { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkEventsByPBrk>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_EVENTS_BY_P_BRK");

            entity.Property(e => e.EventsOnPBreak)
                .HasColumnName("EVENTS_ON_P_BREAK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventsPBreak)
                .HasColumnName("EVENTS_P_BREAK")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GeEvDate)
                .HasColumnName("GE_EV_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.GeEvName)
                .HasColumnName("GE_EV_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GeEvTime)
                .HasColumnName("GE_EV_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.GeGtd)
                .HasColumnName("GE_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GeRoom)
                .HasColumnName("GE_ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GeStartDateNTime)
                .HasColumnName("GE_START_DATE_N_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");
        });
	}
}

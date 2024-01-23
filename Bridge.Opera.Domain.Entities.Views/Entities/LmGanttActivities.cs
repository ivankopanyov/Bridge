namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmGanttActivities
{
    public string AvActCode { get; set; }
    public string Resort { get; set; }
    public decimal? BookedResId { get; set; }
    public decimal? BookedActId { get; set; }
    public decimal? BookedElId { get; set; }
    public string ResType { get; set; }
    public string ResId { get; set; }
    public string ActCode { get; set; }
    public string ActElCode { get; set; }
    public string GanttType { get; set; }
    public string GanttCode { get; set; }
    public decimal? GanttActId { get; set; }
    public string GanttActDesc { get; set; }
    public string GuestName { get; set; }
    public string OutletCode { get; set; }
    public string Status { get; set; }
    public decimal? TrxNo { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal? Rank { get; set; }
    public decimal? Price { get; set; }
    public decimal? MaxAvailable { get; set; }
    public string Comments { get; set; }
    public string GanttResource { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmGanttActivities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_GANTT_ACTIVITIES");

            entity.Property(e => e.ActCode)
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActElCode)
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvActCode)
                .HasColumnName("AV_ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedElId)
                .HasColumnName("BOOKED_EL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedResId)
                .HasColumnName("BOOKED_RES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GanttActDesc)
                .HasColumnName("GANTT_ACT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GanttActId)
                .HasColumnName("GANTT_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GanttCode)
                .HasColumnName("GANTT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GanttResource)
                .HasColumnName("GANTT_RESOURCE")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.GanttType)
                .HasColumnName("GANTT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.MaxAvailable)
                .HasColumnName("MAX_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rank)
                .HasColumnName("RANK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}

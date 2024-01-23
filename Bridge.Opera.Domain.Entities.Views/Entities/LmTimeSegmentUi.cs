namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmTimeSegmentUi
{
    public string TimePatternCode { get; set; }
    public string TimeSegmentCode { get; set; }
    public string Resort { get; set; }
    public string BeginTimeHh24mi { get; set; }
    public string EndTimeHh24mi { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmTimeSegmentUi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_TIME_SEGMENT_UI");

            entity.Property(e => e.BeginTimeHh24mi)
                .HasColumnName("BEGIN_TIME_HH24MI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndTimeHh24mi)
                .HasColumnName("END_TIME_HH24MI")
                .HasMaxLength(20)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimePatternCode)
                .IsRequired()
                .HasColumnName("TIME_PATTERN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeSegmentCode)
                .IsRequired()
                .HasColumnName("TIME_SEGMENT_CODE")
                .HasMaxLength(20)
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

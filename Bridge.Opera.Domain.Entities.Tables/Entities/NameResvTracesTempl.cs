namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameResvTracesTempl
{
    public decimal ResvTraceTemplId { get; set; }
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }
    public string TraceText { get; set; }
    public string InternalNote { get; set; }
    public DateTime? ActionTime { get; set; }
    public DateTime? GoodThrough { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string FrequencyCode { get; set; }
    public DateTime? TraceTime { get; set; }
    public decimal? ResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameResvTracesTempl>(entity =>
        {
            entity.HasKey(e => e.ResvTraceTemplId)
                .HasName("RESV_TRACE_TEMPL_PK");

            entity.ToTable("NAME_RESV_TRACES_TEMPL");

            entity.HasIndex(e => new { e.NameId, e.Resort })
                .HasName("RESV_TRACE_TEMPL_IDX1");

            entity.Property(e => e.ResvTraceTemplId)
                .HasColumnName("RESV_TRACE_TEMPL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionTime)
                .HasColumnName("ACTION_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyCode)
                .HasColumnName("FREQUENCY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GoodThrough)
                .HasColumnName("GOOD_THROUGH")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNote)
                .HasColumnName("INTERNAL_NOTE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TraceText)
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TraceTime)
                .HasColumnName("TRACE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestTraces
{
    public decimal TraceId { get; set; }
    public string DeptId { get; set; }
    public DateTime TraceDate { get; set; }
    public string EnteredBy { get; set; }
    public string TraceText { get; set; }
    public string TraceType { get; set; }
    public string InternalYn { get; set; }
    public string RuleCode { get; set; }
    public string ExternalTraceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestTraces>(entity =>
        {
            entity.HasKey(e => new { e.TraceId, e.DeptId })
                .HasName("GST_TRC_PK");

            entity.ToTable("GUEST_TRACES");

            entity.HasIndex(e => e.ExternalTraceId)
                .HasName("GST_TRC_EXT_ID_IDX");

            entity.Property(e => e.TraceId)
                .HasColumnName("TRACE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EnteredBy)
                .IsRequired()
                .HasColumnName("ENTERED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalTraceId)
                .HasColumnName("EXTERNAL_TRACE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TraceDate)
                .HasColumnName("TRACE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceText)
                .IsRequired()
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TraceType)
                .HasColumnName("TRACE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBlkTrace
{
    public DateTime? TraceDate { get; set; }
    public string? FormatedTraceDate { get; set; }
    public string? Resort { get; set; }
    public string? TraceText { get; set; }
    public string? AllotDesc { get; set; }
    public string? AllotmentCode { get; set; }
    public string? AllotmentType { get; set; }
    public string? Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBlkTrace>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BLK_TRACE");

            entity.Property(e => e.AllotDesc)
                .IsRequired()
                .HasColumnName("ALLOT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormatedTraceDate)
                .HasColumnName("FORMATED_TRACE_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TraceDate)
                .HasColumnName("TRACE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceText)
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

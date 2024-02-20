namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReportLog
{
    public decimal? SeqNo { get; set; }
    public string? ReportId { get; set; }
    public decimal? LogLevel { get; set; }
    public DateTime? LogTime { get; set; }
    public string? CodeLoc { get; set; }
    public string? LogText { get; set; }
    public string? FractionSeconds { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REPORT_LOG");

            entity.HasIndex(e => e.ReportId)
                .HasName("REPORT_LOG_IND1");

            entity.Property(e => e.CodeLoc)
                .HasColumnName("CODE_LOC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FractionSeconds)
                .HasColumnName("FRACTION_SECONDS")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.LogLevel)
                .HasColumnName("LOG_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogText)
                .HasColumnName("LOG_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.LogTime)
                .HasColumnName("LOG_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");
        });
	}
}

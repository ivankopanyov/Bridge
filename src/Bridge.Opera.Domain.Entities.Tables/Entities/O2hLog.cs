namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2hLog
{
    public string? MigrationId { get; set; }
    public decimal? LogLine { get; set; }
    public DateTime? EntryTime { get; set; }
    public string? LogTxt { get; set; }
    public decimal? Duration { get; set; }
    public decimal? RowsProcessed { get; set; }
    public decimal? RowsFailed { get; set; }
    public decimal? LogLevel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2hLog>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.LogLine })
                .HasName("O2H_LOG_PK");

            entity.ToTable("O2H_LOG");

            entity.Property(e => e.MigrationId)
                .HasColumnName("MIGRATION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LogLine)
                .HasColumnName("LOG_LINE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EntryTime)
                .HasColumnName("ENTRY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LogLevel)
                .HasColumnName("LOG_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogTxt)
                .HasColumnName("LOG_TXT")
                .HasColumnType("CLOB");

            entity.Property(e => e.RowsFailed)
                .HasColumnName("ROWS_FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowsProcessed)
                .HasColumnName("ROWS_PROCESSED")
                .HasColumnType("NUMBER");
        });
	}
}

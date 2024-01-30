namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SummaryRefreshLog
{
    public string? Resort { get; set; }
    public DateTime? LastRefreshTime { get; set; }
    public string? TableName { get; set; }
    public string? ProgramName { get; set; }
    public string? LastProcessedKey { get; set; }
    public string? SuccessFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SummaryRefreshLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SUMMARY_REFRESH_LOG");

            entity.HasIndex(e => new { e.ProgramName, e.Resort })
                .HasName("SUMMARY_REFRESH_LOG_PROG_IDX");

            entity.HasIndex(e => new { e.TableName, e.Resort })
                .HasName("SUMMARY_REFRESH_LOG_IDX");

            entity.Property(e => e.LastProcessedKey)
                .HasColumnName("LAST_PROCESSED_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LastRefreshTime)
                .HasColumnName("LAST_REFRESH_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuccessFlag)
                .HasColumnName("SUCCESS_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}

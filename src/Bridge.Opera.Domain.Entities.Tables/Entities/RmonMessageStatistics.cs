namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonMessageStatistics
{
    public string? SiteCode { get; set; }
    public string? SnapId { get; set; }
    public DateTime? SnapFrom { get; set; }
    public DateTime? SnapTo { get; set; }
    public string? InterfaceId { get; set; }
    public string? RemoteResort { get; set; }
    public string? MessageType { get; set; }
    public decimal? TotalSuccess { get; set; }
    public decimal? TotalFailed { get; set; }
    public decimal? TotalExtSuccess { get; set; }
    public decimal? TotalExtFailed { get; set; }
    public decimal? TotalMessageCount { get; set; }
    public decimal? TotalWaitMax { get; set; }
    public decimal? TotalWaitMin { get; set; }
    public decimal? TotalWaitMean { get; set; }
    public decimal? TotalWaitLast { get; set; }
    public decimal? TotalElapsedMax { get; set; }
    public decimal? TotalElapsedMin { get; set; }
    public decimal? TotalElapsedMean { get; set; }
    public decimal? TotalGenerated { get; set; }
    public string? Priority { get; set; }
    public string? StatisticType { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonMessageStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RMON_MESSAGE_STATISTICS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("RMON_MS_INSDT");

            entity.HasIndex(e => new { e.SiteCode, e.SnapId, e.InterfaceId, e.RemoteResort })
                .HasName("RMON_MS_SITE_SNAP");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemoteResort)
                .HasColumnName("REMOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapFrom)
                .HasColumnName("SNAP_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.SnapId)
                .HasColumnName("SNAP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SnapTo)
                .HasColumnName("SNAP_TO")
                .HasColumnType("DATE");

            entity.Property(e => e.StatisticType)
                .HasColumnName("STATISTIC_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalElapsedMax)
                .HasColumnName("TOTAL_ELAPSED_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalElapsedMean)
                .HasColumnName("TOTAL_ELAPSED_MEAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalElapsedMin)
                .HasColumnName("TOTAL_ELAPSED_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalExtFailed)
                .HasColumnName("TOTAL_EXT_FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalExtSuccess)
                .HasColumnName("TOTAL_EXT_SUCCESS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFailed)
                .HasColumnName("TOTAL_FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGenerated)
                .HasColumnName("TOTAL_GENERATED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMessageCount)
                .HasColumnName("TOTAL_MESSAGE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalSuccess)
                .HasColumnName("TOTAL_SUCCESS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalWaitLast)
                .HasColumnName("TOTAL_WAIT_LAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalWaitMax)
                .HasColumnName("TOTAL_WAIT_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalWaitMean)
                .HasColumnName("TOTAL_WAIT_MEAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalWaitMin)
                .HasColumnName("TOTAL_WAIT_MIN")
                .HasColumnType("NUMBER");
        });
	}
}

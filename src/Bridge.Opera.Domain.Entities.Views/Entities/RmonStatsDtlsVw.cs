namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RmonStatsDtlsVw
{
    public string? SnapId { get; set; }
    public string? SiteCode { get; set; }
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
    public decimal? TotInboundWavgWait { get; set; }
    public string? CInboundWavgWait { get; set; }
    public decimal? TotInboundElapsed { get; set; }
    public string? CInboundElapsed { get; set; }
    public decimal? TotOutboundWavgWait { get; set; }
    public string? COutboundWavgWait { get; set; }
    public decimal? TotOutboundLowWavgWait { get; set; }
    public string? COutboundLowWavgWait { get; set; }
    public decimal? TotOutboundFailCount { get; set; }
    public string? COutboundFailCount { get; set; }
    public decimal? TotInboundFailCount { get; set; }
    public string? CInboundFailCount { get; set; }
    public decimal? TotInboundFsRatio { get; set; }
    public string? CInboundFsRatio { get; set; }
    public decimal? TotOutboundFsRatio { get; set; }
    public string? COutboundFsRatio { get; set; }
    public string? RecordColor { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonStatsDtlsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RMON_STATS_DTLS_VW");

            entity.Property(e => e.CInboundElapsed)
                .HasColumnName("C_INBOUND_ELAPSED")
                .IsUnicode(false);

            entity.Property(e => e.CInboundFailCount)
                .HasColumnName("C_INBOUND_FAIL_COUNT")
                .IsUnicode(false);

            entity.Property(e => e.CInboundFsRatio)
                .HasColumnName("C_INBOUND_FS_RATIO")
                .IsUnicode(false);

            entity.Property(e => e.CInboundWavgWait)
                .HasColumnName("C_INBOUND_WAVG_WAIT")
                .IsUnicode(false);

            entity.Property(e => e.COutboundFailCount)
                .HasColumnName("C_OUTBOUND_FAIL_COUNT")
                .IsUnicode(false);

            entity.Property(e => e.COutboundFsRatio)
                .HasColumnName("C_OUTBOUND_FS_RATIO")
                .IsUnicode(false);

            entity.Property(e => e.COutboundLowWavgWait)
                .HasColumnName("C_OUTBOUND_LOW_WAVG_WAIT")
                .IsUnicode(false);

            entity.Property(e => e.COutboundWavgWait)
                .HasColumnName("C_OUTBOUND_WAVG_WAIT")
                .IsUnicode(false);

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

            entity.Property(e => e.RecordColor)
                .HasColumnName("RECORD_COLOR")
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

            entity.Property(e => e.TotInboundElapsed)
                .HasColumnName("TOT_INBOUND_ELAPSED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotInboundFailCount)
                .HasColumnName("TOT_INBOUND_FAIL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotInboundFsRatio)
                .HasColumnName("TOT_INBOUND_FS_RATIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotInboundWavgWait)
                .HasColumnName("TOT_INBOUND_WAVG_WAIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOutboundFailCount)
                .HasColumnName("TOT_OUTBOUND_FAIL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOutboundFsRatio)
                .HasColumnName("TOT_OUTBOUND_FS_RATIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOutboundLowWavgWait)
                .HasColumnName("TOT_OUTBOUND_LOW_WAVG_WAIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOutboundWavgWait)
                .HasColumnName("TOT_OUTBOUND_WAVG_WAIT")
                .HasColumnType("NUMBER");

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

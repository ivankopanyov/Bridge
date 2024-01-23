namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntPerfHistoryData
{
    public decimal? ConsolidationDay { get; set; }
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string Module { get; set; }
    public string MessageType { get; set; }
    public decimal? AvgTotTimeSec { get; set; }
    public decimal? AvgBufferGets { get; set; }
    public decimal? AvgCpuTimeSec { get; set; }
    public decimal? AvgPgaKb { get; set; }
    public decimal? AvgFailRatio { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntPerfHistoryData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_PERF_HISTORY_DATA");

            entity.HasIndex(e => new { e.ConsolidationDay, e.InterfaceId, e.Resort, e.Module, e.MessageType })
                .HasName("INT_PERF_HIST_DATA_UK")
                .IsUnique();

            entity.Property(e => e.AvgBufferGets)
                .HasColumnName("AVG_BUFFER_GETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgCpuTimeSec)
                .HasColumnName("AVG_CPU_TIME_SEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgFailRatio)
                .HasColumnName("AVG_FAIL_RATIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPgaKb)
                .HasColumnName("AVG_PGA_KB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgTotTimeSec)
                .HasColumnName("AVG_TOT_TIME_SEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsolidationDay)
                .HasColumnName("CONSOLIDATION_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'D'");

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

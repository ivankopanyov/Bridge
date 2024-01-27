namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntPerformanceSnapshot
{
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public DateTime SnapshotFrom { get; set; }
    public DateTime SnapshotTo { get; set; }
    public string Module { get; set; }
    public decimal? BePriority { get; set; }
    public string MessageType { get; set; }
    public decimal? Success { get; set; }
    public decimal? Failed { get; set; }
    public decimal? Rejected { get; set; }
    public decimal? TotMsgs { get; set; }
    public decimal? WaitSecsMax { get; set; }
    public decimal? WaitSecsMin { get; set; }
    public decimal? WaitSecsMean { get; set; }
    public decimal? WaitSecsLast { get; set; }
    public decimal? ElapsedSecsMax { get; set; }
    public decimal? ElapsedSecsMin { get; set; }
    public decimal? ElapsedSecsMean { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntPerformanceSnapshot>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_PERFORMANCE_SNAPSHOT");

            entity.HasIndex(e => e.SnapshotTo)
                .HasName("INT_PERF_SNAPSHOT_TO");

            entity.Property(e => e.BePriority)
                .HasColumnName("BE_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElapsedSecsMax)
                .HasColumnName("ELAPSED_SECS_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElapsedSecsMean)
                .HasColumnName("ELAPSED_SECS_MEAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElapsedSecsMin)
                .HasColumnName("ELAPSED_SECS_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Failed)
                .HasColumnName("FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Rejected)
                .HasColumnName("REJECTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotFrom)
                .HasColumnName("SNAPSHOT_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.SnapshotTo)
                .HasColumnName("SNAPSHOT_TO")
                .HasColumnType("DATE");

            entity.Property(e => e.Success)
                .HasColumnName("SUCCESS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotMsgs)
                .HasColumnName("TOT_MSGS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitSecsLast)
                .HasColumnName("WAIT_SECS_LAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitSecsMax)
                .HasColumnName("WAIT_SECS_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitSecsMean)
                .HasColumnName("WAIT_SECS_MEAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitSecsMin)
                .HasColumnName("WAIT_SECS_MIN")
                .HasColumnType("NUMBER");
        });
	}
}

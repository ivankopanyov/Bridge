namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntPerformanceData
{
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string Module { get; set; }
    public string MessageType { get; set; }
    public string MessageStatus { get; set; }
    public decimal MessageId { get; set; }
    public DateTime? MessageDateTime { get; set; }
    public decimal? TotTimeSec { get; set; }
    public decimal? BufferGets { get; set; }
    public decimal? CpuTimeSec { get; set; }
    public decimal? PgaKb { get; set; }
    public string SwDescription { get; set; }
    public DateTime? EnqueueTime { get; set; }
    public DateTime? DequeueTime { get; set; }
    public decimal? NumOfMsgs { get; set; }
    public decimal? BePriority { get; set; }
    public string ActionType { get; set; }
    public string ReviewedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntPerformanceData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_PERFORMANCE_DATA");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.Module, e.MessageType, e.MessageStatus, e.MessageDateTime })
                .HasName("INT_PERF_CONSOLD_INDX1");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BePriority)
                .HasColumnName("BE_PRIORITY")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0");

            entity.Property(e => e.BufferGets)
                .HasColumnName("BUFFER_GETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CpuTimeSec)
                .HasColumnName("CPU_TIME_SEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DequeueTime)
                .HasColumnName("DEQUEUE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EnqueueTime)
                .HasColumnName("ENQUEUE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MessageDateTime)
                .HasColumnName("MESSAGE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageStatus)
                .HasColumnName("MESSAGE_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'D'");

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NumOfMsgs)
                .HasColumnName("NUM_OF_MSGS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1");

            entity.Property(e => e.PgaKb)
                .HasColumnName("PGA_KB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReviewedYn)
                .HasColumnName("REVIEWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SwDescription)
                .HasColumnName("SW_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TotTimeSec)
                .HasColumnName("TOT_TIME_SEC")
                .HasColumnType("NUMBER");
        });
	}
}

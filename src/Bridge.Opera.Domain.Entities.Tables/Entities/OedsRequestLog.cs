namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OedsRequestLog
{
    public decimal? RequestId { get; set; }
    public DateTime? RequestDate { get; set; }
    public decimal? RequestProcessTime { get; set; }
    public decimal? RequestDbTime { get; set; }
    public string? RequestSource { get; set; }
    public string? RequestType { get; set; }
    public decimal? ProcessHour { get; set; }
    public string? RequestStatus { get; set; }
    public string? MachineName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OedsRequestLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OEDS_REQUEST_LOG");

            entity.HasIndex(e => new { e.MachineName, e.RequestDate, e.ProcessHour, e.RequestType })
                .HasName("OEDS_REQUEST_LOG_IDX1");

            entity.Property(e => e.MachineName)
                .IsRequired()
                .HasColumnName("MACHINE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("'SYSTEM'");

            entity.Property(e => e.ProcessHour)
                .HasColumnName("PROCESS_HOUR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestDbTime)
                .HasColumnName("REQUEST_DB_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestProcessTime)
                .HasColumnName("REQUEST_PROCESS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestSource)
                .IsRequired()
                .HasColumnName("REQUEST_SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestStatus)
                .HasColumnName("REQUEST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}

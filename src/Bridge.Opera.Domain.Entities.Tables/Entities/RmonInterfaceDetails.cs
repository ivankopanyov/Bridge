namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonInterfaceDetails
{
    public string? SiteCode { get; set; }
    public string? InterfaceId { get; set; }
    public string? SubProcessType { get; set; }
    public decimal? ThreadId { get; set; }
    public string? ProcessStatus { get; set; }
    public decimal? SecondsSinceUpdate { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? StoppedAt { get; set; }
    public string? Terminal { get; set; }
    public string? CanStartYn { get; set; }
    public string? CanStopYn { get; set; }
    public string? CanRestartYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonInterfaceDetails>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.InterfaceId, e.SubProcessType, e.ThreadId })
                .HasName("RIL_PK");

            entity.ToTable("RMON_INTERFACE_DETAILS");

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SubProcessType)
                .HasColumnName("SUB_PROCESS_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ThreadId)
                .HasColumnName("THREAD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CanRestartYn)
                .HasColumnName("CAN_RESTART_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CanStartYn)
                .HasColumnName("CAN_START_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CanStopYn)
                .HasColumnName("CAN_STOP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProcessStatus)
                .IsRequired()
                .HasColumnName("PROCESS_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecondsSinceUpdate)
                .HasColumnName("SECONDS_SINCE_UPDATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartedAt)
                .HasColumnName("STARTED_AT")
                .HasColumnType("DATE");

            entity.Property(e => e.StoppedAt)
                .HasColumnName("STOPPED_AT")
                .HasColumnType("DATE");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}

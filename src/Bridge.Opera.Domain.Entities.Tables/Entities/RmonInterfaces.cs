namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonInterfaces
{
    public string? SiteCode { get; set; }
    public string? InterfaceId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? MonitorStatus { get; set; }
    public string? InBoundYn { get; set; }
    public string? OutBoundYn { get; set; }
    public string? ExportYn { get; set; }
    public string? LookupYn { get; set; }
    public string? InterfaceType { get; set; }
    public string? ExternalResort { get; set; }
    public string? CanStartYn { get; set; }
    public string? CanStopYn { get; set; }
    public string? CanRestartYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonInterfaces>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.InterfaceId })
                .HasName("RIE_PK");

            entity.ToTable("RMON_INTERFACES");

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

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

            entity.Property(e => e.ExportYn)
                .HasColumnName("EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResort)
                .HasColumnName("EXTERNAL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InBoundYn)
                .HasColumnName("IN_BOUND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InterfaceType)
                .HasColumnName("INTERFACE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LookupYn)
                .HasColumnName("LOOKUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MonitorStatus)
                .HasColumnName("MONITOR_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OutBoundYn)
                .HasColumnName("OUT_BOUND_YN")
                .HasMaxLength(1)
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

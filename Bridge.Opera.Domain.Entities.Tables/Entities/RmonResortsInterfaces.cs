namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonResortsInterfaces
{
    public string SiteCode { get; set; }
    public string RemoteResort { get; set; }
    public string InterfaceId { get; set; }
    public string Status { get; set; }
    public DateTime? Started { get; set; }
    public DateTime? Stopped { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string ErrorMessage { get; set; }
    public string Version { get; set; }
    public string LastSentStatus { get; set; }
    public DateTime? LastSentDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string MonitorStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonResortsInterfaces>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.RemoteResort, e.InterfaceId })
                .HasName("RRE_PK");

            entity.ToTable("RMON_RESORTS_INTERFACES");

            entity.HasIndex(e => new { e.RemoteResort, e.SiteCode })
                .HasName("RMON_RRI_RES");

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemoteResort)
                .HasColumnName("REMOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
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

            entity.Property(e => e.LastSentDate)
                .HasColumnName("LAST_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastSentStatus)
                .HasColumnName("LAST_SENT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdated)
                .HasColumnName("LAST_UPDATED")
                .HasColumnType("DATE");

            entity.Property(e => e.MonitorStatus)
                .HasColumnName("MONITOR_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Started)
                .HasColumnName("STARTED")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Stopped)
                .HasColumnName("STOPPED")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

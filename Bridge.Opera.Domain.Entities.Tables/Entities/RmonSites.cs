namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonSites
{
    public string SiteCode { get; set; }
    public string SiteName { get; set; }
    public string IpAddress { get; set; }
    public string Url { get; set; }
    public string AppServerName { get; set; }
    public string SnapId { get; set; }
    public string Version { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string MonitorStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonSites>(entity =>
        {
            entity.HasKey(e => e.SiteCode)
                .HasName("RSE_PK");

            entity.ToTable("RMON_SITES");

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppServerName)
                .HasColumnName("APP_SERVER_NAME")
                .HasMaxLength(100)
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

            entity.Property(e => e.IpAddress)
                .IsRequired()
                .HasColumnName("IP_ADDRESS")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MonitorStatus)
                .HasColumnName("MONITOR_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SiteName)
                .HasColumnName("SITE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SnapId)
                .HasColumnName("SNAP_ID")
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

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .HasMaxLength(1000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

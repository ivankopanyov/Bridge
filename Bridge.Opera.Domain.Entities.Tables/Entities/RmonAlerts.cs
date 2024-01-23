namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonAlerts
{
    public string SiteCode { get; set; }
    public string SnapId { get; set; }
    public string InterfaceId { get; set; }
    public string RemoteResort { get; set; }
    public string AlertText { get; set; }
    public decimal? AlertPriority { get; set; }
    public string EscalatedTo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonAlerts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RMON_ALERTS");

            entity.HasIndex(e => new { e.SiteCode, e.SnapId, e.InterfaceId, e.RemoteResort })
                .HasName("RMON_ALRT1");

            entity.Property(e => e.AlertPriority)
                .HasColumnName("ALERT_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlertText)
                .HasColumnName("ALERT_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.EscalatedTo)
                .HasColumnName("ESCALATED_TO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RemoteResort)
                .HasColumnName("REMOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SiteCode)
                .IsRequired()
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapId)
                .IsRequired()
                .HasColumnName("SNAP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}

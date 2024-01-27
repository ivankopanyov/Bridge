namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OedsServiceRegistry
{
    public string ServiceName { get; set; }
    public string MachineName { get; set; }
    public DateTime? LastUpdateTime { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OedsServiceRegistry>(entity =>
        {
            entity.HasKey(e => new { e.MachineName, e.ServiceName })
                .HasName("OEDS_SERVICE_REGISTRY_PK1");

            entity.ToTable("OEDS_SERVICE_REGISTRY");

            entity.Property(e => e.MachineName)
                .HasColumnName("MACHINE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ServiceName)
                .HasColumnName("SERVICE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}

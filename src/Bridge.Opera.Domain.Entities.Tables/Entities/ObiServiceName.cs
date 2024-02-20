namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiServiceName
{
    public decimal? InstId { get; set; }
    public string? InstanceName { get; set; }
    public string? ServiceName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiServiceName>(entity =>
        {
            entity.HasKey(e => e.InstId)
                .HasName("OBI_SERVICE_NAME_PK");

            entity.ToTable("OBI_SERVICE_NAME");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstanceName)
                .HasColumnName("INSTANCE_NAME")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.ServiceName)
                .HasColumnName("SERVICE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

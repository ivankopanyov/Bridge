namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsUdfsMapping
{
    public string ModuleName { get; set; }
    public string UdfLabel { get; set; }
    public string UdfName { get; set; }
    public string UpdateYn { get; set; }
    public string UdfType { get; set; }
    public string ActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsUdfsMapping>(entity =>
        {
            entity.HasKey(e => new { e.ModuleName, e.UdfLabel, e.UdfName })
                .HasName("OWS_UDFS_MAPPING_PK");

            entity.ToTable("OWS_UDFS_MAPPING");

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfLabel)
                .HasColumnName("UDF_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfName)
                .HasColumnName("UDF_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .IsRequired()
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateYn)
                .IsRequired()
                .HasColumnName("UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

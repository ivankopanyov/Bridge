namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOwsUdfsMappingSys
{
    public string ModuleName { get; set; }
    public string UdfLabel { get; set; }
    public string UdfName { get; set; }
    public string UpdateYn { get; set; }
    public string UdfType { get; set; }
    public string ActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOwsUdfsMappingSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OWS_UDFS_MAPPING_SYS");

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfLabel)
                .IsRequired()
                .HasColumnName("UDF_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfName)
                .IsRequired()
                .HasColumnName("UDF_NAME")
                .HasMaxLength(20)
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

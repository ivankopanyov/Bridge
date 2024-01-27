namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiExtDatamart
{
    public string DatamartName { get; set; }
    public string Description { get; set; }
    public string ConversionInterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiExtDatamart>(entity =>
        {
            entity.HasKey(e => e.DatamartName)
                .HasName("OBI_EXT_DATAMART_PK");

            entity.ToTable("OBI_EXT_DATAMART");

            entity.Property(e => e.DatamartName)
                .HasColumnName("DATAMART_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ConversionInterfaceId)
                .HasColumnName("CONVERSION_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}

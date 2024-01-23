namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidObiExtDatamartSys
{
    public string DatamartName { get; set; }
    public string Description { get; set; }
    public string ConversionInterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidObiExtDatamartSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OBI_EXT_DATAMART_SYS");

            entity.Property(e => e.ConversionInterfaceId)
                .HasColumnName("CONVERSION_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DatamartName)
                .IsRequired()
                .HasColumnName("DATAMART_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}

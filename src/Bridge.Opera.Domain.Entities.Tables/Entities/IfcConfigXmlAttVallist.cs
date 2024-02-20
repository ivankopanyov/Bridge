namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcConfigXmlAttVallist
{
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public decimal? ConfigId { get; set; }
    public string? ListValues { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcConfigXmlAttVallist>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_CONFIG_XML_ATT_VALLIST");

            entity.Property(e => e.ConfigId)
                .HasColumnName("CONFIG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ListValues)
                .HasColumnName("LIST_VALUES")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

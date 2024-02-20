namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcConfigXmlElements
{
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public string? Element { get; set; }
    public string? Attribute { get; set; }
    public string? AttribValue { get; set; }
    public string? DataType { get; set; }
    public decimal? ConfigId { get; set; }
    public decimal? ParentId { get; set; }
    public string? TooltipText { get; set; }
    public string? DisplayYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ElementTag { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? AttributeType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcConfigXmlElements>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_CONFIG_XML_ELEMENTS");

            entity.HasIndex(e => new { e.Resort, e.IfcCtrlId, e.ParentId })
                .HasName("IFC_RIP_IND");

            entity.Property(e => e.AttribValue)
                .HasColumnName("ATTRIB_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Attribute)
                .HasColumnName("ATTRIBUTE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AttributeType)
                .HasColumnName("ATTRIBUTE_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfigId)
                .HasColumnName("CONFIG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Element)
                .IsRequired()
                .HasColumnName("ELEMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ElementTag)
                .IsRequired()
                .HasColumnName("ELEMENT_TAG")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentId)
                .HasColumnName("PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TooltipText)
                .HasColumnName("TOOLTIP_TEXT")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

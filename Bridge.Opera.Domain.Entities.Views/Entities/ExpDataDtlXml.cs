namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpDataDtlXml
{
    public decimal? ExpXmlId { get; set; }
    public decimal? ExpFileId { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? XmlLevel { get; set; }
    public decimal? OrderBy { get; set; }
    public string Path { get; set; }
    public string IsLeaf { get; set; }
    public string TagName { get; set; }
    public string Formula { get; set; }
    public decimal? ParentDtlId { get; set; }
    public decimal? ExpFileDtlId { get; set; }
    public string AddSourceView { get; set; }
    public string XmlColType { get; set; }
    public string Filter { get; set; }
    public string IgnoreLengthYn { get; set; }
    public decimal? ColLength { get; set; }
    public string TagRequiredYn { get; set; }
    public string XmlAttributeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpDataDtlXml>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_DATA_DTL_XML");

            entity.Property(e => e.AddSourceView)
                .HasColumnName("ADD_SOURCE_VIEW")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ColLength)
                .HasColumnName("COL_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileDtlId)
                .HasColumnName("EXP_FILE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpXmlId)
                .HasColumnName("EXP_XML_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreLengthYn)
                .HasColumnName("IGNORE_LENGTH_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsLeaf)
                .HasColumnName("IS_LEAF")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentDtlId)
                .HasColumnName("PARENT_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Path)
                .HasColumnName("PATH")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TagName)
                .HasColumnName("TAG_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TagRequiredYn)
                .HasColumnName("TAG_REQUIRED_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlAttributeYn)
                .HasColumnName("XML_ATTRIBUTE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlColType)
                .HasColumnName("XML_COL_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlLevel)
                .HasColumnName("XML_LEVEL")
                .HasColumnType("NUMBER");
        });
	}
}

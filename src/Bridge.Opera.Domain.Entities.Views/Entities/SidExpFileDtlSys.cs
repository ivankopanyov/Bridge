namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidExpFileDtlSys
{
    public decimal? ExpFileId { get; set; }
    public decimal? ExpFileDtlId { get; set; }
    public string? ColName { get; set; }
    public decimal? ColLength { get; set; }
    public string? ColFormat { get; set; }
    public string? ColAlignment { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ColType { get; set; }
    public string? DatabaseYn { get; set; }
    public string? Formula { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PromptYn { get; set; }
    public string? DefaultValue { get; set; }
    public string? GenDataType { get; set; }
    public string? IgnoreLengthYn { get; set; }
    public string? XmlColType { get; set; }
    public decimal? ExpDtlLinkId { get; set; }
    public string? AddSourceView { get; set; }
    public string? Filter { get; set; }
    public string? TagRequiredYn { get; set; }
    public string? XmlAttributeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidExpFileDtlSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_EXP_FILE_DTL_SYS");

            entity.Property(e => e.AddSourceView)
                .HasColumnName("ADD_SOURCE_VIEW")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ColAlignment)
                .HasColumnName("COL_ALIGNMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ColFormat)
                .HasColumnName("COL_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ColLength)
                .HasColumnName("COL_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ColName)
                .HasColumnName("COL_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ColType)
                .HasColumnName("COL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseYn)
                .HasColumnName("DATABASE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExpDtlLinkId)
                .HasColumnName("EXP_DTL_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileDtlId)
                .HasColumnName("EXP_FILE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GenDataType)
                .HasColumnName("GEN_DATA_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreLengthYn)
                .HasColumnName("IGNORE_LENGTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromptYn)
                .HasColumnName("PROMPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TagRequiredYn)
                .HasColumnName("TAG_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XmlAttributeYn)
                .HasColumnName("XML_ATTRIBUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.XmlColType)
                .HasColumnName("XML_COL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

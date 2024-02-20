namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiExtRawDataColumn
{
    public string? DatamartName { get; set; }
    public string? RawDataName { get; set; }
    public string? ColumnName { get; set; }
    public string? DataType { get; set; }
    public string? IntColName { get; set; }
    public string? ExtColName { get; set; }
    public string? OperaColName { get; set; }
    public string? ColumnDesc { get; set; }
    public string? PrimaryKeyYn { get; set; }
    public string? DimMeasDm { get; set; }
    public string? TimeFrameDateYn { get; set; }
    public string? Formula { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? DataLength { get; set; }
    public string? HdrColYn { get; set; }
    public string? ColumnSeperator { get; set; }
    public string? ParentColumnName { get; set; }
    public string? ExtAttrColumn { get; set; }
    public string? FormatMask { get; set; }
    public string? OperaFormula { get; set; }
    public string? OperaFormatMask { get; set; }
    public string? OperaConversionCode { get; set; }
    public string? OperaDeleteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiExtRawDataColumn>(entity =>
        {
            entity.HasKey(e => new { e.DatamartName, e.RawDataName, e.ColumnName })
                .HasName("OBI_EXT_RAW_DATA_COLUMN_PK");

            entity.ToTable("OBI_EXT_RAW_DATA_COLUMN");

            entity.Property(e => e.DatamartName)
                .HasColumnName("DATAMART_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RawDataName)
                .HasColumnName("RAW_DATA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnDesc)
                .HasColumnName("COLUMN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ColumnSeperator)
                .HasColumnName("COLUMN_SEPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataLength)
                .HasColumnName("DATA_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(106)
                .IsUnicode(false);

            entity.Property(e => e.DimMeasDm)
                .HasColumnName("DIM_MEAS_DM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtAttrColumn)
                .HasColumnName("EXT_ATTR_COLUMN")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExtColName)
                .HasColumnName("EXT_COL_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.HdrColYn)
                .HasColumnName("HDR_COL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IntColName)
                .HasColumnName("INT_COL_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.OperaColName)
                .HasColumnName("OPERA_COL_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.OperaConversionCode)
                .HasColumnName("OPERA_CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OperaDeleteYn)
                .HasColumnName("OPERA_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperaFormatMask)
                .HasColumnName("OPERA_FORMAT_MASK")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OperaFormula)
                .HasColumnName("OPERA_FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentColumnName)
                .HasColumnName("PARENT_COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryKeyYn)
                .HasColumnName("PRIMARY_KEY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeFrameDateYn)
                .HasColumnName("TIME_FRAME_DATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

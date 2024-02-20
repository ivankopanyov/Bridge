namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpTempData
{
    public decimal? ExpDataId { get; set; }
    public string? ExpClobData { get; set; }
    public decimal? OxiGroupId { get; set; }
    public string? OxiResort { get; set; }
    public int? OxiUploadKeyId { get; set; }
    public string? OxiStatus { get; set; }
    public string? OxiRecordType { get; set; }
    public string? OxiFileName { get; set; }
    public DateTime? OxiInsertDate { get; set; }
    public string? OxiInterfaceId { get; set; }
    public string? OxiUploadType { get; set; }
    public byte[] ExpBlobData { get; set; }
    public DateTime? ExportDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? ExportType { get; set; }
    public string? FileName { get; set; }
    public string? PmsStatus { get; set; }
    public string? Resort { get; set; }
    public decimal? ExpFileId { get; set; }
    public string? AuthKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTempData>(entity =>
        {
            entity.HasKey(e => e.ExpDataId)
                .HasName("EXP_TEMP_DATA_PK");

            entity.ToTable("EXP_TEMP_DATA");

            entity.HasIndex(e => new { e.Resort, e.ExportType, e.ExportDate, e.FileName })
                .HasName("EXP_TEMP_DT_FILE_IDX");

            entity.HasIndex(e => new { e.OxiInterfaceId, e.OxiResort, e.PmsStatus, e.OxiStatus, e.OxiRecordType, e.OxiFileName })
                .HasName("EXP_TEMP_DATA_IDX1");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthKey)
                .HasColumnName("AUTH_KEY")
                .HasColumnType("CLOB");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpBlobData)
                .HasColumnName("EXP_BLOB_DATA")
                .HasColumnType("BLOB");

            entity.Property(e => e.ExpClobData)
                .HasColumnName("EXP_CLOB_DATA")
                .HasColumnType("CLOB");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportDate)
                .HasColumnName("EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OxiFileName)
                .HasColumnName("OXI_FILE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OxiGroupId)
                .HasColumnName("OXI_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OxiInsertDate)
                .HasColumnName("OXI_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OxiInterfaceId)
                .HasColumnName("OXI_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OxiRecordType)
                .HasColumnName("OXI_RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OxiResort)
                .HasColumnName("OXI_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OxiStatus)
                .HasColumnName("OXI_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OxiUploadKeyId)
                .HasColumnName("OXI_UPLOAD_KEY_ID")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.OxiUploadType)
                .HasColumnName("OXI_UPLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsStatus)
                .HasColumnName("PMS_STATUS")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}

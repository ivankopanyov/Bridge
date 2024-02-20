namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisExpFileHdr
{
    public decimal? ExpFileId { get; set; }
    public string? FileGroupId { get; set; }
    public string? FileType { get; set; }
    public string? FileTypeDesc { get; set; }
    public string? ProgramName { get; set; }
    public string? Company { get; set; }
    public string? SourceViewCode { get; set; }
    public string? FileName { get; set; }
    public string? FileExtension { get; set; }
    public string? FileLocation { get; set; }
    public string? ColSeperator { get; set; }
    public string? WhereClause { get; set; }
    public string? RunInNaYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? InactiveYn { get; set; }
    public string? ZipFileLoc { get; set; }
    public string? CompressdataYn { get; set; }
    public string? ZipFileName { get; set; }
    public string? PreExpProc { get; set; }
    public string? PostExpProc { get; set; }
    public string? ParameterForm { get; set; }
    public decimal? BatchSeq { get; set; }
    public string? Resort { get; set; }
    public string? FtpUploadYn { get; set; }
    public string? NaWhenToExport { get; set; }
    public decimal? ExportSequence { get; set; }
    public decimal? ParentId { get; set; }
    public string? AppendToFileYn { get; set; }
    public string? ComponentExportYn { get; set; }
    public string? XmlYn { get; set; }
    public string? XmlDocName { get; set; }
    public string? AutoExportYn { get; set; }
    public string? EncryptKey { get; set; }
    public string? EncryptType { get; set; }
    public string? SftpYn { get; set; }
    public string? HttpAddress { get; set; }
    public string? HttpUploadYn { get; set; }
    public string? OxiInterfaceId { get; set; }
    public string? SoapAction { get; set; }
    public string? TransferMethod { get; set; }
    public string? UploadType { get; set; }
    public decimal? LogLevel { get; set; }
    public string? ExportType { get; set; }
    public string? LargeRecLengthYn { get; set; }
    public string? XmlEncoding { get; set; }
    public string? XmlProcessingInstructions { get; set; }
    public string? XmlDocumentTypeName { get; set; }
    public string? XmlDocumentTypeSysid { get; set; }
    public string? XmlDocumentTypePubid { get; set; }
    public string? MultiPropertyYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisExpFileHdr>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_EXP_FILE_HDR");

            entity.Property(e => e.AppendToFileYn)
                .HasColumnName("APPEND_TO_FILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoExportYn)
                .HasColumnName("AUTO_EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BatchSeq)
                .HasColumnName("BATCH_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ColSeperator)
                .HasColumnName("COL_SEPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ComponentExportYn)
                .HasColumnName("COMPONENT_EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompressdataYn)
                .HasColumnName("COMPRESSDATA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EncryptKey)
                .HasColumnName("ENCRYPT_KEY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EncryptType)
                .HasColumnName("ENCRYPT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportSequence)
                .HasColumnName("EXPORT_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileExtension)
                .HasColumnName("FILE_EXTENSION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FileGroupId)
                .IsRequired()
                .HasColumnName("FILE_GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileLocation)
                .HasColumnName("FILE_LOCATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FileType)
                .IsRequired()
                .HasColumnName("FILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileTypeDesc)
                .HasColumnName("FILE_TYPE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FtpUploadYn)
                .HasColumnName("FTP_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HttpAddress)
                .HasColumnName("HTTP_ADDRESS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HttpUploadYn)
                .HasColumnName("HTTP_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LargeRecLengthYn)
                .HasColumnName("LARGE_REC_LENGTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LogLevel)
                .HasColumnName("LOG_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiPropertyYn)
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NaWhenToExport)
                .HasColumnName("NA_WHEN_TO_EXPORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OxiInterfaceId)
                .HasColumnName("OXI_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterForm)
                .HasColumnName("PARAMETER_FORM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParentId)
                .HasColumnName("PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostExpProc)
                .HasColumnName("POST_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PreExpProc)
                .HasColumnName("PRE_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RunInNaYn)
                .HasColumnName("RUN_IN_NA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SftpYn)
                .HasColumnName("SFTP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SoapAction)
                .HasColumnName("SOAP_ACTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceViewCode)
                .HasColumnName("SOURCE_VIEW_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TransferMethod)
                .HasColumnName("TRANSFER_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UploadType)
                .HasColumnName("UPLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.XmlDocName)
                .HasColumnName("XML_DOC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XmlDocumentTypeName)
                .HasColumnName("XML_DOCUMENT_TYPE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlDocumentTypePubid)
                .HasColumnName("XML_DOCUMENT_TYPE_PUBID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlDocumentTypeSysid)
                .HasColumnName("XML_DOCUMENT_TYPE_SYSID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XmlEncoding)
                .HasColumnName("XML_ENCODING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XmlProcessingInstructions)
                .HasColumnName("XML_PROCESSING_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.XmlYn)
                .HasColumnName("XML_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ZipFileLoc)
                .HasColumnName("ZIP_FILE_LOC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ZipFileName)
                .HasColumnName("ZIP_FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

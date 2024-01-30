namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpExportDefinition
{
    public string? RecordType { get; set; }
    public decimal? HdrExpFileId { get; set; }
    public string? HdrFileType { get; set; }
    public string? HdrFileGroupId { get; set; }
    public string? HdrResort { get; set; }
    public string? HdrFileTypeDesc { get; set; }
    public string? HdrProgramName { get; set; }
    public string? HdrCompany { get; set; }
    public string? HdrSourceViewCode { get; set; }
    public string? HdrSourceViewDescription { get; set; }
    public string? HdrFileName { get; set; }
    public string? HdrFileExtension { get; set; }
    public string? HdrFileLocation { get; set; }
    public string? HdrColSeperator { get; set; }
    public string? HdrWhereClause { get; set; }
    public string? HdrRunInNaYn { get; set; }
    public decimal? HdrInsertUser { get; set; }
    public DateTime? HdrInsertDate { get; set; }
    public decimal? HdrUpdateUser { get; set; }
    public DateTime? HdrUpdateDate { get; set; }
    public string? HdrInactiveYn { get; set; }
    public string? HdrZipFileLoc { get; set; }
    public string? HdrCompressdataYn { get; set; }
    public string? HdrZipFileName { get; set; }
    public string? HdrPreExpProc { get; set; }
    public string? HdrPostExpProc { get; set; }
    public string? HdrParameterForm { get; set; }
    public decimal? HdrBatchSeq { get; set; }
    public string? HdrAddNewlineYn { get; set; }
    public string? HdrNaFrequency { get; set; }
    public string? HdrAlwaysHdrfooterYn { get; set; }
    public string? HdrFtpUploadYn { get; set; }
    public string? HdrUploadType { get; set; }
    public string? HdrOxiInterfaceId { get; set; }
    public string? HdrHttpUploadYn { get; set; }
    public string? HdrHttpAddress { get; set; }
    public string? HdrNaWhenToExport { get; set; }
    public string? HdrComponentExportYn { get; set; }
    public decimal? HdrParentId { get; set; }
    public decimal? HdrExportSequence { get; set; }
    public string? HdrAppendToFileYn { get; set; }
    public string? HdrTransferMethod { get; set; }
    public string? HdrSoapAction { get; set; }
    public string? HdrXmlYn { get; set; }
    public string? HdrXmlDocName { get; set; }
    public decimal? DtlExpFileId { get; set; }
    public decimal? DtlExpFileDtlId { get; set; }
    public string? DtlColName { get; set; }
    public decimal? DtlColLength { get; set; }
    public string? DtlColFormat { get; set; }
    public string? DtlColAlignment { get; set; }
    public decimal? DtlOrderBy { get; set; }
    public string? DtlColType { get; set; }
    public string? DtlDatabaseYn { get; set; }
    public string? DtlFormula { get; set; }
    public decimal? DtlInsertUser { get; set; }
    public DateTime? DtlInsertDate { get; set; }
    public decimal? DtlUpdateUser { get; set; }
    public DateTime? DtlUpdateDate { get; set; }
    public string? DtlPromptYn { get; set; }
    public string? DtlDefaultValue { get; set; }
    public string? DtlGenDataType { get; set; }
    public string? DtlIgnoreLengthYn { get; set; }
    public string? DtlVariableLengthYn { get; set; }
    public decimal? DtlExpDtlLinkId { get; set; }
    public string? DtlXmlColType { get; set; }
    public string? DtlAddSourceView { get; set; }
    public string? DtlFilter { get; set; }
    public string? DtlTagRequiredYn { get; set; }
    public string? DtlXmlAttributeYn { get; set; }
    public decimal? DlvExpFileId { get; set; }
    public string? DlvCommType { get; set; }
    public string? DlvHostUrl { get; set; }
    public string? DlvUserId { get; set; }
    public string? DlvPassword { get; set; }
    public string? DlvDirectory { get; set; }
    public string? DlvSafeCreateYn { get; set; }
    public string? DlvTempDirectory { get; set; }
    public string? DlvFtpPassiveYn { get; set; }
    public string? DlvAsciiTransferYn { get; set; }
    public string? DlvCompressYn { get; set; }
    public string? DlvSoapYn { get; set; }
    public string? DlvSoapVersion { get; set; }
    public string? DlvSoapAction { get; set; }
    public decimal? DlvRetryCount { get; set; }
    public decimal? DlvRetryIntervalSec { get; set; }
    public DateTime? DlvDeliveryTime { get; set; }
    public string? DlvHxExportYn { get; set; }
    public string? DlvHxVersionNo { get; set; }
    public string? DlvHxSystemType { get; set; }
    public string? DlvDeliveryStatus { get; set; }
    public DateTime? DlvInsertDate { get; set; }
    public decimal? DlvInsertUser { get; set; }
    public DateTime? DlvUpdateDate { get; set; }
    public decimal? DlvUpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpExportDefinition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EXPORT_DEFINITION");

            entity.Property(e => e.DlvAsciiTransferYn)
                .HasColumnName("DLV_ASCII_TRANSFER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvCommType)
                .HasColumnName("DLV_COMM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DlvCompressYn)
                .HasColumnName("DLV_COMPRESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvDeliveryStatus)
                .HasColumnName("DLV_DELIVERY_STATUS")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.DlvDeliveryTime)
                .HasColumnName("DLV_DELIVERY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DlvDirectory)
                .HasColumnName("DLV_DIRECTORY")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DlvExpFileId)
                .HasColumnName("DLV_EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DlvFtpPassiveYn)
                .HasColumnName("DLV_FTP_PASSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvHostUrl)
                .HasColumnName("DLV_HOST_URL")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DlvHxExportYn)
                .HasColumnName("DLV_HX_EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvHxSystemType)
                .HasColumnName("DLV_HX_SYSTEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DlvHxVersionNo)
                .HasColumnName("DLV_HX_VERSION_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DlvInsertDate)
                .HasColumnName("DLV_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DlvInsertUser)
                .HasColumnName("DLV_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DlvPassword)
                .HasColumnName("DLV_PASSWORD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DlvRetryCount)
                .HasColumnName("DLV_RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DlvRetryIntervalSec)
                .HasColumnName("DLV_RETRY_INTERVAL_SEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DlvSafeCreateYn)
                .HasColumnName("DLV_SAFE_CREATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvSoapAction)
                .HasColumnName("DLV_SOAP_ACTION")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DlvSoapVersion)
                .HasColumnName("DLV_SOAP_VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DlvSoapYn)
                .HasColumnName("DLV_SOAP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DlvTempDirectory)
                .HasColumnName("DLV_TEMP_DIRECTORY")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DlvUpdateDate)
                .HasColumnName("DLV_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DlvUpdateUser)
                .HasColumnName("DLV_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DlvUserId)
                .HasColumnName("DLV_USER_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DtlAddSourceView)
                .HasColumnName("DTL_ADD_SOURCE_VIEW")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DtlColAlignment)
                .HasColumnName("DTL_COL_ALIGNMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtlColFormat)
                .HasColumnName("DTL_COL_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DtlColLength)
                .HasColumnName("DTL_COL_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlColName)
                .HasColumnName("DTL_COL_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DtlColType)
                .HasColumnName("DTL_COL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtlDatabaseYn)
                .HasColumnName("DTL_DATABASE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlDefaultValue)
                .HasColumnName("DTL_DEFAULT_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DtlExpDtlLinkId)
                .HasColumnName("DTL_EXP_DTL_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlExpFileDtlId)
                .HasColumnName("DTL_EXP_FILE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlExpFileId)
                .HasColumnName("DTL_EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlFilter)
                .HasColumnName("DTL_FILTER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DtlFormula)
                .HasColumnName("DTL_FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DtlGenDataType)
                .HasColumnName("DTL_GEN_DATA_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlIgnoreLengthYn)
                .HasColumnName("DTL_IGNORE_LENGTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlInsertDate)
                .HasColumnName("DTL_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DtlInsertUser)
                .HasColumnName("DTL_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlOrderBy)
                .HasColumnName("DTL_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlPromptYn)
                .HasColumnName("DTL_PROMPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlTagRequiredYn)
                .HasColumnName("DTL_TAG_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlUpdateDate)
                .HasColumnName("DTL_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DtlUpdateUser)
                .HasColumnName("DTL_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtlVariableLengthYn)
                .HasColumnName("DTL_VARIABLE_LENGTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlXmlAttributeYn)
                .HasColumnName("DTL_XML_ATTRIBUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DtlXmlColType)
                .HasColumnName("DTL_XML_COL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrAddNewlineYn)
                .HasColumnName("HDR_ADD_NEWLINE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrAlwaysHdrfooterYn)
                .HasColumnName("HDR_ALWAYS_HDRFOOTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrAppendToFileYn)
                .HasColumnName("HDR_APPEND_TO_FILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrBatchSeq)
                .HasColumnName("HDR_BATCH_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrColSeperator)
                .HasColumnName("HDR_COL_SEPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrCompany)
                .HasColumnName("HDR_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HdrComponentExportYn)
                .HasColumnName("HDR_COMPONENT_EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrCompressdataYn)
                .HasColumnName("HDR_COMPRESSDATA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrExpFileId)
                .HasColumnName("HDR_EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrExportSequence)
                .HasColumnName("HDR_EXPORT_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrFileExtension)
                .HasColumnName("HDR_FILE_EXTENSION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrFileGroupId)
                .HasColumnName("HDR_FILE_GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrFileLocation)
                .HasColumnName("HDR_FILE_LOCATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrFileName)
                .HasColumnName("HDR_FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrFileType)
                .HasColumnName("HDR_FILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrFileTypeDesc)
                .HasColumnName("HDR_FILE_TYPE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.HdrFtpUploadYn)
                .HasColumnName("HDR_FTP_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrHttpAddress)
                .HasColumnName("HDR_HTTP_ADDRESS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrHttpUploadYn)
                .HasColumnName("HDR_HTTP_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrInactiveYn)
                .HasColumnName("HDR_INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrInsertDate)
                .HasColumnName("HDR_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HdrInsertUser)
                .HasColumnName("HDR_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrNaFrequency)
                .HasColumnName("HDR_NA_FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrNaWhenToExport)
                .HasColumnName("HDR_NA_WHEN_TO_EXPORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrOxiInterfaceId)
                .HasColumnName("HDR_OXI_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HdrParameterForm)
                .HasColumnName("HDR_PARAMETER_FORM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.HdrParentId)
                .HasColumnName("HDR_PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrPostExpProc)
                .HasColumnName("HDR_POST_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrPreExpProc)
                .HasColumnName("HDR_PRE_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrProgramName)
                .HasColumnName("HDR_PROGRAM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HdrResort)
                .HasColumnName("HDR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrRunInNaYn)
                .HasColumnName("HDR_RUN_IN_NA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrSoapAction)
                .HasColumnName("HDR_SOAP_ACTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrSourceViewCode)
                .HasColumnName("HDR_SOURCE_VIEW_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HdrSourceViewDescription)
                .HasColumnName("HDR_SOURCE_VIEW_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrTransferMethod)
                .HasColumnName("HDR_TRANSFER_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HdrUpdateDate)
                .HasColumnName("HDR_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HdrUpdateUser)
                .HasColumnName("HDR_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HdrUploadType)
                .HasColumnName("HDR_UPLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrWhereClause)
                .HasColumnName("HDR_WHERE_CLAUSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrXmlDocName)
                .HasColumnName("HDR_XML_DOC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HdrXmlYn)
                .HasColumnName("HDR_XML_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HdrZipFileLoc)
                .HasColumnName("HDR_ZIP_FILE_LOC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HdrZipFileName)
                .HasColumnName("HDR_ZIP_FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(3)");
        });
	}
}

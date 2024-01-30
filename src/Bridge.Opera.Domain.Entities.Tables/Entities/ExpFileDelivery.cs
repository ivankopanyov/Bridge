namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpFileDelivery
{
    public decimal? ExpFileId { get; set; }
    public string? CommType { get; set; }
    public string? HostUrl { get; set; }
    public string? UserId { get; set; }
    public string? Password { get; set; }
    public string? Directory { get; set; }
    public string? SafeCreateYn { get; set; }
    public string? TempDirectory { get; set; }
    public string? FtpPassiveYn { get; set; }
    public string? AsciiTransferYn { get; set; }
    public string? CompressYn { get; set; }
    public string? SoapYn { get; set; }
    public string? SoapVersion { get; set; }
    public string? SoapAction { get; set; }
    public decimal? RetryCount { get; set; }
    public decimal? RetryIntervalSec { get; set; }
    public DateTime? DeliveryTime { get; set; }
    public string? HxExportYn { get; set; }
    public string? HxVersionNo { get; set; }
    public string? HxSystemType { get; set; }
    public string? DeliveryStatus { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ValidYn { get; set; }
    public DateTime? ValidUpdateDate { get; set; }
    public byte[] SftpPrivateKey { get; set; }

    public virtual ExpFileHdr ExpFile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpFileDelivery>(entity =>
        {
            entity.HasKey(e => e.ExpFileId)
                .HasName("EXP_FILE_DELIV_PK");

            entity.ToTable("EXP_FILE_DELIVERY");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AsciiTransferYn)
                .IsRequired()
                .HasColumnName("ASCII_TRANSFER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.CommType)
                .IsRequired()
                .HasColumnName("COMM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompressYn)
                .IsRequired()
                .HasColumnName("COMPRESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.DeliveryStatus)
                .HasColumnName("DELIVERY_STATUS")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryTime)
                .HasColumnName("DELIVERY_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Directory)
                .HasColumnName("DIRECTORY")
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FtpPassiveYn)
                .IsRequired()
                .HasColumnName("FTP_PASSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.HostUrl)
                .HasColumnName("HOST_URL")
                .HasMaxLength(250)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HxExportYn)
                .IsRequired()
                .HasColumnName("HX_EXPORT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.HxSystemType)
                .HasColumnName("HX_SYSTEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HxVersionNo)
                .HasColumnName("HX_VERSION_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER(38)")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.RetryIntervalSec)
                .HasColumnName("RETRY_INTERVAL_SEC")
                .HasColumnType("NUMBER(38)")
                .HasDefaultValueSql("3600");

            entity.Property(e => e.SafeCreateYn)
                .IsRequired()
                .HasColumnName("SAFE_CREATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.SftpPrivateKey)
                .HasColumnName("SFTP_PRIVATE_KEY")
                .HasColumnType("BLOB");

            entity.Property(e => e.SoapAction)
                .HasColumnName("SOAP_ACTION")
                .HasMaxLength(250)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SoapVersion)
                .HasColumnName("SOAP_VERSION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SoapYn)
                .IsRequired()
                .HasColumnName("SOAP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.TempDirectory)
                .HasColumnName("TEMP_DIRECTORY")
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ValidUpdateDate)
                .HasColumnName("VALID_UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExpFileHdr)))
				entity.Ignore(e => e.ExpFile);
			else
	            entity.HasOne(d => d.ExpFile)
	                .WithOne(p => p.ExpFileDelivery)
	                .HasForeignKey<ExpFileDelivery>(d => d.ExpFileId)
	                .HasConstraintName("EXP_FILE_DELIV_FK_EFH");
        });
	}
}

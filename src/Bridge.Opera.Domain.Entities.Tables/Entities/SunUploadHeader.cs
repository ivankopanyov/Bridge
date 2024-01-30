namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SunUploadHeader
{
    public SunUploadHeader()
    {
        SunUploadDetail = new HashSet<SunUploadDetail>();
    }

    public decimal? HeaderId { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? RecordType { get; set; }
    public string? Version { get; set; }
    public string? BankCode { get; set; }
    public string? MerchantUsn { get; set; }
    public string? FileProcessingDate { get; set; }
    public string? ApplicationId { get; set; }
    public string? MerchantName { get; set; }
    public string? Status { get; set; }

    public virtual ICollection<SunUploadDetail> SunUploadDetail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SunUploadHeader>(entity =>
        {
            entity.HasKey(e => e.HeaderId)
                .HasName("SUN_UPLOAD_HEADER_PK");

            entity.ToTable("SUN_UPLOAD_HEADER");

            entity.HasIndex(e => new { e.MerchantName, e.TrxDate })
                .HasName("SUN_UPLOAD_HEADER_UK")
                .IsUnique();

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApplicationId)
                .HasColumnName("APPLICATION_ID")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasColumnName("BANK_CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.FileProcessingDate)
                .HasColumnName("FILE_PROCESSING_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.MerchantName)
                .HasColumnName("MERCHANT_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MerchantUsn)
                .HasColumnName("MERCHANT_USN")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(3)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(SunUploadDetail)))
				entity.Ignore(e => e.SunUploadDetail);
		});
	}
}

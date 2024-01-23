namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaptopDownloadRecords
{
    public string Resort { get; set; }
    public string RecordType { get; set; }
    public decimal RecordId { get; set; }
    public decimal AccountId { get; set; }
    public decimal SrepId { get; set; }
    public string DownloadMode { get; set; }
    public decimal? BlobId { get; set; }
    public string RecordStatus { get; set; }
    public DateTime? ExpectedCheckin { get; set; }
    public DateTime? DownloadDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaptopDownloadRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("LAPTOP$DOWNLOAD$RECORDS");

            entity.HasIndex(e => new { e.SrepId, e.RecordType, e.RecordStatus, e.AccountId })
                .HasName("LDR1_SREP_IDX");

            entity.HasIndex(e => new { e.Resort, e.SrepId, e.RecordId, e.RecordType, e.RecordStatus })
                .HasName("LDR1_RESORT_IDX");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadMode)
                .HasColumnName("DOWNLOAD_MODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ExpectedCheckin)
                .HasColumnName("EXPECTED_CHECKIN")
                .HasColumnType("DATE");

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordStatus)
                .HasColumnName("RECORD_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PimDownloadRecords
{
    public string Resort { get; set; }
    public string RecordType { get; set; }
    public decimal RecordId { get; set; }
    public decimal SrepId { get; set; }
    public string DownloadMode { get; set; }
    public decimal? BlobId { get; set; }
    public string RecordStatus { get; set; }
    public DateTime? ExpectedCheckin { get; set; }
    public DateTime? DownloadDate { get; set; }
    public string PimId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PimDownloadRecords>(entity =>
        {
            entity.HasKey(e => new { e.RecordType, e.RecordId, e.Resort, e.SrepId })
                .HasName("PDR_PK");

            entity.ToTable("PIM$DOWNLOAD$RECORDS");

            entity.HasIndex(e => new { e.SrepId, e.RecordType, e.RecordId })
                .HasName("PDR_SREP_IDX");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadMode)
                .HasColumnName("DOWNLOAD_MODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ExpectedCheckin)
                .HasColumnName("EXPECTED_CHECKIN")
                .HasColumnType("DATE");

            entity.Property(e => e.PimId)
                .HasColumnName("PIM_ID")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RecordStatus)
                .HasColumnName("RECORD_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

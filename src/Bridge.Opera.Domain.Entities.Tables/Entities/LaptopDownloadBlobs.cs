namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaptopDownloadBlobs
{
    public decimal? SrepId { get; set; }
    public decimal? BlobId { get; set; }
    public byte[] BlobItem { get; set; }
    public string? ClobItem { get; set; }
    public string? TransferYn { get; set; }
    public string? Origin { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaptopDownloadBlobs>(entity =>
        {
            entity.HasKey(e => e.BlobId)
                .HasName("LDB_PK");

            entity.ToTable("LAPTOP$DOWNLOAD$BLOBS");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobItem)
                .HasColumnName("BLOB_ITEM")
                .HasColumnType("BLOB");

            entity.Property(e => e.ClobItem)
                .HasColumnName("CLOB_ITEM")
                .HasColumnType("CLOB");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Origin)
                .HasColumnName("ORIGIN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferYn)
                .HasColumnName("TRANSFER_YN")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

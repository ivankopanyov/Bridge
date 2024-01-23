namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BlobTransferArea
{
    public decimal BlobId { get; set; }
    public byte[] BlobItem { get; set; }
    public DateTime? InsertDate { get; set; }
    public string FileName { get; set; }
    public string ClobItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlobTransferArea>(entity =>
        {
            entity.HasKey(e => e.BlobId)
                .HasName("BTA_PK");

            entity.ToTable("BLOB_TRANSFER_AREA");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobItem)
                .HasColumnName("BLOB_ITEM")
                .HasColumnType("BLOB");

            entity.Property(e => e.ClobItem)
                .HasColumnName("CLOB_ITEM")
                .HasColumnType("CLOB");

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");
        });
	}
}

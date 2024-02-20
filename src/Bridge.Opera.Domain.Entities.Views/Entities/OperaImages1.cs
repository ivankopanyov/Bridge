namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaImages1
{
    public decimal? BlobId { get; set; }
    public string? BlobType { get; set; }
    public byte[] BlobItem { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ImgType { get; set; }
    public byte[] BfileLocator { get; set; }
    public byte[] ImageBlob { get; set; }
    public decimal? ImageSize { get; set; }
    public decimal? AttachId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaImages1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_IMAGES");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BfileLocator)
                .HasColumnName("BFILE_LOCATOR")
                .HasColumnType("BFILE");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobItem)
                .HasColumnName("BLOB_ITEM")
                .HasColumnType("BLOB");

            entity.Property(e => e.BlobType)
                .HasColumnName("BLOB_TYPE")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ImageBlob)
                .HasColumnName("IMAGE_BLOB")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageSize)
                .HasColumnName("IMAGE_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImgType)
                .IsRequired()
                .HasColumnName("IMG_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}

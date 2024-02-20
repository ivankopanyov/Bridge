namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScBlob
{
    public decimal? BlobId { get; set; }
    public string? BlobType { get; set; }
    public byte[] BlobItem { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ImgType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScBlob>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_BLOB");

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

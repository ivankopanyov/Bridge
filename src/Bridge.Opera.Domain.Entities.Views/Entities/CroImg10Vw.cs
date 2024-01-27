namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CroImg10Vw
{
    public string CroCode { get; set; }
    public string CroFeature01 { get; set; }
    public string Description01 { get; set; }
    public decimal? BlobId01 { get; set; }
    public byte[] ImageBlob01 { get; set; }
    public string CroFeature02 { get; set; }
    public string Description02 { get; set; }
    public decimal? BlobId02 { get; set; }
    public byte[] ImageBlob02 { get; set; }
    public string CroFeature03 { get; set; }
    public string Description03 { get; set; }
    public decimal? BlobId03 { get; set; }
    public byte[] ImageBlob03 { get; set; }
    public string CroFeature04 { get; set; }
    public string Description04 { get; set; }
    public decimal? BlobId04 { get; set; }
    public byte[] ImageBlob04 { get; set; }
    public string CroFeature05 { get; set; }
    public string Description05 { get; set; }
    public decimal? BlobId05 { get; set; }
    public byte[] ImageBlob05 { get; set; }
    public string CroFeature06 { get; set; }
    public string Description06 { get; set; }
    public decimal? BlobId06 { get; set; }
    public byte[] ImageBlob06 { get; set; }
    public string CroFeature07 { get; set; }
    public string Description07 { get; set; }
    public decimal? BlobId07 { get; set; }
    public byte[] ImageBlob07 { get; set; }
    public string CroFeature08 { get; set; }
    public string Description08 { get; set; }
    public decimal? BlobId08 { get; set; }
    public byte[] ImageBlob08 { get; set; }
    public string CroFeature09 { get; set; }
    public string Description09 { get; set; }
    public decimal? BlobId09 { get; set; }
    public byte[] ImageBlob09 { get; set; }
    public string CroFeature10 { get; set; }
    public string Description10 { get; set; }
    public decimal? BlobId10 { get; set; }
    public byte[] ImageBlob10 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CroImg10Vw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CRO_IMG10_VW");

            entity.Property(e => e.BlobId01)
                .HasColumnName("BLOB_ID_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId02)
                .HasColumnName("BLOB_ID_02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId03)
                .HasColumnName("BLOB_ID_03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId04)
                .HasColumnName("BLOB_ID_04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId05)
                .HasColumnName("BLOB_ID_05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId06)
                .HasColumnName("BLOB_ID_06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId07)
                .HasColumnName("BLOB_ID_07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId08)
                .HasColumnName("BLOB_ID_08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId09)
                .HasColumnName("BLOB_ID_09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId10)
                .HasColumnName("BLOB_ID_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CroCode)
                .IsRequired()
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature01)
                .HasColumnName("CRO_FEATURE_01")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature02)
                .HasColumnName("CRO_FEATURE_02")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature03)
                .HasColumnName("CRO_FEATURE_03")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature04)
                .HasColumnName("CRO_FEATURE_04")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature05)
                .HasColumnName("CRO_FEATURE_05")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature06)
                .HasColumnName("CRO_FEATURE_06")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature07)
                .HasColumnName("CRO_FEATURE_07")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature08)
                .HasColumnName("CRO_FEATURE_08")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature09)
                .HasColumnName("CRO_FEATURE_09")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroFeature10)
                .HasColumnName("CRO_FEATURE_10")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description01)
                .HasColumnName("DESCRIPTION_01")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description02)
                .HasColumnName("DESCRIPTION_02")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description03)
                .HasColumnName("DESCRIPTION_03")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description04)
                .HasColumnName("DESCRIPTION_04")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description05)
                .HasColumnName("DESCRIPTION_05")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description06)
                .HasColumnName("DESCRIPTION_06")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description07)
                .HasColumnName("DESCRIPTION_07")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description08)
                .HasColumnName("DESCRIPTION_08")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description09)
                .HasColumnName("DESCRIPTION_09")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description10)
                .HasColumnName("DESCRIPTION_10")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ImageBlob01)
                .HasColumnName("IMAGE_BLOB_01")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob02)
                .HasColumnName("IMAGE_BLOB_02")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob03)
                .HasColumnName("IMAGE_BLOB_03")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob04)
                .HasColumnName("IMAGE_BLOB_04")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob05)
                .HasColumnName("IMAGE_BLOB_05")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob06)
                .HasColumnName("IMAGE_BLOB_06")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob07)
                .HasColumnName("IMAGE_BLOB_07")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob08)
                .HasColumnName("IMAGE_BLOB_08")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob09)
                .HasColumnName("IMAGE_BLOB_09")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageBlob10)
                .HasColumnName("IMAGE_BLOB_10")
                .HasColumnType("BLOB");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CroImages
{
    public string? CroFeature { get; set; }
    public decimal? BlobId { get; set; }
    public string? Description { get; set; }
    public string? FeatureDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CroImages>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CRO_IMAGES");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CroFeature)
                .IsRequired()
                .HasColumnName("CRO_FEATURE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FeatureDescription)
                .HasColumnName("FEATURE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

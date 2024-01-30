namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiStRevBuckDim
{
    public string? AllId { get; set; }
    public string? AllDesc { get; set; }
    public string? RevBucketCode { get; set; }
    public string? RevBucketDesc { get; set; }
    public string? ResortId { get; set; }
    public string? RevBucketCodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiStRevBuckDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ST_REV_BUCK_DIM");

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllId)
                .HasColumnName("ALL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.RevBucketCode)
                .HasColumnName("REV_BUCKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RevBucketCodeKey)
                .HasColumnName("REV_BUCKET_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RevBucketDesc)
                .HasColumnName("REV_BUCKET_DESC")
                .IsUnicode(false);
        });
	}
}

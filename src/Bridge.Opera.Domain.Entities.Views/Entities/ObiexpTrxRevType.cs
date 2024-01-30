namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpTrxRevType
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllId { get; set; }
    public string? AllDesc { get; set; }
    public string? RevBucketCode { get; set; }
    public string? RevBucketDesc { get; set; }
    public string? ResortId { get; set; }
    public string? RevBucketCodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpTrxRevType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_TRX_REV_TYPE");

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllId)
                .HasColumnName("ALL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevBucketCode)
                .IsRequired()
                .HasColumnName("REV_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevBucketCodeKey)
                .HasColumnName("REV_BUCKET_CODE_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RevBucketDesc)
                .HasColumnName("REV_BUCKET_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}

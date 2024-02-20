namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportBucketAmounts
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ExportBucketType { get; set; }
    public string? ExportBucketCode { get; set; }
    public decimal? ExportBucketId { get; set; }
    public decimal? Amount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportBucketAmounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_BUCKET_AMOUNTS");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportBucketCode)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportBucketId)
                .HasColumnName("EXPORT_BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportBucketType)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}

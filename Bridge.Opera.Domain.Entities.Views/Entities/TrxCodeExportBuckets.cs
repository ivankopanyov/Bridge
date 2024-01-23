namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxCodeExportBuckets
{
    public string Resort { get; set; }
    public string ExportBucketType { get; set; }
    public string ExportBucketCode { get; set; }
    public decimal ArrangementId { get; set; }
    public string TrxCode { get; set; }
    public string EligibleYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeExportBuckets>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_CODE_EXPORT_BUCKETS");

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EligibleYn)
                .HasColumnName("ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketCode)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketType)
                .HasColumnName("EXPORT_BUCKET_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

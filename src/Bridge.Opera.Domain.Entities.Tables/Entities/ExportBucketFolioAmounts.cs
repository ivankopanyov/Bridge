namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExportBucketFolioAmounts
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ExportBucketType { get; set; }
    public string ExportBucketCode { get; set; }
    public decimal? ExportBucketId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? FolioView { get; set; }

    public virtual ExportBucketTypes ExportBucketTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportBucketFolioAmounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXPORT_BUCKET_FOLIO_AMOUNTS");

            entity.HasIndex(e => new { e.Resort, e.ExportBucketType, e.ExportBucketCode })
                .HasName("EBA_EBT_FKI");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.ExportBucketType, e.ExportBucketCode, e.FolioView })
                .HasName("EBA_UK")
                .IsUnique();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportBucketCode)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketId)
                .HasColumnName("EXPORT_BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportBucketType)
                .IsRequired()
                .HasColumnName("EXPORT_BUCKET_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ExportBucketTypes)))
				entity.Ignore(e => e.ExportBucketTypes);
			else
	            entity.HasOne(d => d.ExportBucketTypes)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.Resort, p.ExportBucketType })
	                .HasForeignKey(d => new { d.Resort, d.ExportBucketType })
	                .HasConstraintName("EBA_EBT_FK");
        });
	}
}

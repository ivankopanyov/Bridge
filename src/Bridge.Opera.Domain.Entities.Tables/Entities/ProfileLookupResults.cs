namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileLookupResults
{
    public decimal? RequestId { get; set; }
    public string? DatabaseId { get; set; }
    public decimal? DatasetRowCount { get; set; }
    public string? SuccessYn { get; set; }
    public string? ProcessingMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileLookupResults>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.DatabaseId })
                .HasName("PLR_PK");

            entity.ToTable("PROFILE_LOOKUP_RESULTS");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatasetRowCount)
                .HasColumnName("DATASET_ROW_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.SuccessYn)
                .HasColumnName("SUCCESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

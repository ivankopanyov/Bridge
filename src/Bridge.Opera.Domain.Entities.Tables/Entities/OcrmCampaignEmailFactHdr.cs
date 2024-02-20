namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaignEmailFactHdr
{
    public decimal? ProcessBatchId { get; set; }
    public string? BatchComputeStatus { get; set; }
    public DateTime? BatchComputeDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaignEmailFactHdr>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OCRM_CAMPAIGN_EMAIL_FACT_HDR");

            entity.HasIndex(e => e.BatchComputeStatus)
                .HasName("CAMP_FACT_HDR_IDX2");

            entity.HasIndex(e => e.ProcessBatchId)
                .HasName("CAMP_FACT_HDR_IDX1");

            entity.Property(e => e.BatchComputeDate)
                .HasColumnName("BATCH_COMPUTE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchComputeStatus)
                .HasColumnName("BATCH_COMPUTE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessBatchId)
                .HasColumnName("PROCESS_BATCH_ID")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaignEmailFacts
{
    public decimal FactRecId { get; set; }
    public decimal DateId { get; set; }
    public decimal? CampaignId { get; set; }
    public decimal? SegBatchId { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public string RecordLocator { get; set; }
    public string DataSource { get; set; }
    public decimal? EmailSend { get; set; }
    public decimal? OpenEmail { get; set; }
    public decimal? ClicksOnEmail { get; set; }
    public decimal? Bounce { get; set; }
    public decimal? SoftBounce { get; set; }
    public decimal? HardBounce { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaignEmailFacts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OCRM_CAMPAIGN_EMAIL_FACTS");

            entity.HasIndex(e => e.FactRecId)
                .HasName("OCRM_EMAIL_FACTS_IDX01");

            entity.HasIndex(e => e.OcrmProfileId)
                .HasName("OCRM_EMAIL_FACTS_IDX03");

            entity.HasIndex(e => new { e.CampaignId, e.SegBatchId, e.OcrmProfileId, e.RecordLocator, e.DataSource, e.DateId })
                .HasName("OCRM_EMAIL_FACTS_IDX02");

            entity.Property(e => e.Bounce)
                .HasColumnName("BOUNCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClicksOnEmail)
                .HasColumnName("CLICKS_ON_EMAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateId)
                .HasColumnName("DATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailSend)
                .HasColumnName("EMAIL_SEND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FactRecId)
                .HasColumnName("FACT_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HardBounce)
                .HasColumnName("HARD_BOUNCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenEmail)
                .HasColumnName("OPEN_EMAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordLocator)
                .HasColumnName("RECORD_LOCATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SoftBounce)
                .HasColumnName("SOFT_BOUNCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

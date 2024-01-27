namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmCampEmailFactVw
{
    public decimal FactRecId { get; set; }
    public decimal DateId { get; set; }
    public string DateType { get; set; }
    public string DateCode { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal? CampaignId { get; set; }
    public string DataSource { get; set; }
    public decimal? EmailSend { get; set; }
    public decimal? OpenEmail { get; set; }
    public decimal? ClicksOnEmail { get; set; }
    public decimal? Bounce { get; set; }
    public decimal? SoftBounce { get; set; }
    public decimal? HardBounce { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampEmailFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_CAMP_EMAIL_FACT_VW");

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

            entity.Property(e => e.DateCode)
                .IsRequired()
                .HasColumnName("DATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateId)
                .HasColumnName("DATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateType)
                .IsRequired()
                .HasColumnName("DATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailSend)
                .HasColumnName("EMAIL_SEND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FactRecId)
                .HasColumnName("FACT_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HardBounce)
                .HasColumnName("HARD_BOUNCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenEmail)
                .HasColumnName("OPEN_EMAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SoftBounce)
                .HasColumnName("SOFT_BOUNCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}

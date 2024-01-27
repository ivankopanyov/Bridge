namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmCmpgnResvStayVw
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string DataSource { get; set; }
    public decimal? LegNo { get; set; }
    public decimal? NameId { get; set; }
    public decimal CampaignId { get; set; }
    public string PromotionCode { get; set; }
    public string CampaignCode { get; set; }
    public DateTime? CampaignBeginDate { get; set; }
    public DateTime? CampaignEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCmpgnResvStayVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_CMPGN_RESV_STAY_VW");

            entity.Property(e => e.CampaignBeginDate)
                .HasColumnName("CAMPAIGN_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasColumnName("CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignEndDate)
                .HasColumnName("CAMPAIGN_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LegNo)
                .HasColumnName("LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}

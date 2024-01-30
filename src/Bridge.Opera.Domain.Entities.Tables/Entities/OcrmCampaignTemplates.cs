namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaignTemplates
{
    public decimal? CampaignId { get; set; }
    public string? TemplateCode { get; set; }
    public string? Resort { get; set; }
    public string? DefaultYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaignTemplates>(entity =>
        {
            entity.HasKey(e => new { e.CampaignId, e.TemplateCode, e.Resort })
                .HasName("OCCT_PK");

            entity.ToTable("OCRM_CAMPAIGN_TEMPLATES");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TemplateCode)
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

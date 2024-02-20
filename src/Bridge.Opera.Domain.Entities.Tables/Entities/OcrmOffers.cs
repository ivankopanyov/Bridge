namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmOffers
{
    public OcrmOffers()
    {
        OcrmResvStayOfferLink = new HashSet<OcrmResvStayOfferLink>();
    }

    public decimal? OfferId { get; set; }
    public string? OfferType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? CampaignId { get; set; }
    public string? Resort { get; set; }
    public string? PromotionCode { get; set; }

    public virtual OcrmCampaigns Campaign { get; set; }
    public virtual ICollection<OcrmResvStayOfferLink> OcrmResvStayOfferLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmOffers>(entity =>
        {
            entity.HasKey(e => e.OfferId)
                .HasName("OCOF_PK");

            entity.ToTable("OCRM_OFFERS");

            entity.HasIndex(e => e.CampaignId)
                .HasName("OCRM_OFFER_IND01");

            entity.HasIndex(e => new { e.OfferType, e.Resort, e.PromotionCode })
                .HasName("OCRM_OFFERS__IND02");

            entity.Property(e => e.OfferId)
                .HasColumnName("OFFER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OfferType)
                .IsRequired()
                .HasColumnName("OFFER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OcrmCampaigns)))
				entity.Ignore(e => e.Campaign);
			else
	            entity.HasOne(d => d.Campaign)
	                .WithMany(p => p.OcrmOffers)
	                .HasForeignKey(d => d.CampaignId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCRM_OFFERS_CAMPAIGNS_FK");
        
			if (!types.Contains(typeof(OcrmResvStayOfferLink)))
				entity.Ignore(e => e.OcrmResvStayOfferLink);
		});
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmResvStayOfferLink
{
    public decimal ResvLinkId { get; set; }
    public decimal OfferId { get; set; }
    public decimal CampaignId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OcrmCampaigns Campaign { get; set; }
    public virtual OcrmOffers Offer { get; set; }
    public virtual OcrmResvStayLink ResvLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmResvStayOfferLink>(entity =>
        {
            entity.HasKey(e => new { e.ResvLinkId, e.CampaignId, e.OfferId })
                .HasName("OCRM_RESV_STAY_OFFER_LINK_PK");

            entity.ToTable("OCRM_RESV_STAY_OFFER_LINK");

            entity.HasIndex(e => e.CampaignId)
                .HasName("OCRM_RS_OFFER_LINK_IDX01");

            entity.HasIndex(e => e.OfferId)
                .HasName("OCRM_RS_OFFER_LINK_IDX02");

            entity.Property(e => e.ResvLinkId)
                .HasColumnName("RESV_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OfferId)
                .HasColumnName("OFFER_ID")
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
	                .WithMany(p => p.OcrmResvStayOfferLink)
	                .HasForeignKey(d => d.CampaignId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCRM_OSL_FK03");

			if (!types.Contains(typeof(OcrmOffers)))
				entity.Ignore(e => e.Offer);
			else
	            entity.HasOne(d => d.Offer)
	                .WithMany(p => p.OcrmResvStayOfferLink)
	                .HasForeignKey(d => d.OfferId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCRM_OSL_FK02");

			if (!types.Contains(typeof(OcrmResvStayLink)))
				entity.Ignore(e => e.ResvLink);
			else
	            entity.HasOne(d => d.ResvLink)
	                .WithMany(p => p.OcrmResvStayOfferLink)
	                .HasForeignKey(d => d.ResvLinkId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCRM_OSL_FK01");
        });
	}
}

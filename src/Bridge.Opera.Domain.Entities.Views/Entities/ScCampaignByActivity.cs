namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScCampaignByActivity
{
    public string Type { get; set; }
    public decimal ActId { get; set; }
    public string ActResort { get; set; }
    public string PrimaryYn { get; set; }
    public string CampaingProperty { get; set; }
    public decimal CampaignId { get; set; }
    public string CampaignName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScCampaignByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_CAMPAIGN_BY_ACTIVITY");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActResort)
                .HasColumnName("ACT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignName)
                .HasColumnName("CAMPAIGN_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CampaingProperty)
                .IsRequired()
                .HasColumnName("CAMPAING_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

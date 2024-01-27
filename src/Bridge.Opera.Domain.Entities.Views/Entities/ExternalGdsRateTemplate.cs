namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExternalGdsRateTemplate
{
    public string RateCode { get; set; }
    public string Description { get; set; }
    public string GdsHost { get; set; }
    public string GdsRateCode { get; set; }
    public string GdsRateCategory { get; set; }
    public string GdsRateLevel { get; set; }
    public string NegRateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalGdsRateTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXTERNAL_GDS_RATE_TEMPLATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategory)
                .HasColumnName("GDS_RATE_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode)
                .HasColumnName("GDS_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GdsRateLevel)
                .HasColumnName("GDS_RATE_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.NegRateCode)
                .HasColumnName("NEG_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);
        });
	}
}

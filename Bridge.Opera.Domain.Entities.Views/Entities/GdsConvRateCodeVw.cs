namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsConvRateCodeVw
{
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string GdsRateCode { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string GdsRateCodeName { get; set; }
    public string GdsRateDescription { get; set; }
    public string GdsRateCategory { get; set; }
    public string GdsRateLevel { get; set; }
    public decimal? GdsRateCodeOrder { get; set; }
    public string RatesToGdsYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string RateCreateYn { get; set; }
    public string RateUpdateYn { get; set; }
    public DateTime? RateUpdateDate { get; set; }
    public string ActivateYn { get; set; }
    public string GdsRateShortDesc { get; set; }
    public string AvailabilityUpdateYn { get; set; }
    public string DisplayRegionalYn { get; set; }
    public string BlockRateIndicator { get; set; }
    public string Rp1 { get; set; }
    public string Rp2 { get; set; }
    public string Rp3 { get; set; }
    public string Rpd { get; set; }
    public string PromoCode { get; set; }
    public string PublicYn { get; set; }
    public string BbarYn { get; set; }
    public decimal? RateTier { get; set; }
    public string ResvPromotionCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvRateCodeVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_CONV_RATE_CODE_VW");

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AvailabilityUpdateYn)
                .HasColumnName("AVAILABILITY_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BbarYn)
                .HasColumnName("BBAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockRateIndicator)
                .HasColumnName("BLOCK_RATE_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplayRegionalYn)
                .HasColumnName("DISPLAY_REGIONAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategory)
                .HasColumnName("GDS_RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCodeName)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCodeOrder)
                .HasColumnName("GDS_RATE_CODE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GdsRateDescription)
                .HasColumnName("GDS_RATE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateLevel)
                .HasColumnName("GDS_RATE_LEVEL")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateShortDesc)
                .HasColumnName("GDS_RATE_SHORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PublicYn)
                .HasColumnName("PUBLIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCreateYn)
                .IsRequired()
                .HasColumnName("RATE_CREATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateUpdateDate)
                .HasColumnName("RATE_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateUpdateYn)
                .IsRequired()
                .HasColumnName("RATE_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RatesToGdsYn)
                .HasColumnName("RATES_TO_GDS_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvPromotionCode)
                .HasColumnName("RESV_PROMOTION_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Rp1)
                .HasColumnName("RP1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Rp2)
                .HasColumnName("RP2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Rp3)
                .HasColumnName("RP3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Rpd)
                .HasColumnName("RPD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

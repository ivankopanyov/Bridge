namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OneTimePromoCouponresortVw
{
    public string? PromotionType { get; set; }
    public string? CouponCode { get; set; }
    public string? Resort { get; set; }
    public string? VbhResort { get; set; }
    public string? BenefitSummary { get; set; }
    public string? AvailOnlyYn { get; set; }
    public string? PromotionCode { get; set; }
    public string? PromoName { get; set; }
    public string? Status { get; set; }
    public string? IsCouponAvailableYn { get; set; }
    public decimal? UsedInResvNameId { get; set; }
    public string? UsedInResvResort { get; set; }
    public string? InactiveYn { get; set; }
    public string? VoucherBenefitCode { get; set; }
    public DateTime? VbhBeginDate { get; set; }
    public DateTime? VbhEndDate { get; set; }
    public DateTime? VbhInactiveDate { get; set; }
    public DateTime? PromoBookingStartdate { get; set; }
    public DateTime? PromoBookingEnddate { get; set; }
    public DateTime? PromoStayStartdate { get; set; }
    public DateTime? PromoStayEnddate { get; set; }
    public string? PromoInstructions { get; set; }
    public string? CategoryDesc { get; set; }
    public string? PromoInformation { get; set; }
    public string? DatabaseId { get; set; }
    public string? OtpcUiFlg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OneTimePromoCouponresortVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ONE_TIME_PROMO_COUPONRESORT_VW");

            entity.Property(e => e.AvailOnlyYn)
                .HasColumnName("AVAIL_ONLY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.BenefitSummary)
                .HasColumnName("BENEFIT_SUMMARY")
                .IsUnicode(false);

            entity.Property(e => e.CategoryDesc)
                .HasColumnName("CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CouponCode)
                .HasColumnName("COUPON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsCouponAvailableYn)
                .HasColumnName("IS_COUPON_AVAILABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OtpcUiFlg)
                .HasColumnName("OTPC_UI_FLG")
                .IsUnicode(false);

            entity.Property(e => e.PromoBookingEnddate)
                .HasColumnName("PROMO_BOOKING_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PromoBookingStartdate)
                .HasColumnName("PROMO_BOOKING_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PromoInformation)
                .HasColumnName("PROMO_INFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromoInstructions)
                .HasColumnName("PROMO_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromoName)
                .HasColumnName("PROMO_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PromoStayEnddate)
                .HasColumnName("PROMO_STAY_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PromoStayStartdate)
                .HasColumnName("PROMO_STAY_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionType)
                .HasColumnName("PROMOTION_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UsedInResvNameId)
                .HasColumnName("USED_IN_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInResvResort)
                .HasColumnName("USED_IN_RESV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VbhBeginDate)
                .HasColumnName("VBH_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VbhEndDate)
                .HasColumnName("VBH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VbhInactiveDate)
                .HasColumnName("VBH_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VbhResort)
                .HasColumnName("VBH_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

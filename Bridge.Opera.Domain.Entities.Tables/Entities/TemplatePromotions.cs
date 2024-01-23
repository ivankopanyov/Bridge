namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TemplatePromotions
{
    public string PromoCode { get; set; }
    public string Mpcode { get; set; }
    public string PromoName { get; set; }
    public DateTime? BookingStartdate { get; set; }
    public DateTime? BookingEnddate { get; set; }
    public DateTime? StayStartdate { get; set; }
    public DateTime? StayEnddate { get; set; }
    public string Category { get; set; }
    public string CategoryDesc { get; set; }
    public DateTime? CheckinTime { get; set; }
    public DateTime? CheckoutTime { get; set; }
    public string PromoInstructions { get; set; }
    public string UpgradeAllowedYn { get; set; }
    public string IdRequiredYn { get; set; }
    public string IdRequiredDesc { get; set; }
    public string SetOrAccountFlag { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string PromoInformation { get; set; }
    public string MembershipType { get; set; }
    public string ChainCode { get; set; }
    public string LimitedTimePromotionYn { get; set; }
    public decimal? CouponLength { get; set; }
    public string CouponGenOption { get; set; }
    public string UpdResvOutsideBookingDts { get; set; }
    public string CouponPrefix { get; set; }
    public string CouponSuffix { get; set; }
    public string CouponExChars { get; set; }
    public string CouponGenFormat { get; set; }
    public string VoucherBenefitCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TemplatePromotions>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.PromoCode })
                .HasName("TEMP_PROMO_PK");

            entity.ToTable("TEMPLATE_PROMOTIONS");

            entity.HasIndex(e => new { e.MembershipType, e.Mpcode })
                .HasName("TEMPLATE_PROMOTIONS_MEM_TY_IDX");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingEnddate)
                .HasColumnName("BOOKING_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingStartdate)
                .HasColumnName("BOOKING_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Category)
                .HasColumnName("CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategoryDesc)
                .HasColumnName("CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CheckinTime)
                .HasColumnName("CHECKIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckoutTime)
                .HasColumnName("CHECKOUT_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CouponExChars)
                .HasColumnName("COUPON_EX_CHARS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CouponGenFormat)
                .HasColumnName("COUPON_GEN_FORMAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CouponGenOption)
                .HasColumnName("COUPON_GEN_OPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CouponLength)
                .HasColumnName("COUPON_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CouponPrefix)
                .HasColumnName("COUPON_PREFIX")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CouponSuffix)
                .HasColumnName("COUPON_SUFFIX")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdRequiredDesc)
                .HasColumnName("ID_REQUIRED_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IdRequiredYn)
                .HasColumnName("ID_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LimitedTimePromotionYn)
                .HasColumnName("LIMITED_TIME_PROMOTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .IsRequired()
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SetOrAccountFlag)
                .HasColumnName("SET_OR_ACCOUNT_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StayEnddate)
                .HasColumnName("STAY_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayStartdate)
                .HasColumnName("STAY_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdResvOutsideBookingDts)
                .HasColumnName("UPD_RESV_OUTSIDE_BOOKING_DTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpgradeAllowedYn)
                .HasColumnName("UPGRADE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

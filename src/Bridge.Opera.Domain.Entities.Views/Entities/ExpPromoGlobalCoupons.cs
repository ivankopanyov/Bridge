namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpPromoGlobalCoupons
{
    public string? CBatchCode { get; set; }
    public decimal? CCouponId { get; set; }
    public string? CCouponCode { get; set; }
    public string? CChainCode { get; set; }
    public string? CResort { get; set; }
    public string? CPromotionCode { get; set; }
    public DateTime? CInsertDate { get; set; }
    public decimal? CInsertUser { get; set; }
    public DateTime? CUpdateDate { get; set; }
    public decimal? CUpdateUser { get; set; }
    public string? CStatus { get; set; }
    public decimal? CUsedInResvNameId { get; set; }
    public string? CUsedInResvResort { get; set; }
    public DateTime? CInactiveDate { get; set; }
    public DateTime? CExportDate { get; set; }
    public string? PMpcode { get; set; }
    public string? PPromoName { get; set; }
    public DateTime? PBookingStartdate { get; set; }
    public DateTime? PBookingEnddate { get; set; }
    public DateTime? PStayStartdate { get; set; }
    public DateTime? PStayEnddate { get; set; }
    public string? PCategory { get; set; }
    public string? PCategoryDesc { get; set; }
    public DateTime? PCheckinTime { get; set; }
    public DateTime? PCheckoutTime { get; set; }
    public string? PPromoInstructions { get; set; }
    public string? PUpgradeAllowedYn { get; set; }
    public string? PIdRequiredYn { get; set; }
    public string? PIdRequiredDesc { get; set; }
    public string? PSetOrAccountFlag { get; set; }
    public DateTime? PInactiveDate { get; set; }
    public string? PPromoInformation { get; set; }
    public string? PMembershipType { get; set; }
    public string? PChainCode { get; set; }
    public string? PLimitedTimePromotionYn { get; set; }
    public decimal? PCouponLength { get; set; }
    public string? PCouponGenOption { get; set; }
    public string? PCouponPrefix { get; set; }
    public string? PCouponSuffix { get; set; }
    public string? PCouponExChars { get; set; }
    public string? PCouponGenFormat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpPromoGlobalCoupons>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_PROMO_GLOBAL_COUPONS");

            entity.Property(e => e.CBatchCode)
                .IsRequired()
                .HasColumnName("C_BATCH_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CChainCode)
                .IsRequired()
                .HasColumnName("C_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CCouponCode)
                .IsRequired()
                .HasColumnName("C_COUPON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CCouponId)
                .HasColumnName("C_COUPON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExportDate)
                .HasColumnName("C_EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CInactiveDate)
                .HasColumnName("C_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CInsertDate)
                .HasColumnName("C_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CInsertUser)
                .HasColumnName("C_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CPromotionCode)
                .IsRequired()
                .HasColumnName("C_PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CResort)
                .IsRequired()
                .HasColumnName("C_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CStatus)
                .HasColumnName("C_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CUpdateDate)
                .HasColumnName("C_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CUpdateUser)
                .HasColumnName("C_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CUsedInResvNameId)
                .HasColumnName("C_USED_IN_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CUsedInResvResort)
                .HasColumnName("C_USED_IN_RESV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PBookingEnddate)
                .HasColumnName("P_BOOKING_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PBookingStartdate)
                .HasColumnName("P_BOOKING_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PCategory)
                .HasColumnName("P_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PCategoryDesc)
                .HasColumnName("P_CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PChainCode)
                .IsRequired()
                .HasColumnName("P_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PCheckinTime)
                .HasColumnName("P_CHECKIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.PCheckoutTime)
                .HasColumnName("P_CHECKOUT_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.PCouponExChars)
                .HasColumnName("P_COUPON_EX_CHARS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PCouponGenFormat)
                .HasColumnName("P_COUPON_GEN_FORMAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PCouponGenOption)
                .HasColumnName("P_COUPON_GEN_OPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PCouponLength)
                .HasColumnName("P_COUPON_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PCouponPrefix)
                .HasColumnName("P_COUPON_PREFIX")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.PCouponSuffix)
                .HasColumnName("P_COUPON_SUFFIX")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.PIdRequiredDesc)
                .HasColumnName("P_ID_REQUIRED_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PIdRequiredYn)
                .HasColumnName("P_ID_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PInactiveDate)
                .HasColumnName("P_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PLimitedTimePromotionYn)
                .HasColumnName("P_LIMITED_TIME_PROMOTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PMembershipType)
                .HasColumnName("P_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PMpcode)
                .IsRequired()
                .HasColumnName("P_MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PPromoInformation)
                .HasColumnName("P_PROMO_INFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PPromoInstructions)
                .HasColumnName("P_PROMO_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PPromoName)
                .HasColumnName("P_PROMO_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PSetOrAccountFlag)
                .HasColumnName("P_SET_OR_ACCOUNT_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PStayEnddate)
                .HasColumnName("P_STAY_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PStayStartdate)
                .HasColumnName("P_STAY_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PUpgradeAllowedYn)
                .HasColumnName("P_UPGRADE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

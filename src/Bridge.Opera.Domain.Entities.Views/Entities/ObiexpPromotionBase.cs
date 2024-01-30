namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpPromotionBase
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? PromoCode { get; set; }
    public string? PromoDesc { get; set; }
    public string? Mpcode { get; set; }
    public string? MpcodeDesc { get; set; }
    public string? ResortId { get; set; }
    public string? PromoCodeKey { get; set; }
    public string? MpcodeKey { get; set; }
    public string? AllKey { get; set; }
    public DateTime? BookingStartdate { get; set; }
    public DateTime? BookingEnddate { get; set; }
    public DateTime? StayStartdate { get; set; }
    public DateTime? StayEnddate { get; set; }
    public string? Category { get; set; }
    public string? CategoryDesc { get; set; }
    public DateTime? CheckinTime { get; set; }
    public DateTime? CheckoutTime { get; set; }
    public string? PromoInstructions { get; set; }
    public string? UpgradeAllowedYn { get; set; }
    public string? IdRequiredYn { get; set; }
    public string? IdRequiredDesc { get; set; }
    public string? SetOrAccountFlag { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? PromoInformation { get; set; }
    public string? LimitedTimePromotionYn { get; set; }
    public decimal? CouponLength { get; set; }
    public string? CouponGenOption { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpPromotionBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_PROMOTION_BASE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
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

            entity.Property(e => e.CouponGenOption)
                .HasColumnName("COUPON_GEN_OPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CouponLength)
                .HasColumnName("COUPON_LENGTH")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .IsUnicode(false);

            entity.Property(e => e.MpcodeDesc)
                .HasColumnName("MPCODE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MpcodeKey)
                .HasColumnName("MPCODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .IsUnicode(false);

            entity.Property(e => e.PromoCodeKey)
                .HasColumnName("PROMO_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.PromoDesc)
                .HasColumnName("PROMO_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PromoInformation)
                .HasColumnName("PROMO_INFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromoInstructions)
                .HasColumnName("PROMO_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

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

            entity.Property(e => e.UpgradeAllowedYn)
                .HasColumnName("UPGRADE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

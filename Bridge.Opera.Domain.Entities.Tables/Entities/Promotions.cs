namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Promotions
{
    public Promotions()
    {
        PromoInformationNavigation = new HashSet<PromoInformation>();
        PromoRates = new HashSet<PromoRates>();
        PromoSpecialServices = new HashSet<PromoSpecialServices>();
        ReservationPromotions = new HashSet<ReservationPromotions>();
    }

    public decimal PromoSeqId { get; set; }
    public string Resort { get; set; }
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
    public decimal? AuthorizerId { get; set; }
    public string LimitedTimePromotionYn { get; set; }
    public decimal? CouponLength { get; set; }
    public string CouponGenOption { get; set; }
    public string LockedByType { get; set; }
    public string LockedByCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string UpdResvOutsideBookingDts { get; set; }
    public string CouponPrefix { get; set; }
    public string CouponSuffix { get; set; }
    public string CouponExChars { get; set; }
    public string CouponGenFormat { get; set; }
    public string VoucherBenefitCode { get; set; }

    public virtual MarketingPrograms MarketingPrograms { get; set; }
    public virtual ICollection<PromoInformation> PromoInformationNavigation { get; set; }
    public virtual ICollection<PromoRates> PromoRates { get; set; }
    public virtual ICollection<PromoSpecialServices> PromoSpecialServices { get; set; }
    public virtual ICollection<ReservationPromotions> ReservationPromotions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Promotions>(entity =>
        {
            entity.HasKey(e => e.PromoSeqId)
                .HasName("PROMOTIONS_PK");

            entity.ToTable("PROMOTIONS");

            entity.HasIndex(e => e.PromoCode)
                .HasName("PROMOTIONS_IDX01");

            entity.HasIndex(e => new { e.Resort, e.Mpcode })
                .HasName("PROMOTIONS_FKI");

            entity.HasIndex(e => new { e.Resort, e.PromoCode })
                .HasName("PROMOTIONS_UK")
                .IsUnique();

            entity.Property(e => e.PromoSeqId)
                .HasColumnName("PROMO_SEQ_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LimitedTimePromotionYn)
                .HasColumnName("LIMITED_TIME_PROMOTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LockedByCode)
                .HasColumnName("LOCKED_BY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LockedByType)
                .HasColumnName("LOCKED_BY_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .IsRequired()
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasColumnName("PROMO_CODE")
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
                .IsRequired()
                .HasColumnName("PROMO_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeAllowedYn)
                .HasColumnName("UPGRADE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(MarketingPrograms)))
				entity.Ignore(e => e.MarketingPrograms);
			else
	            entity.HasOne(d => d.MarketingPrograms)
	                .WithMany(p => p.Promotions)
	                .HasForeignKey(d => new { d.Resort, d.Mpcode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PROMOTIONS_FK");
        
			if (!types.Contains(typeof(PromoInformation)))
				entity.Ignore(e => e.PromoInformationNavigation);

			if (!types.Contains(typeof(PromoRates)))
				entity.Ignore(e => e.PromoRates);

			if (!types.Contains(typeof(PromoSpecialServices)))
				entity.Ignore(e => e.PromoSpecialServices);

			if (!types.Contains(typeof(ReservationPromotions)))
				entity.Ignore(e => e.ReservationPromotions);
		});
	}
}

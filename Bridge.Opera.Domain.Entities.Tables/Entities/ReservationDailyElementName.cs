namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationDailyElementName
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime ReservationDate { get; set; }
    public decimal? ResvDailyElSeq { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? GroupId { get; set; }
    public string SharePaymentType { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? SharePrcnt { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPrcnt { get; set; }
    public string DiscountReasonCode { get; set; }
    public string FixedRateYn { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? AutoPostAmount { get; set; }
    public decimal? SharePriority { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string LastShareCalculation { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? NetRoomAmt { get; set; }
    public decimal? RoomTax { get; set; }
    public decimal? PkgAmt { get; set; }
    public decimal? PkgTax { get; set; }
    public decimal? GrossRateAmt { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public string RateCode { get; set; }
    public string CurrencyCode { get; set; }
    public string ExchangePostingType { get; set; }
    public decimal? MembershipPoints { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public string CommissionCode { get; set; }
    public string AwardCode1 { get; set; }
    public string AwardCode2 { get; set; }
    public string AwardCode3 { get; set; }
    public string AwardCode4 { get; set; }
    public string AwardCode5 { get; set; }
    public string AwardVoucher1 { get; set; }
    public string AwardVoucher2 { get; set; }
    public string AwardVoucher3 { get; set; }
    public string AwardVoucher4 { get; set; }
    public string AwardVoucher5 { get; set; }
    public string DoNotMoveYn { get; set; }
    public string AwardCode { get; set; }
    public decimal? Points { get; set; }
    public decimal? UpsellCharge { get; set; }
    public string PointsEligibilityCode { get; set; }
    public decimal? CommissionPaid { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? BillingContactId { get; set; }
    public decimal? ShareAmountOriginal { get; set; }
    public string ReferralYn { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationDailyElementName>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ReservationDate })
                .HasName("RESV_DAILY_ELEMENT_NAME_PK");

            entity.ToTable("RESERVATION_DAILY_ELEMENT_NAME");

            entity.HasIndex(e => new { e.BillingContactId, e.ReservationDate })
                .HasName("RDN_BILLING_CONTACT_ID_IND1");

            entity.HasIndex(e => new { e.CompanyId, e.ReservationDate })
                .HasName("COMPANY_IND1");

            entity.HasIndex(e => new { e.GroupId, e.ReservationDate })
                .HasName("GROUP_IND1");

            entity.HasIndex(e => new { e.Resort, e.BillingContactId })
                .HasName("RDN_BILLING_CONTACT_ID_IND");

            entity.HasIndex(e => new { e.Resort, e.CompanyId })
                .HasName("COMPANY_IND");

            entity.HasIndex(e => new { e.Resort, e.GroupId })
                .HasName("GROUP_IND");

            entity.HasIndex(e => new { e.Resort, e.ResvContactId })
                .HasName("RDN_RESV_CONTACT_ID_IND");

            entity.HasIndex(e => new { e.Resort, e.SourceId })
                .HasName("SOURCE_IND");

            entity.HasIndex(e => new { e.Resort, e.TravelAgentId })
                .HasName("TRAVEL_AGENT_IND");

            entity.HasIndex(e => new { e.ResvContactId, e.ReservationDate })
                .HasName("RDN_RESV_CONTACT_ID_IND1");

            entity.HasIndex(e => new { e.SourceId, e.ReservationDate })
                .HasName("SOURCE_IND1");

            entity.HasIndex(e => new { e.TravelAgentId, e.ReservationDate })
                .HasName("TRAVEL_AGENT_IND1");

            entity.HasIndex(e => new { e.Resort, e.ReservationDate, e.RateCode })
                .HasName("RDEN_DT_RC_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvDailyElSeq, e.ReservationDate, e.ResvNameId })
                .HasName("RESV_DAILY_ELEMENT_NAME_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoPostAmount)
                .HasColumnName("AUTO_POST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardCode1)
                .HasColumnName("AWARD_CODE_1")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardCode2)
                .HasColumnName("AWARD_CODE_2")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardCode3)
                .HasColumnName("AWARD_CODE_3")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardCode4)
                .HasColumnName("AWARD_CODE_4")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardCode5)
                .HasColumnName("AWARD_CODE_5")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardVoucher1)
                .HasColumnName("AWARD_VOUCHER_1")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardVoucher2)
                .HasColumnName("AWARD_VOUCHER_2")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardVoucher3)
                .HasColumnName("AWARD_VOUCHER_3")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardVoucher4)
                .HasColumnName("AWARD_VOUCHER_4")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardVoucher5)
                .HasColumnName("AWARD_VOUCHER_5")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenTaxFree)
                .HasColumnName("CHILDREN_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPrcnt)
                .HasColumnName("DISCOUNT_PRCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DoNotMoveYn)
                .HasColumnName("DO_NOT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.GrossRateAmt)
                .HasColumnName("GROSS_RATE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastShareCalculation)
                .HasColumnName("LAST_SHARE_CALCULATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipPoints)
                .HasColumnName("MEMBERSHIP_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetRoomAmt)
                .HasColumnName("NET_ROOM_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgAmt)
                .HasColumnName("PKG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgTax)
                .HasColumnName("PKG_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsEligibilityCode)
                .HasColumnName("POINTS_ELIGIBILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferralYn)
                .HasColumnName("REFERRAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvDailyElSeq)
                .HasColumnName("RESV_DAILY_EL_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomTax)
                .HasColumnName("ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShareAmountOriginal)
                .HasColumnName("SHARE_AMOUNT_ORIGINAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SharePaymentType)
                .HasColumnName("SHARE_PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SharePrcnt)
                .HasColumnName("SHARE_PRCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SharePriority)
                .HasColumnName("SHARE_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellCharge)
                .HasColumnName("UPSELL_CHARGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationDailyElementName)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_DAILY_ELEMENT_NAME_FK1");
        });
	}
}

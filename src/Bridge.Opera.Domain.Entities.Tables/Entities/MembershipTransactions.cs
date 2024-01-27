namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTransactions
{
    public MembershipTransactions()
    {
        MembershipMultiplePoints = new HashSet<MembershipMultiplePoints>();
        MembershipPointsAccrued = new HashSet<MembershipPointsAccrued>();
        MembershipRejectComments = new HashSet<MembershipRejectComments>();
    }

    public decimal MembershipTrxId { get; set; }
    public DateTime? MembershipTrxDate { get; set; }
    public string RecordType { get; set; }
    public string Resort { get; set; }
    public decimal NameId { get; set; }
    public decimal MembershipId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string PmsNameId { get; set; }
    public string PmsResvNo { get; set; }
    public string PmsResvNameId { get; set; }
    public decimal? StayRecordId { get; set; }
    public string PopulationMethod { get; set; }
    public decimal? AwardRequestId { get; set; }
    public decimal? AwardOrderNo { get; set; }
    public decimal? Stay { get; set; }
    public decimal? Nights { get; set; }
    public string CurrencyCode { get; set; }
    public string PromotionCode1 { get; set; }
    public string PromotionCode2 { get; set; }
    public string PromotionCode3 { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalPoints { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public decimal? OldBalancePoints { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public decimal? PointsCost { get; set; }
    public DateTime? PointsCreditDate { get; set; }
    public string PointsCalculatedYn { get; set; }
    public string ProcessingMessages { get; set; }
    public string DataExportedYn { get; set; }
    public DateTime? DataExportedDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string AutomaticYn { get; set; }
    public string AdjustmentYn { get; set; }
    public decimal? ParentMembershipTrxId { get; set; }
    public string CrsBookNo { get; set; }
    public string TransactionType { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public string PointsRejectedReason { get; set; }
    public decimal? StatementId { get; set; }
    public decimal? MultipleMembershipId { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public decimal MembershipTrxLinkId { get; set; }
    public string UserNotes { get; set; }
    public decimal? MemberStatementId { get; set; }
    public string ExceptionType { get; set; }
    public string PointsAcYn { get; set; }
    public string RoomLabel { get; set; }
    public string PosCode { get; set; }
    public decimal? ExchRateId { get; set; }
    public string AdjRuleCode { get; set; }
    public DateTime? OrigPointsExpirationDate { get; set; }
    public string BillingGroup { get; set; }
    public string ClaimAdjLimitCode { get; set; }
    public string BaseBillingGroup { get; set; }
    public string BonusBillingGroup { get; set; }
    public decimal? TotalEligibleCreditEarn { get; set; }
    public decimal? TotalEligibleAwardRedeem { get; set; }
    public decimal? QualifyingNights { get; set; }
    public string BookedRoomLabel { get; set; }
    public string TierAction { get; set; }
    public string OrigMemberLevel { get; set; }
    public string NewMemberLevel { get; set; }
    public string GraceRenewalFlg { get; set; }

    public virtual ICollection<MembershipMultiplePoints> MembershipMultiplePoints { get; set; }
    public virtual ICollection<MembershipPointsAccrued> MembershipPointsAccrued { get; set; }
    public virtual ICollection<MembershipRejectComments> MembershipRejectComments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTransactions>(entity =>
        {
            entity.HasKey(e => e.MembershipTrxId)
                .HasName("MEMBERSHIP_TRANSACTIONS_PK");

            entity.ToTable("MEMBERSHIP_TRANSACTIONS");

            entity.HasIndex(e => e.BaseBillingGroup)
                .HasName("MEMBERSHIP_TRX_IND13");

            entity.HasIndex(e => e.BillingGroup)
                .HasName("MEMBERSHIP_TRX_IND12");

            entity.HasIndex(e => e.BonusBillingGroup)
                .HasName("MEMBERSHIP_TRX_IND14");

            entity.HasIndex(e => e.MembershipTrxLinkId)
                .HasName("MEMBERSHIP_TRX_LINK_IND");

            entity.HasIndex(e => e.MultipleMembershipId)
                .HasName("MEMBERSHIP_TRX_IND4");

            entity.HasIndex(e => e.NameId)
                .HasName("MEMBERSHIP_TRX_IND3");

            entity.HasIndex(e => e.StayRecordId)
                .HasName("MEMBERSHIP_TRX_IND5");

            entity.HasIndex(e => new { e.DataExportedYn, e.DataExportedDate })
                .HasName("MEMBERSHIP_TRX_IND11");

            entity.HasIndex(e => new { e.PointsExpirationDate, e.MembershipId })
                .HasName("MEMBERSHIP_TRX_IND15");

            entity.HasIndex(e => new { e.StatementId, e.MemberStatementId })
                .HasName("MEMBERSHIP_TRX_IND6");

            entity.HasIndex(e => new { e.MembershipId, e.BeginDate, e.EndDate })
                .HasName("MEMBERSHIP_TRX_IND1");

            entity.HasIndex(e => new { e.PmsResvNo, e.Resort, e.MembershipType })
                .HasName("MEMBERSHIP_TRX_IND2");

            entity.HasIndex(e => new { e.Resort, e.PmsResvNameId, e.PosCode })
                .HasName("MEMBERSHIP_TRX_IND7");

            entity.HasIndex(e => new { e.PromotionCode2, e.Resort, e.BeginDate, e.EndDate })
                .HasName("MEMBERSHIP_TRX_IND9");

            entity.HasIndex(e => new { e.PromotionCode3, e.Resort, e.BeginDate, e.EndDate })
                .HasName("MEMBERSHIP_TRX_IND10");

            entity.HasIndex(e => new { e.PointsAcYn, e.PointsCalculatedYn, e.AdjustmentYn, e.MembershipType, e.RecordType })
                .HasName("MEMBERSHIP_TRX_IND8");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjRuleCode)
                .HasColumnName("ADJ_RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentYn)
                .IsRequired()
                .HasColumnName("ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AutomaticYn)
                .HasColumnName("AUTOMATIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardOrderNo)
                .HasColumnName("AWARD_ORDER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardRequestId)
                .HasColumnName("AWARD_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BaseBillingGroup)
                .HasColumnName("BASE_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BonusBillingGroup)
                .HasColumnName("BONUS_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomLabel)
                .HasColumnName("BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ClaimAdjLimitCode)
                .HasColumnName("CLAIM_ADJ_LIMIT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataExportedDate)
                .HasColumnName("DATA_EXPORTED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DataExportedYn)
                .HasColumnName("DATA_EXPORTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExceptionType)
                .HasColumnName("EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExchRateId)
                .HasColumnName("EXCH_RATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GraceRenewalFlg)
                .HasColumnName("GRACE_RENEWAL_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseNights)
                .HasColumnName("MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseRevenue)
                .HasColumnName("MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseStay)
                .HasColumnName("MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusNights)
                .HasColumnName("MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusRevenue)
                .HasColumnName("MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusStay)
                .HasColumnName("MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxDate)
                .HasColumnName("MEMBERSHIP_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultipleMembershipId)
                .HasColumnName("MULTIPLE_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewMemberLevel)
                .HasColumnName("NEW_MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldBalancePoints)
                .HasColumnName("OLD_BALANCE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigMemberLevel)
                .HasColumnName("ORIG_MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrigPointsExpirationDate)
                .HasColumnName("ORIG_POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentMembershipTrxId)
                .HasColumnName("PARENT_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNameId)
                .HasColumnName("PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PointsAcYn)
                .IsRequired()
                .HasColumnName("POINTS_AC_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.PointsCalculatedYn)
                .IsRequired()
                .HasColumnName("POINTS_CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.PointsCost)
                .HasColumnName("POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsCreditDate)
                .HasColumnName("POINTS_CREDIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsExpirationDate)
                .HasColumnName("POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsRejectedReason)
                .HasColumnName("POINTS_REJECTED_REASON")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PopulationMethod)
                .HasColumnName("POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMessages)
                .HasColumnName("PROCESSING_MESSAGES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode1)
                .HasColumnName("PROMOTION_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode2)
                .HasColumnName("PROMOTION_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode3)
                .HasColumnName("PROMOTION_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.QualifyingNights)
                .HasColumnName("QUALIFYING_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Stay)
                .HasColumnName("STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TierAction)
                .HasColumnName("TIER_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalEligibleAwardRedeem)
                .HasColumnName("TOTAL_ELIGIBLE_AWARD_REDEEM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEligibleCreditEarn)
                .HasColumnName("TOTAL_ELIGIBLE_CREDIT_EARN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserNotes)
                .HasColumnName("USER_NOTES")
                .IsUnicode(false);
        
			if (!types.Contains(typeof(MembershipMultiplePoints)))
				entity.Ignore(e => e.MembershipMultiplePoints);

			if (!types.Contains(typeof(MembershipPointsAccrued)))
				entity.Ignore(e => e.MembershipPointsAccrued);

			if (!types.Contains(typeof(MembershipRejectComments)))
				entity.Ignore(e => e.MembershipRejectComments);
		});
	}
}

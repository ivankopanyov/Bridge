namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipPointsAccrDetVw
{
    public decimal? MpaCostPerPoint { get; set; }
    public decimal MpaMembershipTrxId { get; set; }
    public string MpaMembershipType { get; set; }
    public decimal MpaMembershipPointsSeqno { get; set; }
    public decimal MpaPoints { get; set; }
    public string MpaTypeOfPoints { get; set; }
    public string MpaBillingGroup { get; set; }
    public decimal? MpaAwBucketQuantity { get; set; }
    public decimal? MpaTierBucketQuantity { get; set; }
    public decimal? MpaAwPoints { get; set; }
    public decimal? MpaTierPoints { get; set; }
    public string MpCalculationRule { get; set; }
    public string MpTypeOfPoints { get; set; }
    public decimal? MpPointsRatio { get; set; }
    public decimal? MpPointsBase { get; set; }
    public string MpResort { get; set; }
    public string MpMemberLevel { get; set; }
    public string MpRuleBasedOn { get; set; }
    public string MpMemRateGroup { get; set; }
    public string MpRateCode { get; set; }
    public string MpMemMarketGroup { get; set; }
    public string MpMarketCode { get; set; }
    public string MpRevenueGroup { get; set; }
    public string MpPromotionCode { get; set; }
    public string MpResortGroup { get; set; }
    public DateTime MpBeginDate { get; set; }
    public DateTime? MpEndDate { get; set; }
    public decimal? MpMinimumNights { get; set; }
    public decimal? MpMaximumNights { get; set; }
    public decimal? MpMinimumRateAmount { get; set; }
    public decimal? MpCostPerPoint { get; set; }
    public string MpDescription { get; set; }
    public DateTime? MpInactiveDate { get; set; }
    public string MpTransactionType { get; set; }
    public string MpProgramType { get; set; }
    public string MpQualifyingRatesYn { get; set; }
    public string MpMemRevenueGroup { get; set; }
    public string MpEnrollCode { get; set; }
    public string MpMemEnrollGroup { get; set; }
    public DateTime? MpExpirationDate { get; set; }
    public decimal? MpMinimumStays { get; set; }
    public decimal? MpMinimumRevenue { get; set; }
    public decimal? MpMaximumRevenue { get; set; }
    public string MpDay1 { get; set; }
    public string MpDay2 { get; set; }
    public string MpDay3 { get; set; }
    public string MpDay4 { get; set; }
    public string MpDay5 { get; set; }
    public string MpDay6 { get; set; }
    public string MpDay7 { get; set; }
    public decimal? MpNoTimesEligible { get; set; }
    public string MpElegibleDate { get; set; }
    public string MpMemRategroupExcYn { get; set; }
    public string MpUserpostingOnlyYn { get; set; }
    public decimal? MpAvgRateAmount { get; set; }
    public string MpPseudoRuleYn { get; set; }
    public string MpRoomLabel { get; set; }
    public string MpRoomClass { get; set; }
    public string MpRuleCode { get; set; }
    public string MpChainCode { get; set; }
    public string MpExportLabel { get; set; }
    public decimal? MpMaxBucketSize { get; set; }
    public decimal? MpMinPropertiesReq { get; set; }
    public string MpExcludeRevGroup { get; set; }
    public string MpExcludeMktGroup { get; set; }
    public string MpBillingGroup { get; set; }
    public string MpaRuleGroup { get; set; }
    public decimal? MpDaysFromEnroll { get; set; }
    public string MpPtsRatioPercentYn { get; set; }
    public string MpPtsRatioRoundFlg { get; set; }
    public string MpRtcYn { get; set; }
    public decimal? MpaCQualifiedRev { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPointsAccrDetVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_POINTS_ACCR_DET_VW");

            entity.Property(e => e.MpAvgRateAmount)
                .HasColumnName("MP_AVG_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpBeginDate)
                .HasColumnName("MP_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MpBillingGroup)
                .HasColumnName("MP_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpCalculationRule)
                .IsRequired()
                .HasColumnName("MP_CALCULATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpChainCode)
                .IsRequired()
                .HasColumnName("MP_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpCostPerPoint)
                .HasColumnName("MP_COST_PER_POINT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpDay1)
                .HasColumnName("MP_DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay2)
                .HasColumnName("MP_DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay3)
                .HasColumnName("MP_DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay4)
                .HasColumnName("MP_DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay5)
                .HasColumnName("MP_DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay6)
                .HasColumnName("MP_DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDay7)
                .HasColumnName("MP_DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpDaysFromEnroll)
                .HasColumnName("MP_DAYS_FROM_ENROLL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpDescription)
                .HasColumnName("MP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MpElegibleDate)
                .HasColumnName("MP_ELEGIBLE_DATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpEndDate)
                .HasColumnName("MP_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MpEnrollCode)
                .HasColumnName("MP_ENROLL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpExcludeMktGroup)
                .HasColumnName("MP_EXCLUDE_MKT_GROUP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpExcludeRevGroup)
                .HasColumnName("MP_EXCLUDE_REV_GROUP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpExpirationDate)
                .HasColumnName("MP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MpExportLabel)
                .HasColumnName("MP_EXPORT_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MpInactiveDate)
                .HasColumnName("MP_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MpMarketCode)
                .HasColumnName("MP_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMaxBucketSize)
                .HasColumnName("MP_MAX_BUCKET_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMaximumNights)
                .HasColumnName("MP_MAXIMUM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMaximumRevenue)
                .HasColumnName("MP_MAXIMUM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMemEnrollGroup)
                .HasColumnName("MP_MEM_ENROLL_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMemMarketGroup)
                .HasColumnName("MP_MEM_MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMemRateGroup)
                .HasColumnName("MP_MEM_RATE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMemRategroupExcYn)
                .HasColumnName("MP_MEM_RATEGROUP_EXC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpMemRevenueGroup)
                .HasColumnName("MP_MEM_REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMemberLevel)
                .HasColumnName("MP_MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpMinPropertiesReq)
                .HasColumnName("MP_MIN_PROPERTIES_REQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMinimumNights)
                .HasColumnName("MP_MINIMUM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMinimumRateAmount)
                .HasColumnName("MP_MINIMUM_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMinimumRevenue)
                .HasColumnName("MP_MINIMUM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpMinimumStays)
                .HasColumnName("MP_MINIMUM_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpNoTimesEligible)
                .HasColumnName("MP_NO_TIMES_ELIGIBLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpPointsBase)
                .HasColumnName("MP_POINTS_BASE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpPointsRatio)
                .HasColumnName("MP_POINTS_RATIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpProgramType)
                .HasColumnName("MP_PROGRAM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpPromotionCode)
                .HasColumnName("MP_PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpPseudoRuleYn)
                .HasColumnName("MP_PSEUDO_RULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpPtsRatioPercentYn)
                .HasColumnName("MP_PTS_RATIO_PERCENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpPtsRatioRoundFlg)
                .HasColumnName("MP_PTS_RATIO_ROUND_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpQualifyingRatesYn)
                .HasColumnName("MP_QUALIFYING_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpRateCode)
                .HasColumnName("MP_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpResort)
                .HasColumnName("MP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpResortGroup)
                .HasColumnName("MP_RESORT_GROUP")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.MpRevenueGroup)
                .HasColumnName("MP_REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpRoomClass)
                .HasColumnName("MP_ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpRoomLabel)
                .HasColumnName("MP_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpRtcYn)
                .HasColumnName("MP_RTC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpRuleBasedOn)
                .HasColumnName("MP_RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpRuleCode)
                .HasColumnName("MP_RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpTransactionType)
                .HasColumnName("MP_TRANSACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpTypeOfPoints)
                .HasColumnName("MP_TYPE_OF_POINTS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpUserpostingOnlyYn)
                .HasColumnName("MP_USERPOSTING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpaAwBucketQuantity)
                .HasColumnName("MPA_AW_BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaAwPoints)
                .HasColumnName("MPA_AW_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaBillingGroup)
                .HasColumnName("MPA_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpaCQualifiedRev)
                .HasColumnName("MPA_C_QUALIFIED_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaCostPerPoint)
                .HasColumnName("MPA_COST_PER_POINT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaMembershipPointsSeqno)
                .HasColumnName("MPA_MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaMembershipTrxId)
                .HasColumnName("MPA_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaMembershipType)
                .IsRequired()
                .HasColumnName("MPA_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpaPoints)
                .HasColumnName("MPA_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaRuleGroup)
                .HasColumnName("MPA_RULE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MpaTierBucketQuantity)
                .HasColumnName("MPA_TIER_BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaTierPoints)
                .HasColumnName("MPA_TIER_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MpaTypeOfPoints)
                .HasColumnName("MPA_TYPE_OF_POINTS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

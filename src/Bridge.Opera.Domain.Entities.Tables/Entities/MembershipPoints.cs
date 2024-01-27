namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipPoints
{
    public string MembershipType { get; set; }
    public decimal MembershipPointsSeqno { get; set; }
    public string CalculationRule { get; set; }
    public string TypeOfPoints { get; set; }
    public decimal? PointsRatio { get; set; }
    public decimal? PointsBase { get; set; }
    public string Resort { get; set; }
    public string MemberLevel { get; set; }
    public string RuleBasedOn { get; set; }
    public string MemRateGroup { get; set; }
    public string RateCode { get; set; }
    public string MemMarketGroup { get; set; }
    public string MarketCode { get; set; }
    public string RevenueGroup { get; set; }
    public string PromotionCode { get; set; }
    public string ResortGroup { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? MinimumNights { get; set; }
    public decimal? MaximumNights { get; set; }
    public decimal? MinimumRateAmount { get; set; }
    public decimal? CostPerPoint { get; set; }
    public string Description { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string TransactionType { get; set; }
    public string ProgramType { get; set; }
    public string MultipleTransactionsYn { get; set; }
    public string QualifyingRatesYn { get; set; }
    public string MemRevenueGroup { get; set; }
    public string EnrollCode { get; set; }
    public string MemEnrollGroup { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public decimal? MinimumStays { get; set; }
    public decimal? MinimumRevenue { get; set; }
    public decimal? MaximumRevenue { get; set; }
    public string CreditMultipleMembershipYn { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public decimal? NoTimesEligible { get; set; }
    public string ElegibleDate { get; set; }
    public string MemRateGroupExcludeYn { get; set; }
    public string UserpostingOnlyYn { get; set; }
    public decimal? AvgRateAmount { get; set; }
    public string PseudoRuleYn { get; set; }
    public string RoomLabel { get; set; }
    public string RoomClass { get; set; }
    public string RuleCode { get; set; }
    public string ChainCode { get; set; }
    public string ExportLabel { get; set; }
    public string BillingGroup { get; set; }
    public decimal? MaxBucketSize { get; set; }
    public decimal? MinPropertiesReq { get; set; }
    public string ExcludeRevGroup { get; set; }
    public string ExcludeMktGroup { get; set; }
    public DateTime? BookBeginDate { get; set; }
    public DateTime? BookEndDate { get; set; }
    public string Channel { get; set; }
    public string ExcludePointProj { get; set; }
    public string ExcludeBbFlg { get; set; }
    public string PointsEligibilityCode { get; set; }
    public string AllMembershipTrxYn { get; set; }
    public string AllMembershipRatesYn { get; set; }
    public decimal? DaysFromEnroll { get; set; }
    public string PointsRatioPercentYn { get; set; }
    public string PointsRatioRoundingFlg { get; set; }
    public string RtcYn { get; set; }
    public string MemRoomGroup { get; set; }
    public string EarningRhythmFlg { get; set; }
    public decimal? EarningRhythmNights { get; set; }
    public string ToMemberLevel { get; set; }
    public string IncludeGraceRenewalFlg { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPoints>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.MembershipPointsSeqno })
                .HasName("MEMBERSHIP_POINTS_PK");

            entity.ToTable("MEMBERSHIP_POINTS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllMembershipRatesYn)
                .HasColumnName("ALL_MEMBERSHIP_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllMembershipTrxYn)
                .HasColumnName("ALL_MEMBERSHIP_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvgRateAmount)
                .HasColumnName("AVG_RATE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookBeginDate)
                .HasColumnName("BOOK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookEndDate)
                .HasColumnName("BOOK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalculationRule)
                .IsRequired()
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CostPerPoint)
                .HasColumnName("COST_PER_POINT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditMultipleMembershipYn)
                .HasColumnName("CREDIT_MULTIPLE_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DaysFromEnroll)
                .HasColumnName("DAYS_FROM_ENROLL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EarningRhythmFlg)
                .HasColumnName("EARNING_RHYTHM_FLG")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EarningRhythmNights)
                .HasColumnName("EARNING_RHYTHM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElegibleDate)
                .HasColumnName("ELEGIBLE_DATE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnrollCode)
                .HasColumnName("ENROLL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExcludeBbFlg)
                .HasColumnName("EXCLUDE_BB_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeMktGroup)
                .HasColumnName("EXCLUDE_MKT_GROUP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExcludePointProj)
                .HasColumnName("EXCLUDE_POINT_PROJ")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeRevGroup)
                .HasColumnName("EXCLUDE_REV_GROUP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportLabel)
                .HasColumnName("EXPORT_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludeGraceRenewalFlg)
                .HasColumnName("INCLUDE_GRACE_RENEWAL_FLG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxBucketSize)
                .HasColumnName("MAX_BUCKET_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaximumNights)
                .HasColumnName("MAXIMUM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaximumRevenue)
                .HasColumnName("MAXIMUM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemEnrollGroup)
                .HasColumnName("MEM_ENROLL_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemMarketGroup)
                .HasColumnName("MEM_MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRateGroup)
                .HasColumnName("MEM_RATE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRateGroupExcludeYn)
                .HasColumnName("MEM_RATE_GROUP_EXCLUDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRevenueGroup)
                .HasColumnName("MEM_REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemRoomGroup)
                .HasColumnName("MEM_ROOM_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemberLevel)
                .HasColumnName("MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinPropertiesReq)
                .HasColumnName("MIN_PROPERTIES_REQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumNights)
                .HasColumnName("MINIMUM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinimumRateAmount)
                .HasColumnName("MINIMUM_RATE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinimumRevenue)
                .HasColumnName("MINIMUM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinimumStays)
                .HasColumnName("MINIMUM_STAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultipleTransactionsYn)
                .HasColumnName("MULTIPLE_TRANSACTIONS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoTimesEligible)
                .HasColumnName("NO_TIMES_ELIGIBLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsBase)
                .HasColumnName("POINTS_BASE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsEligibilityCode)
                .HasColumnName("POINTS_ELIGIBILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsRatio)
                .HasColumnName("POINTS_RATIO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsRatioPercentYn)
                .HasColumnName("POINTS_RATIO_PERCENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsRatioRoundingFlg)
                .HasColumnName("POINTS_RATIO_ROUNDING_FLG")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProgramType)
                .HasColumnName("PROGRAM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PseudoRuleYn)
                .HasColumnName("PSEUDO_RULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QualifyingRatesYn)
                .HasColumnName("QUALIFYING_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortGroup)
                .HasColumnName("RESORT_GROUP")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueGroup)
                .HasColumnName("REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RtcYn)
                .HasColumnName("RTC_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleBasedOn)
                .HasColumnName("RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToMemberLevel)
                .HasColumnName("TO_MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeOfPoints)
                .HasColumnName("TYPE_OF_POINTS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserpostingOnlyYn)
                .HasColumnName("USERPOSTING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipPoints)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_POINTS_FK");
        });
	}
}

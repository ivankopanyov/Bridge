namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisMembershipPoints
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
    public string RuleBasedOnValue { get; set; }
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
    public decimal? DaysFromEnroll { get; set; }
    public string PointsRatioPercentYn { get; set; }
    public string PointsRatioRoundingFlg { get; set; }
    public string RtcYn { get; set; }
    public string MemRoomGroup { get; set; }
    public string EarningRhythmFlg { get; set; }
    public decimal? EarningRhythmNights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisMembershipPoints>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_MEMBERSHIP_POINTS");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalculationRule)
                .IsRequired()
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CostPerPoint)
                .HasColumnName("COST_PER_POINT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DaysFromEnroll)
                .HasColumnName("DAYS_FROM_ENROLL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EarningRhythmFlg)
                .HasColumnName("EARNING_RHYTHM_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EarningRhythmNights)
                .HasColumnName("EARNING_RHYTHM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaximumNights)
                .HasColumnName("MAXIMUM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemMarketGroup)
                .HasColumnName("MEM_MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemRateGroup)
                .HasColumnName("MEM_RATE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemRoomGroup)
                .HasColumnName("MEM_ROOM_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemberLevel)
                .HasColumnName("MEMBER_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinimumNights)
                .HasColumnName("MINIMUM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRateAmount)
                .HasColumnName("MINIMUM_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsBase)
                .HasColumnName("POINTS_BASE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRatio)
                .HasColumnName("POINTS_RATIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRatioPercentYn)
                .HasColumnName("POINTS_RATIO_PERCENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsRatioRoundingFlg)
                .HasColumnName("POINTS_RATIO_ROUNDING_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortGroup)
                .HasColumnName("RESORT_GROUP")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup)
                .HasColumnName("REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RtcYn)
                .HasColumnName("RTC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RuleBasedOn)
                .HasColumnName("RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleBasedOnValue)
                .HasColumnName("RULE_BASED_ON_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeOfPoints)
                .HasColumnName("TYPE_OF_POINTS")
                .HasMaxLength(20)
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

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateSetView
{
    public decimal? RateSetId { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? SeasonCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal? Amount2 { get; set; }
    public decimal? Amount3 { get; set; }
    public decimal? Amount4 { get; set; }
    public decimal? Amount5 { get; set; }
    public decimal? AdultCharge { get; set; }
    public decimal? ChildrenCharge { get; set; }
    public decimal? PackageRateStayOver { get; set; }
    public decimal? PackageChildrenStayOver { get; set; }
    public decimal? PackageAdultStayOver { get; set; }
    public decimal? RoomCost { get; set; }
    public string? DepositRequieredYn { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public byte? MinimumClosingProbability { get; set; }
    public string? RatesActiveYn { get; set; }
    public string? GlobalRateUpdateYn { get; set; }
    public string? CalculationFlag { get; set; }
    public decimal? FlatIncrease { get; set; }
    public decimal? PercentIncrease { get; set; }
    public decimal? RoundToNearest { get; set; }
    public decimal? AddAfterRounding { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? RoomTypes { get; set; }
    public string? Products { get; set; }
    public string? SysStatus { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }
    public decimal? ChildOwnCharge1 { get; set; }
    public decimal? ChildOwnCharge2 { get; set; }
    public decimal? ChildOwnCharge3 { get; set; }
    public decimal? ChildOwnCharge4 { get; set; }
    public decimal? LinkRateSetId { get; set; }
    public decimal? TierId { get; set; }
    public decimal? PerPersonAmt2 { get; set; }
    public decimal? PerPersonAmt3 { get; set; }
    public decimal? PerPersonAmt4 { get; set; }
    public decimal? PerPersonAmt5 { get; set; }
    public decimal? PerChildOwnCharge2 { get; set; }
    public decimal? PerChildOwnCharge3 { get; set; }
    public decimal? PerChildOwnCharge4 { get; set; }
    public string? RateRule { get; set; }
    public decimal? Los1Amt { get; set; }
    public decimal? Los2Amt { get; set; }
    public decimal? Los3Amt { get; set; }
    public decimal? Los4Amt { get; set; }
    public decimal? Los5Amt { get; set; }
    public decimal? Los6Amt { get; set; }
    public decimal? Los7Amt { get; set; }
    public decimal? Los8Amt { get; set; }
    public decimal? Los9Amt { get; set; }
    public decimal? Los10Amt { get; set; }
    public decimal? Los11Amt { get; set; }
    public decimal? Los12Amt { get; set; }
    public decimal? Los13Amt { get; set; }
    public decimal? Los14Amt { get; set; }
    public decimal? NumChildrenStayFree { get; set; }
    public decimal? MinChildrenForFreeStay { get; set; }
    public decimal? AdultsThreshold { get; set; }
    public decimal? ChildrenThreshold { get; set; }
    public decimal? OccupantsThreshold { get; set; }
    public decimal? AdultsThresholdCharge { get; set; }
    public decimal? ChildrenThresholdCharge { get; set; }
    public decimal? OccupantsThresholdCharge { get; set; }
    public string? AdvBaseFltPct { get; set; }
    public decimal? AdvBaseAmount { get; set; }
    public string? ChildExcThreshold1 { get; set; }
    public string? ChildExcThreshold2 { get; set; }
    public string? ChildExcThreshold3 { get; set; }
    public string? BarYn { get; set; }
    public string? Amount1Type { get; set; }
    public string? DiffPercentage1Yn { get; set; }
    public string? DiffPercentage2Yn { get; set; }
    public string? DiffPercentage3Yn { get; set; }
    public string? DiffPercentage4Yn { get; set; }
    public string? DiffPercentage5Yn { get; set; }
    public string? DiffPercentageExtraAdultYn { get; set; }
    public decimal? DiffAmount1 { get; set; }
    public decimal? DiffAmount2 { get; set; }
    public decimal? DiffAmount3 { get; set; }
    public decimal? DiffAmount4 { get; set; }
    public decimal? DiffAmount5 { get; set; }
    public decimal? DiffAmountExtraAdult { get; set; }
    public string? Amount2Type { get; set; }
    public string? Amount3Type { get; set; }
    public string? Amount4Type { get; set; }
    public string? Amount5Type { get; set; }
    public string? ExtraAdultType { get; set; }
    public string? CatPkgPriceCode { get; set; }
    public decimal? BarAmount { get; set; }
    public string? BarFltPct { get; set; }
    public string? BarRounding { get; set; }
    public decimal? MinimumAmount1 { get; set; }
    public decimal? MinimumAmount2 { get; set; }
    public decimal? MaximumAmount1 { get; set; }
    public decimal? MaximumAmount2 { get; set; }
    public string? AdvDailyBaseRateCode { get; set; }
    public string? AdvBaseCompareYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateSetView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_SET_VIEW");

            entity.Property(e => e.AddAfterRounding)
                .HasColumnName("ADD_AFTER_ROUNDING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultCharge)
                .HasColumnName("ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsThreshold)
                .HasColumnName("ADULTS_THRESHOLD")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.AdultsThresholdCharge)
                .HasColumnName("ADULTS_THRESHOLD_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvBaseAmount)
                .HasColumnName("ADV_BASE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvBaseCompareYn)
                .HasColumnName("ADV_BASE_COMPARE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AdvBaseFltPct)
                .HasColumnName("ADV_BASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.AdvDailyBaseRateCode)
                .HasColumnName("ADV_DAILY_BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount1Type)
                .HasColumnName("AMOUNT_1_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount2)
                .HasColumnName("AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount2Type)
                .HasColumnName("AMOUNT_2_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount3)
                .HasColumnName("AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount3Type)
                .HasColumnName("AMOUNT_3_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount4)
                .HasColumnName("AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount4Type)
                .HasColumnName("AMOUNT_4_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount5)
                .HasColumnName("AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount5Type)
                .HasColumnName("AMOUNT_5_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BarAmount)
                .HasColumnName("BAR_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BarFltPct)
                .HasColumnName("BAR_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.BarRounding)
                .HasColumnName("BAR_ROUNDING")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.BarYn)
                .HasColumnName("BAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalculationFlag)
                .HasColumnName("CALCULATION_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CatPkgPriceCode)
                .HasColumnName("CAT_PKG_PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildExcThreshold1)
                .HasColumnName("CHILD_EXC_THRESHOLD_1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChildExcThreshold2)
                .HasColumnName("CHILD_EXC_THRESHOLD_2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChildExcThreshold3)
                .HasColumnName("CHILD_EXC_THRESHOLD_3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChildOwnCharge1)
                .HasColumnName("CHILD_OWN_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge2)
                .HasColumnName("CHILD_OWN_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge3)
                .HasColumnName("CHILD_OWN_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge4)
                .HasColumnName("CHILD_OWN_CHARGE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenThreshold)
                .HasColumnName("CHILDREN_THRESHOLD")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.ChildrenThresholdCharge)
                .HasColumnName("CHILDREN_THRESHOLD_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositRequieredYn)
                .HasColumnName("DEPOSIT_REQUIERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffAmount1)
                .HasColumnName("DIFF_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmount2)
                .HasColumnName("DIFF_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmount3)
                .HasColumnName("DIFF_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmount4)
                .HasColumnName("DIFF_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmount5)
                .HasColumnName("DIFF_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmountExtraAdult)
                .HasColumnName("DIFF_AMOUNT_EXTRA_ADULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffPercentage1Yn)
                .HasColumnName("DIFF_PERCENTAGE_1_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffPercentage2Yn)
                .HasColumnName("DIFF_PERCENTAGE_2_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffPercentage3Yn)
                .HasColumnName("DIFF_PERCENTAGE_3_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffPercentage4Yn)
                .HasColumnName("DIFF_PERCENTAGE_4_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffPercentage5Yn)
                .HasColumnName("DIFF_PERCENTAGE_5_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiffPercentageExtraAdultYn)
                .HasColumnName("DIFF_PERCENTAGE_EXTRA_ADULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExtraAdultType)
                .HasColumnName("EXTRA_ADULT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FlatIncrease)
                .HasColumnName("FLAT_INCREASE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalRateUpdateYn)
                .HasColumnName("GLOBAL_RATE_UPDATE_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.LinkRateSetId)
                .HasColumnName("LINK_RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los10Amt)
                .HasColumnName("LOS10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los11Amt)
                .HasColumnName("LOS11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los12Amt)
                .HasColumnName("LOS12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los13Amt)
                .HasColumnName("LOS13_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los14Amt)
                .HasColumnName("LOS14_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los1Amt)
                .HasColumnName("LOS1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los2Amt)
                .HasColumnName("LOS2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los3Amt)
                .HasColumnName("LOS3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los4Amt)
                .HasColumnName("LOS4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los5Amt)
                .HasColumnName("LOS5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los6Amt)
                .HasColumnName("LOS6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los7Amt)
                .HasColumnName("LOS7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los8Amt)
                .HasColumnName("LOS8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los9Amt)
                .HasColumnName("LOS9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaximumAmount1)
                .HasColumnName("MAXIMUM_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaximumAmount2)
                .HasColumnName("MAXIMUM_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinChildrenForFreeStay)
                .HasColumnName("MIN_CHILDREN_FOR_FREE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumAmount1)
                .HasColumnName("MINIMUM_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumAmount2)
                .HasColumnName("MINIMUM_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumClosingProbability).HasColumnName("MINIMUM_CLOSING_PROBABILITY");

            entity.Property(e => e.NumChildrenStayFree)
                .HasColumnName("NUM_CHILDREN_STAY_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupantsThreshold)
                .HasColumnName("OCCUPANTS_THRESHOLD")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.OccupantsThresholdCharge)
                .HasColumnName("OCCUPANTS_THRESHOLD_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageAdultStayOver)
                .HasColumnName("PACKAGE_ADULT_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageChildrenStayOver)
                .HasColumnName("PACKAGE_CHILDREN_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRateStayOver)
                .HasColumnName("PACKAGE_RATE_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerChildOwnCharge2)
                .HasColumnName("PER_CHILD_OWN_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerChildOwnCharge3)
                .HasColumnName("PER_CHILD_OWN_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerChildOwnCharge4)
                .HasColumnName("PER_CHILD_OWN_CHARGE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerPersonAmt2)
                .HasColumnName("PER_PERSON_AMT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerPersonAmt3)
                .HasColumnName("PER_PERSON_AMT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerPersonAmt4)
                .HasColumnName("PER_PERSON_AMT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PerPersonAmt5)
                .HasColumnName("PER_PERSON_AMT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentIncrease)
                .HasColumnName("PERCENT_INCREASE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateRule)
                .HasColumnName("RATE_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RatesActiveYn)
                .HasColumnName("RATES_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCost)
                .HasColumnName("ROOM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTypes)
                .HasColumnName("ROOM_TYPES")
                .IsUnicode(false);

            entity.Property(e => e.RoundToNearest)
                .HasColumnName("ROUND_TO_NEAREST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SysStatus)
                .HasColumnName("SYS_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.TierId)
                .HasColumnName("TIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateHeader
{
    public RateHeader()
    {
        DayTypeRateOrder = new HashSet<DayTypeRateOrder>();
        RateAccessExclusions = new HashSet<RateAccessExclusions>();
        RateCodeRoutInstr = new HashSet<RateCodeRoutInstr>();
        RateDailyRanking = new HashSet<RateDailyRanking>();
        RateRoomCategories = new HashSet<RateRoomCategories>();
        RateSet = new HashSet<RateSet>();
        RateSetErr = new HashSet<RateSetErr>();
        RateTransactions = new HashSet<RateTransactions>();
        RateTranslation = new HashSet<RateTranslation>();
        ResortRateProducts = new HashSet<ResortRateProducts>();
        SellMessages = new HashSet<SellMessages>();
    }

    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public decimal? LosUnit { get; set; }
    public decimal? SellSequence { get; set; }
    public string? PackageYn { get; set; }
    public string? Description { get; set; }
    public string? FlatOrPercentage { get; set; }
    public string? OperatorType { get; set; }
    public string? BaseRateCode { get; set; }
    public decimal? OrderBy { get; set; }
    public string? AlternateRateCode { get; set; }
    public string? CommissionCode { get; set; }
    public string? CommissionYn { get; set; }
    public string? Label { get; set; }
    public string? FolioText { get; set; }
    public string? RateIncludesTaxYn { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? BackToBackYn { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public string? YieldableYn { get; set; }
    public string? HighlightRateAmountYn { get; set; }
    public string? ShowRateAmountYn { get; set; }
    public string? DayuseYn { get; set; }
    public string? PrintRateYn { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxCodeWk { get; set; }
    public string? PkgTrxCode { get; set; }
    public string? TrxTaxInclYn { get; set; }
    public string? PkgTrxCodeWk { get; set; }
    public string? ProfitTrxCode { get; set; }
    public string? TrxWkTaxInclYn { get; set; }
    public string? PkgTrxTaxInclYn { get; set; }
    public string? PkgTrxWkTaxInclYn { get; set; }
    public string? CurrencyCode { get; set; }
    public string? ExchangePostingType { get; set; }
    public string? Negotiated { get; set; }
    public string? ComplimentaryYn { get; set; }
    public string? HouseUseYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? PostingRhythm { get; set; }
    public string? WeekendDays { get; set; }
    public string? RateCalendarYn { get; set; }
    public decimal? AdvanceBooking { get; set; }
    public string? ClosedToArrival { get; set; }
    public string? FrequentFlyerYn { get; set; }
    public decimal? MaxLos { get; set; }
    public string? Addition { get; set; }
    public string? Multiplication { get; set; }
    public string? ShortInfo { get; set; }
    public string? LongInfo { get; set; }
    public string? RateCodeLocked { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? RateBucket { get; set; }
    public string? ExternalLocked { get; set; }
    public string? YieldAs { get; set; }
    public string? GdsAllowedYn { get; set; }
    public string? LoyaltyProgramYn { get; set; }
    public string? RedemptionRateYn { get; set; }
    public string? DisplaySet { get; set; }
    public string? BaseFltPct { get; set; }
    public string? BaseRounding { get; set; }
    public decimal? BaseAmount { get; set; }
    public string? DistributeYn { get; set; }
    public string? TieredYn { get; set; }
    public string? DeptCode { get; set; }
    public string? WkDeptCode { get; set; }
    public decimal? CommissionPct { get; set; }
    public string? DiscountYn { get; set; }
    public string? GroupCode { get; set; }
    public decimal? RateLevel { get; set; }
    public string? RodYn { get; set; }
    public string? RodBasedYn { get; set; }
    public string? RodBaseFltPct { get; set; }
    public string? RodBaseRounding { get; set; }
    public decimal? RodBaseAmount { get; set; }
    public string? RateinfoUrl { get; set; }
    public string? CommissionableYn { get; set; }
    public decimal? FitDiscountPerc { get; set; }
    public string? BfstInclYn { get; set; }
    public decimal? BfstPrice { get; set; }
    public string? ServiceInclYn { get; set; }
    public decimal? FitDiscountLevel { get; set; }
    public decimal? ServicePerc { get; set; }
    public decimal? CommissionablePerc { get; set; }
    public string? DblRmSupplementYn { get; set; }
    public decimal? DblRmSupplementPrice { get; set; }
    public string? TaxIncludedYn { get; set; }
    public decimal? TaxIncludedPerc { get; set; }
    public string? DailyRatesYn { get; set; }
    public decimal? MaxAdvanceBooking { get; set; }
    public string? BbarYn { get; set; }
    public string? BbarBasedYn { get; set; }
    public string? BbarBaseFltPct { get; set; }
    public string? BbarBaseRounding { get; set; }
    public decimal? BbarBaseAmount { get; set; }
    public string? YmCode { get; set; }
    public decimal? MinOccupancy { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public string? AvailabilityUpdateYn { get; set; }
    public string? RatesToGdsYn { get; set; }
    public string? DisplayRegionalYn { get; set; }
    public string? DbaseRateCode { get; set; }
    public string? DbaseFltPct { get; set; }
    public string? DbaseRounding { get; set; }
    public decimal? DbaseAmount { get; set; }
    public string? DbaseCompareYn { get; set; }
    public decimal? RateFloor { get; set; }
    public string? MfnUploadYn { get; set; }
    public string? AsbRateCycle { get; set; }
    public string? OwnerRateYn { get; set; }
    public string? MandateResvProfiles { get; set; }
    public string? ChangeState { get; set; }
    public DateTime? SdowBeginBookingDate { get; set; }
    public DateTime? SdowEndBookingDate { get; set; }
    public string? AdvBaseRateCode { get; set; }
    public string? AdvBaseRounding { get; set; }
    public string? PendingApprovalYn { get; set; }
    public string? UpsellYn { get; set; }
    public string? BbarCompareYn { get; set; }
    public string? BypassHurdleYn { get; set; }
    public decimal? OrsSellSequence { get; set; }
    public string? AdvBaseCompareYn { get; set; }
    public string? BypassRankCheckYn { get; set; }
    public decimal? RankValue { get; set; }
    public decimal? RankAdjustmentFactor { get; set; }
    public string? DefaultToHighestBarYn { get; set; }
    public string? RateFloorOverrideYn { get; set; }
    public decimal? ExtraPersonChargeBegins { get; set; }
    public decimal? CurrCodeDecimalPos { get; set; }
    public decimal? OccupancyLevel { get; set; }
    public string? OverridePackageYn { get; set; }
    public string? CatPkgYn { get; set; }
    public string? CatPkgCode { get; set; }
    public string? RepeatPostingRhythmYn { get; set; }
    public decimal? DiscountRateAmount { get; set; }
    public string? DiscountRatePercentageYn { get; set; }
    public decimal? PostingRhythmNights { get; set; }
    public string? AdvDailyRateYn { get; set; }
    public string? AdvDailyBaseYn { get; set; }
    public string? BaseType { get; set; }
    public string? PrivilegedYn { get; set; }
    public string? PrivilegedRestrictionYn { get; set; }
    public string? VoucherBenefitRateYn { get; set; }

    public virtual RateBuckets R { get; set; }
    public virtual ResortCommission ResortCommission { get; set; }
    public virtual ResortMarkets ResortMarkets { get; set; }
    public virtual Resort ResortNavigation { get; set; }
    public virtual ResortOriginsOfBooking ResortOriginsOfBooking { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }
    public virtual ICollection<DayTypeRateOrder> DayTypeRateOrder { get; set; }
    public virtual ICollection<RateAccessExclusions> RateAccessExclusions { get; set; }
    public virtual ICollection<RateCodeRoutInstr> RateCodeRoutInstr { get; set; }
    public virtual ICollection<RateDailyRanking> RateDailyRanking { get; set; }
    public virtual ICollection<RateRoomCategories> RateRoomCategories { get; set; }
    public virtual ICollection<RateSet> RateSet { get; set; }
    public virtual ICollection<RateSetErr> RateSetErr { get; set; }
    public virtual ICollection<RateTransactions> RateTransactions { get; set; }
    public virtual ICollection<RateTranslation> RateTranslation { get; set; }
    public virtual ICollection<ResortRateProducts> ResortRateProducts { get; set; }
    public virtual ICollection<SellMessages> SellMessages { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode })
                .HasName("RATE_HEADER_PKEY");

            entity.ToTable("RATE_HEADER");

            entity.HasIndex(e => e.MarketCode)
                .HasName("RATE_HEADER_MARKET_CODE_IND");

            entity.HasIndex(e => new { e.DbaseRateCode, e.Resort })
                .HasName("RH_DBASE_RATE_CODE");

            entity.HasIndex(e => new { e.GroupCode, e.Resort })
                .HasName("RATE_GROUP_IDX");

            entity.HasIndex(e => new { e.MarketCode, e.Resort })
                .HasName("RH_MARKET_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.BaseRateCode })
                .HasName("RH_BASE_RATE_CODE");

            entity.HasIndex(e => new { e.Resort, e.CommissionCode })
                .HasName("RATE_COMMISION_IDX");

            entity.HasIndex(e => new { e.Resort, e.GroupCode })
                .HasName("RATE_HEADER_DBAR_IDX")
                .HasFilter("\"RATE_LEVEL\"");

            entity.HasIndex(e => new { e.Resort, e.RateBucket })
                .HasName("RH_RATE_BUCKETS_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateCode })
                .HasName("RATE_HEADER_PKEY")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.RateLevel })
                .HasName("RATE_LEVEL_IDX");

            entity.HasIndex(e => new { e.Resort, e.SourceCode })
                .HasName("RH_SOURCE_IDX");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("RH_TRX_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.OrsSellSequence, e.RateCode })
                .HasName("RH_ORS_SELLSEQ_IDX");

            entity.HasIndex(e => new { e.Resort, e.SellSequence, e.RateCode })
                .HasName("RATE_HEADER_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.BeginBookingDate, e.EndBookingDate })
                .HasName("RH_BEG_END_DATE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Addition)
                .HasColumnName("ADDITION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvBaseCompareYn)
                .HasColumnName("ADV_BASE_COMPARE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvBaseRateCode)
                .HasColumnName("ADV_BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvBaseRounding)
                .HasColumnName("ADV_BASE_ROUNDING")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvDailyBaseYn)
                .HasColumnName("ADV_DAILY_BASE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvDailyRateYn)
                .HasColumnName("ADV_DAILY_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvanceBooking)
                .HasColumnName("ADVANCE_BOOKING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlternateRateCode)
                .HasColumnName("ALTERNATE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AsbRateCycle)
                .HasColumnName("ASB_RATE_CYCLE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvailabilityUpdateYn)
                .HasColumnName("AVAILABILITY_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BackToBackYn)
                .HasColumnName("BACK_TO_BACK_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseAmount)
                .HasColumnName("BASE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseFltPct)
                .HasColumnName("BASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseRateCode)
                .HasColumnName("BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseRounding)
                .HasColumnName("BASE_ROUNDING")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BaseType)
                .HasColumnName("BASE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarBaseAmount)
                .HasColumnName("BBAR_BASE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarBaseFltPct)
                .HasColumnName("BBAR_BASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarBaseRounding)
                .HasColumnName("BBAR_BASE_ROUNDING")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarBasedYn)
                .HasColumnName("BBAR_BASED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarCompareYn)
                .HasColumnName("BBAR_COMPARE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BbarYn)
                .HasColumnName("BBAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BfstInclYn)
                .HasColumnName("BFST_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BfstPrice)
                .HasColumnName("BFST_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BypassHurdleYn)
                .HasColumnName("BYPASS_HURDLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BypassRankCheckYn)
                .HasColumnName("BYPASS_RANK_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CatPkgCode)
                .HasColumnName("CAT_PKG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatPkgYn)
                .HasColumnName("CAT_PKG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChangeState)
                .HasColumnName("CHANGE_STATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ClosedToArrival)
                .HasColumnName("CLOSED_TO_ARRIVAL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionPct)
                .HasColumnName("COMMISSION_PCT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionYn)
                .HasColumnName("COMMISSION_YN")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionablePerc)
                .HasColumnName("COMMISSIONABLE_PERC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionableYn)
                .HasColumnName("COMMISSIONABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrCodeDecimalPos)
                .HasColumnName("CURR_CODE_DECIMAL_POS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DailyRatesYn)
                .HasColumnName("DAILY_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DayuseYn)
                .HasColumnName("DAYUSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbaseAmount)
                .HasColumnName("DBASE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbaseCompareYn)
                .HasColumnName("DBASE_COMPARE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbaseFltPct)
                .HasColumnName("DBASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbaseRateCode)
                .HasColumnName("DBASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbaseRounding)
                .HasColumnName("DBASE_ROUNDING")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DblRmSupplementPrice)
                .HasColumnName("DBL_RM_SUPPLEMENT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DblRmSupplementYn)
                .HasColumnName("DBL_RM_SUPPLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultToHighestBarYn)
                .HasColumnName("DEFAULT_TO_HIGHEST_BAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptCode)
                .HasColumnName("DEPT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountRateAmount)
                .HasColumnName("DISCOUNT_RATE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountRatePercentageYn)
                .HasColumnName("DISCOUNT_RATE_PERCENTAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountYn)
                .HasColumnName("DISCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayRegionalYn)
                .HasColumnName("DISPLAY_REGIONAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySet)
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DistributeYn)
                .HasColumnName("DISTRIBUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalLocked)
                .HasColumnName("EXTERNAL_LOCKED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ExtraPersonChargeBegins)
                .HasColumnName("EXTRA_PERSON_CHARGE_BEGINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitDiscountLevel)
                .HasColumnName("FIT_DISCOUNT_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FitDiscountPerc)
                .HasColumnName("FIT_DISCOUNT_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatOrPercentage)
                .HasColumnName("FLAT_OR_PERCENTAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioText)
                .HasColumnName("FOLIO_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerYn)
                .HasColumnName("FREQUENT_FLYER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsAllowedYn)
                .HasColumnName("GDS_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HighlightRateAmountYn)
                .HasColumnName("HIGHLIGHT_RATE_AMOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongInfo)
                .HasColumnName("LONG_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LosUnit)
                .HasColumnName("LOS_UNIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LoyaltyProgramYn)
                .HasColumnName("LOYALTY_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MandateResvProfiles)
                .HasColumnName("MANDATE_RESV_PROFILES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxAdvanceBooking)
                .HasColumnName("MAX_ADVANCE_BOOKING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MfnUploadYn)
                .HasColumnName("MFN_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinOccupancy)
                .HasColumnName("MIN_OCCUPANCY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Multiplication)
                .HasColumnName("MULTIPLICATION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Negotiated)
                .HasColumnName("NEGOTIATED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OccupancyLevel)
                .HasColumnName("OCCUPANCY_LEVEL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperatorType)
                .HasColumnName("OPERATOR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrsSellSequence)
                .HasColumnName("ORS_SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverridePackageYn)
                .HasColumnName("OVERRIDE_PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerRateYn)
                .HasColumnName("OWNER_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PackageYn)
                .IsRequired()
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PendingApprovalYn)
                .HasColumnName("PENDING_APPROVAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgTrxCodeWk)
                .HasColumnName("PKG_TRX_CODE_WK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgTrxTaxInclYn)
                .HasColumnName("PKG_TRX_TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PkgTrxWkTaxInclYn)
                .HasColumnName("PKG_TRX_WK_TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'D'");

            entity.Property(e => e.PostingRhythmNights)
                .HasColumnName("POSTING_RHYTHM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrivilegedRestrictionYn)
                .HasColumnName("PRIVILEGED_RESTRICTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrivilegedYn)
                .HasColumnName("PRIVILEGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProfitTrxCode)
                .HasColumnName("PROFIT_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RankAdjustmentFactor)
                .HasColumnName("RANK_ADJUSTMENT_FACTOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateBucket)
                .HasColumnName("RATE_BUCKET")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCalendarYn)
                .HasColumnName("RATE_CALENDAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCategory)
                .IsRequired()
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateClass)
                .IsRequired()
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCodeLocked)
                .HasColumnName("RATE_CODE_LOCKED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateFloor)
                .HasColumnName("RATE_FLOOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateFloorOverrideYn)
                .HasColumnName("RATE_FLOOR_OVERRIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateIncludesTaxYn)
                .HasColumnName("RATE_INCLUDES_TAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateLevel)
                .HasColumnName("RATE_LEVEL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateinfoUrl)
                .HasColumnName("RATEINFO_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RatesToGdsYn)
                .HasColumnName("RATES_TO_GDS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RedemptionRateYn)
                .HasColumnName("REDEMPTION_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RepeatPostingRhythmYn)
                .HasColumnName("REPEAT_POSTING_RHYTHM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RodBaseAmount)
                .HasColumnName("ROD_BASE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RodBaseFltPct)
                .HasColumnName("ROD_BASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RodBaseRounding)
                .HasColumnName("ROD_BASE_ROUNDING")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RodBasedYn)
                .HasColumnName("ROD_BASED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RodYn)
                .HasColumnName("ROD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SdowBeginBookingDate)
                .HasColumnName("SDOW_BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SdowEndBookingDate)
                .HasColumnName("SDOW_END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ServiceInclYn)
                .HasColumnName("SERVICE_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ServicePerc)
                .HasColumnName("SERVICE_PERC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShortInfo)
                .HasColumnName("SHORT_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ShowRateAmountYn)
                .HasColumnName("SHOW_RATE_AMOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxIncludedPerc)
                .HasColumnName("TAX_INCLUDED_PERC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxIncludedYn)
                .HasColumnName("TAX_INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TieredYn)
                .HasColumnName("TIERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCodeWk)
                .HasColumnName("TRX_CODE_WK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxTaxInclYn)
                .HasColumnName("TRX_TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TrxWkTaxInclYn)
                .HasColumnName("TRX_WK_TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellYn)
                .HasColumnName("UPSELL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitRateYn)
                .HasColumnName("VOUCHER_BENEFIT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WeekendDays)
                .HasColumnName("WEEKEND_DAYS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WkDeptCode)
                .HasColumnName("WK_DEPT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldAs)
                .HasColumnName("YIELD_AS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.RateHeader)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_FK12");

			if (!types.Contains(typeof(ResortCommission)))
				entity.Ignore(e => e.ResortCommission);
			else
	            entity.HasOne(d => d.ResortCommission)
	                .WithMany(p => p.RateHeader)
	                .HasForeignKey(d => new { d.CommissionCode, d.Resort })
	                .HasConstraintName("RATE_COMMISSION");

			if (!types.Contains(typeof(ResortMarkets)))
				entity.Ignore(e => e.ResortMarkets);
			else
	            entity.HasOne(d => d.ResortMarkets)
	                .WithMany(p => p.RateHeader)
	                .HasPrincipalKey(p => new { p.MarketCode, p.Resort })
	                .HasForeignKey(d => new { d.MarketCode, d.Resort })
	                .HasConstraintName("RATE_HEADER_MARKET_CODE_FK");

			if (!types.Contains(typeof(RateBuckets)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateHeader)
	                .HasForeignKey(d => new { d.Resort, d.RateBucket })
	                .HasConstraintName("RATE_HEADER_RATE_BUCKETS_FK");

			if (!types.Contains(typeof(ResortOriginsOfBooking)))
				entity.Ignore(e => e.ResortOriginsOfBooking);
			else
	            entity.HasOne(d => d.ResortOriginsOfBooking)
	                .WithMany(p => p.RateHeader)
	                .HasForeignKey(d => new { d.Resort, d.SourceCode })
	                .HasConstraintName("RATE_HEADER_SOURCE_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.RateHeader)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("RATE_HEADER_TRX_CODE_FK");
        
			if (!types.Contains(typeof(DayTypeRateOrder)))
				entity.Ignore(e => e.DayTypeRateOrder);

			if (!types.Contains(typeof(RateAccessExclusions)))
				entity.Ignore(e => e.RateAccessExclusions);

			if (!types.Contains(typeof(RateCodeRoutInstr)))
				entity.Ignore(e => e.RateCodeRoutInstr);

			if (!types.Contains(typeof(RateDailyRanking)))
				entity.Ignore(e => e.RateDailyRanking);

			if (!types.Contains(typeof(RateRoomCategories)))
				entity.Ignore(e => e.RateRoomCategories);

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);

			if (!types.Contains(typeof(RateSetErr)))
				entity.Ignore(e => e.RateSetErr);

			if (!types.Contains(typeof(RateTransactions)))
				entity.Ignore(e => e.RateTransactions);

			if (!types.Contains(typeof(RateTranslation)))
				entity.Ignore(e => e.RateTranslation);

			if (!types.Contains(typeof(ResortRateProducts)))
				entity.Ignore(e => e.ResortRateProducts);

			if (!types.Contains(typeof(SellMessages)))
				entity.Ignore(e => e.SellMessages);
		});
	}
}

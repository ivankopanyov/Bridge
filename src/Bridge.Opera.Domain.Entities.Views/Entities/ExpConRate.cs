namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConRate
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TmpRateId { get; set; }
    public decimal? InvAllocInd { get; set; }
    public decimal? IsCommissionable { get; set; }
    public decimal? Negotiated { get; set; }
    public decimal? SuppressRate { get; set; }
    public decimal? PrintRate { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Pkg { get; set; }
    public decimal? Tiered { get; set; }
    public decimal? Dayuse { get; set; }
    public decimal? Complimentary { get; set; }
    public decimal? HouseUse { get; set; }
    public decimal? DayType { get; set; }
    public decimal? MinOccupancy { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? TaxInclusive { get; set; }
    public decimal? CnclDaysPriorToArrival { get; set; }
    public decimal? CnclPenltyAmount { get; set; }
    public decimal? YieldableYn { get; set; }
    public decimal? ArrivalSun { get; set; }
    public decimal? ArrivalMon { get; set; }
    public decimal? ArrivalTue { get; set; }
    public decimal? ArrivalWed { get; set; }
    public decimal? ArrivalThu { get; set; }
    public decimal? ArrivalFri { get; set; }
    public decimal? ArrivalSat { get; set; }
    public decimal? AvailSun { get; set; }
    public decimal? AvailMon { get; set; }
    public decimal? AvailTue { get; set; }
    public decimal? AvailWed { get; set; }
    public decimal? AvailThu { get; set; }
    public decimal? AvailFri { get; set; }
    public decimal? AvailSat { get; set; }
    public string RatePlanType { get; set; }
    public string RateCode { get; set; }
    public string RateCategory { get; set; }
    public string CurrencyCode { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string PkgTrxCode { get; set; }
    public string TrxCode { get; set; }
    public string ExchangePostingType { get; set; }
    public string CnclBeforeTime { get; set; }
    public string CnclPnltyAmountType { get; set; }
    public string RateCodeDesc { get; set; }
    public string RateCodeLongDesc { get; set; }
    public string FolioText { get; set; }
    public string PkgCode { get; set; }
    public DateTime? BeginSellDate { get; set; }
    public DateTime? EndSellDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RATE");

            entity.Property(e => e.ArrivalFri)
                .HasColumnName("ARRIVAL_FRI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalMon)
                .HasColumnName("ARRIVAL_MON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalSat)
                .HasColumnName("ARRIVAL_SAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalSun)
                .HasColumnName("ARRIVAL_SUN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalThu)
                .HasColumnName("ARRIVAL_THU")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalTue)
                .HasColumnName("ARRIVAL_TUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalWed)
                .HasColumnName("ARRIVAL_WED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailFri)
                .HasColumnName("AVAIL_FRI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailMon)
                .HasColumnName("AVAIL_MON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailSat)
                .HasColumnName("AVAIL_SAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailSun)
                .HasColumnName("AVAIL_SUN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailThu)
                .HasColumnName("AVAIL_THU")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailTue)
                .HasColumnName("AVAIL_TUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailWed)
                .HasColumnName("AVAIL_WED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginSellDate)
                .HasColumnName("BEGIN_SELL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CnclBeforeTime)
                .HasColumnName("CNCL_BEFORE_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CnclDaysPriorToArrival)
                .HasColumnName("CNCL_DAYS_PRIOR_TO_ARRIVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclPenltyAmount)
                .HasColumnName("CNCL_PENLTY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclPnltyAmountType)
                .HasColumnName("CNCL_PNLTY_AMOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Complimentary)
                .HasColumnName("COMPLIMENTARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DayType)
                .HasColumnName("DAY_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dayuse)
                .HasColumnName("DAYUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndSellDate)
                .HasColumnName("END_SELL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioText)
                .HasColumnName("FOLIO_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HouseUse)
                .HasColumnName("HOUSE_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvAllocInd)
                .HasColumnName("INV_ALLOC_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsCommissionable)
                .HasColumnName("IS_COMMISSIONABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinOccupancy)
                .HasColumnName("MIN_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Negotiated)
                .HasColumnName("NEGOTIATED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pkg)
                .HasColumnName("PKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintRate)
                .HasColumnName("PRINT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDesc)
                .HasColumnName("RATE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeLongDesc)
                .HasColumnName("RATE_CODE_LONG_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RatePlanType)
                .HasColumnName("RATE_PLAN_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SuppressRate)
                .HasColumnName("SUPPRESS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxInclusive)
                .HasColumnName("TAX_INCLUSIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tiered)
                .HasColumnName("TIERED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TmpRateId)
                .HasColumnName("TMP_RATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasColumnType("NUMBER");
        });
	}
}

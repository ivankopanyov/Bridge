namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortProductsView
{
    public string? Resort { get; set; }
    public string? Product { get; set; }
    public string? Description { get; set; }
    public string? ShortDescription { get; set; }
    public string? PrintSeparateYn { get; set; }
    public string? AddToRateYn { get; set; }
    public string? CalculationRule { get; set; }
    public string? PostingRhythm { get; set; }
    public string? Formula { get; set; }
    public string? PosAccountYn { get; set; }
    public string? PosNextDayYn { get; set; }
    public string? ForecastGroupCode { get; set; }
    public string? CurrencyCode { get; set; }
    public DateTime? FromValidTime { get; set; }
    public DateTime? ToValidTime { get; set; }
    public string? ProductType { get; set; }
    public string? OutletCode { get; set; }
    public decimal? StandardDuration { get; set; }
    public decimal? BookingDuration { get; set; }
    public string? FlexibleDurationYn { get; set; }
    public string? StandardPersons { get; set; }
    public string? MaxPersons { get; set; }
    public string? SeparatelySoldYn { get; set; }
    public string? InventoriedYn { get; set; }
    public string? ExternalLocked { get; set; }
    public string? DeptCode { get; set; }
    public string? ProfitCode { get; set; }
    public string? LossCode { get; set; }
    public string? OverageCode { get; set; }
    public decimal? ResortRateProductDtlId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Price { get; set; }
    public decimal? AllowanceAmount { get; set; }
    public string? RedemptionProductYn { get; set; }
    public string? PkgForcastGroup { get; set; }
    public string? DeptTaxFlag { get; set; }
    public string? OverageTaxFlag { get; set; }
    public string? AlternateTaxFlag { get; set; }
    public string? ProfitTaxFlag { get; set; }
    public string? LossTaxFlag { get; set; }
    public string? ForecastNextDayYn { get; set; }
    public string? CateringYn { get; set; }
    public string? SellOwsYn { get; set; }
    public string? DeliveryTimeReqrdYn { get; set; }
    public string? ArrangementCode { get; set; }
    public string? TicketsYn { get; set; }
    public string? OverrideFixedRateYn { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public string? GenPlAtEodOfCoDate { get; set; }
    public string? LongInfo { get; set; }
    public decimal? MinAdvBookDays { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortProductsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_PRODUCTS_VIEW");

            entity.Property(e => e.AddToRateYn)
                .IsRequired()
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowanceAmount)
                .HasColumnName("ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlternateTaxFlag)
                .HasColumnName("ALTERNATE_TAX_FLAG")
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingDuration)
                .HasColumnName("BOOKING_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CateringYn)
                .HasColumnName("CATERING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.DeliveryTimeReqrdYn)
                .HasColumnName("DELIVERY_TIME_REQRD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeptCode)
                .HasColumnName("DEPT_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DeptTaxFlag)
                .HasColumnName("DEPT_TAX_FLAG")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalLocked)
                .HasColumnName("EXTERNAL_LOCKED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FlexibleDurationYn)
                .HasColumnName("FLEXIBLE_DURATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForecastGroupCode)
                .HasColumnName("FORECAST_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForecastNextDayYn)
                .HasColumnName("FORECAST_NEXT_DAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FromValidTime)
                .HasColumnName("FROM_VALID_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GenPlAtEodOfCoDate)
                .HasColumnName("GEN_PL_AT_EOD_OF_CO_DATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InventoriedYn)
                .HasColumnName("INVENTORIED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LongInfo)
                .HasColumnName("LONG_INFO")
                .IsUnicode(false);

            entity.Property(e => e.LossCode)
                .HasColumnName("LOSS_CODE")
                .IsUnicode(false);

            entity.Property(e => e.LossTaxFlag)
                .HasColumnName("LOSS_TAX_FLAG")
                .IsUnicode(false);

            entity.Property(e => e.MaxPersons)
                .HasColumnName("MAX_PERSONS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MinAdvBookDays)
                .HasColumnName("MIN_ADV_BOOK_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OverageCode)
                .HasColumnName("OVERAGE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.OverageTaxFlag)
                .HasColumnName("OVERAGE_TAX_FLAG")
                .IsUnicode(false);

            entity.Property(e => e.OverrideFixedRateYn)
                .HasColumnName("OVERRIDE_FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgForcastGroup)
                .HasColumnName("PKG_FORCAST_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosAccountYn)
                .HasColumnName("POS_ACCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PosNextDayYn)
                .HasColumnName("POS_NEXT_DAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintSeparateYn)
                .IsRequired()
                .HasColumnName("PRINT_SEPARATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductType)
                .HasColumnName("PRODUCT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfitCode)
                .HasColumnName("PROFIT_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ProfitTaxFlag)
                .HasColumnName("PROFIT_TAX_FLAG")
                .IsUnicode(false);

            entity.Property(e => e.RedemptionProductYn)
                .HasColumnName("REDEMPTION_PRODUCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortRateProductDtlId)
                .HasColumnName("RESORT_RATE_PRODUCT_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellOwsYn)
                .HasColumnName("SELL_OWS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SeparatelySoldYn)
                .IsRequired()
                .HasColumnName("SEPARATELY_SOLD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StandardDuration)
                .HasColumnName("STANDARD_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StandardPersons)
                .HasColumnName("STANDARD_PERSONS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TicketsYn)
                .HasColumnName("TICKETS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToValidTime)
                .HasColumnName("TO_VALID_TIME")
                .HasColumnType("DATE");
        });
	}
}

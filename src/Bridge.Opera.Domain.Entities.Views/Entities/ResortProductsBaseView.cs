namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortProductsBaseView
{
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
    public string? InventoriedYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ExternalLocked { get; set; }
    public string? RedemptionProductYn { get; set; }
    public string? PkgForcastGroup { get; set; }
    public string? ForecastNextDayYn { get; set; }
    public string? CateringYn { get; set; }
    public string? Resort { get; set; }
    public string? Product { get; set; }
    public string? Description { get; set; }
    public string? ShortDescription { get; set; }
    public string? PrintSeparateYn { get; set; }
    public string? AddToRateYn { get; set; }
    public string? SeparatelySoldYn { get; set; }
    public string? CalculationRule { get; set; }
    public string? PostingRhythm { get; set; }
    public string? Formula { get; set; }
    public string? DeliveryTimeReqrdYn { get; set; }
    public string? ArrangementCode { get; set; }
    public string? TicketsYn { get; set; }
    public string? OverrideFixedRateYn { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public string? GenPlAtEodOfCoDate { get; set; }
    public decimal? MinAdvBookDays { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortProductsBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_PRODUCTS_BASE_VIEW");

            entity.Property(e => e.AddToRateYn)
                .IsRequired()
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
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

            entity.Property(e => e.DeliveryTimeReqrdYn)
                .HasColumnName("DELIVERY_TIME_REQRD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InventoriedYn)
                .HasColumnName("INVENTORIED_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.RedemptionProductYn)
                .HasColumnName("REDEMPTION_PRODUCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationProductsDetails
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ProductId { get; set; }
    public string RateCode { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string ProductSource { get; set; }
    public decimal? QtyExcluded { get; set; }
    public string Formula { get; set; }
    public string PostingRhythm { get; set; }
    public string CurrencyCode { get; set; }
    public string ProductGroup { get; set; }
    public decimal ReservationProductId { get; set; }
    public decimal InsertUser { get; set; }
    public string PosAccountYn { get; set; }
    public string AddToRateYn { get; set; }
    public string PrintSeparateYn { get; set; }
    public string PosNextDayYn { get; set; }
    public string CalculationRule { get; set; }
    public DateTime? FromValidTime { get; set; }
    public DateTime? ToValidTime { get; set; }
    public string ForecastNextDayYn { get; set; }
    public string CateringYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationProductsDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_PRODUCTS_DETAILS");

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

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
                .HasColumnName("PRINT_SEPARATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProductGroup)
                .HasColumnName("PRODUCT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductSource)
                .HasColumnName("PRODUCT_SOURCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.QtyExcluded)
                .HasColumnName("QTY_EXCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationProductId)
                .HasColumnName("RESERVATION_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToValidTime)
                .HasColumnName("TO_VALID_TIME")
                .HasColumnType("DATE");
        });
	}
}

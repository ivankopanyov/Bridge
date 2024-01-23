namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationProducts
{
    public ReservationProducts()
    {
        ReservationProductPrices = new HashSet<ReservationProductPrices>();
    }

    public decimal ReservationProductId { get; set; }
    public string RateCode { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal ResvNameId { get; set; }
    public string Resort { get; set; }
    public string ProductId { get; set; }
    public string ProductSource { get; set; }
    public decimal? QtyExcluded { get; set; }
    public string AwardCode { get; set; }
    public decimal? Points { get; set; }
    public string Formula { get; set; }
    public string PostingRhythm { get; set; }
    public string CurrencyCode { get; set; }
    public string ProductGroup { get; set; }
    public DateTime? DeliveryTime { get; set; }
    public string PosAccountYn { get; set; }
    public string AddToRateYn { get; set; }
    public string PrintSeparateYn { get; set; }
    public string PosNextDayYn { get; set; }
    public string CalculationRule { get; set; }
    public DateTime? FromValidTime { get; set; }
    public DateTime? ToValidTime { get; set; }
    public string ForecastNextDayYn { get; set; }
    public string CateringYn { get; set; }
    public string FixedPackageYn { get; set; }
    public string TicketsYn { get; set; }
    public string OverrideFixedRateYn { get; set; }

    public virtual ReservationName Res { get; set; }
    public virtual ICollection<ReservationProductPrices> ReservationProductPrices { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationProducts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ReservationProductId })
                .HasName("RESERVATION_PRODUCTS_PK");

            entity.ToTable("RESERVATION_PRODUCTS");

            entity.HasIndex(e => new { e.Resort, e.ProductId })
                .HasName("RESERVATION_PRODUCTS_FK1_IDX");

            entity.HasIndex(e => new { e.ResvNameId, e.Resort, e.ProductSource })
                .HasName("RESERVATION_PRODUCTS_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationProductId)
                .HasColumnName("RESERVATION_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.DeliveryTime)
                .HasColumnName("DELIVERY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FixedPackageYn)
                .HasColumnName("FIXED_PACKAGE_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideFixedRateYn)
                .HasColumnName("OVERRIDE_FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
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
                .IsRequired()
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

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationProducts)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_PRODUCTS_FK2");
        
			if (!types.Contains(typeof(ReservationProductPrices)))
				entity.Ignore(e => e.ReservationProductPrices);
		});
	}
}

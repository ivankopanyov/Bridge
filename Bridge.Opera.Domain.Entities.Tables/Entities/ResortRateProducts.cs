namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRateProducts
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string Product { get; set; }
    public string GroupProduct { get; set; }
    public string Description { get; set; }
    public string PrintSeparateYn { get; set; }
    public string AddToRateYn { get; set; }
    public string CalculationRule { get; set; }
    public string PostingRhythm { get; set; }
    public string Formula { get; set; }
    public string PosAccountYn { get; set; }
    public string PosNextDayYn { get; set; }
    public string ForecastGroupCode { get; set; }
    public string CurrencyCode { get; set; }
    public DateTime? FromValidTime { get; set; }
    public DateTime? ToValidTime { get; set; }
    public decimal? IncludedQtyInRate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ForecastNextDayYn { get; set; }
    public string DeliveryTimeReqrdYn { get; set; }
    public string OverrideFixedRateYn { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public string GenPlAtEodOfCoDate { get; set; }
    public decimal? MinAdvBookDays { get; set; }

    public virtual RateHeader R { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRateProducts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.Product })
                .HasName("RESORT_RATE_PRODUCTS_PK");

            entity.ToTable("RESORT_RATE_PRODUCTS");

            entity.HasIndex(e => new { e.Resort, e.Product })
                .HasName("PRODUCT_FK1_I");

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

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeliveryTimeReqrdYn)
                .HasColumnName("DELIVERY_TIME_REQRD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastGroupCode)
                .HasColumnName("FORECAST_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastNextDayYn)
                .HasColumnName("FORECAST_NEXT_DAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FromValidTime)
                .HasColumnName("FROM_VALID_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenPlAtEodOfCoDate)
                .HasColumnName("GEN_PL_AT_EOD_OF_CO_DATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupProduct)
                .HasColumnName("GROUP_PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludedQtyInRate)
                .HasColumnName("INCLUDED_QTY_IN_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAdvBookDays)
                .HasColumnName("MIN_ADV_BOOK_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideFixedRateYn)
                .HasColumnName("OVERRIDE_FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PosAccountYn)
                .HasColumnName("POS_ACCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PosNextDayYn)
                .HasColumnName("POS_NEXT_DAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintSeparateYn)
                .HasColumnName("PRINT_SEPARATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToValidTime)
                .HasColumnName("TO_VALID_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.ResortRateProducts)
	                .HasForeignKey(d => new { d.Resort, d.Product })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PRODUCT_FK1");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.ResortRateProducts)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_RATE_PRODUCTS_RATE_FK");
        });
	}
}

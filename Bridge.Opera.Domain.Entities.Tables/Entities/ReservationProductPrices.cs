namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationProductPrices
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal ReservationProductId { get; set; }
    public DateTime ConsumptionDate { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal? AllowanceAmount { get; set; }
    public decimal? Bucket2Price { get; set; }
    public decimal? Bucket2AllowanceAmount { get; set; }
    public decimal? Bucket3Price { get; set; }
    public decimal? Bucket3AllowanceAmount { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? DeliveryTime { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string FixedPackageYn { get; set; }
    public decimal? QtyExcluded { get; set; }
    public decimal? Quantity { get; set; }
    public string PosAccountYn { get; set; }
    public string AddToRateYn { get; set; }
    public string PrintSeparateYn { get; set; }
    public string PosNextDayYn { get; set; }
    public string CalculationRule { get; set; }
    public string PostingRhythm { get; set; }
    public string ProductSource { get; set; }
    public decimal? OrigPrice { get; set; }
    public decimal? OrigAllowance { get; set; }
    public decimal? OrigBucket2Price { get; set; }
    public decimal? OrigBucket2AllowanceAmount { get; set; }
    public decimal? OrigBucket3Price { get; set; }
    public decimal? OrigBucket3AllowanceAmount { get; set; }
    public string OverrideFixedRateYn { get; set; }
    public string GenPlAtEodOfCoDate { get; set; }

    public virtual ReservationProducts Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationProductPrices>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ConsumptionDate, e.Product, e.ReservationProductId })
                .HasName("RESERVATION_PRODUCT_PRICES_PK");

            entity.ToTable("RESERVATION_PRODUCT_PRICES");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.ReservationProductId })
                .HasName("RESVPP_RESVPROD_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationProductId)
                .HasColumnName("RESERVATION_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowanceAmount)
                .HasColumnName("ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bucket2AllowanceAmount)
                .HasColumnName("BUCKET2_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bucket2Price)
                .HasColumnName("BUCKET2_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bucket3AllowanceAmount)
                .HasColumnName("BUCKET3_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bucket3Price)
                .HasColumnName("BUCKET3_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryTime)
                .HasColumnName("DELIVERY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FixedPackageYn)
                .HasColumnName("FIXED_PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.OrigAllowance)
                .HasColumnName("ORIG_ALLOWANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigBucket2AllowanceAmount)
                .HasColumnName("ORIG_BUCKET2_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigBucket2Price)
                .HasColumnName("ORIG_BUCKET2_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigBucket3AllowanceAmount)
                .HasColumnName("ORIG_BUCKET3_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigBucket3Price)
                .HasColumnName("ORIG_BUCKET3_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrigPrice)
                .HasColumnName("ORIG_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideFixedRateYn)
                .HasColumnName("OVERRIDE_FIXED_RATE_YN")
                .HasMaxLength(1)
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
                .HasColumnName("PRINT_SEPARATE_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationProducts)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationProductPrices)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId, d.ReservationProductId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESVPP_RESVPROD_FK");
        });
	}
}

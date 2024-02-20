namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TmpTaxcalc
{
    public decimal? Tmpsid { get; set; }
    public DateTime? Tdate { get; set; }
    public string? Tratecode { get; set; }
    public string? Troomcategory { get; set; }
    public decimal? Tshareamount { get; set; }
    public decimal? Netamount { get; set; }
    public decimal? Grossamount { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FoodRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? NonRevenueTax { get; set; }
    public decimal? ExtraRevenue { get; set; }
    public decimal? FcGrossamount { get; set; }
    public decimal? FcNetamount { get; set; }
    public decimal? FcExtraRevenue { get; set; }
    public decimal? FcRoomRevenue { get; set; }
    public decimal? FcFoodRevenue { get; set; }
    public decimal? FcOtherRevenue { get; set; }
    public decimal? FcTotalRevenue { get; set; }
    public decimal? FcNonRevenue { get; set; }
    public decimal? FcRoomRevenueTax { get; set; }
    public decimal? FcFoodRevenueTax { get; set; }
    public decimal? FcOtherRevenueTax { get; set; }
    public decimal? FcTotalRevenueTax { get; set; }
    public decimal? FcNonRevenueTax { get; set; }
    public string? CurrencyCode { get; set; }
    public DateTime? ExchangeDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TmpTaxcalc>(entity =>
        {
            entity.HasKey(e => new { e.Troomcategory, e.Tmpsid, e.Tdate, e.Tshareamount })
                .HasName("TMP_TAXCALC_PK");

            entity.ToTable("TMP_TAXCALC");

            entity.Property(e => e.Troomcategory)
                .HasColumnName("TROOMCATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tmpsid)
                .HasColumnName("TMPSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tdate)
                .HasColumnName("TDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Tshareamount)
                .HasColumnName("TSHAREAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeDate)
                .HasColumnName("EXCHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExtraRevenue)
                .HasColumnName("EXTRA_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcExtraRevenue)
                .HasColumnName("FC_EXTRA_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcFoodRevenue)
                .HasColumnName("FC_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcFoodRevenueTax)
                .HasColumnName("FC_FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcGrossamount)
                .HasColumnName("FC_GROSSAMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNetamount)
                .HasColumnName("FC_NETAMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenue)
                .HasColumnName("FC_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenueTax)
                .HasColumnName("FC_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenue)
                .HasColumnName("FC_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenueTax)
                .HasColumnName("FC_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenue)
                .HasColumnName("FC_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenueTax)
                .HasColumnName("FC_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenue)
                .HasColumnName("FC_TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenueTax)
                .HasColumnName("FC_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FoodRevenueTax)
                .HasColumnName("FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grossamount)
                .HasColumnName("GROSSAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Netamount)
                .HasColumnName("NETAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NonRevenueTax)
                .HasColumnName("NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tratecode)
                .HasColumnName("TRATECODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

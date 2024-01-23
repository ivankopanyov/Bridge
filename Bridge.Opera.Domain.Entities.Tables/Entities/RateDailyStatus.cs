namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateDailyStatus
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public DateTime RateBeginDate { get; set; }
    public string SStatus { get; set; }
    public decimal? SMinlos { get; set; }
    public decimal? SMaxlos { get; set; }
    public string SHurdleYn { get; set; }
    public string AStatus { get; set; }
    public decimal? AMinlos { get; set; }
    public decimal? AMaxlos { get; set; }
    public string DStatus { get; set; }
    public decimal? BookMinAdvance { get; set; }
    public decimal? BookMaxAdvance { get; set; }
    public decimal Amount1 { get; set; }
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
    public string CurrencyCode { get; set; }
    public decimal? Adder { get; set; }
    public decimal? Multiplier { get; set; }
    public decimal InsertRateSetId { get; set; }
    public decimal UpdateRateSetId { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string Los1Yn { get; set; }
    public string Los2Yn { get; set; }
    public string Los3Yn { get; set; }
    public string Los4Yn { get; set; }
    public string Los5Yn { get; set; }
    public string Los6Yn { get; set; }
    public string Los7Yn { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDailyStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_DAILY_STATUS");

            entity.HasIndex(e => e.UpdateRateSetId)
                .HasName("RDS_UPDATE_RATE_SET_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateBeginDate, e.RateCode, e.RoomCategory })
                .HasName("RDS_RES_DT_RT_RC_IDX")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.RateBeginDate, e.RoomCategory })
                .HasName("RES_RCODE_RBD_RCAT");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.RoomCategory, e.RateBeginDate })
                .HasName("RDS_RES_RT_RM_DT_UNQ_IDX")
                .IsUnique();

            entity.Property(e => e.AMaxlos)
                .HasColumnName("A_MAXLOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AMinlos)
                .HasColumnName("A_MINLOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AStatus)
                .HasColumnName("A_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Adder)
                .HasColumnName("ADDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultCharge)
                .HasColumnName("ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount2)
                .HasColumnName("AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount3)
                .HasColumnName("AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount4)
                .HasColumnName("AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount5)
                .HasColumnName("AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookMaxAdvance)
                .HasColumnName("BOOK_MAX_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookMinAdvance)
                .HasColumnName("BOOK_MIN_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DStatus)
                .HasColumnName("D_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertRateSetId)
                .HasColumnName("INSERT_RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los1Yn)
                .HasColumnName("LOS1_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los2Yn)
                .HasColumnName("LOS2_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los3Yn)
                .HasColumnName("LOS3_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los4Yn)
                .HasColumnName("LOS4_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los5Yn)
                .HasColumnName("LOS5_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los6Yn)
                .HasColumnName("LOS6_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los7Yn)
                .HasColumnName("LOS7_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Multiplier)
                .HasColumnName("MULTIPLIER")
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

            entity.Property(e => e.RateBeginDate)
                .HasColumnName("RATE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCost)
                .HasColumnName("ROOM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SHurdleYn)
                .HasColumnName("S_HURDLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SMaxlos)
                .HasColumnName("S_MAXLOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SMinlos)
                .HasColumnName("S_MINLOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SStatus)
                .IsRequired()
                .HasColumnName("S_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateRateSetId)
                .HasColumnName("UPDATE_RATE_SET_ID")
                .HasColumnType("NUMBER");
        });
	}
}

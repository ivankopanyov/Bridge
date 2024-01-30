namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConRateDtl
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TmpRateId { get; set; }
    public decimal? RateSetId { get; set; }
    public decimal? UnitMplier { get; set; }
    public decimal? RateSun { get; set; }
    public decimal? RateMon { get; set; }
    public decimal? RateTue { get; set; }
    public decimal? RateWed { get; set; }
    public decimal? RateThur { get; set; }
    public decimal? RateFri { get; set; }
    public decimal? RateSat { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal? Amount2 { get; set; }
    public decimal? Amount3 { get; set; }
    public decimal? Amount4 { get; set; }
    public decimal? Amount5 { get; set; }
    public decimal? AdultCharge { get; set; }
    public decimal? ChildrenCharge { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }
    public decimal? ChildOwnCharge1 { get; set; }
    public decimal? ChildOwnCharge2 { get; set; }
    public decimal? ChildOwnCharge3 { get; set; }
    public decimal? ChildOwnCharge4 { get; set; }
    public string? RateCode { get; set; }
    public string? CurrencyCode { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? RoomType { get; set; }
    public string? PkgCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConRateDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RATE_DTL");

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

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge1)
                .HasColumnName("CHILD_OWN_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge2)
                .HasColumnName("CHILD_OWN_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge3)
                .HasColumnName("CHILD_OWN_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge4)
                .HasColumnName("CHILD_OWN_CHARGE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateFri)
                .HasColumnName("RATE_FRI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateMon)
                .HasColumnName("RATE_MON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSat)
                .HasColumnName("RATE_SAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSun)
                .HasColumnName("RATE_SUN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateThur)
                .HasColumnName("RATE_THUR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateTue)
                .HasColumnName("RATE_TUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateWed)
                .HasColumnName("RATE_WED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TmpRateId)
                .HasColumnName("TMP_RATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UnitMplier)
                .HasColumnName("UNIT_MPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}

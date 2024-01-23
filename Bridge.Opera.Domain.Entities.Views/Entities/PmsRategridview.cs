namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsRategridview
{
    public string Resort { get; set; }
    public decimal? SellSequence { get; set; }
    public string RateCode { get; set; }
    public string Description { get; set; }
    public string CurrencyCode { get; set; }
    public string YieldableYn { get; set; }
    public string OperatorType { get; set; }
    public string BaseRateCode { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public decimal? LosUnit { get; set; }
    public string PackageYn { get; set; }
    public decimal? DisplaySequence { get; set; }
    public string ClosedToArrival { get; set; }
    public decimal? RateStatus { get; set; }
    public string ShowRateAmountYn { get; set; }
    public string BackToBackYn { get; set; }
    public decimal? MaxLos { get; set; }
    public decimal? AdvanceBooking { get; set; }
    public string ShortInfo { get; set; }
    public string RoResort { get; set; }
    public string RoRateCode { get; set; }
    public string YieldAs { get; set; }
    public string NegRateSource { get; set; }
    public string RateCalendarYn { get; set; }
    public string Addition { get; set; }
    public string Multiplication { get; set; }
    public decimal? NegRateOrder { get; set; }
    public string Negotiated { get; set; }
    public string DisplaySet { get; set; }
    public string AwardType { get; set; }
    public string YmCode { get; set; }
    public decimal? OrsSellSequence { get; set; }
    public string AsbRateCycle { get; set; }
    public string AdvBaseRateCode { get; set; }
    public string LongInfo { get; set; }
    public string BbarCompareYn { get; set; }
    public string GroupCode { get; set; }
    public string BbarBasedYn { get; set; }
    public string BbarBaseFltPct { get; set; }
    public string BbarBaseRounding { get; set; }
    public decimal? BbarBaseAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsRategridview>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_RATEGRIDVIEW");

            entity.Property(e => e.Addition)
                .HasColumnName("ADDITION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AdvBaseRateCode)
                .HasColumnName("ADV_BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdvanceBooking)
                .HasColumnName("ADVANCE_BOOKING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AsbRateCycle)
                .HasColumnName("ASB_RATE_CYCLE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.BackToBackYn)
                .HasColumnName("BACK_TO_BACK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateCode)
                .HasColumnName("BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BbarBaseAmount)
                .HasColumnName("BBAR_BASE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbarBaseFltPct)
                .HasColumnName("BBAR_BASE_FLT_PCT")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.BbarBaseRounding)
                .HasColumnName("BBAR_BASE_ROUNDING")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.BbarBasedYn)
                .HasColumnName("BBAR_BASED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BbarCompareYn)
                .HasColumnName("BBAR_COMPARE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ClosedToArrival)
                .HasColumnName("CLOSED_TO_ARRIVAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySequence)
                .HasColumnName("DISPLAY_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplaySet)
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongInfo)
                .HasColumnName("LONG_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LosUnit)
                .HasColumnName("LOS_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Multiplication)
                .HasColumnName("MULTIPLICATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NegRateOrder)
                .HasColumnName("NEG_RATE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRateSource)
                .HasColumnName("NEG_RATE_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.Negotiated)
                .HasColumnName("NEGOTIATED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperatorType)
                .HasColumnName("OPERATOR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrsSellSequence)
                .HasColumnName("ORS_SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageYn)
                .IsRequired()
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCalendarYn)
                .HasColumnName("RATE_CALENDAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateStatus)
                .HasColumnName("RATE_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoRateCode)
                .HasColumnName("RO_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoResort)
                .HasColumnName("RO_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShortInfo)
                .HasColumnName("SHORT_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ShowRateAmountYn)
                .HasColumnName("SHOW_RATE_AMOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YieldAs)
                .HasColumnName("YIELD_AS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .IsUnicode(false);
        });
	}
}

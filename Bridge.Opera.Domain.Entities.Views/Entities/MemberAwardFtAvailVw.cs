namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardFtAvailVw
{
    public string Application { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string MembershipLevel { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public DateTime? SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public string ResortCurrency { get; set; }
    public string OcisCurrency { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? AwardValue { get; set; }
    public string ExchangeRateType { get; set; }
    public decimal? MaxPercentAllowed { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyCharge { get; set; }
    public string CancelPenaltyType { get; set; }
    public string IssueKey { get; set; }
    public byte[] IssueKeyRaw { get; set; }
    public string PtsSchCode { get; set; }
    public decimal? OriginalPointsRequired { get; set; }
    public string IgnoreFtTrxYn { get; set; }
    public string DisplaySet { get; set; }
    public decimal? TotalLocalBillAmt { get; set; }
    public decimal? TotalLocalBillAmtAllowed { get; set; }
    public decimal? TotalCentralBillAmt { get; set; }
    public decimal? TotalCentralBillAmtAllowed { get; set; }
    public decimal? ComputedPointsRequired { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardFtAvailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARD_FT_AVAIL_VW");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardValue)
                .HasColumnName("AWARD_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyCharge)
                .HasColumnName("CANCEL_PENALTY_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyType)
                .HasColumnName("CANCEL_PENALTY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComputedPointsRequired)
                .HasColumnName("COMPUTED_POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplaySet)
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreFtTrxYn)
                .HasColumnName("IGNORE_FT_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IssueKey)
                .HasColumnName("ISSUE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.IssueKeyRaw).HasColumnName("ISSUE_KEY_RAW");

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxPercentAllowed)
                .HasColumnName("MAX_PERCENT_ALLOWED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OcisCurrency)
                .HasColumnName("OCIS_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.OriginalPointsRequired)
                .HasColumnName("ORIGINAL_POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtsSchCode)
                .HasColumnName("PTS_SCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortCurrency)
                .HasColumnName("RESORT_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.SellBeginDate)
                .HasColumnName("SELL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellEndDate)
                .HasColumnName("SELL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TotalCentralBillAmt)
                .HasColumnName("TOTAL_CENTRAL_BILL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCentralBillAmtAllowed)
                .HasColumnName("TOTAL_CENTRAL_BILL_AMT_ALLOWED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalLocalBillAmt)
                .HasColumnName("TOTAL_LOCAL_BILL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalLocalBillAmtAllowed)
                .HasColumnName("TOTAL_LOCAL_BILL_AMT_ALLOWED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

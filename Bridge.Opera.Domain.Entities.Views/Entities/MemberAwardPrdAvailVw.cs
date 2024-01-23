namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardPrdAvailVw
{
    public string Application { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string Resort { get; set; }
    public string Product { get; set; }
    public string ShortDescription { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyCharge { get; set; }
    public string CancelPenaltyType { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public string CalculationRule { get; set; }
    public string CalculationRuleDesc { get; set; }
    public string PostingRhythm { get; set; }
    public string PostingRhythmDesc { get; set; }
    public DateTime? SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public string IssueKey { get; set; }
    public byte[] IssueKeyRaw { get; set; }
    public string PtsSchCode { get; set; }
    public decimal? OriginalPointsRequired { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardPrdAvailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARD_PRD_AVAIL_VW");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CalculationRuleDesc)
                .HasColumnName("CALCULATION_RULE_DESC")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CancelPenaltyCharge)
                .HasColumnName("CANCEL_PENALTY_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyPoints)
                .HasColumnName("CANCEL_PENALTY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyType)
                .HasColumnName("CANCEL_PENALTY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IssueKey)
                .HasColumnName("ISSUE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.IssueKeyRaw).HasColumnName("ISSUE_KEY_RAW");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalPointsRequired)
                .HasColumnName("ORIGINAL_POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostingRhythmDesc)
                .HasColumnName("POSTING_RHYTHM_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PtsSchCode)
                .HasColumnName("PTS_SCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellBeginDate)
                .HasColumnName("SELL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellEndDate)
                .HasColumnName("SELL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

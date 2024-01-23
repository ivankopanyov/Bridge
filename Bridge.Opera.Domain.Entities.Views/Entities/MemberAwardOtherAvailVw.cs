namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardOtherAvailVw
{
    public string Application { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string MembershipLevel { get; set; }
    public decimal? AwardQuantity { get; set; }
    public string AwardBasedOn { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public string MessageLine1 { get; set; }
    public string MessageLine2 { get; set; }
    public string MessageLine3 { get; set; }
    public string MessageLine4 { get; set; }
    public decimal? AwardValue { get; set; }
    public string ExchangeRateType { get; set; }
    public decimal? MaxPercentAllowed { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyCharge { get; set; }
    public string CancelPenaltyType { get; set; }
    public string PtsSchCode { get; set; }
    public string AutoConsumeYn { get; set; }
    public string ForceVerificationYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? OriginalPointsRequired { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardOtherAvailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARD_OTHER_AVAIL_VW");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.AutoConsumeYn)
                .HasColumnName("AUTO_CONSUME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardBasedOn)
                .HasColumnName("AWARD_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardQuantity)
                .HasColumnName("AWARD_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardValue)
                .HasColumnName("AWARD_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForceVerificationYn)
                .HasColumnName("FORCE_VERIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

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
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MessageLine1)
                .HasColumnName("MESSAGE_LINE1")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine2)
                .HasColumnName("MESSAGE_LINE2")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine3)
                .HasColumnName("MESSAGE_LINE3")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine4)
                .HasColumnName("MESSAGE_LINE4")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

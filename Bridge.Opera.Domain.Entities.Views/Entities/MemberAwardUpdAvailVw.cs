namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardUpdAvailVw
{
    public string Application { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string Resort { get; set; }
    public string FromRoom { get; set; }
    public string ToRoom { get; set; }
    public string FromRoomLabel { get; set; }
    public string ToRoomLabel { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyCharge { get; set; }
    public string CancelPenaltyType { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public DateTime? SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public string IssueKey { get; set; }
    public byte[] IssueKeyRaw { get; set; }
    public DateTime? StayDate { get; set; }
    public string PtsSchCode { get; set; }
    public decimal? OriginalPointsRequired { get; set; }
    public string CancelPolicyType { get; set; }
    public decimal? NumberOfNights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardUpdAvailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARD_UPD_AVAIL_VW");

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

            entity.Property(e => e.CancelPolicyType)
                .HasColumnName("CANCEL_POLICY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromRoom)
                .HasColumnName("FROM_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.IssueKey)
                .HasColumnName("ISSUE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.IssueKeyRaw).HasColumnName("ISSUE_KEY_RAW");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfNights)
                .HasColumnName("NUMBER_OF_NIGHTS")
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

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToRoom)
                .HasColumnName("TO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
                .IsUnicode(false);
        });
	}
}

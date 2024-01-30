namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipUpDn
{
    public decimal? MembershipId { get; set; }
    public decimal? ReportId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ActionToDo { get; set; }
    public decimal? OrderBy { get; set; }
    public string? DisplayName { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? RecordType { get; set; }
    public string? MembershipType { get; set; }
    public string? OldMembershipLevel { get; set; }
    public string? NewMembershipLevel { get; set; }
    public string? FinMembershipLevel { get; set; }
    public string? OldGracePeriodIndicator { get; set; }
    public string? NewGracePeriodIndicator { get; set; }
    public string? FinGracePeriodIndicator { get; set; }
    public string? MemStatus { get; set; }
    public DateTime? EvalDate { get; set; }
    public DateTime? OldExpirationDate { get; set; }
    public DateTime? NewExpirationDate { get; set; }
    public DateTime? EvalFromDate { get; set; }
    public DateTime? EvalToDate { get; set; }
    public string? MemLog { get; set; }
    public string? MemError { get; set; }
    public decimal? StayActual { get; set; }
    public decimal? StayRequired { get; set; }
    public decimal? NightsActual { get; set; }
    public decimal? NightsRequired { get; set; }
    public decimal? StayRevenueActual { get; set; }
    public decimal? StayRevenueRequired { get; set; }
    public decimal? FbTrxActual { get; set; }
    public decimal? FbTrxRequired { get; set; }
    public decimal? FbCoverActual { get; set; }
    public decimal? FbCoverRequired { get; set; }
    public decimal? FbRevenueActual { get; set; }
    public decimal? FbRevenueRequired { get; set; }
    public string? ReviewFlg { get; set; }
    public string? MembershipStatus { get; set; }
    public string? InactiveYn { get; set; }
    public decimal? RfmScoreDtlId { get; set; }
    public string? GraceRenewalFlg { get; set; }
    public decimal? MembershipTrxId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipUpDn>(entity =>
        {
            entity.HasKey(e => new { e.MembershipId, e.ReportId })
                .HasName("MEM_UP_DN_PK");

            entity.ToTable("MEMBERSHIP_UP_DN");

            entity.HasIndex(e => e.DisplayName)
                .HasName("MEM_UP_DN_NAME");

            entity.HasIndex(e => e.MembershipCardNo)
                .HasName("MEM_UP_DN_MEMBER_NO");

            entity.HasIndex(e => e.RfmScoreDtlId)
                .HasName("MEMBERSHIP_UP_DN_IDX1");

            entity.HasIndex(e => new { e.ReportId, e.MemStatus })
                .HasName("REPORT_IDX");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionToDo)
                .HasColumnName("ACTION_TO_DO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EvalDate)
                .HasColumnName("EVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvalFromDate)
                .HasColumnName("EVAL_FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvalToDate)
                .HasColumnName("EVAL_TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbCoverActual)
                .HasColumnName("FB_COVER_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbCoverRequired)
                .HasColumnName("FB_COVER_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueActual)
                .HasColumnName("FB_REVENUE_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueRequired)
                .HasColumnName("FB_REVENUE_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTrxActual)
                .HasColumnName("FB_TRX_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTrxRequired)
                .HasColumnName("FB_TRX_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinGracePeriodIndicator)
                .HasColumnName("FIN_GRACE_PERIOD_INDICATOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FinMembershipLevel)
                .HasColumnName("FIN_MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GraceRenewalFlg)
                .HasColumnName("GRACE_RENEWAL_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemError)
                .HasColumnName("MEM_ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MemLog)
                .HasColumnName("MEM_LOG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MemStatus)
                .IsRequired()
                .HasColumnName("MEM_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewExpirationDate)
                .HasColumnName("NEW_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NewGracePeriodIndicator)
                .HasColumnName("NEW_GRACE_PERIOD_INDICATOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NewMembershipLevel)
                .HasColumnName("NEW_MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NightsActual)
                .HasColumnName("NIGHTS_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightsRequired)
                .HasColumnName("NIGHTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldExpirationDate)
                .HasColumnName("OLD_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldGracePeriodIndicator)
                .HasColumnName("OLD_GRACE_PERIOD_INDICATOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OldMembershipLevel)
                .HasColumnName("OLD_MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReviewFlg)
                .HasColumnName("REVIEW_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RfmScoreDtlId)
                .HasColumnName("RFM_SCORE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayActual)
                .HasColumnName("STAY_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRequired)
                .HasColumnName("STAY_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRevenueActual)
                .HasColumnName("STAY_REVENUE_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRevenueRequired)
                .HasColumnName("STAY_REVENUE_REQUIRED")
                .HasColumnType("NUMBER");
        });
	}
}

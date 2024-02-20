namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipTierDetailVw
{
    public decimal? ReportId { get; set; }
    public string? ReportStatus { get; set; }
    public string? ChainCode { get; set; }
    public decimal? RfmScoreHdrId { get; set; }
    public string? ReQualifyYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? ActionToDo { get; set; }
    public decimal? OrderBy { get; set; }
    public string? DisplayName { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? Action { get; set; }
    public string? MembershipType { get; set; }
    public string? OldMembershipLevel { get; set; }
    public string? NewMembershipLevel { get; set; }
    public string? FinMembershipLevel { get; set; }
    public string? OldGracePeriodIndicator { get; set; }
    public string? NewGracePeriodIndicator { get; set; }
    public string? FinGracePeriodIndicator { get; set; }
    public string? Status { get; set; }
    public DateTime? EvalDate { get; set; }
    public DateTime? OldExpirationDate { get; set; }
    public DateTime? NewExpirationDate { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string? Log { get; set; }
    public string? Error { get; set; }
    public decimal? StayActual { get; set; }
    public decimal? StayRequired { get; set; }
    public decimal? NightsActual { get; set; }
    public decimal? NightsRequired { get; set; }
    public decimal? StayRevenueRequired { get; set; }
    public decimal? FbTrxActual { get; set; }
    public decimal? FbTrxRequired { get; set; }
    public decimal? FbCoverRequired { get; set; }
    public decimal? FbRevenueRequired { get; set; }
    public string? ReviewFlg { get; set; }
    public string? MembershipStatus { get; set; }
    public string? InactiveYn { get; set; }
    public decimal? RfmScoreDtlId { get; set; }
    public string? TmrActiveYn { get; set; }
    public string? GraceRenewalFlg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTierDetailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_TIER_DETAIL_VW");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("ACTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ActionToDo)
                .HasColumnName("ACTION_TO_DO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Error)
                .HasColumnName("ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EvalDate)
                .HasColumnName("EVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbCoverRequired)
                .HasColumnName("FB_COVER_REQUIRED")
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

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.Log)
                .HasColumnName("LOG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.ReQualifyYn)
                .HasColumnName("RE_QUALIFY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportStatus)
                .IsRequired()
                .HasColumnName("REPORT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReviewFlg)
                .HasColumnName("REVIEW_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RfmScoreDtlId)
                .HasColumnName("RFM_SCORE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfmScoreHdrId)
                .HasColumnName("RFM_SCORE_HDR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayActual)
                .HasColumnName("STAY_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRequired)
                .HasColumnName("STAY_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRevenueRequired)
                .HasColumnName("STAY_REVENUE_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TmrActiveYn)
                .HasColumnName("TMR_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");
        });
	}
}

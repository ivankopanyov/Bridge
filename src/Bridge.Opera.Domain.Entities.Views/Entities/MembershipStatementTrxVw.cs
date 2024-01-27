namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipStatementTrxVw
{
    public decimal? StatementBatchId { get; set; }
    public decimal? MemberStatementId { get; set; }
    public decimal? RecordId { get; set; }
    public DateTime? RecordDate { get; set; }
    public string RecordType { get; set; }
    public string RecordTypeDesc { get; set; }
    public string Resort { get; set; }
    public string PmsResvNo { get; set; }
    public string OrsBookNo { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? MembershipId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public DateTime? PostingDate { get; set; }
    public decimal? Points { get; set; }
    public decimal? PosPoints { get; set; }
    public decimal? NegPoints { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public string PointsCalculatedYn { get; set; }
    public string AdjustmentYn { get; set; }
    public decimal? StayRecordId { get; set; }
    public string AwardType { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public decimal? MembershipTrxLinkId { get; set; }
    public string UserNotes { get; set; }
    public decimal? AwardCancellationNo { get; set; }
    public string ResvCancellationNo { get; set; }
    public decimal? TrxInsertUser { get; set; }
    public DateTime? TrxInsertDate { get; set; }
    public decimal? TrxUpdateUser { get; set; }
    public DateTime? TrxUpdateDate { get; set; }
    public DateTime? TrxInactiveDate { get; set; }
    public decimal? ParentMembershipTrxId { get; set; }
    public string ProcessingMsg { get; set; }
    public string PosCode { get; set; }
    public decimal? CertId { get; set; }
    public string CertificateNo { get; set; }
    public string CertCode { get; set; }
    public DateTime? CertConsumptionDate { get; set; }
    public DateTime? CertCertExpiryDate { get; set; }
    public string CertConsumerLastName { get; set; }
    public string CertConsumerFirstName { get; set; }
    public decimal? CertResvNameId { get; set; }
    public string CertResort { get; set; }
    public string CertConsumeResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipStatementTrxVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_STATEMENT_TRX_VW");

            entity.Property(e => e.AdjustmentYn)
                .HasColumnName("ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardCancellationNo)
                .HasColumnName("AWARD_CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertCertExpiryDate)
                .HasColumnName("CERT_CERT_EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertCode)
                .HasColumnName("CERT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CertConsumeResort)
                .HasColumnName("CERT_CONSUME_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CertConsumerFirstName)
                .HasColumnName("CERT_CONSUMER_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CertConsumerLastName)
                .HasColumnName("CERT_CONSUMER_LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CertConsumptionDate)
                .HasColumnName("CERT_CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertId)
                .HasColumnName("CERT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CertResort)
                .HasColumnName("CERT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CertResvNameId)
                .HasColumnName("CERT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CertificateNo)
                .HasColumnName("CERTIFICATE_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseNights)
                .HasColumnName("MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseRevenue)
                .HasColumnName("MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseStay)
                .HasColumnName("MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusNights)
                .HasColumnName("MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusRevenue)
                .HasColumnName("MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusStay)
                .HasColumnName("MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegPoints)
                .HasColumnName("NEG_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrsBookNo)
                .HasColumnName("ORS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ParentMembershipTrxId)
                .HasColumnName("PARENT_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsCalculatedYn)
                .HasColumnName("POINTS_CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsExpirationDate)
                .HasColumnName("POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosPoints)
                .HasColumnName("POS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordTypeDesc)
                .HasColumnName("RECORD_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvCancellationNo)
                .HasColumnName("RESV_CANCELLATION_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxInactiveDate)
                .HasColumnName("TRX_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertDate)
                .HasColumnName("TRX_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertUser)
                .HasColumnName("TRX_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxUpdateDate)
                .HasColumnName("TRX_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxUpdateUser)
                .HasColumnName("TRX_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserNotes)
                .HasColumnName("USER_NOTES")
                .IsUnicode(false);
        });
	}
}

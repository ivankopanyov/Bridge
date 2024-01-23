namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbMembershipIssuedAwards
{
    public decimal IssuedAwardId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string MembershipLevel { get; set; }
    public decimal MembershipId { get; set; }
    public string MembershipCardNo { get; set; }
    public string PmsResvNo { get; set; }
    public string Resort { get; set; }
    public string CrsBookNo { get; set; }
    public string AwardStatus { get; set; }
    public DateTime? DateAwarded { get; set; }
    public string AwardSource { get; set; }
    public DateTime? DateOfExpiry { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public string RateCode { get; set; }
    public string CancellationNumber { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? MembershipAwardId { get; set; }
    public string RoomLabel { get; set; }
    public string FromRoomLabel { get; set; }
    public string ToRoomLabel { get; set; }
    public string Product { get; set; }
    public decimal? ActualCancelPoints { get; set; }
    public decimal? AwardCancellationNo { get; set; }
    public decimal? StayRecordId { get; set; }
    public string AutoConsumedYn { get; set; }
    public string AwardConsumedYn { get; set; }
    public string IssuedManuallyYn { get; set; }
    public DateTime? AwardCancelDate { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public decimal? StatementId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? MemberStatementId { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? AwardValue { get; set; }
    public decimal? CancelStatementId { get; set; }
    public decimal? CancelMemberStatementId { get; set; }
    public string ChainCode { get; set; }
    public decimal? TrxNo { get; set; }
    public string ExtTrxNo { get; set; }
    public string TrxCode { get; set; }
    public decimal? TotalLocalAmount { get; set; }
    public decimal? RedeemedLocalAmount { get; set; }
    public decimal? TotalCentralAmount { get; set; }
    public decimal? RedeemedCentralAmount { get; set; }
    public string ExchangeRateType { get; set; }
    public string Comments { get; set; }
    public string BillingGroup { get; set; }
    public string CancelPolicyType { get; set; }
    public decimal? NumberOfNights { get; set; }
    public string AwardVoucherNo { get; set; }
    public string PtsSchCode { get; set; }
    public decimal? LocalResvNameId { get; set; }
    public string RoomLabelName { get; set; }
    public string FromRoomLabelName { get; set; }
    public string ToRoomLabelName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbMembershipIssuedAwards>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_MEMBERSHIP_ISSUED_AWARDS");

            entity.Property(e => e.ActualCancelPoints)
                .HasColumnName("ACTUAL_CANCEL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AutoConsumedYn)
                .HasColumnName("AUTO_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardCancelDate)
                .HasColumnName("AWARD_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardCancellationNo)
                .HasColumnName("AWARD_CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardConsumedYn)
                .HasColumnName("AWARD_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardSource)
                .HasColumnName("AWARD_SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardStatus)
                .HasColumnName("AWARD_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardValue)
                .HasColumnName("AWARD_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardVoucherNo)
                .HasColumnName("AWARD_VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelMemberStatementId)
                .HasColumnName("CANCEL_MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyPoints)
                .HasColumnName("CANCEL_PENALTY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPolicyType)
                .HasColumnName("CANCEL_POLICY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelStatementId)
                .HasColumnName("CANCEL_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancellationNumber)
                .HasColumnName("CANCELLATION_NUMBER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DateAwarded)
                .HasColumnName("DATE_AWARDED")
                .HasColumnType("DATE");

            entity.Property(e => e.DateOfExpiry)
                .HasColumnName("DATE_OF_EXPIRY")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtTrxNo)
                .HasColumnName("EXT_TRX_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomLabelName)
                .HasColumnName("FROM_ROOM_LABEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssuedAwardId)
                .HasColumnName("ISSUED_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssuedManuallyYn)
                .HasColumnName("ISSUED_MANUALLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LocalResvNameId)
                .HasColumnName("LOCAL_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipAwardId)
                .HasColumnName("MEMBERSHIP_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberOfNights)
                .HasColumnName("NUMBER_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PtsSchCode)
                .HasColumnName("PTS_SCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RedeemedCentralAmount)
                .HasColumnName("REDEEMED_CENTRAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RedeemedLocalAmount)
                .HasColumnName("REDEEMED_LOCAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabelName)
                .HasColumnName("ROOM_LABEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomLabelName)
                .HasColumnName("TO_ROOM_LABEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalCentralAmount)
                .HasColumnName("TOTAL_CENTRAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalLocalAmount)
                .HasColumnName("TOTAL_LOCAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

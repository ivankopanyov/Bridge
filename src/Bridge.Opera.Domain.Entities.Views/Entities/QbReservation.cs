namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbReservation
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public string NameUsageType { get; set; }
    public decimal? ContactNameId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ResvStatus { get; set; }
    public string CommissionCode { get; set; }
    public decimal? AddressId { get; set; }
    public decimal? PhoneId { get; set; }
    public string FaxYn { get; set; }
    public string MailYn { get; set; }
    public string PrintRateYn { get; set; }
    public string ReportId { get; set; }
    public decimal? ResvNo { get; set; }
    public string ConfirmationNo { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? FaxId { get; set; }
    public decimal? EmailId { get; set; }
    public string EmailYn { get; set; }
    public string ConsumerYn { get; set; }
    public decimal? CreditCardId { get; set; }
    public string FinanciallyResponsibleYn { get; set; }
    public string PaymentMethod { get; set; }
    public string IntermediaryYn { get; set; }
    public string PostingAllowedYn { get; set; }
    public string DisplayColor { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? TruncActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public DateTime? TruncActualCheckOutDate { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? AuthorizedBy { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public string CancellationNo { get; set; }
    public string CancellationReasonCode { get; set; }
    public string CancellationReasonDesc { get; set; }
    public string ArrivalTransportType { get; set; }
    public string ArrivalStationCode { get; set; }
    public string ArrivalCarrierCode { get; set; }
    public string ArrivalTransportCode { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public DateTime? ArrivalEstimateTime { get; set; }
    public string ArrivalTranportationYn { get; set; }
    public string ArrivalComments { get; set; }
    public string DepartureTransportType { get; set; }
    public string DepartureStationCode { get; set; }
    public string DepartureCarrierCode { get; set; }
    public string DepartureTransportCode { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public DateTime? DepartureEstimateTime { get; set; }
    public string DepartureTransportationYn { get; set; }
    public string DepartureComments { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string GuaranteeCode { get; set; }
    public string WlReasonDescription { get; set; }
    public string WlReasonCode { get; set; }
    public string WlPriority { get; set; }
    public string DoNotMoveRoom { get; set; }
    public string ExternalReference { get; set; }
    public string PartyCode { get; set; }
    public string WalkinYn { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? AmountPercent { get; set; }
    public string NameTaxType { get; set; }
    public string TaxExemptNo { get; set; }
    public string RoomFeatures { get; set; }
    public string WlTelephoneNo { get; set; }
    public string VideoCheckoutYn { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPrcnt { get; set; }
    public string DiscountReasonCode { get; set; }
    public decimal? CommissionPaid { get; set; }
    public string CommissionHoldCode { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public string SguestName { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public string TurndownYn { get; set; }
    public string RoomInstructions { get; set; }
    public string RoomServiceTime { get; set; }
    public decimal? EventId { get; set; }
    public string RevenueTypeCode { get; set; }
    public decimal? Hurdle { get; set; }
    public string HurdleOverride { get; set; }
    public decimal? RateableValue { get; set; }
    public string RestrictionOverride { get; set; }
    public string YieldableYn { get; set; }
    public string SguestFirstname { get; set; }
    public string GuestLastName { get; set; }
    public string GuestFirstName { get; set; }
    public string GuestLastNameSdx { get; set; }
    public string GuestFirstNameSdx { get; set; }
    public string Channel { get; set; }
    public decimal? ShareSeqNo { get; set; }
    public string GuestSignature { get; set; }
    public decimal? ExtensionId { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? BillingContactId { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public string MasterShare { get; set; }
    public string RegistrationCardNo { get; set; }
    public string Tiad { get; set; }
    public string PurposeOfStay { get; set; }
    public DateTime? ReinstateDate { get; set; }
    public DateTime? PurgeDate { get; set; }
    public DateTime? LastSettleDate { get; set; }
    public DateTime? LastPeriodicFolioDate { get; set; }
    public decimal? PeriodicFolioFreq { get; set; }
    public decimal? ConfirmationLegNo { get; set; }
    public string GuestStatus { get; set; }
    public string GuestType { get; set; }
    public decimal? CheckinDuration { get; set; }
    public decimal? AuthorizerId { get; set; }
    public decimal? LastOnlinePrintSeq { get; set; }
    public string EntryPoint { get; set; }
    public DateTime? EntryDate { get; set; }
    public string FolioText1 { get; set; }
    public string FolioText2 { get; set; }
    public string PseudoMemType { get; set; }
    public decimal? PseudoMemTotalPoints { get; set; }
    public string CompTypeCode { get; set; }
    public string UniCardId { get; set; }
    public decimal? ExpCheckinresId { get; set; }
    public DateTime? OriginalBeginDate { get; set; }
    public string OwnerFfFlag { get; set; }
    public string CommissionPayoutTo { get; set; }
    public string PreChargingYn { get; set; }
    public string PostChargingYn { get; set; }
    public string PostCoFlag { get; set; }
    public DateTime? FolioCloseDate { get; set; }
    public string ScheduleCheckoutYn { get; set; }
    public string CustomReference { get; set; }
    public string GuaranteeCodePreCi { get; set; }
    public decimal? AwardMembershipId { get; set; }
    public string EsignedRegCardName { get; set; }
    public decimal? StatisticalRoomType { get; set; }
    public decimal? StatisticalRateTier { get; set; }
    public decimal? TaxRegistrationNo { get; set; }
    public string VisaNumber { get; set; }
    public DateTime? VisaIssueDate { get; set; }
    public DateTime? VisaExpirationDate { get; set; }
    public decimal? TaxNoOfStays { get; set; }
    public string YmCode { get; set; }
    public DateTime? KeyValidUntil { get; set; }
    public string PreRegisteredYn { get; set; }
    public string AsbProratedYn { get; set; }
    public decimal? AutoSettleDays { get; set; }
    public string AutoSettleYn { get; set; }
    public decimal? SplitFromResvNameId { get; set; }
    public string NextDestination { get; set; }
    public DateTime? DateOfArrivalInCountry { get; set; }
    public DateTime? PreArrReviewedDt { get; set; }
    public decimal? PreArrReviewedUser { get; set; }
    public decimal? BonusCheckId { get; set; }
    public string MobileAudioKeyYn { get; set; }
    public string DirectBillVerifyResponse { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public string SuperSearchIndexText { get; set; }
    public string AutoCheckinYn { get; set; }
    public string EmailFolioYn { get; set; }
    public string EmailAddress { get; set; }
    public string SpgUpgradeConfirmedRoomtype { get; set; }
    public string SpgUpgradeReasonCode { get; set; }
    public string SpgSuiteNightAwardStatus { get; set; }
    public string SpgDiscloseRoomTypeYn { get; set; }
    public string AmenityEligibleYn { get; set; }
    public string AmenityLevelCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbReservation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_RESERVATION");

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmenityEligibleYn)
                .HasColumnName("AMENITY_ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AmenityLevelCode)
                .HasColumnName("AMENITY_LEVEL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AmountPercent)
                .HasColumnName("AMOUNT_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalCarrierCode)
                .HasColumnName("ARRIVAL_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalComments)
                .HasColumnName("ARRIVAL_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalEstimateTime)
                .HasColumnName("ARRIVAL_ESTIMATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalStationCode)
                .HasColumnName("ARRIVAL_STATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTranportationYn)
                .HasColumnName("ARRIVAL_TRANPORTATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTransportCode)
                .HasColumnName("ARRIVAL_TRANSPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTransportType)
                .HasColumnName("ARRIVAL_TRANSPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AsbProratedYn)
                .HasColumnName("ASB_PRORATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizedBy)
                .HasColumnName("AUTHORIZED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoCheckinYn)
                .HasColumnName("AUTO_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoSettleDays)
                .HasColumnName("AUTO_SETTLE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoSettleYn)
                .HasColumnName("AUTO_SETTLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardMembershipId)
                .HasColumnName("AWARD_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusCheckId)
                .HasColumnName("BONUS_CHECK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonCode)
                .HasColumnName("CANCELLATION_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonDesc)
                .HasColumnName("CANCELLATION_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CheckinDuration)
                .HasColumnName("CHECKIN_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionHoldCode)
                .HasColumnName("COMMISSION_HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionPayoutTo)
                .HasColumnName("COMMISSION_PAYOUT_TO")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLegNo)
                .HasColumnName("CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ConsumerYn)
                .HasColumnName("CONSUMER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomReference)
                .HasColumnName("CUSTOM_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DateOfArrivalInCountry)
                .HasColumnName("DATE_OF_ARRIVAL_IN_COUNTRY")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureCarrierCode)
                .HasColumnName("DEPARTURE_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureComments)
                .HasColumnName("DEPARTURE_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureEstimateTime)
                .HasColumnName("DEPARTURE_ESTIMATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureStationCode)
                .HasColumnName("DEPARTURE_STATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportCode)
                .HasColumnName("DEPARTURE_TRANSPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportType)
                .HasColumnName("DEPARTURE_TRANSPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportationYn)
                .HasColumnName("DEPARTURE_TRANSPORTATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DirectBillVerifyResponse)
                .HasColumnName("DIRECT_BILL_VERIFY_RESPONSE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPrcnt)
                .HasColumnName("DISCOUNT_PRCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailFolioYn)
                .HasColumnName("EMAIL_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EntryDate)
                .HasColumnName("ENTRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EntryPoint)
                .HasColumnName("ENTRY_POINT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EsignedRegCardName)
                .HasColumnName("ESIGNED_REG_CARD_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpCheckinresId)
                .HasColumnName("EXP_CHECKINRES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtensionId)
                .HasColumnName("EXTENSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxYn)
                .HasColumnName("FAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FinanciallyResponsibleYn)
                .HasColumnName("FINANCIALLY_RESPONSIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioCloseDate)
                .HasColumnName("FOLIO_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioText1)
                .HasColumnName("FOLIO_TEXT1")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FolioText2)
                .HasColumnName("FOLIO_TEXT2")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCodePreCi)
                .HasColumnName("GUARANTEE_CODE_PRE_CI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstNameSdx)
                .HasColumnName("GUEST_FIRST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastNameSdx)
                .HasColumnName("GUEST_LAST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestSignature)
                .HasColumnName("GUEST_SIGNATURE")
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.GuestStatus)
                .HasColumnName("GUEST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleOverride)
                .HasColumnName("HURDLE_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IntermediaryYn)
                .HasColumnName("INTERMEDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.KeyValidUntil)
                .HasColumnName("KEY_VALID_UNTIL")
                .HasColumnType("DATE");

            entity.Property(e => e.LastOnlinePrintSeq)
                .HasColumnName("LAST_ONLINE_PRINT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastPeriodicFolioDate)
                .HasColumnName("LAST_PERIODIC_FOLIO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastSettleDate)
                .HasColumnName("LAST_SETTLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MobileAudioKeyYn)
                .HasColumnName("MOBILE_AUDIO_KEY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameUsageType)
                .IsRequired()
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NextDestination)
                .HasColumnName("NEXT_DESTINATION")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.OriginalBeginDate)
                .HasColumnName("ORIGINAL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OwnerFfFlag)
                .HasColumnName("OWNER_FF_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PeriodicFolioFreq)
                .HasColumnName("PERIODIC_FOLIO_FREQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostChargingYn)
                .HasColumnName("POST_CHARGING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostCoFlag)
                .HasColumnName("POST_CO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreArrReviewedDt)
                .HasColumnName("PRE_ARR_REVIEWED_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.PreArrReviewedUser)
                .HasColumnName("PRE_ARR_REVIEWED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreChargingYn)
                .HasColumnName("PRE_CHARGING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreRegisteredYn)
                .HasColumnName("PRE_REGISTERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PseudoMemTotalPoints)
                .HasColumnName("PSEUDO_MEM_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoMemType)
                .HasColumnName("PSEUDO_MEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PurposeOfStay)
                .HasColumnName("PURPOSE_OF_STAY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegistrationCardNo)
                .HasColumnName("REGISTRATION_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReinstateDate)
                .HasColumnName("REINSTATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionOverride)
                .HasColumnName("RESTRICTION_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueTypeCode)
                .HasColumnName("REVENUE_TYPE_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomFeatures)
                .HasColumnName("ROOM_FEATURES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstructions)
                .HasColumnName("ROOM_INSTRUCTIONS")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RoomServiceTime)
                .HasColumnName("ROOM_SERVICE_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleCheckoutYn)
                .HasColumnName("SCHEDULE_CHECKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SguestFirstname)
                .HasColumnName("SGUEST_FIRSTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareSeqNo)
                .HasColumnName("SHARE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpgDiscloseRoomTypeYn)
                .HasColumnName("SPG_DISCLOSE_ROOM_TYPE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SpgSuiteNightAwardStatus)
                .HasColumnName("SPG_SUITE_NIGHT_AWARD_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SpgUpgradeConfirmedRoomtype)
                .HasColumnName("SPG_UPGRADE_CONFIRMED_ROOMTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpgUpgradeReasonCode)
                .HasColumnName("SPG_UPGRADE_REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SplitFromResvNameId)
                .HasColumnName("SPLIT_FROM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticalRateTier)
                .HasColumnName("STATISTICAL_RATE_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticalRoomType)
                .HasColumnName("STATISTICAL_ROOM_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuperSearchIndexText)
                .HasColumnName("SUPER_SEARCH_INDEX_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxNoOfStays)
                .HasColumnName("TAX_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxRegistrationNo)
                .HasColumnName("TAX_REGISTRATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tiad)
                .HasColumnName("TIAD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckInDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncActualCheckOutDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TurndownYn)
                .HasColumnName("TURNDOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UniCardId)
                .HasColumnName("UNI_CARD_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VideoCheckoutYn)
                .HasColumnName("VIDEO_CHECKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VisaExpirationDate)
                .HasColumnName("VISA_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VisaIssueDate)
                .HasColumnName("VISA_ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VisaNumber)
                .HasColumnName("VISA_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WlPriority)
                .HasColumnName("WL_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonCode)
                .HasColumnName("WL_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonDescription)
                .HasColumnName("WL_REASON_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WlTelephoneNo)
                .HasColumnName("WL_TELEPHONE_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

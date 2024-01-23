namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationName
{
    public ReservationName()
    {
        AmandaInfo = new HashSet<AmandaInfo>();
        CustomFacilityCodesSchedule = new HashSet<CustomFacilityCodesSchedule>();
        CustomFacilityTaskHeader = new HashSet<CustomFacilityTaskHeader>();
        CustomFacilityTaskSchedule = new HashSet<CustomFacilityTaskSchedule>();
        GuestRsvMessages = new HashSet<GuestRsvMessages>();
        Locators = new HashSet<Locators>();
        ReservationChanges = new HashSet<ReservationChanges>();
        ReservationCommPref = new HashSet<ReservationCommPref>();
        ReservationComment = new HashSet<ReservationComment>();
        ReservationConfLetter = new HashSet<ReservationConfLetter>();
        ReservationDailyElementName = new HashSet<ReservationDailyElementName>();
        ReservationDepositSchedule = new HashSet<ReservationDepositSchedule>();
        ReservationFeatures = new HashSet<ReservationFeatures>();
        ReservationItems = new HashSet<ReservationItems>();
        ReservationKeyOptions = new HashSet<ReservationKeyOptions>();
        ReservationLinkageCnrReservationName = new HashSet<ReservationLinkageCnr>();
        ReservationLinkageCnrReservationNameNavigation = new HashSet<ReservationLinkageCnr>();
        ReservationLoyaltySegments = new HashSet<ReservationLoyaltySegments>();
        ReservationOverrides = new HashSet<ReservationOverrides>();
        ReservationProducts = new HashSet<ReservationProducts>();
        ReservationPromotions = new HashSet<ReservationPromotions>();
        ReservationReceipts = new HashSet<ReservationReceipts>();
        ReservationReceiptsJrnl = new HashSet<ReservationReceiptsJrnl>();
        ReservationSpecialRequests = new HashSet<ReservationSpecialRequests>();
        ReservationVirtual = new HashSet<ReservationVirtual>();
        TrackitItems = new HashSet<TrackitItems>();
        VouchersHeader = new HashSet<VouchersHeader>();
    }

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
    public string Udfc01 { get; set; }
    public string Udfc02 { get; set; }
    public string Udfc03 { get; set; }
    public string Udfc04 { get; set; }
    public string Udfc05 { get; set; }
    public string Udfc06 { get; set; }
    public string Udfc07 { get; set; }
    public string Udfc08 { get; set; }
    public string Udfc09 { get; set; }
    public string Udfc10 { get; set; }
    public string Udfc11 { get; set; }
    public string Udfc12 { get; set; }
    public string Udfc13 { get; set; }
    public string Udfc14 { get; set; }
    public string Udfc15 { get; set; }
    public string Udfc16 { get; set; }
    public string Udfc17 { get; set; }
    public string Udfc18 { get; set; }
    public string Udfc19 { get; set; }
    public string Udfc20 { get; set; }
    public string Udfc21 { get; set; }
    public string Udfc22 { get; set; }
    public string Udfc23 { get; set; }
    public string Udfc24 { get; set; }
    public string Udfc25 { get; set; }
    public string Udfc26 { get; set; }
    public string Udfc27 { get; set; }
    public string Udfc28 { get; set; }
    public string Udfc29 { get; set; }
    public string Udfc30 { get; set; }
    public string Udfc31 { get; set; }
    public string Udfc32 { get; set; }
    public string Udfc33 { get; set; }
    public string Udfc34 { get; set; }
    public string Udfc35 { get; set; }
    public string Udfc36 { get; set; }
    public string Udfc37 { get; set; }
    public string Udfc38 { get; set; }
    public string Udfc39 { get; set; }
    public string Udfc40 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public decimal? Udfn16 { get; set; }
    public decimal? Udfn17 { get; set; }
    public decimal? Udfn18 { get; set; }
    public decimal? Udfn19 { get; set; }
    public decimal? Udfn20 { get; set; }
    public decimal? Udfn21 { get; set; }
    public decimal? Udfn22 { get; set; }
    public decimal? Udfn23 { get; set; }
    public decimal? Udfn24 { get; set; }
    public decimal? Udfn25 { get; set; }
    public decimal? Udfn26 { get; set; }
    public decimal? Udfn27 { get; set; }
    public decimal? Udfn28 { get; set; }
    public decimal? Udfn29 { get; set; }
    public decimal? Udfn30 { get; set; }
    public decimal? Udfn31 { get; set; }
    public decimal? Udfn32 { get; set; }
    public decimal? Udfn33 { get; set; }
    public decimal? Udfn34 { get; set; }
    public decimal? Udfn35 { get; set; }
    public decimal? Udfn36 { get; set; }
    public decimal? Udfn37 { get; set; }
    public decimal? Udfn38 { get; set; }
    public decimal? Udfn39 { get; set; }
    public decimal? Udfn40 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public DateTime? Udfd11 { get; set; }
    public DateTime? Udfd12 { get; set; }
    public DateTime? Udfd13 { get; set; }
    public DateTime? Udfd14 { get; set; }
    public DateTime? Udfd15 { get; set; }
    public DateTime? Udfd16 { get; set; }
    public DateTime? Udfd17 { get; set; }
    public DateTime? Udfd18 { get; set; }
    public DateTime? Udfd19 { get; set; }
    public DateTime? Udfd20 { get; set; }
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
    public string YmCode { get; set; }
    public decimal? TaxRegistrationNo { get; set; }
    public string VisaNumber { get; set; }
    public DateTime? VisaIssueDate { get; set; }
    public DateTime? VisaExpirationDate { get; set; }
    public decimal? TaxNoOfStays { get; set; }
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
    public string BaseRateCurrencyCode { get; set; }
    public string BaseRateCode { get; set; }
    public decimal? LocalBaseRateAmount { get; set; }
    public string PhoneDisplayNameYn { get; set; }

    public virtual NameCreditCard CreditCard { get; set; }
    public virtual Name Name { get; set; }
    public virtual Resort ResortNavigation { get; set; }
    public virtual FacilityScheduleDates FacilityScheduleDates { get; set; }
    public virtual Qrooms Qrooms { get; set; }
    public virtual ReservationBalances ReservationBalances { get; set; }
    public virtual ReservationCancelList ReservationCancelList { get; set; }
    public virtual ICollection<AmandaInfo> AmandaInfo { get; set; }
    public virtual ICollection<CustomFacilityCodesSchedule> CustomFacilityCodesSchedule { get; set; }
    public virtual ICollection<CustomFacilityTaskHeader> CustomFacilityTaskHeader { get; set; }
    public virtual ICollection<CustomFacilityTaskSchedule> CustomFacilityTaskSchedule { get; set; }
    public virtual ICollection<GuestRsvMessages> GuestRsvMessages { get; set; }
    public virtual ICollection<Locators> Locators { get; set; }
    public virtual ICollection<ReservationChanges> ReservationChanges { get; set; }
    public virtual ICollection<ReservationCommPref> ReservationCommPref { get; set; }
    public virtual ICollection<ReservationComment> ReservationComment { get; set; }
    public virtual ICollection<ReservationConfLetter> ReservationConfLetter { get; set; }
    public virtual ICollection<ReservationDailyElementName> ReservationDailyElementName { get; set; }
    public virtual ICollection<ReservationDepositSchedule> ReservationDepositSchedule { get; set; }
    public virtual ICollection<ReservationFeatures> ReservationFeatures { get; set; }
    public virtual ICollection<ReservationItems> ReservationItems { get; set; }
    public virtual ICollection<ReservationKeyOptions> ReservationKeyOptions { get; set; }
    public virtual ICollection<ReservationLinkageCnr> ReservationLinkageCnrReservationName { get; set; }
    public virtual ICollection<ReservationLinkageCnr> ReservationLinkageCnrReservationNameNavigation { get; set; }
    public virtual ICollection<ReservationLoyaltySegments> ReservationLoyaltySegments { get; set; }
    public virtual ICollection<ReservationOverrides> ReservationOverrides { get; set; }
    public virtual ICollection<ReservationProducts> ReservationProducts { get; set; }
    public virtual ICollection<ReservationPromotions> ReservationPromotions { get; set; }
    public virtual ICollection<ReservationReceipts> ReservationReceipts { get; set; }
    public virtual ICollection<ReservationReceiptsJrnl> ReservationReceiptsJrnl { get; set; }
    public virtual ICollection<ReservationSpecialRequests> ReservationSpecialRequests { get; set; }
    public virtual ICollection<ReservationVirtual> ReservationVirtual { get; set; }
    public virtual ICollection<TrackitItems> TrackitItems { get; set; }
    public virtual ICollection<VouchersHeader> VouchersHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationName>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_NAME_PK");

            entity.ToTable("RESERVATION_NAME");

            entity.HasIndex(e => e.AddresseeNameId)
                .HasName("RESV_NAME_ADDRESSEE_IDX");

            entity.HasIndex(e => e.AwardMembershipId)
                .HasName("RESERVATION_NAME_IND14");

            entity.HasIndex(e => e.BillingContactId)
                .HasName("RESV_BILLING_ID_IND");

            entity.HasIndex(e => e.CancellationNo)
                .HasName("RESV_CANCEL_NO_IND");

            entity.HasIndex(e => e.ConfirmationNo)
                .HasName("RESV_NAME_CONFIRM_NO_IND");

            entity.HasIndex(e => e.CreditCardId)
                .HasName("RESERVATION_NAME_IND6");

            entity.HasIndex(e => e.InsertActionInstanceId)
                .HasName("RESERVATION_NAME_IND8");

            entity.HasIndex(e => e.InsertUser)
                .HasName("RESERVATION_NAME_IND11");

            entity.HasIndex(e => e.ResvContactId)
                .HasName("RESV_CONTACT_ID_IND");

            entity.HasIndex(e => e.ResvNameId)
                .HasName("RESERVATION_NAME_UK")
                .IsUnique();

            entity.HasIndex(e => e.SplitFromResvNameId)
                .HasName("RESV_SPLIT_RNID");

            entity.HasIndex(e => new { e.BusinessDateCreated, e.Resort })
                .HasName("RESERVATION_NAME_IND10");

            entity.HasIndex(e => new { e.CustomReference, e.Resort })
                .HasName("RESERVATION_NAME_IND13");

            entity.HasIndex(e => new { e.Resort, e.ConfirmationNo })
                .HasName("RESERVATION_NAME_IND5");

            entity.HasIndex(e => new { e.Resort, e.ExternalReference })
                .HasName("RESV_EXT_REF_IND1");

            entity.HasIndex(e => new { e.Resort, e.NameId })
                .HasName("RESERVATION_NAME_IND4");

            entity.HasIndex(e => new { e.Resort, e.UpdateDate })
                .HasName("RESV_NAME_UPD_DATE_IND");

            entity.HasIndex(e => new { e.UniCardId, e.Resort })
                .HasName("RESV_UNI_CARD_ID");

            entity.HasIndex(e => new { e.Resort, e.EventId, e.TruncBeginDate })
                .HasName("RESV_EVENT_IND");

            entity.HasIndex(e => new { e.Resort, e.OriginalEndDate, e.TruncEndDate })
                .HasName("RESERVATION_NAME_IND7");

            entity.HasIndex(e => new { e.Resort, e.SguestName, e.TruncBeginDate })
                .HasName("RESV_NAME_IND1");

            entity.HasIndex(e => new { e.TruncBeginDate, e.SguestName, e.ResvStatus })
                .HasName("RESV_NAME_IND2_MP");

            entity.HasIndex(e => new { e.Resort, e.NameUsageType, e.ParentResvNameId, e.NameId })
                .HasName("RESERVATION_NAME_IND3");

            entity.HasIndex(e => new { e.Resort, e.NameUsageType, e.SguestName, e.SguestFirstname })
                .HasName("RESV_NAME_ACCOMPANY_IDX");

            entity.HasIndex(e => new { e.Resort, e.PostCoFlag, e.FolioCloseDate, e.TruncEndDate })
                .HasName("RESV_NAME_FOLIO_CLOSE_IND");

            entity.HasIndex(e => new { e.Resort, e.ScheduleCheckoutYn, e.ResvStatus, e.EndDate })
                .HasName("RESERVATION_NAME_IND12");

            entity.HasIndex(e => new { e.TruncEndDate, e.TruncBeginDate, e.ResvStatus, e.Resort })
                .HasName("RESERVATION_NAME_IND9");

            entity.HasIndex(e => new { e.NameId, e.ActualCheckInDate, e.ActualCheckOutDate, e.TruncEndDate, e.Resort })
                .HasName("RESERVATION_NAME_IND1");

            entity.HasIndex(e => new { e.Resort, e.ResvStatus, e.TruncEndDate, e.ResvNameId, e.InsertActionInstanceId })
                .HasName("RESV_NAME_STAT_END_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.TruncBeginDate, e.SguestName, e.SguestFirstname, e.ResvStatus })
                .HasName("RESV_NAME_IND2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmenityEligibleYn)
                .HasColumnName("AMENITY_ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmenityLevelCode)
                .HasColumnName("AMENITY_LEVEL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmountPercent)
                .HasColumnName("AMOUNT_PERCENT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalCarrierCode)
                .HasColumnName("ARRIVAL_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalComments)
                .HasColumnName("ARRIVAL_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalEstimateTime)
                .HasColumnName("ARRIVAL_ESTIMATE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalStationCode)
                .HasColumnName("ARRIVAL_STATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalTranportationYn)
                .HasColumnName("ARRIVAL_TRANPORTATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ArrivalTransportCode)
                .HasColumnName("ARRIVAL_TRANSPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalTransportType)
                .HasColumnName("ARRIVAL_TRANSPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AsbProratedYn)
                .HasColumnName("ASB_PRORATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorizedBy)
                .HasColumnName("AUTHORIZED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoCheckinYn)
                .HasColumnName("AUTO_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoSettleDays)
                .HasColumnName("AUTO_SETTLE_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoSettleYn)
                .HasColumnName("AUTO_SETTLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardMembershipId)
                .HasColumnName("AWARD_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BaseRateCode)
                .HasColumnName("BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateCurrencyCode)
                .HasColumnName("BASE_RATE_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusCheckId)
                .HasColumnName("BONUS_CHECK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancellationReasonCode)
                .HasColumnName("CANCELLATION_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancellationReasonDesc)
                .HasColumnName("CANCELLATION_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionHoldCode)
                .HasColumnName("COMMISSION_HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"0");

            entity.Property(e => e.CommissionPayoutTo)
                .HasColumnName("COMMISSION_PAYOUT_TO")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfirmationLegNo)
                .HasColumnName("CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerYn)
                .HasColumnName("CONSUMER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomReference)
                .HasColumnName("CUSTOM_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DateOfArrivalInCountry)
                .HasColumnName("DATE_OF_ARRIVAL_IN_COUNTRY")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureCarrierCode)
                .HasColumnName("DEPARTURE_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureComments)
                .HasColumnName("DEPARTURE_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureEstimateTime)
                .HasColumnName("DEPARTURE_ESTIMATE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureStationCode)
                .HasColumnName("DEPARTURE_STATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureTransportCode)
                .HasColumnName("DEPARTURE_TRANSPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureTransportType)
                .HasColumnName("DEPARTURE_TRANSPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureTransportationYn)
                .HasColumnName("DEPARTURE_TRANSPORTATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.DirectBillVerifyResponse)
                .HasColumnName("DIRECT_BILL_VERIFY_RESPONSE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountPrcnt)
                .HasColumnName("DISCOUNT_PRCNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailFolioYn)
                .HasColumnName("EMAIL_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxYn)
                .HasColumnName("FAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinanciallyResponsibleYn)
                .HasColumnName("FINANCIALLY_RESPONSIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.FolioCloseDate)
                .HasColumnName("FOLIO_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioText1)
                .HasColumnName("FOLIO_TEXT1")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioText2)
                .HasColumnName("FOLIO_TEXT2")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteeCodePreCi)
                .HasColumnName("GUARANTEE_CODE_PRE_CI")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestFirstNameSdx)
                .HasColumnName("GUEST_FIRST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestLastNameSdx)
                .HasColumnName("GUEST_LAST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IntermediaryYn)
                .HasColumnName("INTERMEDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

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
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LocalBaseRateAmount)
                .HasColumnName("LOCAL_BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MobileAudioKeyYn)
                .HasColumnName("MOBILE_AUDIO_KEY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameUsageType)
                .IsRequired()
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'DG'");

            entity.Property(e => e.NextDestination)
                .HasColumnName("NEXT_DESTINATION")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.OriginalBeginDate)
                .HasColumnName("ORIGINAL_BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerFfFlag)
                .HasColumnName("OWNER_FF_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PeriodicFolioFreq)
                .HasColumnName("PERIODIC_FOLIO_FREQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneDisplayNameYn)
                .HasColumnName("PHONE_DISPLAY_NAME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionOverride)
                .HasColumnName("RESTRICTION_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueTypeCode)
                .HasColumnName("REVENUE_TYPE_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomFeatures)
                .HasColumnName("ROOM_FEATURES")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SguestFirstname)
                .HasColumnName("SGUEST_FIRSTNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShareSeqNo)
                .HasColumnName("SHARE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpgDiscloseRoomTypeYn)
                .HasColumnName("SPG_DISCLOSE_ROOM_TYPE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SpgSuiteNightAwardStatus)
                .HasColumnName("SPG_SUITE_NIGHT_AWARD_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SpgUpgradeConfirmedRoomtype)
                .HasColumnName("SPG_UPGRADE_CONFIRMED_ROOMTYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SpgUpgradeReasonCode)
                .HasColumnName("SPG_UPGRADE_REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SplitFromResvNameId)
                .HasColumnName("SPLIT_FROM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticalRateTier)
                .HasColumnName("STATISTICAL_RATE_TIER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatisticalRoomType)
                .HasColumnName("STATISTICAL_ROOM_TYPE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SuperSearchIndexText)
                .HasColumnName("SUPER_SEARCH_INDEX_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxNoOfStays)
                .HasColumnName("TAX_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxRegistrationNo)
                .HasColumnName("TAX_REGISTRATION_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tiad)
                .HasColumnName("TIAD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckInDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TruncActualCheckOutDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TurndownYn)
                .HasColumnName("TURNDOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UniCardId)
                .HasColumnName("UNI_CARD_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VideoCheckoutYn)
                .HasColumnName("VIDEO_CHECKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VisaExpirationDate)
                .HasColumnName("VISA_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VisaIssueDate)
                .HasColumnName("VISA_ISSUE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VisaNumber)
                .HasColumnName("VISA_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WlPriority)
                .HasColumnName("WL_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WlReasonCode)
                .HasColumnName("WL_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WlReasonDescription)
                .HasColumnName("WL_REASON_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WlTelephoneNo)
                .HasColumnName("WL_TELEPHONE_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(NameCreditCard)))
				entity.Ignore(e => e.CreditCard);
			else
	            entity.HasOne(d => d.CreditCard)
	                .WithMany(p => p.ReservationName)
	                .HasForeignKey(d => d.CreditCardId)
	                .HasConstraintName("RESERVATION_NAME_CC_CARD_FK");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.ReservationName)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_NAME_FK1");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ReservationName)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_NAME_FK3");

            if (!types.Contains(typeof(FacilityScheduleDates)))
				entity.Ignore(e => e.FacilityScheduleDates);

            if (!types.Contains(typeof(Qrooms)))
				entity.Ignore(e => e.Qrooms);

            if (!types.Contains(typeof(ReservationBalances)))
				entity.Ignore(e => e.ReservationBalances);

            if (!types.Contains(typeof(ReservationCancelList)))
				entity.Ignore(e => e.ReservationCancelList);
        
			if (!types.Contains(typeof(AmandaInfo)))
				entity.Ignore(e => e.AmandaInfo);

			if (!types.Contains(typeof(CustomFacilityCodesSchedule)))
				entity.Ignore(e => e.CustomFacilityCodesSchedule);

			if (!types.Contains(typeof(CustomFacilityTaskHeader)))
				entity.Ignore(e => e.CustomFacilityTaskHeader);

			if (!types.Contains(typeof(CustomFacilityTaskSchedule)))
				entity.Ignore(e => e.CustomFacilityTaskSchedule);

			if (!types.Contains(typeof(GuestRsvMessages)))
				entity.Ignore(e => e.GuestRsvMessages);

			if (!types.Contains(typeof(Locators)))
				entity.Ignore(e => e.Locators);

			if (!types.Contains(typeof(ReservationChanges)))
				entity.Ignore(e => e.ReservationChanges);

			if (!types.Contains(typeof(ReservationCommPref)))
				entity.Ignore(e => e.ReservationCommPref);

			if (!types.Contains(typeof(ReservationComment)))
				entity.Ignore(e => e.ReservationComment);

			if (!types.Contains(typeof(ReservationConfLetter)))
				entity.Ignore(e => e.ReservationConfLetter);

			if (!types.Contains(typeof(ReservationDailyElementName)))
				entity.Ignore(e => e.ReservationDailyElementName);

			if (!types.Contains(typeof(ReservationDepositSchedule)))
				entity.Ignore(e => e.ReservationDepositSchedule);

			if (!types.Contains(typeof(ReservationFeatures)))
				entity.Ignore(e => e.ReservationFeatures);

			if (!types.Contains(typeof(ReservationItems)))
				entity.Ignore(e => e.ReservationItems);

			if (!types.Contains(typeof(ReservationKeyOptions)))
				entity.Ignore(e => e.ReservationKeyOptions);

			if (!types.Contains(typeof(ReservationLinkageCnr)))
				entity.Ignore(e => e.ReservationLinkageCnrReservationName);

			if (!types.Contains(typeof(ReservationLinkageCnr)))
				entity.Ignore(e => e.ReservationLinkageCnrReservationNameNavigation);

			if (!types.Contains(typeof(ReservationLoyaltySegments)))
				entity.Ignore(e => e.ReservationLoyaltySegments);

			if (!types.Contains(typeof(ReservationOverrides)))
				entity.Ignore(e => e.ReservationOverrides);

			if (!types.Contains(typeof(ReservationProducts)))
				entity.Ignore(e => e.ReservationProducts);

			if (!types.Contains(typeof(ReservationPromotions)))
				entity.Ignore(e => e.ReservationPromotions);

			if (!types.Contains(typeof(ReservationReceipts)))
				entity.Ignore(e => e.ReservationReceipts);

			if (!types.Contains(typeof(ReservationReceiptsJrnl)))
				entity.Ignore(e => e.ReservationReceiptsJrnl);

			if (!types.Contains(typeof(ReservationSpecialRequests)))
				entity.Ignore(e => e.ReservationSpecialRequests);

			if (!types.Contains(typeof(ReservationVirtual)))
				entity.Ignore(e => e.ReservationVirtual);

			if (!types.Contains(typeof(TrackitItems)))
				entity.Ignore(e => e.TrackitItems);

			if (!types.Contains(typeof(VouchersHeader)))
				entity.Ignore(e => e.VouchersHeader);
		});
	}
}

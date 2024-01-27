namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipTrxExpVw
{
    public decimal TrxMembershipTrxId { get; set; }
    public DateTime? TrxMembershipTrxDate { get; set; }
    public string TrxRecordType { get; set; }
    public string TrxResort { get; set; }
    public decimal TrxNameId { get; set; }
    public decimal TrxMembershipId { get; set; }
    public string TrxMembershipType { get; set; }
    public string TrxMembershipCardNo { get; set; }
    public string TrxMembershipLevel { get; set; }
    public DateTime TrxBeginDate { get; set; }
    public DateTime TrxEndDate { get; set; }
    public string TrxPmsNameId { get; set; }
    public string TrxPmsResvNo { get; set; }
    public string TrxPmsResvNameId { get; set; }
    public decimal? TrxStayRecordId { get; set; }
    public string TrxPopulationMethod { get; set; }
    public decimal? TrxAwardRequestId { get; set; }
    public decimal? TrxAwardOrderNo { get; set; }
    public decimal? TrxStay { get; set; }
    public decimal? TrxNights { get; set; }
    public string TrxCurrencyCode { get; set; }
    public string TrxPromotionCode1 { get; set; }
    public string TrxPromotionCode2 { get; set; }
    public string TrxPromotionCode3 { get; set; }
    public decimal? TrxTotalRevenue { get; set; }
    public decimal? TrxTotalPoints { get; set; }
    public decimal? TrxTotalBasePoints { get; set; }
    public decimal? TrxTotalBonusPoints { get; set; }
    public decimal? TrxTotalMiscPoints { get; set; }
    public decimal? TrxOldBalancePoints { get; set; }
    public decimal? TrxMembershipBaseNights { get; set; }
    public decimal? TrxMembershipBaseRevenue { get; set; }
    public decimal? TrxMembershipBonusNights { get; set; }
    public decimal? TrxMembershipBonusRevenue { get; set; }
    public decimal? TrxPointsCost { get; set; }
    public DateTime? TrxPointsCreditDate { get; set; }
    public string TrxPointsCalculatedYn { get; set; }
    public string TrxProcessingMessages { get; set; }
    public string TrxDataExportedYn { get; set; }
    public DateTime? TrxDataExportedDate { get; set; }
    public decimal TrxInsertUser { get; set; }
    public DateTime TrxInsertDate { get; set; }
    public decimal TrxUpdateUser { get; set; }
    public DateTime TrxUpdateDate { get; set; }
    public DateTime? TrxInactiveDate { get; set; }
    public string TrxAutomaticYn { get; set; }
    public string TrxAdjustmentYn { get; set; }
    public decimal? TrxParentMembershipTrxId { get; set; }
    public string TrxCrsBookNo { get; set; }
    public string TrxTransactionType { get; set; }
    public decimal? TrxMembershipBaseStay { get; set; }
    public decimal? TrxMembershipBonusStay { get; set; }
    public string TrxPointsRejectedReason { get; set; }
    public decimal? TrxStatementId { get; set; }
    public decimal? TrxMemberStatementId { get; set; }
    public decimal? TrxMultipleMembershipId { get; set; }
    public DateTime? TrxPointsExpirationDate { get; set; }
    public decimal TrxMembershipTrxLinkId { get; set; }
    public string TrxUserNotes { get; set; }
    public string TrxExceptionType { get; set; }
    public string TrxPointsAcYn { get; set; }
    public decimal? TrxCentralAvgRate { get; set; }
    public string TrxRoomLabel { get; set; }
    public string TrxPosCode { get; set; }
    public string StRecordType { get; set; }
    public DateTime? StBookDate { get; set; }
    public DateTime? StBookedArrivalDate { get; set; }
    public DateTime? StBookedDepartureDate { get; set; }
    public string StShareNo { get; set; }
    public string StPrimarySharer { get; set; }
    public DateTime? StCancellationDate { get; set; }
    public decimal? StCancelledRoomNights { get; set; }
    public decimal? StNoshowRoomNights { get; set; }
    public decimal? StAdults { get; set; }
    public decimal? StChildren { get; set; }
    public string StCrsBookNo { get; set; }
    public string StRoomLabel { get; set; }
    public string StRoomNumber { get; set; }
    public string StPmsCurrencyCode { get; set; }
    public string StSourceCode { get; set; }
    public string StChannel { get; set; }
    public string StPaymentMethod { get; set; }
    public string StCompYn { get; set; }
    public decimal? StGuestNameId { get; set; }
    public decimal? StCompanyNameId { get; set; }
    public decimal? StTravelNameId { get; set; }
    public decimal? StWholesalerNameId { get; set; }
    public decimal? StGroupNameId { get; set; }
    public decimal? StMiscNameId { get; set; }
    public string StResInsertSource { get; set; }
    public string StResInsertSourceType { get; set; }
    public decimal? StTotalRevenue { get; set; }
    public decimal? StRoomRevenue { get; set; }
    public decimal? StFbRevenue { get; set; }
    public decimal? StExchangeRate { get; set; }
    public string StAllotmentCode { get; set; }
    public string StUdfc01 { get; set; }
    public string StUdfc02 { get; set; }
    public string StUdfc03 { get; set; }
    public string StUdfc04 { get; set; }
    public string StUdfc05 { get; set; }
    public string StUdfc06 { get; set; }
    public string StUdfc07 { get; set; }
    public string StUdfc08 { get; set; }
    public string StUdfc09 { get; set; }
    public string StUdfc10 { get; set; }
    public decimal? StUdfn01 { get; set; }
    public decimal? StUdfn02 { get; set; }
    public decimal? StUdfn03 { get; set; }
    public decimal? StUdfn04 { get; set; }
    public decimal? StUdfn05 { get; set; }
    public DateTime? StUdfd01 { get; set; }
    public DateTime? StUdfd02 { get; set; }
    public DateTime? StUdfd03 { get; set; }
    public DateTime? StUdfd04 { get; set; }
    public DateTime? StUdfd05 { get; set; }
    public decimal? StMiscRevenue { get; set; }
    public decimal? StOtherRevenue { get; set; }
    public decimal? StNumberStay { get; set; }
    public decimal? StNumberNights { get; set; }
    public string StAdjustmentYn { get; set; }
    public string StUserNotes { get; set; }
    public string StPosCode { get; set; }
    public string StIataConsortia { get; set; }
    public string StWholesalerRecordLocator { get; set; }
    public decimal? StAllotmentHeaderId { get; set; }
    public decimal? StRoomRevenueTax { get; set; }
    public decimal? StFbRevenueTax { get; set; }
    public decimal? StMiscRevenueTax { get; set; }
    public decimal? StOtherRevenueTax { get; set; }
    public string MemMembershipType { get; set; }
    public string MemMembershipCardNo { get; set; }
    public string MemMembershipLevel { get; set; }
    public string MemNameOnCard { get; set; }
    public string MemComments { get; set; }
    public DateTime? MemJoinedDate { get; set; }
    public DateTime? MemExpirationDate { get; set; }
    public decimal? MemCreditLimit { get; set; }
    public string MemPrimaryAirlinePartner { get; set; }
    public string MemPointIndicator { get; set; }
    public decimal? MemCurrentPoints { get; set; }
    public string MemMemberIndicator { get; set; }
    public string MemMemberSubtype { get; set; }
    public DateTime? MemInactiveDate { get; set; }
    public decimal? MemOrderBy { get; set; }
    public DateTime? MemProcessExpirationDate { get; set; }
    public string MemEnrollmentCode { get; set; }
    public string MemGracePeriodIndicator { get; set; }
    public string MemMembershipStatus { get; set; }
    public string MemTrackData { get; set; }
    public decimal? MemPointsAvailable { get; set; }
    public string MemPrimaryMembershipYn { get; set; }
    public string MemCentralSetupYn { get; set; }
    public string MemMembershipClass { get; set; }
    public string MemCalculationMethod { get; set; }
    public decimal? MemCalculationMonths { get; set; }
    public decimal? MemExpirationMonth { get; set; }
    public decimal? MemCardValidYears { get; set; }
    public decimal? MemYearsToExpire { get; set; }
    public string MemExpirationDateRequired { get; set; }
    public string MemLevelRequired { get; set; }
    public string MemAwardGenerationMethod { get; set; }
    public decimal? MemBatchDelayPeriod { get; set; }
    public string MemAllowDupCardYn { get; set; }
    public string MemExceptionType { get; set; }
    public decimal? MemMultipleRoomsLimit { get; set; }
    public string MemBookerProgramYn { get; set; }
    public string MemPointsLabel { get; set; }
    public string MemEarningPreference { get; set; }
    public string MemMemberInfoDispSet { get; set; }
    public string MemAutoCardNoBasedOn { get; set; }
    public string MemDefaultMemStatus { get; set; }
    public string MemEnrollmentCodeReqYn { get; set; }
    public string NamName { get; set; }
    public string NamFirst { get; set; }
    public string NamMiddle { get; set; }
    public string NamDisplayName { get; set; }
    public string NamSalutation { get; set; }
    public string NamName2 { get; set; }
    public string NamName3 { get; set; }
    public string NamSname { get; set; }
    public string NamSfirst { get; set; }
    public string NamNameType { get; set; }
    public string NamNameTypeDesc { get; set; }
    public string NamTitle { get; set; }
    public string NamTitleName { get; set; }
    public string NamPosition { get; set; }
    public string NamProfession { get; set; }
    public string NamLegalCompany { get; set; }
    public string NamContactYn { get; set; }
    public string NamStreet1 { get; set; }
    public string NamStreet2 { get; set; }
    public string NamStreet3 { get; set; }
    public string NamStreet4 { get; set; }
    public string NamCity { get; set; }
    public string NamState { get; set; }
    public string NamStateDesc { get; set; }
    public string NamCountry { get; set; }
    public string NamCountryDesc { get; set; }
    public string NamZip { get; set; }
    public string NamCityExt { get; set; }
    public string NamAddrLanguageCode { get; set; }
    public string NamAddrLanguageDesc { get; set; }
    public string NamAddressindicator { get; set; }
    public string NamAddressTypeDesc { get; set; }
    public decimal? NamAddressId { get; set; }
    public string NamPreferredlanguage { get; set; }
    public string NamLanguageDesc { get; set; }
    public string NamCompany { get; set; }
    public string NamAltname { get; set; }
    public string NamAltfirst { get; set; }
    public string NamAltlanguage { get; set; }
    public string NamAlttitle { get; set; }
    public string NamAltsalution { get; set; }
    public string NamAddresslanguage { get; set; }
    public string NamSxname { get; set; }
    public string NamSxfirstName { get; set; }
    public string NamXdisplayName { get; set; }
    public string NamXlanguageDesc { get; set; }
    public string NamMailblock { get; set; }
    public string NamPassport { get; set; }
    public DateTime? NamBirthDate { get; set; }
    public string NamNationality { get; set; }
    public string NamNationalityDesc { get; set; }
    public decimal? NamPhoneId { get; set; }
    public string NamPhoneNo { get; set; }
    public string NamPhoneType { get; set; }
    public decimal? NamFaxId { get; set; }
    public string NamFaxNo { get; set; }
    public decimal? NamEmailId { get; set; }
    public string NamEmail { get; set; }
    public decimal? NamHomePhoneId { get; set; }
    public string NamHomePhoneNumber { get; set; }
    public decimal? NamBusinessPhoneId { get; set; }
    public string NamBusinessPhoneNumber { get; set; }
    public decimal? NamMobilePhoneId { get; set; }
    public string NamMobilePhoneNumber { get; set; }
    public decimal? NamWebPageId { get; set; }
    public string NamWebPage { get; set; }
    public string NamActiveYn { get; set; }
    public string NamHistoryYn { get; set; }
    public string NamAcctContact { get; set; }
    public string NamCblInd { get; set; }
    public string NamBlMsg { get; set; }
    public string NamVipStatus { get; set; }
    public string NamVipName { get; set; }
    public string NamArNo { get; set; }
    public string NamIataCorpNo { get; set; }
    public string NamIataCompType { get; set; }
    public string NamNameKeywords { get; set; }
    public string NamGender { get; set; }
    public string NamBirthPlace { get; set; }
    public string NamBirthCountry { get; set; }
    public decimal? NamCreditCardId { get; set; }
    public string NamCreditCardType { get; set; }
    public string NamCreditCardNumber { get; set; }
    public string NamCreditCardName { get; set; }
    public DateTime? NamCreditCardExpDate { get; set; }
    public string NamEnvelopeGreeting { get; set; }
    public string NamXenvelopeGreeting { get; set; }
    public string NamEmailYn { get; set; }
    public string NamPhoneYn { get; set; }
    public string NamSmsYn { get; set; }
    public string NamProtected { get; set; }
    public string NamUdfc01 { get; set; }
    public string NamUdfc02 { get; set; }
    public string NamUdfc03 { get; set; }
    public string NamUdfc04 { get; set; }
    public string NamUdfc05 { get; set; }
    public string NamUdfc06 { get; set; }
    public string NamUdfc07 { get; set; }
    public string NamUdfc08 { get; set; }
    public string NamUdfc09 { get; set; }
    public string NamUdfc10 { get; set; }
    public string NamUdfc11 { get; set; }
    public string NamUdfc12 { get; set; }
    public string NamUdfc13 { get; set; }
    public string NamUdfc14 { get; set; }
    public string NamUdfc15 { get; set; }
    public string NamUdfc16 { get; set; }
    public string NamUdfc17 { get; set; }
    public string NamUdfc18 { get; set; }
    public string NamUdfc19 { get; set; }
    public string NamUdfc20 { get; set; }
    public string NamUdfc21 { get; set; }
    public string NamUdfc22 { get; set; }
    public string NamUdfc23 { get; set; }
    public string NamUdfc24 { get; set; }
    public string NamUdfc25 { get; set; }
    public string NamUdfc26 { get; set; }
    public string NamUdfc27 { get; set; }
    public string NamUdfc28 { get; set; }
    public string NamUdfc29 { get; set; }
    public string NamUdfc30 { get; set; }
    public string NamUdfc31 { get; set; }
    public string NamUdfc32 { get; set; }
    public string NamUdfc33 { get; set; }
    public string NamUdfc34 { get; set; }
    public string NamUdfc35 { get; set; }
    public string NamUdfc36 { get; set; }
    public string NamUdfc37 { get; set; }
    public string NamUdfc38 { get; set; }
    public string NamUdfc39 { get; set; }
    public string NamUdfc40 { get; set; }
    public decimal? NamUdfn01 { get; set; }
    public decimal? NamUdfn02 { get; set; }
    public decimal? NamUdfn03 { get; set; }
    public decimal? NamUdfn04 { get; set; }
    public decimal? NamUdfn05 { get; set; }
    public decimal? NamUdfn06 { get; set; }
    public decimal? NamUdfn07 { get; set; }
    public decimal? NamUdfn08 { get; set; }
    public decimal? NamUdfn09 { get; set; }
    public decimal? NamUdfn10 { get; set; }
    public decimal? NamUdfn11 { get; set; }
    public decimal? NamUdfn12 { get; set; }
    public decimal? NamUdfn13 { get; set; }
    public decimal? NamUdfn14 { get; set; }
    public decimal? NamUdfn15 { get; set; }
    public decimal? NamUdfn16 { get; set; }
    public decimal? NamUdfn17 { get; set; }
    public decimal? NamUdfn18 { get; set; }
    public decimal? NamUdfn19 { get; set; }
    public decimal? NamUdfn20 { get; set; }
    public decimal? NamUdfn21 { get; set; }
    public decimal? NamUdfn22 { get; set; }
    public decimal? NamUdfn23 { get; set; }
    public decimal? NamUdfn24 { get; set; }
    public decimal? NamUdfn25 { get; set; }
    public decimal? NamUdfn26 { get; set; }
    public decimal? NamUdfn27 { get; set; }
    public decimal? NamUdfn28 { get; set; }
    public decimal? NamUdfn29 { get; set; }
    public decimal? NamUdfn30 { get; set; }
    public decimal? NamUdfn31 { get; set; }
    public decimal? NamUdfn32 { get; set; }
    public decimal? NamUdfn33 { get; set; }
    public decimal? NamUdfn34 { get; set; }
    public decimal? NamUdfn35 { get; set; }
    public decimal? NamUdfn36 { get; set; }
    public decimal? NamUdfn37 { get; set; }
    public decimal? NamUdfn38 { get; set; }
    public decimal? NamUdfn39 { get; set; }
    public decimal? NamUdfn40 { get; set; }
    public DateTime? NamUdfd01 { get; set; }
    public DateTime? NamUdfd02 { get; set; }
    public DateTime? NamUdfd03 { get; set; }
    public DateTime? NamUdfd04 { get; set; }
    public DateTime? NamUdfd05 { get; set; }
    public DateTime? NamUdfd06 { get; set; }
    public DateTime? NamUdfd07 { get; set; }
    public DateTime? NamUdfd08 { get; set; }
    public DateTime? NamUdfd09 { get; set; }
    public DateTime? NamUdfd10 { get; set; }
    public DateTime? NamUdfd11 { get; set; }
    public DateTime? NamUdfd12 { get; set; }
    public DateTime? NamUdfd13 { get; set; }
    public DateTime? NamUdfd14 { get; set; }
    public DateTime? NamUdfd15 { get; set; }
    public DateTime? NamUdfd16 { get; set; }
    public DateTime? NamUdfd17 { get; set; }
    public DateTime? NamUdfd18 { get; set; }
    public DateTime? NamUdfd19 { get; set; }
    public DateTime? NamUdfd20 { get; set; }
    public string SetExpDataYn { get; set; }
    public decimal MemNameId { get; set; }
    public string TrxBookedRoomLabel { get; set; }
    public string StBookedRoomLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxExpVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_TRX_EXP_VW");

            entity.Property(e => e.MemAllowDupCardYn)
                .HasColumnName("MEM_ALLOW_DUP_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemAutoCardNoBasedOn)
                .HasColumnName("MEM_AUTO_CARD_NO_BASED_ON")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MemAwardGenerationMethod)
                .HasColumnName("MEM_AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemBatchDelayPeriod)
                .HasColumnName("MEM_BATCH_DELAY_PERIOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemBookerProgramYn)
                .HasColumnName("MEM_BOOKER_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemCalculationMethod)
                .HasColumnName("MEM_CALCULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemCalculationMonths)
                .HasColumnName("MEM_CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemCardValidYears)
                .HasColumnName("MEM_CARD_VALID_YEARS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemCentralSetupYn)
                .HasColumnName("MEM_CENTRAL_SETUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemComments)
                .HasColumnName("MEM_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MemCreditLimit)
                .HasColumnName("MEM_CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemCurrentPoints)
                .HasColumnName("MEM_CURRENT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemDefaultMemStatus)
                .HasColumnName("MEM_DEFAULT_MEM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemEarningPreference)
                .HasColumnName("MEM_EARNING_PREFERENCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemEnrollmentCode)
                .HasColumnName("MEM_ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemEnrollmentCodeReqYn)
                .HasColumnName("MEM_ENROLLMENT_CODE_REQ_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemExceptionType)
                .HasColumnName("MEM_EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MemExpirationDate)
                .HasColumnName("MEM_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemExpirationDateRequired)
                .HasColumnName("MEM_EXPIRATION_DATE_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemExpirationMonth)
                .HasColumnName("MEM_EXPIRATION_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemGracePeriodIndicator)
                .HasColumnName("MEM_GRACE_PERIOD_INDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemInactiveDate)
                .HasColumnName("MEM_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemJoinedDate)
                .HasColumnName("MEM_JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemLevelRequired)
                .HasColumnName("MEM_LEVEL_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemMemberIndicator)
                .HasColumnName("MEM_MEMBER_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemMemberInfoDispSet)
                .HasColumnName("MEM_MEMBER_INFO_DISP_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MemMemberSubtype)
                .HasColumnName("MEM_MEMBER_SUBTYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemMembershipCardNo)
                .IsRequired()
                .HasColumnName("MEM_MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MemMembershipClass)
                .HasColumnName("MEM_MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemMembershipLevel)
                .HasColumnName("MEM_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemMembershipStatus)
                .HasColumnName("MEM_MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemMembershipType)
                .IsRequired()
                .HasColumnName("MEM_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemMultipleRoomsLimit)
                .HasColumnName("MEM_MULTIPLE_ROOMS_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemNameId)
                .HasColumnName("MEM_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemNameOnCard)
                .IsRequired()
                .HasColumnName("MEM_NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MemOrderBy)
                .HasColumnName("MEM_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemPointIndicator)
                .HasColumnName("MEM_POINT_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemPointsAvailable)
                .HasColumnName("MEM_POINTS_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemPointsLabel)
                .HasColumnName("MEM_POINTS_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemPrimaryAirlinePartner)
                .HasColumnName("MEM_PRIMARY_AIRLINE_PARTNER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemPrimaryMembershipYn)
                .HasColumnName("MEM_PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemProcessExpirationDate)
                .HasColumnName("MEM_PROCESS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemTrackData)
                .HasColumnName("MEM_TRACK_DATA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MemYearsToExpire)
                .HasColumnName("MEM_YEARS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamAcctContact)
                .HasColumnName("NAM_ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamActiveYn)
                .HasColumnName("NAM_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamAddrLanguageCode)
                .HasColumnName("NAM_ADDR_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamAddrLanguageDesc)
                .HasColumnName("NAM_ADDR_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamAddressId)
                .HasColumnName("NAM_ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamAddressTypeDesc)
                .HasColumnName("NAM_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamAddressindicator)
                .HasColumnName("NAM_ADDRESSINDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamAddresslanguage)
                .HasColumnName("NAM_ADDRESSLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamAltfirst)
                .HasColumnName("NAM_ALTFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamAltlanguage)
                .HasColumnName("NAM_ALTLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamAltname)
                .HasColumnName("NAM_ALTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamAltsalution)
                .HasColumnName("NAM_ALTSALUTION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.NamAlttitle)
                .HasColumnName("NAM_ALTTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamArNo)
                .HasColumnName("NAM_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.NamBirthCountry)
                .HasColumnName("NAM_BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamBirthDate)
                .HasColumnName("NAM_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NamBirthPlace)
                .HasColumnName("NAM_BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamBlMsg)
                .HasColumnName("NAM_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NamBusinessPhoneId)
                .HasColumnName("NAM_BUSINESS_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamBusinessPhoneNumber)
                .HasColumnName("NAM_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NamCblInd)
                .HasColumnName("NAM_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamCity)
                .HasColumnName("NAM_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamCityExt)
                .HasColumnName("NAM_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamCompany)
                .HasColumnName("NAM_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.NamContactYn)
                .IsRequired()
                .HasColumnName("NAM_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamCountry)
                .HasColumnName("NAM_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamCountryDesc)
                .HasColumnName("NAM_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamCreditCardExpDate)
                .HasColumnName("NAM_CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NamCreditCardId)
                .HasColumnName("NAM_CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamCreditCardName)
                .HasColumnName("NAM_CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NamCreditCardNumber)
                .HasColumnName("NAM_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NamCreditCardType)
                .HasColumnName("NAM_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NamDisplayName)
                .HasColumnName("NAM_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.NamEmail)
                .HasColumnName("NAM_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.NamEmailId)
                .HasColumnName("NAM_EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamEmailYn)
                .HasColumnName("NAM_EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamEnvelopeGreeting)
                .HasColumnName("NAM_ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NamFaxId)
                .HasColumnName("NAM_FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamFaxNo)
                .HasColumnName("NAM_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.NamFirst)
                .HasColumnName("NAM_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamGender)
                .HasColumnName("NAM_GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamHistoryYn)
                .HasColumnName("NAM_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamHomePhoneId)
                .HasColumnName("NAM_HOME_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamHomePhoneNumber)
                .HasColumnName("NAM_HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NamIataCompType)
                .HasColumnName("NAM_IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamIataCorpNo)
                .HasColumnName("NAM_IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamLanguageDesc)
                .HasColumnName("NAM_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamLegalCompany)
                .HasColumnName("NAM_LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamMailblock)
                .HasColumnName("NAM_MAILBLOCK")
                .IsUnicode(false);

            entity.Property(e => e.NamMiddle)
                .HasColumnName("NAM_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamMobilePhoneId)
                .HasColumnName("NAM_MOBILE_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamMobilePhoneNumber)
                .HasColumnName("NAM_MOBILE_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NamName)
                .HasColumnName("NAM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamName2)
                .HasColumnName("NAM_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamName3)
                .HasColumnName("NAM_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamNameKeywords)
                .HasColumnName("NAM_NAME_KEYWORDS")
                .IsUnicode(false);

            entity.Property(e => e.NamNameType)
                .IsRequired()
                .HasColumnName("NAM_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamNameTypeDesc)
                .HasColumnName("NAM_NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NamNationality)
                .HasColumnName("NAM_NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamNationalityDesc)
                .HasColumnName("NAM_NATIONALITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamPassport)
                .HasColumnName("NAM_PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamPhoneId)
                .HasColumnName("NAM_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamPhoneNo)
                .HasColumnName("NAM_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.NamPhoneType)
                .HasColumnName("NAM_PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NamPhoneYn)
                .HasColumnName("NAM_PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamPosition)
                .HasColumnName("NAM_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamPreferredlanguage)
                .HasColumnName("NAM_PREFERREDLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamProfession)
                .HasColumnName("NAM_PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamProtected)
                .HasColumnName("NAM_PROTECTED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamSalutation)
                .HasColumnName("NAM_SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.NamSfirst)
                .HasColumnName("NAM_SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamSmsYn)
                .HasColumnName("NAM_SMS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NamSname)
                .IsRequired()
                .HasColumnName("NAM_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamState)
                .HasColumnName("NAM_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamStateDesc)
                .HasColumnName("NAM_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamStreet1)
                .HasColumnName("NAM_STREET1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamStreet2)
                .HasColumnName("NAM_STREET2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamStreet3)
                .HasColumnName("NAM_STREET3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamStreet4)
                .HasColumnName("NAM_STREET4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamSxfirstName)
                .HasColumnName("NAM_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamSxname)
                .HasColumnName("NAM_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NamTitle)
                .HasColumnName("NAM_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NamTitleName)
                .HasColumnName("NAM_TITLE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc01)
                .HasColumnName("NAM_UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc02)
                .HasColumnName("NAM_UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc03)
                .HasColumnName("NAM_UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc04)
                .HasColumnName("NAM_UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc05)
                .HasColumnName("NAM_UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc06)
                .HasColumnName("NAM_UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc07)
                .HasColumnName("NAM_UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc08)
                .HasColumnName("NAM_UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc09)
                .HasColumnName("NAM_UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc10)
                .HasColumnName("NAM_UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc11)
                .HasColumnName("NAM_UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc12)
                .HasColumnName("NAM_UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc13)
                .HasColumnName("NAM_UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc14)
                .HasColumnName("NAM_UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc15)
                .HasColumnName("NAM_UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc16)
                .HasColumnName("NAM_UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc17)
                .HasColumnName("NAM_UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc18)
                .HasColumnName("NAM_UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc19)
                .HasColumnName("NAM_UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc20)
                .HasColumnName("NAM_UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc21)
                .HasColumnName("NAM_UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc22)
                .HasColumnName("NAM_UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc23)
                .HasColumnName("NAM_UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc24)
                .HasColumnName("NAM_UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc25)
                .HasColumnName("NAM_UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc26)
                .HasColumnName("NAM_UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc27)
                .HasColumnName("NAM_UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc28)
                .HasColumnName("NAM_UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc29)
                .HasColumnName("NAM_UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc30)
                .HasColumnName("NAM_UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc31)
                .HasColumnName("NAM_UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc32)
                .HasColumnName("NAM_UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc33)
                .HasColumnName("NAM_UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc34)
                .HasColumnName("NAM_UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc35)
                .HasColumnName("NAM_UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc36)
                .HasColumnName("NAM_UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc37)
                .HasColumnName("NAM_UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc38)
                .HasColumnName("NAM_UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc39)
                .HasColumnName("NAM_UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfc40)
                .HasColumnName("NAM_UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamUdfd01)
                .HasColumnName("NAM_UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd02)
                .HasColumnName("NAM_UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd03)
                .HasColumnName("NAM_UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd04)
                .HasColumnName("NAM_UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd05)
                .HasColumnName("NAM_UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd06)
                .HasColumnName("NAM_UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd07)
                .HasColumnName("NAM_UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd08)
                .HasColumnName("NAM_UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd09)
                .HasColumnName("NAM_UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd10)
                .HasColumnName("NAM_UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd11)
                .HasColumnName("NAM_UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd12)
                .HasColumnName("NAM_UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd13)
                .HasColumnName("NAM_UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd14)
                .HasColumnName("NAM_UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd15)
                .HasColumnName("NAM_UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd16)
                .HasColumnName("NAM_UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd17)
                .HasColumnName("NAM_UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd18)
                .HasColumnName("NAM_UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd19)
                .HasColumnName("NAM_UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfd20)
                .HasColumnName("NAM_UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.NamUdfn01)
                .HasColumnName("NAM_UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn02)
                .HasColumnName("NAM_UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn03)
                .HasColumnName("NAM_UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn04)
                .HasColumnName("NAM_UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn05)
                .HasColumnName("NAM_UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn06)
                .HasColumnName("NAM_UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn07)
                .HasColumnName("NAM_UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn08)
                .HasColumnName("NAM_UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn09)
                .HasColumnName("NAM_UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn10)
                .HasColumnName("NAM_UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn11)
                .HasColumnName("NAM_UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn12)
                .HasColumnName("NAM_UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn13)
                .HasColumnName("NAM_UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn14)
                .HasColumnName("NAM_UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn15)
                .HasColumnName("NAM_UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn16)
                .HasColumnName("NAM_UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn17)
                .HasColumnName("NAM_UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn18)
                .HasColumnName("NAM_UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn19)
                .HasColumnName("NAM_UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn20)
                .HasColumnName("NAM_UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn21)
                .HasColumnName("NAM_UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn22)
                .HasColumnName("NAM_UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn23)
                .HasColumnName("NAM_UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn24)
                .HasColumnName("NAM_UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn25)
                .HasColumnName("NAM_UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn26)
                .HasColumnName("NAM_UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn27)
                .HasColumnName("NAM_UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn28)
                .HasColumnName("NAM_UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn29)
                .HasColumnName("NAM_UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn30)
                .HasColumnName("NAM_UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn31)
                .HasColumnName("NAM_UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn32)
                .HasColumnName("NAM_UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn33)
                .HasColumnName("NAM_UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn34)
                .HasColumnName("NAM_UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn35)
                .HasColumnName("NAM_UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn36)
                .HasColumnName("NAM_UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn37)
                .HasColumnName("NAM_UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn38)
                .HasColumnName("NAM_UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn39)
                .HasColumnName("NAM_UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamUdfn40)
                .HasColumnName("NAM_UDFN40")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamVipName)
                .HasColumnName("NAM_VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NamVipStatus)
                .HasColumnName("NAM_VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NamWebPage)
                .HasColumnName("NAM_WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.NamWebPageId)
                .HasColumnName("NAM_WEB_PAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NamXdisplayName)
                .HasColumnName("NAM_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.NamXenvelopeGreeting)
                .HasColumnName("NAM_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NamXlanguageDesc)
                .HasColumnName("NAM_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NamZip)
                .HasColumnName("NAM_ZIP")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.SetExpDataYn)
                .HasColumnName("SET_EXP_DATA_YN")
                .IsUnicode(false);

            entity.Property(e => e.StAdjustmentYn)
                .HasColumnName("ST_ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StAdults)
                .HasColumnName("ST_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StAllotmentCode)
                .HasColumnName("ST_ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StAllotmentHeaderId)
                .HasColumnName("ST_ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StBookDate)
                .HasColumnName("ST_BOOK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StBookedArrivalDate)
                .HasColumnName("ST_BOOKED_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StBookedDepartureDate)
                .HasColumnName("ST_BOOKED_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StBookedRoomLabel)
                .HasColumnName("ST_BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StCancellationDate)
                .HasColumnName("ST_CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StCancelledRoomNights)
                .HasColumnName("ST_CANCELLED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StChannel)
                .HasColumnName("ST_CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StChildren)
                .HasColumnName("ST_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StCompYn)
                .HasColumnName("ST_COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StCompanyNameId)
                .HasColumnName("ST_COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StCrsBookNo)
                .HasColumnName("ST_CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StExchangeRate)
                .HasColumnName("ST_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StFbRevenue)
                .HasColumnName("ST_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StFbRevenueTax)
                .HasColumnName("ST_FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StGroupNameId)
                .HasColumnName("ST_GROUP_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StGuestNameId)
                .HasColumnName("ST_GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StIataConsortia)
                .HasColumnName("ST_IATA_CONSORTIA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StMiscNameId)
                .HasColumnName("ST_MISC_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StMiscRevenue)
                .HasColumnName("ST_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StMiscRevenueTax)
                .HasColumnName("ST_MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNoshowRoomNights)
                .HasColumnName("ST_NOSHOW_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNumberNights)
                .HasColumnName("ST_NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNumberStay)
                .HasColumnName("ST_NUMBER_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StOtherRevenue)
                .HasColumnName("ST_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StOtherRevenueTax)
                .HasColumnName("ST_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StPaymentMethod)
                .HasColumnName("ST_PAYMENT_METHOD")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.StPmsCurrencyCode)
                .HasColumnName("ST_PMS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StPosCode)
                .HasColumnName("ST_POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StPrimarySharer)
                .HasColumnName("ST_PRIMARY_SHARER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StRecordType)
                .HasColumnName("ST_RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StResInsertSource)
                .HasColumnName("ST_RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StResInsertSourceType)
                .HasColumnName("ST_RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StRoomLabel)
                .HasColumnName("ST_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StRoomNumber)
                .HasColumnName("ST_ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StRoomRevenue)
                .HasColumnName("ST_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StRoomRevenueTax)
                .HasColumnName("ST_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StShareNo)
                .HasColumnName("ST_SHARE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StSourceCode)
                .HasColumnName("ST_SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StTotalRevenue)
                .HasColumnName("ST_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StTravelNameId)
                .HasColumnName("ST_TRAVEL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUdfc01)
                .HasColumnName("ST_UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc02)
                .HasColumnName("ST_UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc03)
                .HasColumnName("ST_UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc04)
                .HasColumnName("ST_UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc05)
                .HasColumnName("ST_UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc06)
                .HasColumnName("ST_UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc07)
                .HasColumnName("ST_UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc08)
                .HasColumnName("ST_UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc09)
                .HasColumnName("ST_UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfc10)
                .HasColumnName("ST_UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StUdfd01)
                .HasColumnName("ST_UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.StUdfd02)
                .HasColumnName("ST_UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.StUdfd03)
                .HasColumnName("ST_UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.StUdfd04)
                .HasColumnName("ST_UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.StUdfd05)
                .HasColumnName("ST_UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.StUdfn01)
                .HasColumnName("ST_UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUdfn02)
                .HasColumnName("ST_UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUdfn03)
                .HasColumnName("ST_UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUdfn04)
                .HasColumnName("ST_UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUdfn05)
                .HasColumnName("ST_UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StUserNotes)
                .HasColumnName("ST_USER_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.StWholesalerNameId)
                .HasColumnName("ST_WHOLESALER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StWholesalerRecordLocator)
                .HasColumnName("ST_WHOLESALER_RECORD_LOCATOR")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.TrxAdjustmentYn)
                .IsRequired()
                .HasColumnName("TRX_ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxAutomaticYn)
                .HasColumnName("TRX_AUTOMATIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxAwardOrderNo)
                .HasColumnName("TRX_AWARD_ORDER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAwardRequestId)
                .HasColumnName("TRX_AWARD_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxBeginDate)
                .HasColumnName("TRX_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxBookedRoomLabel)
                .HasColumnName("TRX_BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxCentralAvgRate)
                .HasColumnName("TRX_CENTRAL_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCrsBookNo)
                .HasColumnName("TRX_CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxCurrencyCode)
                .HasColumnName("TRX_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDataExportedDate)
                .HasColumnName("TRX_DATA_EXPORTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDataExportedYn)
                .HasColumnName("TRX_DATA_EXPORTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxEndDate)
                .HasColumnName("TRX_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxExceptionType)
                .HasColumnName("TRX_EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TrxInactiveDate)
                .HasColumnName("TRX_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertDate)
                .HasColumnName("TRX_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertUser)
                .HasColumnName("TRX_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMemberStatementId)
                .HasColumnName("TRX_MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBaseNights)
                .HasColumnName("TRX_MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBaseRevenue)
                .HasColumnName("TRX_MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBaseStay)
                .HasColumnName("TRX_MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBonusNights)
                .HasColumnName("TRX_MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBonusRevenue)
                .HasColumnName("TRX_MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipBonusStay)
                .HasColumnName("TRX_MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipCardNo)
                .IsRequired()
                .HasColumnName("TRX_MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxMembershipId)
                .HasColumnName("TRX_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipLevel)
                .HasColumnName("TRX_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxMembershipTrxDate)
                .HasColumnName("TRX_MEMBERSHIP_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxMembershipTrxId)
                .HasColumnName("TRX_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipTrxLinkId)
                .HasColumnName("TRX_MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxMembershipType)
                .IsRequired()
                .HasColumnName("TRX_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxMultipleMembershipId)
                .HasColumnName("TRX_MULTIPLE_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNameId)
                .HasColumnName("TRX_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNights)
                .HasColumnName("TRX_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxOldBalancePoints)
                .HasColumnName("TRX_OLD_BALANCE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxParentMembershipTrxId)
                .HasColumnName("TRX_PARENT_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxPmsNameId)
                .HasColumnName("TRX_PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxPmsResvNameId)
                .HasColumnName("TRX_PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxPmsResvNo)
                .HasColumnName("TRX_PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxPointsAcYn)
                .IsRequired()
                .HasColumnName("TRX_POINTS_AC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxPointsCalculatedYn)
                .IsRequired()
                .HasColumnName("TRX_POINTS_CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxPointsCost)
                .HasColumnName("TRX_POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxPointsCreditDate)
                .HasColumnName("TRX_POINTS_CREDIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxPointsExpirationDate)
                .HasColumnName("TRX_POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxPointsRejectedReason)
                .HasColumnName("TRX_POINTS_REJECTED_REASON")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TrxPopulationMethod)
                .HasColumnName("TRX_POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxPosCode)
                .HasColumnName("TRX_POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxProcessingMessages)
                .HasColumnName("TRX_PROCESSING_MESSAGES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxPromotionCode1)
                .HasColumnName("TRX_PROMOTION_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxPromotionCode2)
                .HasColumnName("TRX_PROMOTION_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxPromotionCode3)
                .HasColumnName("TRX_PROMOTION_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxRecordType)
                .IsRequired()
                .HasColumnName("TRX_RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxResort)
                .IsRequired()
                .HasColumnName("TRX_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxRoomLabel)
                .HasColumnName("TRX_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxStatementId)
                .HasColumnName("TRX_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxStay)
                .HasColumnName("TRX_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxStayRecordId)
                .HasColumnName("TRX_STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTotalBasePoints)
                .HasColumnName("TRX_TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTotalBonusPoints)
                .HasColumnName("TRX_TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTotalMiscPoints)
                .HasColumnName("TRX_TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTotalPoints)
                .HasColumnName("TRX_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTotalRevenue)
                .HasColumnName("TRX_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTransactionType)
                .HasColumnName("TRX_TRANSACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxUpdateDate)
                .HasColumnName("TRX_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxUpdateUser)
                .HasColumnName("TRX_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxUserNotes)
                .HasColumnName("TRX_USER_NOTES")
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GenExtStayrecRev
{
    public decimal StayRecordId { get; set; }
    public string Resort { get; set; }
    public string PmsResvNo { get; set; }
    public string Status { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? BookDate { get; set; }
    public DateTime? BookedArrivalDate { get; set; }
    public DateTime? BookedDepartureDate { get; set; }
    public string ShareNo { get; set; }
    public string PrimarySharer { get; set; }
    public DateTime? CancellationDate { get; set; }
    public decimal? CancelledRoomNights { get; set; }
    public decimal? NoshowRoomNights { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string CrsBookNo { get; set; }
    public string RoomLabel { get; set; }
    public string RoomNumber { get; set; }
    public string PmsCurrencyCode { get; set; }
    public string SourceCode { get; set; }
    public string Channel { get; set; }
    public string PaymentMethod { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? TravelNameId { get; set; }
    public decimal? MiscNameId { get; set; }
    public string PmsNameId { get; set; }
    public string PmsCompanyId { get; set; }
    public string PmsTravelId { get; set; }
    public string PmsWholesalerId { get; set; }
    public string PmsGroupId { get; set; }
    public string PmsMiscId { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string AllotmentCode { get; set; }
    public string PmsResvNameId { get; set; }
    public decimal MembershipTrxLinkId { get; set; }
    public string PointsYn { get; set; }
    public decimal? MiscRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NumberStay { get; set; }
    public decimal? NumberNights { get; set; }
    public string PromotionCode1 { get; set; }
    public string PromotionCode2 { get; set; }
    public string PromotionCode3 { get; set; }
    public string IataConsortia { get; set; }
    public string WholesalerRecordLocator { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FbRevenueTax { get; set; }
    public decimal? MiscRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public string PseudoYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? Guestnameid1 { get; set; }
    public string DNameType { get; set; }
    public string DNameTypeDesc { get; set; }
    public string DContactYn { get; set; }
    public string DName { get; set; }
    public string DDisplayName { get; set; }
    public string DFirst { get; set; }
    public string DMiddle { get; set; }
    public string DSname { get; set; }
    public string DPassport { get; set; }
    public string DPassportStr { get; set; }
    public DateTime? DBirthDate { get; set; }
    public string DBirthDateStr { get; set; }
    public string DTitle { get; set; }
    public string DTitleName { get; set; }
    public string DLanguage { get; set; }
    public string DLanguageDesc { get; set; }
    public string DNationality { get; set; }
    public string DNationalityDesc { get; set; }
    public string DSalutation { get; set; }
    public string DLetterGreeting { get; set; }
    public string DAddressType { get; set; }
    public string DAddress1 { get; set; }
    public string DAddress2 { get; set; }
    public string DAddress3 { get; set; }
    public string DAddress4 { get; set; }
    public string DCity { get; set; }
    public string DState { get; set; }
    public string DStateDesc { get; set; }
    public string DCountry { get; set; }
    public string DCountryDesc { get; set; }
    public string DZipCode { get; set; }
    public string DCityExt { get; set; }
    public string DPhoneNo { get; set; }
    public string DPhoneType { get; set; }
    public string DFaxNo { get; set; }
    public string DEmail { get; set; }
    public string DActiveYn { get; set; }
    public string DCblInd { get; set; }
    public string DBlMsg { get; set; }
    public string DVipStatus { get; set; }
    public string DVipName { get; set; }
    public string DBusinessTitle { get; set; }
    public string DRateCode { get; set; }
    public string DArNo { get; set; }
    public string DNameComment { get; set; }
    public string DMembershipNumber { get; set; }
    public string DMembershipType { get; set; }
    public string DMembershipLevel { get; set; }
    public string DCommissionCode { get; set; }
    public string DCurrencyCode { get; set; }
    public string DCommPayCentral { get; set; }
    public string DIataCorpNo { get; set; }
    public string DKeyword { get; set; }
    public string DNameKeyword { get; set; }
    public string DGender { get; set; }
    public string DBirthPlace { get; set; }
    public string DBirthCountry { get; set; }
    public string DProfession { get; set; }
    public string DIdType { get; set; }
    public string DIdNumber { get; set; }
    public string DIdNumberStr { get; set; }
    public DateTime? DIdDate { get; set; }
    public string DIdPlace { get; set; }
    public string DIdCountry { get; set; }
    public string DComm1Type { get; set; }
    public string DComm1Value { get; set; }
    public string DComm2Type { get; set; }
    public string DComm2Value { get; set; }
    public string DComm3Type { get; set; }
    public string DComm3Value { get; set; }
    public DateTime? DMembershipExpirationDate { get; set; }
    public string DMembershipNameOnCard { get; set; }
    public string DCreditCardType { get; set; }
    public string DCreditCardNumber { get; set; }
    public string DCreditCardName { get; set; }
    public DateTime? DCreditCardExpirationDat { get; set; }
    public decimal? DPaymentDueDays { get; set; }
    public string DSfirst { get; set; }
    public string DCompany { get; set; }
    public string DXname { get; set; }
    public string DXfirstName { get; set; }
    public string DXtitle { get; set; }
    public string DXsalutation { get; set; }
    public string DSxname { get; set; }
    public string DSxfirstName { get; set; }
    public string DXdisplayName { get; set; }
    public DateTime? DInactiveDate { get; set; }
    public string DEnvelopeGreeting { get; set; }
    public string DXenvelopeGreeting { get; set; }
    public string DHomePhoneNumber { get; set; }
    public string DBusinessPhoneNumber { get; set; }
    public string DMobilePhoneNumber { get; set; }
    public string DXlanguage { get; set; }
    public string DXlanguageDesc { get; set; }
    public string DArNoCentral { get; set; }
    public string DMembershipStatus { get; set; }
    public string DAddressTypeDesc { get; set; }
    public string DCcExpDtStr { get; set; }
    public string DCreditCardNumberStr { get; set; }
    public decimal? DTitleSuffix { get; set; }
    public string DEmailYn { get; set; }
    public string DSpecials { get; set; }
    public string DFeatures { get; set; }
    public string DActioncode { get; set; }
    public string DAutoenrollMemberyn { get; set; }
    public string DAvailoverYn { get; set; }
    public string DBillingInstr { get; set; }
    public string DHistoryYn { get; set; }
    public string DMailYn { get; set; }
    public string DMarkets { get; set; }
    public string DMultAddressYn { get; set; }
    public string DMultPhonesYn { get; set; }
    public string DMultCommentsYn { get; set; }
    public string DMailList { get; set; }
    public decimal? TaNameid { get; set; }
    public string TaNameType { get; set; }
    public string TaNameTypeDesc { get; set; }
    public string TaName { get; set; }
    public string TaDisplayName { get; set; }
    public string TaSname { get; set; }
    public string TaLanguage { get; set; }
    public string TaLanguageDesc { get; set; }
    public string TaAddressType { get; set; }
    public string TaAddress1 { get; set; }
    public string TaAddress2 { get; set; }
    public string TaAddress3 { get; set; }
    public string TaAddress4 { get; set; }
    public string TaCity { get; set; }
    public string TaState { get; set; }
    public string TaStateDesc { get; set; }
    public string TaCountry { get; set; }
    public string TaCountryDesc { get; set; }
    public string TaZipCode { get; set; }
    public string TaCityExt { get; set; }
    public string TaPhoneNo { get; set; }
    public string TaPhoneType { get; set; }
    public string TaFaxNo { get; set; }
    public string TaEmail { get; set; }
    public string TaActiveYn { get; set; }
    public string TaCblInd { get; set; }
    public string TaBlMsg { get; set; }
    public string TaRateCode { get; set; }
    public string TaArNo { get; set; }
    public string TaNameComment { get; set; }
    public string TaMembershipNumber { get; set; }
    public string TaMembershipType { get; set; }
    public string TaMembershipLevel { get; set; }
    public string TaCommissionCode { get; set; }
    public string TaCurrencyCode { get; set; }
    public string TaCommPayCentral { get; set; }
    public string TaIataCorpNo { get; set; }
    public string TaIataCompType { get; set; }
    public string TaKeyword { get; set; }
    public string TaComm1Type { get; set; }
    public string TaComm1Value { get; set; }
    public string TaComm2Type { get; set; }
    public string TaComm2Value { get; set; }
    public string TaComm3Type { get; set; }
    public string TaComm3Value { get; set; }
    public DateTime? TaMembershipExpirationDate { get; set; }
    public string TaMembershipNameOnCard { get; set; }
    public string TaCreditCardType { get; set; }
    public string TaCreditCardNumber { get; set; }
    public string TaCreditCardName { get; set; }
    public DateTime? TaCreditCardExpirationDat { get; set; }
    public decimal? TaPaymentDueDays { get; set; }
    public string TaCompany { get; set; }
    public string TaLastGroup { get; set; }
    public string TaLastSource { get; set; }
    public string TaXname { get; set; }
    public string TaSxname { get; set; }
    public string TaSxfirstName { get; set; }
    public string TaXdisplayName { get; set; }
    public DateTime? TaInactiveDate { get; set; }
    public string TaEnvelopeGreeting { get; set; }
    public string TaHomePhoneNumber { get; set; }
    public string TaBusinessPhoneNumber { get; set; }
    public string TaMobilePhoneNumber { get; set; }
    public string TaWebPage { get; set; }
    public string TaXlanguage { get; set; }
    public string TaXlanguageDesc { get; set; }
    public string TaArNoCentral { get; set; }
    public string TaMembershipStatus { get; set; }
    public string TaAddressTypeDesc { get; set; }
    public string TaCreditCardNumberStr { get; set; }
    public string TaSpecials { get; set; }
    public string TaFeatures { get; set; }
    public string TaAccountsource { get; set; }
    public string TaAccountType { get; set; }
    public string TaActioncode { get; set; }
    public string TaAutoenrollMemberyn { get; set; }
    public string TaAvailoverYn { get; set; }
    public string TaBillingInstr { get; set; }
    public string TaCommAccountName { get; set; }
    public string TaHistoryYn { get; set; }
    public string TaIndustryCode { get; set; }
    public string TaMailYn { get; set; }
    public string TaMarkets { get; set; }
    public string TaMultAddressYn { get; set; }
    public string TaMultPhonesYn { get; set; }
    public string TaMultCommentsYn { get; set; }
    public string GpName { get; set; }
    public string GpDisplayName { get; set; }
    public string GpLanguage { get; set; }
    public string GpLanguageDesc { get; set; }
    public string GpAddressType { get; set; }
    public string GpAddress1 { get; set; }
    public string GpAddress2 { get; set; }
    public string GpAddress3 { get; set; }
    public string GpAddress4 { get; set; }
    public string GpCity { get; set; }
    public string GpState { get; set; }
    public string GpStateDesc { get; set; }
    public string GpCountry { get; set; }
    public string GpCountryDesc { get; set; }
    public string GpZipCode { get; set; }
    public string GpCityExt { get; set; }
    public string GpPhoneNo { get; set; }
    public string GpPhoneType { get; set; }
    public string GpFaxNo { get; set; }
    public string GpEmail { get; set; }
    public string GpActiveYn { get; set; }
    public string GpCblInd { get; set; }
    public string GpBlMsg { get; set; }
    public string GpVipStatus { get; set; }
    public string GpVipName { get; set; }
    public string GpRateCode { get; set; }
    public string GpArNo { get; set; }
    public string GpNameComment { get; set; }
    public string GpCommissionCode { get; set; }
    public string GpCurrencyCode { get; set; }
    public string GpCommPayCentral { get; set; }
    public string GpKeyword { get; set; }
    public string GpComm1Type { get; set; }
    public string GpComm1Value { get; set; }
    public string GpComm2Type { get; set; }
    public string GpComm2Value { get; set; }
    public string GpComm3Type { get; set; }
    public string GpComm3Value { get; set; }
    public decimal? GpPaymentDueDays { get; set; }
    public string GpCompany { get; set; }
    public string GpLastGroup { get; set; }
    public string GpLastSource { get; set; }
    public string GpXname { get; set; }
    public string GpXdisplayName { get; set; }
    public DateTime? GpInactiveDate { get; set; }
    public string GpHomePhoneNumber { get; set; }
    public string GpBusinessPhoneNumber { get; set; }
    public string GpMobilePhoneNumber { get; set; }
    public string GpWebPage { get; set; }
    public string GpXlanguage { get; set; }
    public string GpXlanguageDesc { get; set; }
    public string GpArNoCentral { get; set; }
    public string GpAddressTypeDesc { get; set; }
    public string GpSpecials { get; set; }
    public string GpFeatues { get; set; }
    public string GpAvailoverYn { get; set; }
    public string GpBillingInstr { get; set; }
    public string GpHistoryYn { get; set; }
    public string GpIndustryCode { get; set; }
    public string GpMailYn { get; set; }
    public string GpMarkets { get; set; }
    public string GpMultAddressYn { get; set; }
    public string GpMultPhonesYn { get; set; }
    public string GpMultCommentsYn { get; set; }
    public decimal? CNameid { get; set; }
    public string CNameType { get; set; }
    public string CNameTypeDesc { get; set; }
    public string CName { get; set; }
    public string CDisplayName { get; set; }
    public string CLanguage { get; set; }
    public string CLanguageDesc { get; set; }
    public string CAddressType { get; set; }
    public string CAddress1 { get; set; }
    public string CAddress2 { get; set; }
    public string CAddress3 { get; set; }
    public string CAddress4 { get; set; }
    public string CCity { get; set; }
    public string CState { get; set; }
    public string CStateDesc { get; set; }
    public string CCountry { get; set; }
    public string CCountryDesc { get; set; }
    public string CZipCode { get; set; }
    public string CCityExt { get; set; }
    public string CFaxNo { get; set; }
    public string CEmail { get; set; }
    public string CActiveYn { get; set; }
    public string CCblInd { get; set; }
    public string CBlMsg { get; set; }
    public string CBusinessTitle { get; set; }
    public string CRateCode { get; set; }
    public string CArNo { get; set; }
    public string CNameComment { get; set; }
    public string CMembershipNumber { get; set; }
    public string CMembershipType { get; set; }
    public string CMembershipLevel { get; set; }
    public string CCommissionCode { get; set; }
    public string CCommPayCentral { get; set; }
    public string CIataCorpNo { get; set; }
    public string CIataCompType { get; set; }
    public string CKeyword { get; set; }
    public string CComm1Type { get; set; }
    public string CComm1Value { get; set; }
    public string CComm2Type { get; set; }
    public string CComm2Value { get; set; }
    public string CComm3Type { get; set; }
    public string CComm3Value { get; set; }
    public decimal? CMembershipId { get; set; }
    public DateTime? CMembershipExpirationDate { get; set; }
    public string CMembershipNameOnCard { get; set; }
    public string CCreditCardType { get; set; }
    public string CCreditCardNumber { get; set; }
    public string CCreditCardName { get; set; }
    public DateTime? CCreditCardExpirationDat { get; set; }
    public string CCompany { get; set; }
    public string CLastSource { get; set; }
    public string CXname { get; set; }
    public DateTime? CInactiveDate { get; set; }
    public string CBusinessPhoneNumber { get; set; }
    public string CWebPage { get; set; }
    public string CXlanguage { get; set; }
    public string CXlanguageDesc { get; set; }
    public string CArNoCentral { get; set; }
    public string CMembershipStatus { get; set; }
    public string CAddressTypeDesc { get; set; }
    public string CCcExpDtStr { get; set; }
    public string CCreditCardNumberStr { get; set; }
    public string CEmailYn { get; set; }
    public string CAccountsource { get; set; }
    public string CAccountType { get; set; }
    public string CActioncode { get; set; }
    public string CAutoenrollMemberyn { get; set; }
    public string CAvailoverYn { get; set; }
    public string CBillingInstr { get; set; }
    public string CHistoryYn { get; set; }
    public string CIndustryCode { get; set; }
    public string CMailYn { get; set; }
    public string CMarkets { get; set; }
    public string CMultPhonesYn { get; set; }
    public string WsNameType { get; set; }
    public string WsNameTypeDesc { get; set; }
    public string WsName { get; set; }
    public string WsDisplayName { get; set; }
    public string WsSname { get; set; }
    public string WsTitle { get; set; }
    public string WsLanguage { get; set; }
    public string WsLanguageDesc { get; set; }
    public string WsAddressType { get; set; }
    public string WsAddress1 { get; set; }
    public string WsAddress2 { get; set; }
    public string WsAddress3 { get; set; }
    public string WsAddress4 { get; set; }
    public string WsCity { get; set; }
    public string WsState { get; set; }
    public string WsStateDesc { get; set; }
    public string WsCountry { get; set; }
    public string WsCountryDesc { get; set; }
    public string WsZipCode { get; set; }
    public string WsCityExt { get; set; }
    public string WsPhoneNo { get; set; }
    public string WsPhoneType { get; set; }
    public string WsFaxNo { get; set; }
    public string WsEmail { get; set; }
    public string WsActiveYn { get; set; }
    public string WsCblInd { get; set; }
    public string WsRateCode { get; set; }
    public string WsArNo { get; set; }
    public string WsNameComment { get; set; }
    public string WsMembershipNumber { get; set; }
    public string WsMembershipType { get; set; }
    public string WsMembershipLevel { get; set; }
    public string WsCommissionCode { get; set; }
    public string WsCurrencyCode { get; set; }
    public string WsIataCorpNo { get; set; }
    public string WsIataCompType { get; set; }
    public string WsKeyword { get; set; }
    public string WsComm1Type { get; set; }
    public string WsComm1Value { get; set; }
    public string WsComm2Type { get; set; }
    public string WsComm2Value { get; set; }
    public string WsComm3Type { get; set; }
    public string WsComm3Value { get; set; }
    public DateTime? WsMembershipExpirationDate { get; set; }
    public string WsMembershipNameOnCard { get; set; }
    public string WsCreditCardType { get; set; }
    public string WsCreditCardNumber { get; set; }
    public string WsCreditCardName { get; set; }
    public DateTime? WsCreditCardExpirationDat { get; set; }
    public decimal? WsPaymentDueDays { get; set; }
    public string WsXname { get; set; }
    public string WsSxname { get; set; }
    public string WsXdisplayName { get; set; }
    public DateTime? WsInactiveDate { get; set; }
    public string WsHomePhoneNumber { get; set; }
    public string WsBusinessPhoneNumber { get; set; }
    public string WsMobilePhoneNumber { get; set; }
    public string WsWebPage { get; set; }
    public string WsXlanguage { get; set; }
    public string WsXlanguageDesc { get; set; }
    public string WsArNoCentral { get; set; }
    public string WsMembershipStatus { get; set; }
    public string WsAddressTypeDesc { get; set; }
    public string WsCreditCardNumberStr { get; set; }
    public string WsSpecials { get; set; }
    public string WsFeatues { get; set; }
    public string WsAccountsource { get; set; }
    public string WsAccountType { get; set; }
    public string WsActioncode { get; set; }
    public string WsAutoenrollMemberyn { get; set; }
    public string WsAvailoverYn { get; set; }
    public string WsBillingInstr { get; set; }
    public string WsHistoryYn { get; set; }
    public string WsIndustryCode { get; set; }
    public string WsMailYn { get; set; }
    public string WsMarkets { get; set; }
    public string WsMultAddressYn { get; set; }
    public string WsMultPhonesYn { get; set; }
    public string WsMultCommentsYn { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string TransactionRevenueType { get; set; }
    public decimal? LocalRevenueAmount { get; set; }
    public decimal? CentralRevenueAmount { get; set; }
    public string MembershipRevenueType { get; set; }
    public string Description { get; set; }
    public string Label { get; set; }
    public string ExportBucketCode { get; set; }
    public decimal? RevenueOrderBy { get; set; }
    public string AllRatecodes { get; set; }
    public string AllMrktcodes { get; set; }
    public string AllRevtypes { get; set; }
    public decimal? KeyTransDate { get; set; }
    public string KeyTransRevenueType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GenExtStayrecRev>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEN_EXT_STAYREC_REV");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllMrktcodes)
                .HasColumnName("ALL_MRKTCODES")
                .IsUnicode(false);

            entity.Property(e => e.AllRatecodes)
                .HasColumnName("ALL_RATECODES")
                .IsUnicode(false);

            entity.Property(e => e.AllRevtypes)
                .HasColumnName("ALL_REVTYPES")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookDate)
                .HasColumnName("BOOK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedArrivalDate)
                .HasColumnName("BOOKED_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedDepartureDate)
                .HasColumnName("BOOKED_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CAccountType)
                .HasColumnName("C_ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CAccountsource)
                .HasColumnName("C_ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CActioncode)
                .HasColumnName("C_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.CActiveYn)
                .HasColumnName("C_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CAddress1)
                .HasColumnName("C_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CAddress2)
                .HasColumnName("C_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CAddress3)
                .HasColumnName("C_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CAddress4)
                .HasColumnName("C_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CAddressType)
                .HasColumnName("C_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CAddressTypeDesc)
                .HasColumnName("C_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CArNo)
                .HasColumnName("C_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.CArNoCentral)
                .HasColumnName("C_AR_NO_CENTRAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CAutoenrollMemberyn)
                .HasColumnName("C_AUTOENROLL_MEMBERYN")
                .IsUnicode(false);

            entity.Property(e => e.CAvailoverYn)
                .HasColumnName("C_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CBillingInstr)
                .HasColumnName("C_BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.CBlMsg)
                .HasColumnName("C_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CBusinessPhoneNumber)
                .HasColumnName("C_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CBusinessTitle)
                .HasColumnName("C_BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CCblInd)
                .HasColumnName("C_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CCcExpDtStr)
                .HasColumnName("C_CC_EXP_DT_STR")
                .IsUnicode(false);

            entity.Property(e => e.CCity)
                .HasColumnName("C_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CCityExt)
                .HasColumnName("C_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CComm1Type)
                .HasColumnName("C_COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CComm1Value)
                .HasColumnName("C_COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.CComm2Type)
                .HasColumnName("C_COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CComm2Value)
                .HasColumnName("C_COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.CComm3Type)
                .HasColumnName("C_COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CComm3Value)
                .HasColumnName("C_COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.CCommPayCentral)
                .HasColumnName("C_COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CCommissionCode)
                .HasColumnName("C_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CCompany)
                .HasColumnName("C_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.CCountry)
                .HasColumnName("C_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CCountryDesc)
                .HasColumnName("C_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CCreditCardExpirationDat)
                .HasColumnName("C_CREDIT_CARD_EXPIRATION_DAT")
                .HasColumnType("DATE");

            entity.Property(e => e.CCreditCardName)
                .HasColumnName("C_CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CCreditCardNumber)
                .HasColumnName("C_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CCreditCardNumberStr)
                .HasColumnName("C_CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.CCreditCardType)
                .HasColumnName("C_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CDisplayName)
                .HasColumnName("C_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CEmail)
                .HasColumnName("C_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.CEmailYn)
                .HasColumnName("C_EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CFaxNo)
                .HasColumnName("C_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.CHistoryYn)
                .HasColumnName("C_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CIataCompType)
                .HasColumnName("C_IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CIataCorpNo)
                .HasColumnName("C_IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CInactiveDate)
                .HasColumnName("C_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CIndustryCode)
                .HasColumnName("C_INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CKeyword)
                .HasColumnName("C_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.CLanguage)
                .HasColumnName("C_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CLanguageDesc)
                .HasColumnName("C_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CLastSource)
                .HasColumnName("C_LAST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.CMailYn)
                .HasColumnName("C_MAIL_YN")
                .IsUnicode(false);

            entity.Property(e => e.CMarkets)
                .HasColumnName("C_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CMembershipExpirationDate)
                .HasColumnName("C_MEMBERSHIP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CMembershipId)
                .HasColumnName("C_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CMembershipLevel)
                .HasColumnName("C_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.CMembershipNameOnCard)
                .HasColumnName("C_MEMBERSHIP_NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.CMembershipNumber)
                .HasColumnName("C_MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CMembershipStatus)
                .HasColumnName("C_MEMBERSHIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.CMembershipType)
                .HasColumnName("C_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CMultPhonesYn)
                .HasColumnName("C_MULT_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.CName)
                .HasColumnName("C_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CNameComment)
                .HasColumnName("C_NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.CNameType)
                .HasColumnName("C_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CNameTypeDesc)
                .HasColumnName("C_NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CNameid)
                .HasColumnName("C_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRateCode)
                .HasColumnName("C_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CState)
                .HasColumnName("C_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CStateDesc)
                .HasColumnName("C_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CWebPage)
                .HasColumnName("C_WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.CXlanguage)
                .HasColumnName("C_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CXlanguageDesc)
                .HasColumnName("C_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CXname)
                .HasColumnName("C_XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CZipCode)
                .HasColumnName("C_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledRoomNights)
                .HasColumnName("CANCELLED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralRevenueAmount)
                .HasColumnName("CENTRAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DActioncode)
                .HasColumnName("D_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.DActiveYn)
                .HasColumnName("D_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DAddress1)
                .HasColumnName("D_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DAddress2)
                .HasColumnName("D_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DAddress3)
                .HasColumnName("D_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DAddress4)
                .HasColumnName("D_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DAddressType)
                .HasColumnName("D_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DAddressTypeDesc)
                .HasColumnName("D_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DArNo)
                .HasColumnName("D_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.DArNoCentral)
                .HasColumnName("D_AR_NO_CENTRAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DAutoenrollMemberyn)
                .HasColumnName("D_AUTOENROLL_MEMBERYN")
                .IsUnicode(false);

            entity.Property(e => e.DAvailoverYn)
                .HasColumnName("D_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DBillingInstr)
                .HasColumnName("D_BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.DBirthCountry)
                .HasColumnName("D_BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DBirthDate)
                .HasColumnName("D_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DBirthDateStr)
                .HasColumnName("D_BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DBirthPlace)
                .HasColumnName("D_BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DBlMsg)
                .HasColumnName("D_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DBusinessPhoneNumber)
                .HasColumnName("D_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.DBusinessTitle)
                .HasColumnName("D_BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DCblInd)
                .HasColumnName("D_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DCcExpDtStr)
                .HasColumnName("D_CC_EXP_DT_STR")
                .IsUnicode(false);

            entity.Property(e => e.DCity)
                .HasColumnName("D_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DCityExt)
                .HasColumnName("D_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DComm1Type)
                .HasColumnName("D_COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DComm1Value)
                .HasColumnName("D_COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.DComm2Type)
                .HasColumnName("D_COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DComm2Value)
                .HasColumnName("D_COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.DComm3Type)
                .HasColumnName("D_COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DComm3Value)
                .HasColumnName("D_COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.DCommPayCentral)
                .HasColumnName("D_COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DCommissionCode)
                .HasColumnName("D_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DCompany)
                .HasColumnName("D_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.DContactYn)
                .HasColumnName("D_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DCountry)
                .HasColumnName("D_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DCountryDesc)
                .HasColumnName("D_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DCreditCardExpirationDat)
                .HasColumnName("D_CREDIT_CARD_EXPIRATION_DAT")
                .HasColumnType("DATE");

            entity.Property(e => e.DCreditCardName)
                .HasColumnName("D_CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.DCreditCardNumber)
                .HasColumnName("D_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.DCreditCardNumberStr)
                .HasColumnName("D_CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.DCreditCardType)
                .HasColumnName("D_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DCurrencyCode)
                .HasColumnName("D_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DDisplayName)
                .HasColumnName("D_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.DEmail)
                .HasColumnName("D_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.DEmailYn)
                .HasColumnName("D_EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DEnvelopeGreeting)
                .HasColumnName("D_ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DFaxNo)
                .HasColumnName("D_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.DFeatures)
                .HasColumnName("D_FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.DFirst)
                .HasColumnName("D_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DGender)
                .HasColumnName("D_GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DHistoryYn)
                .HasColumnName("D_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DHomePhoneNumber)
                .HasColumnName("D_HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.DIataCorpNo)
                .HasColumnName("D_IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DIdCountry)
                .HasColumnName("D_ID_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.DIdDate)
                .HasColumnName("D_ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DIdNumber)
                .HasColumnName("D_ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DIdNumberStr)
                .HasColumnName("D_ID_NUMBER_STR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DIdPlace)
                .HasColumnName("D_ID_PLACE")
                .IsUnicode(false);

            entity.Property(e => e.DIdType)
                .HasColumnName("D_ID_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DInactiveDate)
                .HasColumnName("D_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DKeyword)
                .HasColumnName("D_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.DLanguage)
                .HasColumnName("D_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DLanguageDesc)
                .HasColumnName("D_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DLetterGreeting)
                .HasColumnName("D_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.DMailList)
                .HasColumnName("D_MAIL_LIST")
                .IsUnicode(false);

            entity.Property(e => e.DMailYn)
                .HasColumnName("D_MAIL_YN")
                .IsUnicode(false);

            entity.Property(e => e.DMarkets)
                .HasColumnName("D_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DMembershipExpirationDate)
                .HasColumnName("D_MEMBERSHIP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DMembershipLevel)
                .HasColumnName("D_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.DMembershipNameOnCard)
                .HasColumnName("D_MEMBERSHIP_NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.DMembershipNumber)
                .HasColumnName("D_MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.DMembershipStatus)
                .HasColumnName("D_MEMBERSHIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.DMembershipType)
                .HasColumnName("D_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DMiddle)
                .HasColumnName("D_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DMobilePhoneNumber)
                .HasColumnName("D_MOBILE_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.DMultAddressYn)
                .HasColumnName("D_MULT_ADDRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.DMultCommentsYn)
                .HasColumnName("D_MULT_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.DMultPhonesYn)
                .HasColumnName("D_MULT_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.DName)
                .HasColumnName("D_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DNameComment)
                .HasColumnName("D_NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.DNameKeyword)
                .HasColumnName("D_NAME_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.DNameType)
                .HasColumnName("D_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DNameTypeDesc)
                .HasColumnName("D_NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DNationality)
                .HasColumnName("D_NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DNationalityDesc)
                .HasColumnName("D_NATIONALITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DPassport)
                .HasColumnName("D_PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DPassportStr)
                .HasColumnName("D_PASSPORT_STR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DPaymentDueDays)
                .HasColumnName("D_PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DPhoneNo)
                .HasColumnName("D_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.DPhoneType)
                .HasColumnName("D_PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DProfession)
                .HasColumnName("D_PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DRateCode)
                .HasColumnName("D_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DSalutation)
                .HasColumnName("D_SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.DSfirst)
                .HasColumnName("D_SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DSname)
                .HasColumnName("D_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DSpecials)
                .HasColumnName("D_SPECIALS")
                .IsUnicode(false);

            entity.Property(e => e.DState)
                .HasColumnName("D_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DStateDesc)
                .HasColumnName("D_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DSxfirstName)
                .HasColumnName("D_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DSxname)
                .HasColumnName("D_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DTitle)
                .HasColumnName("D_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DTitleName)
                .HasColumnName("D_TITLE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.DTitleSuffix)
                .HasColumnName("D_TITLE_SUFFIX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DVipName)
                .HasColumnName("D_VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.DVipStatus)
                .HasColumnName("D_VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DXdisplayName)
                .HasColumnName("D_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.DXenvelopeGreeting)
                .HasColumnName("D_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DXfirstName)
                .HasColumnName("D_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DXlanguage)
                .HasColumnName("D_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DXlanguageDesc)
                .HasColumnName("D_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DXname)
                .HasColumnName("D_XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DXsalutation)
                .HasColumnName("D_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.DXtitle)
                .HasColumnName("D_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DZipCode)
                .HasColumnName("D_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportBucketCode)
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueTax)
                .HasColumnName("FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GpActiveYn)
                .HasColumnName("GP_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpAddress1)
                .HasColumnName("GP_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpAddress2)
                .HasColumnName("GP_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpAddress3)
                .HasColumnName("GP_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpAddress4)
                .HasColumnName("GP_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpAddressType)
                .HasColumnName("GP_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpAddressTypeDesc)
                .HasColumnName("GP_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GpArNo)
                .HasColumnName("GP_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.GpArNoCentral)
                .HasColumnName("GP_AR_NO_CENTRAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpAvailoverYn)
                .HasColumnName("GP_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpBillingInstr)
                .HasColumnName("GP_BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.GpBlMsg)
                .HasColumnName("GP_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GpBusinessPhoneNumber)
                .HasColumnName("GP_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.GpCblInd)
                .HasColumnName("GP_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpCity)
                .HasColumnName("GP_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GpCityExt)
                .HasColumnName("GP_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpComm1Type)
                .HasColumnName("GP_COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GpComm1Value)
                .HasColumnName("GP_COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.GpComm2Type)
                .HasColumnName("GP_COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GpComm2Value)
                .HasColumnName("GP_COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.GpComm3Type)
                .HasColumnName("GP_COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GpComm3Value)
                .HasColumnName("GP_COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.GpCommPayCentral)
                .HasColumnName("GP_COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpCommissionCode)
                .HasColumnName("GP_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GpCompany)
                .HasColumnName("GP_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.GpCountry)
                .HasColumnName("GP_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpCountryDesc)
                .HasColumnName("GP_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GpCurrencyCode)
                .HasColumnName("GP_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GpDisplayName)
                .HasColumnName("GP_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.GpEmail)
                .HasColumnName("GP_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.GpFaxNo)
                .HasColumnName("GP_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.GpFeatues)
                .HasColumnName("GP_FEATUES")
                .IsUnicode(false);

            entity.Property(e => e.GpHistoryYn)
                .HasColumnName("GP_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpHomePhoneNumber)
                .HasColumnName("GP_HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.GpInactiveDate)
                .HasColumnName("GP_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GpIndustryCode)
                .HasColumnName("GP_INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GpKeyword)
                .HasColumnName("GP_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.GpLanguage)
                .HasColumnName("GP_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpLanguageDesc)
                .HasColumnName("GP_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GpLastGroup)
                .HasColumnName("GP_LAST_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.GpLastSource)
                .HasColumnName("GP_LAST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.GpMailYn)
                .HasColumnName("GP_MAIL_YN")
                .IsUnicode(false);

            entity.Property(e => e.GpMarkets)
                .HasColumnName("GP_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GpMobilePhoneNumber)
                .HasColumnName("GP_MOBILE_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.GpMultAddressYn)
                .HasColumnName("GP_MULT_ADDRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.GpMultCommentsYn)
                .HasColumnName("GP_MULT_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.GpMultPhonesYn)
                .HasColumnName("GP_MULT_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.GpName)
                .HasColumnName("GP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpNameComment)
                .HasColumnName("GP_NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.GpPaymentDueDays)
                .HasColumnName("GP_PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GpPhoneNo)
                .HasColumnName("GP_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.GpPhoneType)
                .HasColumnName("GP_PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GpRateCode)
                .HasColumnName("GP_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GpSpecials)
                .HasColumnName("GP_SPECIALS")
                .IsUnicode(false);

            entity.Property(e => e.GpState)
                .HasColumnName("GP_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GpStateDesc)
                .HasColumnName("GP_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GpVipName)
                .HasColumnName("GP_VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GpVipStatus)
                .HasColumnName("GP_VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpWebPage)
                .HasColumnName("GP_WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.GpXdisplayName)
                .HasColumnName("GP_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.GpXlanguage)
                .HasColumnName("GP_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpXlanguageDesc)
                .HasColumnName("GP_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GpXname)
                .HasColumnName("GP_XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GpZipCode)
                .HasColumnName("GP_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guestnameid1)
                .HasColumnName("GUESTNAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IataConsortia)
                .HasColumnName("IATA_CONSORTIA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyTransDate)
                .HasColumnName("KEY_TRANS_DATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyTransRevenueType)
                .HasColumnName("KEY_TRANS_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocalRevenueAmount)
                .HasColumnName("LOCAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipRevenueType)
                .HasColumnName("MEMBERSHIP_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscNameId)
                .HasColumnName("MISC_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscRevenue)
                .HasColumnName("MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscRevenueTax)
                .HasColumnName("MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoomNights)
                .HasColumnName("NOSHOW_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNights)
                .HasColumnName("NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberStay)
                .HasColumnName("NUMBER_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.PmsCompanyId)
                .HasColumnName("PMS_COMPANY_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsCurrencyCode)
                .HasColumnName("PMS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsGroupId)
                .HasColumnName("PMS_GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsMiscId)
                .HasColumnName("PMS_MISC_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNameId)
                .HasColumnName("PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsTravelId)
                .HasColumnName("PMS_TRAVEL_ID")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.PmsWholesalerId)
                .HasColumnName("PMS_WHOLESALER_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsYn)
                .HasColumnName("POINTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimarySharer)
                .HasColumnName("PRIMARY_SHARER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode1)
                .HasColumnName("PROMOTION_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode2)
                .HasColumnName("PROMOTION_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode3)
                .HasColumnName("PROMOTION_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
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
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueOrderBy)
                .HasColumnName("REVENUE_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareNo)
                .HasColumnName("SHARE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaAccountType)
                .HasColumnName("TA_ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaAccountsource)
                .HasColumnName("TA_ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaActioncode)
                .HasColumnName("TA_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.TaActiveYn)
                .HasColumnName("TA_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress1)
                .HasColumnName("TA_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress2)
                .HasColumnName("TA_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress3)
                .HasColumnName("TA_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress4)
                .HasColumnName("TA_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaAddressType)
                .HasColumnName("TA_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaAddressTypeDesc)
                .HasColumnName("TA_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaArNo)
                .HasColumnName("TA_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.TaArNoCentral)
                .HasColumnName("TA_AR_NO_CENTRAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaAutoenrollMemberyn)
                .HasColumnName("TA_AUTOENROLL_MEMBERYN")
                .IsUnicode(false);

            entity.Property(e => e.TaAvailoverYn)
                .HasColumnName("TA_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaBillingInstr)
                .HasColumnName("TA_BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.TaBlMsg)
                .HasColumnName("TA_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaBusinessPhoneNumber)
                .HasColumnName("TA_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.TaCblInd)
                .HasColumnName("TA_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCity)
                .HasColumnName("TA_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaCityExt)
                .HasColumnName("TA_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaComm1Type)
                .HasColumnName("TA_COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaComm1Value)
                .HasColumnName("TA_COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.TaComm2Type)
                .HasColumnName("TA_COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaComm2Value)
                .HasColumnName("TA_COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.TaComm3Type)
                .HasColumnName("TA_COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaComm3Value)
                .HasColumnName("TA_COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.TaCommAccountName)
                .HasColumnName("TA_COMM_ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TaCommPayCentral)
                .HasColumnName("TA_COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionCode)
                .HasColumnName("TA_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TaCompany)
                .HasColumnName("TA_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.TaCountry)
                .HasColumnName("TA_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaCountryDesc)
                .HasColumnName("TA_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaCreditCardExpirationDat)
                .HasColumnName("TA_CREDIT_CARD_EXPIRATION_DAT")
                .HasColumnType("DATE");

            entity.Property(e => e.TaCreditCardName)
                .HasColumnName("TA_CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TaCreditCardNumber)
                .HasColumnName("TA_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.TaCreditCardNumberStr)
                .HasColumnName("TA_CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.TaCreditCardType)
                .HasColumnName("TA_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaCurrencyCode)
                .HasColumnName("TA_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TaDisplayName)
                .HasColumnName("TA_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.TaEmail)
                .HasColumnName("TA_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.TaEnvelopeGreeting)
                .HasColumnName("TA_ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaFaxNo)
                .HasColumnName("TA_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.TaFeatures)
                .HasColumnName("TA_FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.TaHistoryYn)
                .HasColumnName("TA_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaHomePhoneNumber)
                .HasColumnName("TA_HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.TaIataCompType)
                .HasColumnName("TA_IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaIataCorpNo)
                .HasColumnName("TA_IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaInactiveDate)
                .HasColumnName("TA_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaIndustryCode)
                .HasColumnName("TA_INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaKeyword)
                .HasColumnName("TA_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.TaLanguage)
                .HasColumnName("TA_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaLanguageDesc)
                .HasColumnName("TA_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaLastGroup)
                .HasColumnName("TA_LAST_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.TaLastSource)
                .HasColumnName("TA_LAST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.TaMailYn)
                .HasColumnName("TA_MAIL_YN")
                .IsUnicode(false);

            entity.Property(e => e.TaMarkets)
                .HasColumnName("TA_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaMembershipExpirationDate)
                .HasColumnName("TA_MEMBERSHIP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaMembershipLevel)
                .HasColumnName("TA_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.TaMembershipNameOnCard)
                .HasColumnName("TA_MEMBERSHIP_NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.TaMembershipNumber)
                .HasColumnName("TA_MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.TaMembershipStatus)
                .HasColumnName("TA_MEMBERSHIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.TaMembershipType)
                .HasColumnName("TA_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaMobilePhoneNumber)
                .HasColumnName("TA_MOBILE_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.TaMultAddressYn)
                .HasColumnName("TA_MULT_ADDRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.TaMultCommentsYn)
                .HasColumnName("TA_MULT_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.TaMultPhonesYn)
                .HasColumnName("TA_MULT_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.TaName)
                .HasColumnName("TA_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaNameComment)
                .HasColumnName("TA_NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.TaNameType)
                .HasColumnName("TA_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaNameTypeDesc)
                .HasColumnName("TA_NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaNameid)
                .HasColumnName("TA_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaPaymentDueDays)
                .HasColumnName("TA_PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaPhoneNo)
                .HasColumnName("TA_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.TaPhoneType)
                .HasColumnName("TA_PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TaRateCode)
                .HasColumnName("TA_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TaSname)
                .HasColumnName("TA_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaSpecials)
                .HasColumnName("TA_SPECIALS")
                .IsUnicode(false);

            entity.Property(e => e.TaState)
                .HasColumnName("TA_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaStateDesc)
                .HasColumnName("TA_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaSxfirstName)
                .HasColumnName("TA_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaSxname)
                .HasColumnName("TA_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaWebPage)
                .HasColumnName("TA_WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.TaXdisplayName)
                .HasColumnName("TA_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.TaXlanguage)
                .HasColumnName("TA_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaXlanguageDesc)
                .HasColumnName("TA_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaXname)
                .HasColumnName("TA_XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaZipCode)
                .HasColumnName("TA_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TransactionRevenueType)
                .HasColumnName("TRANSACTION_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelNameId)
                .HasColumnName("TRAVEL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WholesalerRecordLocator)
                .HasColumnName("WHOLESALER_RECORD_LOCATOR")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.WsAccountType)
                .HasColumnName("WS_ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsAccountsource)
                .HasColumnName("WS_ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WsActioncode)
                .HasColumnName("WS_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.WsActiveYn)
                .HasColumnName("WS_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WsAddress1)
                .HasColumnName("WS_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsAddress2)
                .HasColumnName("WS_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsAddress3)
                .HasColumnName("WS_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsAddress4)
                .HasColumnName("WS_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsAddressType)
                .HasColumnName("WS_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsAddressTypeDesc)
                .HasColumnName("WS_ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.WsArNo)
                .HasColumnName("WS_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.WsArNoCentral)
                .HasColumnName("WS_AR_NO_CENTRAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsAutoenrollMemberyn)
                .HasColumnName("WS_AUTOENROLL_MEMBERYN")
                .IsUnicode(false);

            entity.Property(e => e.WsAvailoverYn)
                .HasColumnName("WS_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WsBillingInstr)
                .HasColumnName("WS_BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.WsBusinessPhoneNumber)
                .HasColumnName("WS_BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.WsCblInd)
                .HasColumnName("WS_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WsCity)
                .HasColumnName("WS_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WsCityExt)
                .HasColumnName("WS_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsComm1Type)
                .HasColumnName("WS_COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsComm1Value)
                .HasColumnName("WS_COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.WsComm2Type)
                .HasColumnName("WS_COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsComm2Value)
                .HasColumnName("WS_COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.WsComm3Type)
                .HasColumnName("WS_COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsComm3Value)
                .HasColumnName("WS_COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.WsCommissionCode)
                .HasColumnName("WS_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.WsCountry)
                .HasColumnName("WS_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsCountryDesc)
                .HasColumnName("WS_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.WsCreditCardExpirationDat)
                .HasColumnName("WS_CREDIT_CARD_EXPIRATION_DAT")
                .HasColumnType("DATE");

            entity.Property(e => e.WsCreditCardName)
                .HasColumnName("WS_CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.WsCreditCardNumber)
                .HasColumnName("WS_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.WsCreditCardNumberStr)
                .HasColumnName("WS_CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.WsCreditCardType)
                .HasColumnName("WS_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsCurrencyCode)
                .HasColumnName("WS_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.WsDisplayName)
                .HasColumnName("WS_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.WsEmail)
                .HasColumnName("WS_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.WsFaxNo)
                .HasColumnName("WS_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.WsFeatues)
                .HasColumnName("WS_FEATUES")
                .IsUnicode(false);

            entity.Property(e => e.WsHistoryYn)
                .HasColumnName("WS_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WsHomePhoneNumber)
                .HasColumnName("WS_HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.WsIataCompType)
                .HasColumnName("WS_IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsIataCorpNo)
                .HasColumnName("WS_IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsInactiveDate)
                .HasColumnName("WS_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WsIndustryCode)
                .HasColumnName("WS_INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WsKeyword)
                .HasColumnName("WS_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.WsLanguage)
                .HasColumnName("WS_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsLanguageDesc)
                .HasColumnName("WS_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.WsMailYn)
                .HasColumnName("WS_MAIL_YN")
                .IsUnicode(false);

            entity.Property(e => e.WsMarkets)
                .HasColumnName("WS_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WsMembershipExpirationDate)
                .HasColumnName("WS_MEMBERSHIP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WsMembershipLevel)
                .HasColumnName("WS_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.WsMembershipNameOnCard)
                .HasColumnName("WS_MEMBERSHIP_NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.WsMembershipNumber)
                .HasColumnName("WS_MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.WsMembershipStatus)
                .HasColumnName("WS_MEMBERSHIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.WsMembershipType)
                .HasColumnName("WS_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsMobilePhoneNumber)
                .HasColumnName("WS_MOBILE_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.WsMultAddressYn)
                .HasColumnName("WS_MULT_ADDRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.WsMultCommentsYn)
                .HasColumnName("WS_MULT_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.WsMultPhonesYn)
                .HasColumnName("WS_MULT_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.WsName)
                .HasColumnName("WS_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsNameComment)
                .HasColumnName("WS_NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.WsNameType)
                .HasColumnName("WS_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsNameTypeDesc)
                .HasColumnName("WS_NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WsPaymentDueDays)
                .HasColumnName("WS_PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WsPhoneNo)
                .HasColumnName("WS_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.WsPhoneType)
                .HasColumnName("WS_PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.WsRateCode)
                .HasColumnName("WS_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.WsSname)
                .HasColumnName("WS_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsSpecials)
                .HasColumnName("WS_SPECIALS")
                .IsUnicode(false);

            entity.Property(e => e.WsState)
                .HasColumnName("WS_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WsStateDesc)
                .HasColumnName("WS_STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.WsSxname)
                .HasColumnName("WS_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsTitle)
                .HasColumnName("WS_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WsWebPage)
                .HasColumnName("WS_WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.WsXdisplayName)
                .HasColumnName("WS_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.WsXlanguage)
                .HasColumnName("WS_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsXlanguageDesc)
                .HasColumnName("WS_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.WsXname)
                .HasColumnName("WS_XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WsZipCode)
                .HasColumnName("WS_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

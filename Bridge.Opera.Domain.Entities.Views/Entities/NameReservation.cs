namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameReservation
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string RoomResort { get; set; }
    public string ComputedResvStatus { get; set; }
    public string ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public string ArrivalTime { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public string DepartureTime { get; set; }
    public string ConfirmationLetter { get; set; }
    public decimal? ConfirmationLetterId { get; set; }
    public decimal? ResvConfLetterId { get; set; }
    public string ResvConfLetterStatus { get; set; }
    public DateTime? ResvConfLetterLta { get; set; }
    public string ResvClDestination { get; set; }
    public string ResvClDestinationId { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentMethodDesc { get; set; }
    public string CreditCardNumber { get; set; }
    public DateTime? CreditCardExpDate { get; set; }
    public string CreditCardType { get; set; }
    public string SwcardIssueNumber { get; set; }
    public DateTime? SwcardStartDate { get; set; }
    public string AttachCcToProfile { get; set; }
    public string PostingAllowedYn { get; set; }
    public string PrintRateYn { get; set; }
    public string ConfirmationNo { get; set; }
    public string SfirstGuestName { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string GuestLastNameSdx { get; set; }
    public string GuestFirstNameSdx { get; set; }
    public string GuestPhone { get; set; }
    public string GuestCountry { get; set; }
    public string GuestCountryDesc { get; set; }
    public decimal GuestNameId { get; set; }
    public decimal? PhoneId { get; set; }
    public decimal? AddressId { get; set; }
    public string NameUsageType { get; set; }
    public string RoomPlanColor { get; set; }
    public string DoNotMoveRoom { get; set; }
    public string WalkinYn { get; set; }
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
    public string CancellationNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationReasonCode { get; set; }
    public string CancellationReasonDesc { get; set; }
    public string WlReasonCode { get; set; }
    public string WlPriority { get; set; }
    public string WlReasonDescription { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public DateTime? TruncActualCheckOutDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public string GuaranteeCode { get; set; }
    public string GuaranteeCodeDesc { get; set; }
    public string Comments { get; set; }
    public string SpecialRequests { get; set; }
    public string Products { get; set; }
    public string Promotions { get; set; }
    public string ConsumerYn { get; set; }
    public string FinanciallyResponsibleYn { get; set; }
    public string IntermediaryYn { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public string PartyCode { get; set; }
    public string ExternalReference { get; set; }
    public decimal? CreditLimit { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string NameTaxType { get; set; }
    public string NameTaxDescription { get; set; }
    public string TaxExemptNo { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPrcnt { get; set; }
    public string DiscountReasonCode { get; set; }
    public decimal? CommissionPaid { get; set; }
    public decimal? MembershipId { get; set; }
    public string MembershipNumber { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public decimal? EventId { get; set; }
    public string RevenueTypeCode { get; set; }
    public string FixedRateYn { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? MyRoomRate { get; set; }
    public decimal? SharePrcnt { get; set; }
    public decimal? CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public string OriginOfBooking { get; set; }
    public string OriginOfBookingDesc { get; set; }
    public string MarketCode { get; set; }
    public string MarketDesc { get; set; }
    public string RateCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string BlockCode { get; set; }
    public string BlockDescription { get; set; }
    public string RoomClass { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string BookedRoomCategory { get; set; }
    public string BookedRoomCategoryLabel { get; set; }
    public string PsuedoRoomType { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string Room { get; set; }
    public decimal? OriginalBaseRate { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? RoomCost { get; set; }
    public decimal? EffectiveRateAmount { get; set; }
    public string CurrencyCode { get; set; }
    public string ExchangeRate { get; set; }
    public string ExchangePostingType { get; set; }
    public DateTime ReservationDate { get; set; }
    public DateTime RdenReservationDate { get; set; }
    public string HasAnyShareFixedRateYn { get; set; }
    public decimal ShareId { get; set; }
    public string SysStatus { get; set; }
    public string MultipleYn { get; set; }
    public string MultipleRoomCategoryYn { get; set; }
    public string MultipleRoomYn { get; set; }
    public string MultipleBookedRoomCatYn { get; set; }
    public string MultipleRateCodeYn { get; set; }
    public string MultipleMarketCodeYn { get; set; }
    public string MultipleOriginOfBookingYn { get; set; }
    public string MultipleShareAmountYn { get; set; }
    public string MultipleAdultsYn { get; set; }
    public string MultipleChildrenYn { get; set; }
    public string MultipleFixedRate { get; set; }
    public string MultipleMembershipsYn { get; set; }
    public string SharedYn { get; set; }
    public string AccompanyingYn { get; set; }
    public string MessageYn { get; set; }
    public string TraceYn { get; set; }
    public string RoutingYn { get; set; }
    public string FolioYn { get; set; }
    public string LocatorYn { get; set; }
    public string MealplanYn { get; set; }
    public string AuthorisedBillingYn { get; set; }
    public string MultipleCommentsYn { get; set; }
    public string PreferredRoomType { get; set; }
    public string LastRoom { get; set; }
    public string SuiteWith { get; set; }
    public decimal? ContactNameId { get; set; }
    public decimal? CreditCardId { get; set; }
    public string CommissionCode { get; set; }
    public decimal? ResvNo { get; set; }
    public decimal? FixedCharge { get; set; }
    public decimal? PaymentAmount { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public string AccompanyingNames { get; set; }
    public decimal? Balance { get; set; }
    public string ComplimentaryYn { get; set; }
    public string RoomFeatures { get; set; }
    public string WlTelephoneNo { get; set; }
    public string VideoCheckoutYn { get; set; }
    public string OverrideInventoryYn { get; set; }
    public string ReinstateYn { get; set; }
    public string BreakToEmptyRoomYn { get; set; }
    public string DoNotUpdateProfile { get; set; }
    public string RecalculateRateYn { get; set; }
    public string InPersonToShareWith { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string SguestName { get; set; }
    public string Channel { get; set; }
    public decimal? ShareSeqNo { get; set; }
    public decimal? ExtSeqNo { get; set; }
    public decimal? ExtSegNo { get; set; }
    public string GuestSignature { get; set; }
    public decimal? Hurdle { get; set; }
    public string HurdleOverride { get; set; }
    public decimal? RateableValue { get; set; }
    public string RestrictionOverride { get; set; }
    public string YieldableYn { get; set; }
    public decimal? ExtensionId { get; set; }
    public string ExtnNumber { get; set; }
    public string ExtnType { get; set; }
    public string MultipleExtensionsYn { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? ResvContactId { get; set; }
    public string ResvContactName { get; set; }
    public decimal? BillingContactId { get; set; }
    public string BillingContactName { get; set; }
    public string MultipleSegmentsYn { get; set; }
    public string RgUdfc01 { get; set; }
    public string RgUdfc02 { get; set; }
    public string RgUdfc03 { get; set; }
    public string RgUdfc04 { get; set; }
    public string RgUdfc05 { get; set; }
    public string RgUdfc06 { get; set; }
    public string RgUdfc07 { get; set; }
    public string RgUdfc08 { get; set; }
    public string RgUdfc09 { get; set; }
    public string RgUdfc10 { get; set; }
    public string RgUdfc11 { get; set; }
    public string RgUdfc12 { get; set; }
    public string RgUdfc13 { get; set; }
    public string RgUdfc14 { get; set; }
    public string RgUdfc15 { get; set; }
    public string RgUdfc16 { get; set; }
    public string RgUdfc17 { get; set; }
    public string RgUdfc18 { get; set; }
    public string RgUdfc19 { get; set; }
    public string RgUdfc20 { get; set; }
    public string RgUdfc21 { get; set; }
    public string RgUdfc22 { get; set; }
    public string RgUdfc23 { get; set; }
    public string RgUdfc24 { get; set; }
    public string RgUdfc25 { get; set; }
    public string RgUdfc26 { get; set; }
    public string RgUdfc27 { get; set; }
    public string RgUdfc28 { get; set; }
    public string RgUdfc29 { get; set; }
    public string RgUdfc30 { get; set; }
    public string RgUdfc31 { get; set; }
    public string RgUdfc32 { get; set; }
    public string RgUdfc33 { get; set; }
    public string RgUdfc34 { get; set; }
    public string RgUdfc35 { get; set; }
    public string RgUdfc36 { get; set; }
    public string RgUdfc37 { get; set; }
    public string RgUdfc38 { get; set; }
    public string RgUdfc39 { get; set; }
    public string RgUdfc40 { get; set; }
    public DateTime? RgUdfd01 { get; set; }
    public DateTime? RgUdfd02 { get; set; }
    public DateTime? RgUdfd03 { get; set; }
    public DateTime? RgUdfd04 { get; set; }
    public DateTime? RgUdfd05 { get; set; }
    public DateTime? RgUdfd06 { get; set; }
    public DateTime? RgUdfd07 { get; set; }
    public DateTime? RgUdfd08 { get; set; }
    public DateTime? RgUdfd09 { get; set; }
    public DateTime? RgUdfd10 { get; set; }
    public DateTime? RgUdfd11 { get; set; }
    public DateTime? RgUdfd12 { get; set; }
    public DateTime? RgUdfd13 { get; set; }
    public DateTime? RgUdfd14 { get; set; }
    public DateTime? RgUdfd15 { get; set; }
    public DateTime? RgUdfd16 { get; set; }
    public DateTime? RgUdfd17 { get; set; }
    public DateTime? RgUdfd18 { get; set; }
    public DateTime? RgUdfd19 { get; set; }
    public DateTime? RgUdfd20 { get; set; }
    public decimal? RgUdfn01 { get; set; }
    public decimal? RgUdfn02 { get; set; }
    public decimal? RgUdfn03 { get; set; }
    public decimal? RgUdfn04 { get; set; }
    public decimal? RgUdfn05 { get; set; }
    public decimal? RgUdfn06 { get; set; }
    public decimal? RgUdfn07 { get; set; }
    public decimal? RgUdfn08 { get; set; }
    public decimal? RgUdfn09 { get; set; }
    public decimal? RgUdfn10 { get; set; }
    public decimal? RgUdfn11 { get; set; }
    public decimal? RgUdfn12 { get; set; }
    public decimal? RgUdfn13 { get; set; }
    public decimal? RgUdfn14 { get; set; }
    public decimal? RgUdfn15 { get; set; }
    public decimal? RgUdfn16 { get; set; }
    public decimal? RgUdfn17 { get; set; }
    public decimal? RgUdfn18 { get; set; }
    public decimal? RgUdfn19 { get; set; }
    public decimal? RgUdfn20 { get; set; }
    public decimal? RgUdfn21 { get; set; }
    public decimal? RgUdfn22 { get; set; }
    public decimal? RgUdfn23 { get; set; }
    public decimal? RgUdfn24 { get; set; }
    public decimal? RgUdfn25 { get; set; }
    public decimal? RgUdfn26 { get; set; }
    public decimal? RgUdfn27 { get; set; }
    public decimal? RgUdfn28 { get; set; }
    public decimal? RgUdfn29 { get; set; }
    public decimal? RgUdfn30 { get; set; }
    public decimal? RgUdfn31 { get; set; }
    public decimal? RgUdfn32 { get; set; }
    public decimal? RgUdfn33 { get; set; }
    public decimal? RgUdfn34 { get; set; }
    public decimal? RgUdfn35 { get; set; }
    public decimal? RgUdfn36 { get; set; }
    public decimal? RgUdfn37 { get; set; }
    public decimal? RgUdfn38 { get; set; }
    public decimal? RgUdfn39 { get; set; }
    public decimal? RgUdfn40 { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public string MasterShare { get; set; }
    public string RegistrationCardNo { get; set; }
    public string Tiad { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public string PurposeOfStay { get; set; }
    public string MaintainRoomFeatures { get; set; }
    public decimal? PhysicalQuantity { get; set; }
    public DateTime? ReinstateDate { get; set; }
    public string MultipleCribsYn { get; set; }
    public string MultipleXbedsYn { get; set; }
    public decimal? CardUsage { get; set; }
    public DateTime? PurgeDate { get; set; }
    public DateTime? LastDirectBillBatchDate { get; set; }
    public DateTime? LastPeriodicFolioDate { get; set; }
    public decimal? PeriodicFolioFreq { get; set; }
    public decimal? ConfirmationLegNo { get; set; }
    public decimal NameId { get; set; }
    public string NameType { get; set; }
    public string NameTypeDesc { get; set; }
    public string ContactYn { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string First { get; set; }
    public string Middle { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string Sname { get; set; }
    public string Passport { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Title { get; set; }
    public string TitleName { get; set; }
    public string TitleDesc { get; set; }
    public string Language { get; set; }
    public string LanguageName { get; set; }
    public string LanguageDesc { get; set; }
    public string Nationality { get; set; }
    public string NationalityDesc { get; set; }
    public string Salutation { get; set; }
    public string LetterGreeting { get; set; }
    public string AddressType { get; set; }
    public string NameAddressId { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string StateDesc { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public string ZipCode { get; set; }
    public string CityExt { get; set; }
    public string DeptId { get; set; }
    public string Department { get; set; }
    public decimal? NamePhoneId { get; set; }
    public string PhoneNo { get; set; }
    public string PhoneType { get; set; }
    public decimal? FaxId { get; set; }
    public string FaxNo { get; set; }
    public decimal? EmailId { get; set; }
    public string Email { get; set; }
    public string ActiveYn { get; set; }
    public string HistoryYn { get; set; }
    public string AcctContact { get; set; }
    public string CblInd { get; set; }
    public string BlMsg { get; set; }
    public string VipStatus { get; set; }
    public string VipName { get; set; }
    public string VipDesc { get; set; }
    public string BusinessTitle { get; set; }
    public string NameRateCode { get; set; }
    public string ArNo { get; set; }
    public string MailList { get; set; }
    public string MailType { get; set; }
    public string AvailabilityOverride { get; set; }
    public string Interest { get; set; }
    public string Salesrep { get; set; }
    public string SrepCode { get; set; }
    public string SrepId { get; set; }
    public string NameComment { get; set; }
    public string BillingInstr { get; set; }
    public string NameMembershipNumber { get; set; }
    public string NameMembershipType { get; set; }
    public string NameMembershipLevel { get; set; }
    public string NameCommissionCode { get; set; }
    public string NameCurrencyCode { get; set; }
    public string CommPayCentral { get; set; }
    public string IataCorpNo { get; set; }
    public string IataCompType { get; set; }
    public string SummRefCc { get; set; }
    public decimal? CrsNameid { get; set; }
    public decimal? PotentialRevenue { get; set; }
    public decimal? PotentialNights { get; set; }
    public string Influence { get; set; }
    public string NameUdfc01 { get; set; }
    public string NameUdfc02 { get; set; }
    public string NameUdfc03 { get; set; }
    public string NameUdfc04 { get; set; }
    public string NameUdfc05 { get; set; }
    public string NameUdfc06 { get; set; }
    public string NameUdfc07 { get; set; }
    public string NameUdfc08 { get; set; }
    public string NameUdfc09 { get; set; }
    public string NameUdfc10 { get; set; }
    public string NameUdfc11 { get; set; }
    public string NameUdfc12 { get; set; }
    public string NameUdfc13 { get; set; }
    public string NameUdfc14 { get; set; }
    public string NameUdfc15 { get; set; }
    public string NameUdfc16 { get; set; }
    public string NameUdfc17 { get; set; }
    public string NameUdfc18 { get; set; }
    public string NameUdfc19 { get; set; }
    public string NameUdfc20 { get; set; }
    public string NameUdfc21 { get; set; }
    public string NameUdfc22 { get; set; }
    public string NameUdfc23 { get; set; }
    public string NameUdfc24 { get; set; }
    public string NameUdfc25 { get; set; }
    public string NameUdfc26 { get; set; }
    public string NameUdfc27 { get; set; }
    public string NameUdfc28 { get; set; }
    public string NameUdfc29 { get; set; }
    public string NameUdfc30 { get; set; }
    public string NameUdfc31 { get; set; }
    public string NameUdfc32 { get; set; }
    public string NameUdfc33 { get; set; }
    public string NameUdfc34 { get; set; }
    public string NameUdfc35 { get; set; }
    public string NameUdfc36 { get; set; }
    public string NameUdfc37 { get; set; }
    public string NameUdfc38 { get; set; }
    public string NameUdfc39 { get; set; }
    public string NameUdfc40 { get; set; }
    public decimal? NameUdfn01 { get; set; }
    public decimal? NameUdfn02 { get; set; }
    public decimal? NameUdfn03 { get; set; }
    public decimal? NameUdfn04 { get; set; }
    public decimal? NameUdfn05 { get; set; }
    public decimal? NameUdfn06 { get; set; }
    public decimal? NameUdfn07 { get; set; }
    public decimal? NameUdfn08 { get; set; }
    public decimal? NameUdfn09 { get; set; }
    public decimal? NameUdfn10 { get; set; }
    public decimal? NameUdfn11 { get; set; }
    public decimal? NameUdfn12 { get; set; }
    public decimal? NameUdfn13 { get; set; }
    public decimal? NameUdfn14 { get; set; }
    public decimal? NameUdfn15 { get; set; }
    public decimal? NameUdfn16 { get; set; }
    public decimal? NameUdfn17 { get; set; }
    public decimal? NameUdfn18 { get; set; }
    public decimal? NameUdfn19 { get; set; }
    public decimal? NameUdfn20 { get; set; }
    public decimal? NameUdfn21 { get; set; }
    public decimal? NameUdfn22 { get; set; }
    public decimal? NameUdfn23 { get; set; }
    public decimal? NameUdfn24 { get; set; }
    public decimal? NameUdfn25 { get; set; }
    public decimal? NameUdfn26 { get; set; }
    public decimal? NameUdfn27 { get; set; }
    public decimal? NameUdfn28 { get; set; }
    public decimal? NameUdfn29 { get; set; }
    public decimal? NameUdfn30 { get; set; }
    public decimal? NameUdfn31 { get; set; }
    public decimal? NameUdfn32 { get; set; }
    public decimal? NameUdfn33 { get; set; }
    public decimal? NameUdfn34 { get; set; }
    public decimal? NameUdfn35 { get; set; }
    public decimal? NameUdfn36 { get; set; }
    public decimal? NameUdfn37 { get; set; }
    public decimal? NameUdfn38 { get; set; }
    public decimal? NameUdfn39 { get; set; }
    public decimal? NameUdfn40 { get; set; }
    public DateTime? NameUdfd01 { get; set; }
    public DateTime? NameUdfd02 { get; set; }
    public DateTime? NameUdfd03 { get; set; }
    public DateTime? NameUdfd04 { get; set; }
    public DateTime? NameUdfd05 { get; set; }
    public DateTime? NameUdfd06 { get; set; }
    public DateTime? NameUdfd07 { get; set; }
    public DateTime? NameUdfd08 { get; set; }
    public DateTime? NameUdfd09 { get; set; }
    public DateTime? NameUdfd10 { get; set; }
    public DateTime? NameUdfd11 { get; set; }
    public DateTime? NameUdfd12 { get; set; }
    public DateTime? NameUdfd13 { get; set; }
    public DateTime? NameUdfd14 { get; set; }
    public DateTime? NameUdfd15 { get; set; }
    public DateTime? NameUdfd16 { get; set; }
    public DateTime? NameUdfd17 { get; set; }
    public DateTime? NameUdfd18 { get; set; }
    public DateTime? NameUdfd19 { get; set; }
    public DateTime? NameUdfd20 { get; set; }
    public string AccountType { get; set; }
    public string Tracecode { get; set; }
    public string Priority { get; set; }
    public string RoomsPotential { get; set; }
    public string IndustryCode { get; set; }
    public string CompetitionCode { get; set; }
    public string Scope { get; set; }
    public string ScopeCity { get; set; }
    public string Territory { get; set; }
    public string Actioncode { get; set; }
    public string Keyword { get; set; }
    public string Accountsource { get; set; }
    public string Markets { get; set; }
    public string ProductInterest { get; set; }
    public string DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? DownloadDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public DateTime NameInsertDate { get; set; }
    public DateTime NameUpdateDate { get; set; }
    public decimal NameInsertUser { get; set; }
    public decimal NameUpdateUser { get; set; }
    public string InsertUserName { get; set; }
    public string UpdateUserName { get; set; }
    public string HoldCode { get; set; }
    public string Hasattachments { get; set; }
    public string Hasnotes { get; set; }
    public decimal? LastRate { get; set; }
    public string NameLastRoom { get; set; }
    public DateTime? LastStay { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? TotalStay { get; set; }
    public decimal? TotalCancels { get; set; }
    public decimal? TotalNoShows { get; set; }
    public decimal? NameTotalRevenue { get; set; }
    public decimal? TotalDayUse { get; set; }
    public decimal? TotalNightsLastyr { get; set; }
    public decimal? TotalStayLastyr { get; set; }
    public decimal? TotalCancelsLastyr { get; set; }
    public decimal? TotalNoShowsLastyr { get; set; }
    public decimal? TotalRevenueLastyr { get; set; }
    public decimal? TotalDayUseLastyr { get; set; }
    public string MultipleAddressYn { get; set; }
    public string MultiplePhonesYn { get; set; }
    public string MultipleNameCommentsYn { get; set; }
    public string Tax1No { get; set; }
    public string Tax2No { get; set; }
    public string NameKeywords { get; set; }
    public decimal? CommissionAccountId { get; set; }
    public string CommissionAccountName { get; set; }
    public string Gender { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public string Profession { get; set; }
    public string IdType { get; set; }
    public string IdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string IdPlace { get; set; }
    public string IdCountry { get; set; }
    public string Comm1Id { get; set; }
    public string Comm1Type { get; set; }
    public string Comm1Value { get; set; }
    public string Comm2Id { get; set; }
    public string Comm2Type { get; set; }
    public string Comm2Value { get; set; }
    public string Comm3Id { get; set; }
    public string Comm3Type { get; set; }
    public string Comm3Value { get; set; }
    public decimal? NameMembershipId { get; set; }
    public DateTime? MembershipExpirationDate { get; set; }
    public string MembershipNameOnCard { get; set; }
    public decimal? NameCreditCardId { get; set; }
    public string NameCreditCardType { get; set; }
    public string NameCreditCardNumber { get; set; }
    public string CreditCardName { get; set; }
    public DateTime? CreditCardExpirationDate { get; set; }
    public decimal? PaymentDueDays { get; set; }
    public string Sfirst { get; set; }
    public string Company { get; set; }
    public string LastGroup { get; set; }
    public string LastSource { get; set; }
    public decimal? NextResvnameid { get; set; }
    public DateTime? NextStay { get; set; }
    public string NameOfTaxType { get; set; }
    public string CisHistoryYn { get; set; }
    public string Xname { get; set; }
    public string XfirstName { get; set; }
    public string Xtitle { get; set; }
    public string Xsalutation { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string XdisplayName { get; set; }
    public string XcompanyName { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string EnvelopeGreeting { get; set; }
    public string XenvelopeGreeting { get; set; }
    public string ContractNo { get; set; }
    public DateTime? ContractRecvDate { get; set; }
    public string GuestPrivYn { get; set; }
    public string EmailYn { get; set; }
    public string MailYn { get; set; }
    public string DirectBillBatchType { get; set; }
    public string TaxPerc1 { get; set; }
    public string TaxPerc2 { get; set; }
    public string TaxPerc3 { get; set; }
    public string TaxPerc4 { get; set; }
    public string TaxPerc5 { get; set; }
    public string LegalCompany { get; set; }
    public string Xlanguage { get; set; }
    public string XlanguageDesc { get; set; }
    public string ProfileSpecialRequests { get; set; }
    public string ProfileRoomFeatures { get; set; }
    public string ProfilePrivacyFlg { get; set; }
    public string MarketResearchYn { get; set; }
    public string ThirdPartyYn { get; set; }
    public string AutoenrollMemberYn { get; set; }
    public string ParentMarketCode { get; set; }
    public string AllMembershipTypes { get; set; }
    public DateTime? KeyValidUntil { get; set; }
    public string AwardNumber { get; set; }
    public string LoggedSrepCode { get; set; }
    public string EnrollmentSource { get; set; }
    public string FirstStayYn { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string BirthDateStr { get; set; }
    public string PassportStr { get; set; }
    public string IdNumberStr { get; set; }
    public decimal? RnResvContactId { get; set; }
    public decimal? RnBillingContactId { get; set; }
    public decimal? RdenResvContactId { get; set; }
    public decimal? RdenBillingContactId { get; set; }
    public string InvItemCodes { get; set; }
    public string TurndownYn { get; set; }
    public string ReservationPreferences { get; set; }
    public string DoNotMoveYn { get; set; }
    public string PointsEligibilityCode { get; set; }
    public string DropOffTime { get; set; }
    public decimal? PointsExpiringThisYear { get; set; }
    public string FirstMembershipUpgradeYn { get; set; }
    public DateTime? MembershipJoinDate { get; set; }
    public decimal? NumberOfNightsLast365Days { get; set; }
    public decimal? NumberOfNightsAtProperty { get; set; }
    public decimal? TotalNumberOfAvailPoints { get; set; }
    public string CheckinAlertsYn { get; set; }
    public string CheckoutAlertsYn { get; set; }
    public string InhouseAlertsYn { get; set; }
    public string ReservationAlertsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameReservation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_RESERVATION");

            entity.Property(e => e.AccompanyingNames)
                .HasColumnName("ACCOMPANYING_NAMES")
                .IsUnicode(false);

            entity.Property(e => e.AccompanyingYn)
                .HasColumnName("ACCOMPANYING_YN")
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accountsource)
                .HasColumnName("ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllMembershipTypes)
                .HasColumnName("ALL_MEMBERSHIP_TYPES")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

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

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(5)
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

            entity.Property(e => e.AttachCcToProfile)
                .HasColumnName("ATTACH_CC_TO_PROFILE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.AuthorisedBillingYn)
                .HasColumnName("AUTHORISED_BILLING_YN")
                .IsUnicode(false);

            entity.Property(e => e.AutoenrollMemberYn)
                .HasColumnName("AUTOENROLL_MEMBER_YN")
                .IsUnicode(false);

            entity.Property(e => e.AvailabilityOverride)
                .HasColumnName("AVAILABILITY_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwardNumber)
                .HasColumnName("AWARD_NUMBER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactName)
                .HasColumnName("BILLING_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.BillingInstr)
                .HasColumnName("BILLING_INSTR")
                .IsUnicode(false);

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthDateStr)
                .HasColumnName("BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BlMsg)
                .HasColumnName("BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BlockDescription)
                .HasColumnName("BLOCK_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategory)
                .IsRequired()
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategoryLabel)
                .HasColumnName("BOOKED_ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.BreakToEmptyRoomYn)
                .HasColumnName("BREAK_TO_EMPTY_ROOM_YN")
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

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

            entity.Property(e => e.CardUsage)
                .HasColumnName("CARD_USAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CblInd)
                .HasColumnName("CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CheckinAlertsYn)
                .HasColumnName("CHECKIN_ALERTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.CheckoutAlertsYn)
                .HasColumnName("CHECKOUT_ALERTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenTaxFree)
                .HasColumnName("CHILDREN_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CisHistoryYn)
                .HasColumnName("CIS_HISTORY_YN")
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .IsUnicode(false);

            entity.Property(e => e.Comm1Id)
                .HasColumnName("COMM1_ID")
                .IsUnicode(false);

            entity.Property(e => e.Comm1Type)
                .HasColumnName("COMM1_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Comm1Value)
                .HasColumnName("COMM1_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.Comm2Id)
                .HasColumnName("COMM2_ID")
                .IsUnicode(false);

            entity.Property(e => e.Comm2Type)
                .HasColumnName("COMM2_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Comm2Value)
                .HasColumnName("COMM2_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.Comm3Id)
                .HasColumnName("COMM3_ID")
                .IsUnicode(false);

            entity.Property(e => e.Comm3Type)
                .HasColumnName("COMM3_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Comm3Value)
                .HasColumnName("COMM3_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.CommPayCentral)
                .HasColumnName("COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CommissionAccountId)
                .HasColumnName("COMMISSION_ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionAccountName)
                .HasColumnName("COMMISSION_ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLegNo)
                .HasColumnName("CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationLetter)
                .HasColumnName("CONFIRMATION_LETTER")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLetterId)
                .HasColumnName("CONFIRMATION_LETTER_ID")
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

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContractNo)
                .HasColumnName("CONTRACT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContractRecvDate)
                .HasColumnName("CONTRACT_RECV_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsNameid)
                .HasColumnName("CRS_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Department)
                .HasColumnName("DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
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

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(5)
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

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DirectBillBatchType)
                .HasColumnName("DIRECT_BILL_BATCH_TYPE")
                .HasMaxLength(40)
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

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DoNotMoveYn)
                .HasColumnName("DO_NOT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DoNotUpdateProfile)
                .HasColumnName("DO_NOT_UPDATE_PROFILE")
                .IsUnicode(false);

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DropOffTime)
                .HasColumnName("DROP_OFF_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentSource)
                .HasColumnName("ENROLLMENT_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .IsUnicode(false);

            entity.Property(e => e.ExtSegNo)
                .HasColumnName("EXT_SEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtSeqNo)
                .HasColumnName("EXT_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtensionId)
                .HasColumnName("EXTENSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExtnNumber)
                .HasColumnName("EXTN_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.ExtnType)
                .HasColumnName("EXTN_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinanciallyResponsibleYn)
                .HasColumnName("FINANCIALLY_RESPONSIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstMembershipUpgradeYn)
                .HasColumnName("FIRST_MEMBERSHIP_UPGRADE_YN")
                .IsUnicode(false);

            entity.Property(e => e.FirstStayYn)
                .HasColumnName("FIRST_STAY_YN")
                .IsUnicode(false);

            entity.Property(e => e.FixedCharge)
                .HasColumnName("FIXED_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioYn)
                .HasColumnName("FOLIO_YN")
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCodeDesc)
                .HasColumnName("GUARANTEE_CODE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountryDesc)
                .HasColumnName("GUEST_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstNameSdx)
                .HasColumnName("GUEST_FIRST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastNameSdx)
                .HasColumnName("GUEST_LAST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestPhone)
                .HasColumnName("GUEST_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestSignature)
                .HasColumnName("GUEST_SIGNATURE")
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.HasAnyShareFixedRateYn)
                .HasColumnName("HAS_ANY_SHARE_FIXED_RATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Hasattachments)
                .HasColumnName("HASATTACHMENTS")
                .IsUnicode(false);

            entity.Property(e => e.Hasnotes)
                .HasColumnName("HASNOTES")
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleOverride)
                .HasColumnName("HURDLE_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.IdNumberStr)
                .HasColumnName("ID_NUMBER_STR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .IsUnicode(false);

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InPersonToShareWith)
                .HasColumnName("IN_PERSON_TO_SHARE_WITH")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Influence)
                .HasColumnName("INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InhouseAlertsYn)
                .HasColumnName("INHOUSE_ALERTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Interest)
                .HasColumnName("INTEREST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IntermediaryYn)
                .HasColumnName("INTERMEDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InvItemCodes)
                .HasColumnName("INV_ITEM_CODES")
                .IsUnicode(false);

            entity.Property(e => e.KeyValidUntil)
                .HasColumnName("KEY_VALID_UNTIL")
                .HasColumnType("DATE");

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LanguageName)
                .HasColumnName("LANGUAGE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LastDirectBillBatchDate)
                .HasColumnName("LAST_DIRECT_BILL_BATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastGroup)
                .HasColumnName("LAST_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.LastPeriodicFolioDate)
                .HasColumnName("LAST_PERIODIC_FOLIO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastRate)
                .HasColumnName("LAST_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.LastSource)
                .HasColumnName("LAST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.LastStay)
                .HasColumnName("LAST_STAY")
                .HasColumnType("DATE");

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LetterGreeting)
                .HasColumnName("LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.LocatorYn)
                .HasColumnName("LOCATOR_YN")
                .IsUnicode(false);

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .IsUnicode(false);

            entity.Property(e => e.MailType)
                .HasColumnName("MAIL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaintainRoomFeatures)
                .HasColumnName("MAINTAIN_ROOM_FEATURES")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchYn)
                .HasColumnName("MARKET_RESEARCH_YN")
                .IsUnicode(false);

            entity.Property(e => e.Markets)
                .HasColumnName("MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MealplanYn)
                .HasColumnName("MEALPLAN_YN")
                .IsUnicode(false);

            entity.Property(e => e.MembershipExpirationDate)
                .HasColumnName("MEMBERSHIP_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipJoinDate)
                .HasColumnName("MEMBERSHIP_JOIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MembershipNameOnCard)
                .HasColumnName("MEMBERSHIP_NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.MessageYn)
                .HasColumnName("MESSAGE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MultipleAddressYn)
                .HasColumnName("MULTIPLE_ADDRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleAdultsYn)
                .HasColumnName("MULTIPLE_ADULTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleBookedRoomCatYn)
                .HasColumnName("MULTIPLE_BOOKED_ROOM_CAT_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleChildrenYn)
                .HasColumnName("MULTIPLE_CHILDREN_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleCommentsYn)
                .HasColumnName("MULTIPLE_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleCribsYn)
                .HasColumnName("MULTIPLE_CRIBS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleExtensionsYn)
                .HasColumnName("MULTIPLE_EXTENSIONS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleFixedRate)
                .HasColumnName("MULTIPLE_FIXED_RATE")
                .IsUnicode(false);

            entity.Property(e => e.MultipleMarketCodeYn)
                .HasColumnName("MULTIPLE_MARKET_CODE_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleMembershipsYn)
                .HasColumnName("MULTIPLE_MEMBERSHIPS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleNameCommentsYn)
                .HasColumnName("MULTIPLE_NAME_COMMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleOriginOfBookingYn)
                .HasColumnName("MULTIPLE_ORIGIN_OF_BOOKING_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultiplePhonesYn)
                .HasColumnName("MULTIPLE_PHONES_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleRateCodeYn)
                .HasColumnName("MULTIPLE_RATE_CODE_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleRoomCategoryYn)
                .HasColumnName("MULTIPLE_ROOM_CATEGORY_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleRoomYn)
                .HasColumnName("MULTIPLE_ROOM_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleSegmentsYn)
                .HasColumnName("MULTIPLE_SEGMENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleShareAmountYn)
                .HasColumnName("MULTIPLE_SHARE_AMOUNT_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleXbedsYn)
                .HasColumnName("MULTIPLE_XBEDS_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleYn)
                .HasColumnName("MULTIPLE_YN")
                .IsUnicode(false);

            entity.Property(e => e.MyRoomRate)
                .HasColumnName("MY_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameAddressId)
                .HasColumnName("NAME_ADDRESS_ID")
                .IsUnicode(false);

            entity.Property(e => e.NameComment)
                .HasColumnName("NAME_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.NameCommissionCode)
                .HasColumnName("NAME_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.NameCreditCardId)
                .HasColumnName("NAME_CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameCreditCardNumber)
                .HasColumnName("NAME_CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NameCreditCardType)
                .HasColumnName("NAME_CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameCurrencyCode)
                .HasColumnName("NAME_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameInsertDate)
                .HasColumnName("NAME_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameInsertUser)
                .HasColumnName("NAME_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameKeywords)
                .HasColumnName("NAME_KEYWORDS")
                .IsUnicode(false);

            entity.Property(e => e.NameLastRoom)
                .HasColumnName("NAME_LAST_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.NameMembershipId)
                .HasColumnName("NAME_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameMembershipLevel)
                .HasColumnName("NAME_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.NameMembershipNumber)
                .HasColumnName("NAME_MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NameMembershipType)
                .HasColumnName("NAME_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameOfTaxType)
                .HasColumnName("NAME_OF_TAX_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NamePhoneId)
                .HasColumnName("NAME_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameRateCode)
                .HasColumnName("NAME_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.NameTaxDescription)
                .HasColumnName("NAME_TAX_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTotalRevenue)
                .HasColumnName("NAME_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTypeDesc)
                .HasColumnName("NAME_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc01)
                .HasColumnName("NAME_UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc02)
                .HasColumnName("NAME_UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc03)
                .HasColumnName("NAME_UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc04)
                .HasColumnName("NAME_UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc05)
                .HasColumnName("NAME_UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc06)
                .HasColumnName("NAME_UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc07)
                .HasColumnName("NAME_UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc08)
                .HasColumnName("NAME_UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc09)
                .HasColumnName("NAME_UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc10)
                .HasColumnName("NAME_UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc11)
                .HasColumnName("NAME_UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc12)
                .HasColumnName("NAME_UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc13)
                .HasColumnName("NAME_UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc14)
                .HasColumnName("NAME_UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc15)
                .HasColumnName("NAME_UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc16)
                .HasColumnName("NAME_UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc17)
                .HasColumnName("NAME_UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc18)
                .HasColumnName("NAME_UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc19)
                .HasColumnName("NAME_UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc20)
                .HasColumnName("NAME_UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc21)
                .HasColumnName("NAME_UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc22)
                .HasColumnName("NAME_UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc23)
                .HasColumnName("NAME_UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc24)
                .HasColumnName("NAME_UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc25)
                .HasColumnName("NAME_UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc26)
                .HasColumnName("NAME_UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc27)
                .HasColumnName("NAME_UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc28)
                .HasColumnName("NAME_UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc29)
                .HasColumnName("NAME_UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc30)
                .HasColumnName("NAME_UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc31)
                .HasColumnName("NAME_UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc32)
                .HasColumnName("NAME_UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc33)
                .HasColumnName("NAME_UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc34)
                .HasColumnName("NAME_UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc35)
                .HasColumnName("NAME_UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc36)
                .HasColumnName("NAME_UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc37)
                .HasColumnName("NAME_UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc38)
                .HasColumnName("NAME_UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc39)
                .HasColumnName("NAME_UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfc40)
                .HasColumnName("NAME_UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameUdfd01)
                .HasColumnName("NAME_UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd02)
                .HasColumnName("NAME_UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd03)
                .HasColumnName("NAME_UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd04)
                .HasColumnName("NAME_UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd05)
                .HasColumnName("NAME_UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd06)
                .HasColumnName("NAME_UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd07)
                .HasColumnName("NAME_UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd08)
                .HasColumnName("NAME_UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd09)
                .HasColumnName("NAME_UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd10)
                .HasColumnName("NAME_UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd11)
                .HasColumnName("NAME_UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd12)
                .HasColumnName("NAME_UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd13)
                .HasColumnName("NAME_UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd14)
                .HasColumnName("NAME_UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd15)
                .HasColumnName("NAME_UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd16)
                .HasColumnName("NAME_UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd17)
                .HasColumnName("NAME_UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd18)
                .HasColumnName("NAME_UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd19)
                .HasColumnName("NAME_UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfd20)
                .HasColumnName("NAME_UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUdfn01)
                .HasColumnName("NAME_UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn02)
                .HasColumnName("NAME_UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn03)
                .HasColumnName("NAME_UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn04)
                .HasColumnName("NAME_UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn05)
                .HasColumnName("NAME_UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn06)
                .HasColumnName("NAME_UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn07)
                .HasColumnName("NAME_UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn08)
                .HasColumnName("NAME_UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn09)
                .HasColumnName("NAME_UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn10)
                .HasColumnName("NAME_UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn11)
                .HasColumnName("NAME_UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn12)
                .HasColumnName("NAME_UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn13)
                .HasColumnName("NAME_UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn14)
                .HasColumnName("NAME_UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn15)
                .HasColumnName("NAME_UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn16)
                .HasColumnName("NAME_UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn17)
                .HasColumnName("NAME_UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn18)
                .HasColumnName("NAME_UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn19)
                .HasColumnName("NAME_UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn20)
                .HasColumnName("NAME_UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn21)
                .HasColumnName("NAME_UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn22)
                .HasColumnName("NAME_UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn23)
                .HasColumnName("NAME_UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn24)
                .HasColumnName("NAME_UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn25)
                .HasColumnName("NAME_UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn26)
                .HasColumnName("NAME_UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn27)
                .HasColumnName("NAME_UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn28)
                .HasColumnName("NAME_UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn29)
                .HasColumnName("NAME_UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn30)
                .HasColumnName("NAME_UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn31)
                .HasColumnName("NAME_UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn32)
                .HasColumnName("NAME_UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn33)
                .HasColumnName("NAME_UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn34)
                .HasColumnName("NAME_UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn35)
                .HasColumnName("NAME_UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn36)
                .HasColumnName("NAME_UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn37)
                .HasColumnName("NAME_UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn38)
                .HasColumnName("NAME_UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn39)
                .HasColumnName("NAME_UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfn40)
                .HasColumnName("NAME_UDFN40")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUpdateDate)
                .HasColumnName("NAME_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameUpdateUser)
                .HasColumnName("NAME_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUsageType)
                .IsRequired()
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NationalityDesc)
                .HasColumnName("NATIONALITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NextResvnameid)
                .HasColumnName("NEXT_RESVNAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NextStay)
                .HasColumnName("NEXT_STAY")
                .HasColumnType("DATE");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberOfNightsAtProperty)
                .HasColumnName("NUMBER_OF_NIGHTS_AT_PROPERTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberOfNightsLast365Days)
                .HasColumnName("NUMBER_OF_NIGHTS_LAST_365_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginOfBookingDesc)
                .HasColumnName("ORIGIN_OF_BOOKING_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OriginalBaseRate)
                .HasColumnName("ORIGINAL_BASE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OverrideInventoryYn)
                .HasColumnName("OVERRIDE_INVENTORY_YN")
                .IsUnicode(false);

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .IsUnicode(false);

            entity.Property(e => e.PassportStr)
                .HasColumnName("PASSPORT_STR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PaymentAmount)
                .HasColumnName("PAYMENT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDueDays)
                .HasColumnName("PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethodDesc)
                .HasColumnName("PAYMENT_METHOD_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PeriodicFolioFreq)
                .HasColumnName("PERIODIC_FOLIO_FREQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PhysicalQuantity)
                .HasColumnName("PHYSICAL_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsEligibilityCode)
                .HasColumnName("POINTS_ELIGIBILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsExpiringThisYear)
                .HasColumnName("POINTS_EXPIRING_THIS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PotentialNights)
                .HasColumnName("POTENTIAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PotentialRevenue)
                .HasColumnName("POTENTIAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferredRoomType)
                .HasColumnName("PREFERRED_ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductInterest)
                .HasColumnName("PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .IsUnicode(false);

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProfilePrivacyFlg)
                .HasColumnName("PROFILE_PRIVACY_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileRoomFeatures)
                .HasColumnName("PROFILE_ROOM_FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.ProfileSpecialRequests)
                .HasColumnName("PROFILE_SPECIAL_REQUESTS")
                .IsUnicode(false);

            entity.Property(e => e.Promotions)
                .HasColumnName("PROMOTIONS")
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PurposeOfStay)
                .HasColumnName("PURPOSE_OF_STAY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RdenBillingContactId)
                .HasColumnName("RDEN_BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RdenReservationDate)
                .HasColumnName("RDEN_RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RdenResvContactId)
                .HasColumnName("RDEN_RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecalculateRateYn)
                .HasColumnName("RECALCULATE_RATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.RegistrationCardNo)
                .HasColumnName("REGISTRATION_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReinstateDate)
                .HasColumnName("REINSTATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReinstateYn)
                .HasColumnName("REINSTATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationAlertsYn)
                .HasColumnName("RESERVATION_ALERTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReservationPreferences)
                .HasColumnName("RESERVATION_PREFERENCES")
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

            entity.Property(e => e.ResvClDestination)
                .HasColumnName("RESV_CL_DESTINATION")
                .IsUnicode(false);

            entity.Property(e => e.ResvClDestinationId)
                .HasColumnName("RESV_CL_DESTINATION_ID")
                .IsUnicode(false);

            entity.Property(e => e.ResvConfLetterId)
                .HasColumnName("RESV_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvConfLetterLta)
                .HasColumnName("RESV_CONF_LETTER_LTA")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvConfLetterStatus)
                .HasColumnName("RESV_CONF_LETTER_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvContactName)
                .HasColumnName("RESV_CONTACT_NAME")
                .IsUnicode(false);

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

            entity.Property(e => e.RgUdfc01)
                .HasColumnName("RG_UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc02)
                .HasColumnName("RG_UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc03)
                .HasColumnName("RG_UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc04)
                .HasColumnName("RG_UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc05)
                .HasColumnName("RG_UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc06)
                .HasColumnName("RG_UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc07)
                .HasColumnName("RG_UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc08)
                .HasColumnName("RG_UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc09)
                .HasColumnName("RG_UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc10)
                .HasColumnName("RG_UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc11)
                .HasColumnName("RG_UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc12)
                .HasColumnName("RG_UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc13)
                .HasColumnName("RG_UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc14)
                .HasColumnName("RG_UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc15)
                .HasColumnName("RG_UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc16)
                .HasColumnName("RG_UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc17)
                .HasColumnName("RG_UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc18)
                .HasColumnName("RG_UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc19)
                .HasColumnName("RG_UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc20)
                .HasColumnName("RG_UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc21)
                .HasColumnName("RG_UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc22)
                .HasColumnName("RG_UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc23)
                .HasColumnName("RG_UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc24)
                .HasColumnName("RG_UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc25)
                .HasColumnName("RG_UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc26)
                .HasColumnName("RG_UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc27)
                .HasColumnName("RG_UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc28)
                .HasColumnName("RG_UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc29)
                .HasColumnName("RG_UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc30)
                .HasColumnName("RG_UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc31)
                .HasColumnName("RG_UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc32)
                .HasColumnName("RG_UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc33)
                .HasColumnName("RG_UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc34)
                .HasColumnName("RG_UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc35)
                .HasColumnName("RG_UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc36)
                .HasColumnName("RG_UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc37)
                .HasColumnName("RG_UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc38)
                .HasColumnName("RG_UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc39)
                .HasColumnName("RG_UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfc40)
                .HasColumnName("RG_UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RgUdfd01)
                .HasColumnName("RG_UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd02)
                .HasColumnName("RG_UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd03)
                .HasColumnName("RG_UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd04)
                .HasColumnName("RG_UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd05)
                .HasColumnName("RG_UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd06)
                .HasColumnName("RG_UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd07)
                .HasColumnName("RG_UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd08)
                .HasColumnName("RG_UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd09)
                .HasColumnName("RG_UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd10)
                .HasColumnName("RG_UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd11)
                .HasColumnName("RG_UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd12)
                .HasColumnName("RG_UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd13)
                .HasColumnName("RG_UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd14)
                .HasColumnName("RG_UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd15)
                .HasColumnName("RG_UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd16)
                .HasColumnName("RG_UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd17)
                .HasColumnName("RG_UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd18)
                .HasColumnName("RG_UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd19)
                .HasColumnName("RG_UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfd20)
                .HasColumnName("RG_UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.RgUdfn01)
                .HasColumnName("RG_UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn02)
                .HasColumnName("RG_UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn03)
                .HasColumnName("RG_UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn04)
                .HasColumnName("RG_UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn05)
                .HasColumnName("RG_UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn06)
                .HasColumnName("RG_UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn07)
                .HasColumnName("RG_UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn08)
                .HasColumnName("RG_UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn09)
                .HasColumnName("RG_UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn10)
                .HasColumnName("RG_UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn11)
                .HasColumnName("RG_UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn12)
                .HasColumnName("RG_UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn13)
                .HasColumnName("RG_UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn14)
                .HasColumnName("RG_UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn15)
                .HasColumnName("RG_UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn16)
                .HasColumnName("RG_UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn17)
                .HasColumnName("RG_UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn18)
                .HasColumnName("RG_UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn19)
                .HasColumnName("RG_UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn20)
                .HasColumnName("RG_UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn21)
                .HasColumnName("RG_UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn22)
                .HasColumnName("RG_UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn23)
                .HasColumnName("RG_UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn24)
                .HasColumnName("RG_UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn25)
                .HasColumnName("RG_UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn26)
                .HasColumnName("RG_UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn27)
                .HasColumnName("RG_UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn28)
                .HasColumnName("RG_UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn29)
                .HasColumnName("RG_UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn30)
                .HasColumnName("RG_UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn31)
                .HasColumnName("RG_UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn32)
                .HasColumnName("RG_UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn33)
                .HasColumnName("RG_UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn34)
                .HasColumnName("RG_UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn35)
                .HasColumnName("RG_UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn36)
                .HasColumnName("RG_UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn37)
                .HasColumnName("RG_UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn38)
                .HasColumnName("RG_UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn39)
                .HasColumnName("RG_UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RgUdfn40)
                .HasColumnName("RG_UDFN40")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RnBillingContactId)
                .HasColumnName("RN_BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RnResvContactId)
                .HasColumnName("RN_RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCost)
                .HasColumnName("ROOM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomFeatures)
                .HasColumnName("ROOM_FEATURES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomPlanColor)
                .HasColumnName("ROOM_PLAN_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoutingYn)
                .HasColumnName("ROUTING_YN")
                .IsUnicode(false);

            entity.Property(e => e.Salesrep)
                .HasColumnName("SALESREP")
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ScopeCity)
                .HasColumnName("SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SharePrcnt)
                .HasColumnName("SHARE_PRCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareSeqNo)
                .HasColumnName("SHARE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequests)
                .HasColumnName("SPECIAL_REQUESTS")
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SuiteWith)
                .HasColumnName("SUITE_WITH")
                .IsUnicode(false);

            entity.Property(e => e.SummRefCc)
                .HasColumnName("SUMM_REF_CC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SwcardIssueNumber)
                .HasColumnName("SWCARD_ISSUE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.SwcardStartDate)
                .HasColumnName("SWCARD_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SysStatus)
                .HasColumnName("SYS_STATUS")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc1)
                .HasColumnName("TAX_PERC1")
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc2)
                .HasColumnName("TAX_PERC2")
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc3)
                .HasColumnName("TAX_PERC3")
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc4)
                .HasColumnName("TAX_PERC4")
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc5)
                .HasColumnName("TAX_PERC5")
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .IsUnicode(false);

            entity.Property(e => e.Tiad)
                .HasColumnName("TIAD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TitleDesc)
                .HasColumnName("TITLE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TitleName)
                .HasColumnName("TITLE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TotalCancels)
                .HasColumnName("TOTAL_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCancelsLastyr)
                .HasColumnName("TOTAL_CANCELS_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDayUse)
                .HasColumnName("TOTAL_DAY_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDayUseLastyr)
                .HasColumnName("TOTAL_DAY_USE_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNightsLastyr)
                .HasColumnName("TOTAL_NIGHTS_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNoShows)
                .HasColumnName("TOTAL_NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNoShowsLastyr)
                .HasColumnName("TOTAL_NO_SHOWS_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNumberOfAvailPoints)
                .HasColumnName("TOTAL_NUMBER_OF_AVAIL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueLastyr)
                .HasColumnName("TOTAL_REVENUE_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStay)
                .HasColumnName("TOTAL_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayLastyr)
                .HasColumnName("TOTAL_STAY_LASTYR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TraceYn)
                .HasColumnName("TRACE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckOutDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.TurndownYn)
                .HasColumnName("TURNDOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VideoCheckoutYn)
                .HasColumnName("VIDEO_CHECKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VipDesc)
                .HasColumnName("VIP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.VipName)
                .HasColumnName("VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
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

            entity.Property(e => e.XcompanyName)
                .HasColumnName("XCOMPANY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XlanguageDesc)
                .HasColumnName("XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Xname)
                .HasColumnName("XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvWaitlistGeneralView
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
    public string GuestTitle { get; set; }
    public string Sname { get; set; }
    public string GuestTitleDesc { get; set; }
    public string GuestMiddleName { get; set; }
    public string GuestLanguage { get; set; }
    public string GuestLanguageDesc { get; set; }
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
    public string Vip { get; set; }
    public string GuestVipDesc { get; set; }
    public string SuiteWith { get; set; }
    public decimal? ContactNameId { get; set; }
    public decimal? CreditCardId { get; set; }
    public string CommissionCode { get; set; }
    public decimal? ResvNo { get; set; }
    public string FixedCharge { get; set; }
    public string PaymentAmount { get; set; }
    public string FbRevenue { get; set; }
    public string RoomRevenue { get; set; }
    public string TotalRevenue { get; set; }
    public string AccompanyingNames { get; set; }
    public string Balance { get; set; }
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
    public string BusinessTitle { get; set; }
    public string Passport { get; set; }
    public string Nationality { get; set; }
    public DateTime? BirthDate { get; set; }
    public decimal? Hurdle { get; set; }
    public string HurdleOverride { get; set; }
    public decimal? RateableValue { get; set; }
    public string RestrictionOverride { get; set; }
    public string YieldableYn { get; set; }
    public string NameType { get; set; }
    public decimal? ExtensionId { get; set; }
    public string ExtnNumber { get; set; }
    public string ExtnType { get; set; }
    public string MultipleExtensionsYn { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
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
    public string Priority { get; set; }
    public decimal? OrderBy { get; set; }
    public string XlastName { get; set; }
    public string XfirstName { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string ResvContactName { get; set; }
    public string BillingContactName { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public string GdsRecordLocator { get; set; }
    public string SpgSuiteNightAwardStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvWaitlistGeneralView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_WAITLIST_GENERAL_VIEW");

            entity.Property(e => e.AccompanyingNames)
                .HasColumnName("ACCOMPANYING_NAMES")
                .IsUnicode(false);

            entity.Property(e => e.AccompanyingYn)
                .HasColumnName("ACCOMPANYING_YN")
                .IsUnicode(false);

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .IsUnicode(false);

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactName)
                .HasColumnName("BILLING_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
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

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DoNotUpdateProfile)
                .HasColumnName("DO_NOT_UPDATE_PROFILE")
                .IsUnicode(false);

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .IsUnicode(false);

            entity.Property(e => e.FinanciallyResponsibleYn)
                .HasColumnName("FINANCIALLY_RESPONSIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FixedCharge)
                .HasColumnName("FIXED_CHARGE")
                .IsUnicode(false);

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioYn)
                .HasColumnName("FOLIO_YN")
                .IsUnicode(false);

            entity.Property(e => e.GdsRecordLocator)
                .HasColumnName("GDS_RECORD_LOCATOR")
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

            entity.Property(e => e.GuestLanguage)
                .HasColumnName("GUEST_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguageDesc)
                .HasColumnName("GUEST_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestLastNameSdx)
                .HasColumnName("GUEST_LAST_NAME_SDX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestMiddleName)
                .HasColumnName("GUEST_MIDDLE_NAME")
                .HasMaxLength(40)
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

            entity.Property(e => e.GuestSignature)
                .HasColumnName("GUEST_SIGNATURE")
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitleDesc)
                .HasColumnName("GUEST_TITLE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestVipDesc)
                .HasColumnName("GUEST_VIP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.HasAnyShareFixedRateYn)
                .HasColumnName("HAS_ANY_SHARE_FIXED_RATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleOverride)
                .HasColumnName("HURDLE_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InPersonToShareWith)
                .HasColumnName("IN_PERSON_TO_SHARE_WITH")
                .IsUnicode(false);

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

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.LocatorYn)
                .HasColumnName("LOCATOR_YN")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MealplanYn)
                .HasColumnName("MEALPLAN_YN")
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
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

            entity.Property(e => e.MultipleOriginOfBookingYn)
                .HasColumnName("MULTIPLE_ORIGIN_OF_BOOKING_YN")
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

            entity.Property(e => e.MultipleShareAmountYn)
                .HasColumnName("MULTIPLE_SHARE_AMOUNT_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleYn)
                .HasColumnName("MULTIPLE_YN")
                .IsUnicode(false);

            entity.Property(e => e.MyRoomRate)
                .HasColumnName("MY_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxDescription)
                .HasColumnName("NAME_TAX_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameUsageType)
                .IsRequired()
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
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

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PaymentAmount)
                .HasColumnName("PAYMENT_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethodDesc)
                .HasColumnName("PAYMENT_METHOD_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoomType)
                .HasColumnName("PREFERRED_ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .IsUnicode(false);

            entity.Property(e => e.Promotions)
                .HasColumnName("PROMOTIONS")
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RdenReservationDate)
                .HasColumnName("RDEN_RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecalculateRateYn)
                .HasColumnName("RECALCULATE_RATE_YN")
                .IsUnicode(false);

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

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

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
                .IsUnicode(false);

            entity.Property(e => e.RoutingYn)
                .HasColumnName("ROUTING_YN")
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

            entity.Property(e => e.SpgSuiteNightAwardStatus)
                .HasColumnName("SPG_SUITE_NIGHT_AWARD_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SuiteWith)
                .HasColumnName("SUITE_WITH")
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

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .IsUnicode(false);

            entity.Property(e => e.TraceYn)
                .HasColumnName("TRACE_YN")
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

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
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

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

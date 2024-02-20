namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepReservationView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public string? Arrival { get; set; }
    public string? ArrivalTime { get; set; }
    public decimal? Nights { get; set; }
    public string? Departure { get; set; }
    public string? DepartureTime { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CreditCardNumber { get; set; }
    public DateTime? CreditCardExpDate { get; set; }
    public string? CreditCardType { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? SguestName { get; set; }
    public string? FullName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestMiddleName { get; set; }
    public string? GuestName { get; set; }
    public string? SfirstGuestName { get; set; }
    public string? GuestTitle { get; set; }
    public string? GuestLanguage { get; set; }
    public string? GuestPhone { get; set; }
    public string? GuestCountry { get; set; }
    public string? Nationality { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? NameUsageType { get; set; }
    public string? DoNotMoveRoom { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public DateTime? ArrivalEstimateTime { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public DateTime? DepartureEstimateTime { get; set; }
    public string? DepartureComments { get; set; }
    public string? CancellationNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? CancellationReasonCode { get; set; }
    public string? CancellationReasonDesc { get; set; }
    public string? WlReasonCode { get; set; }
    public string? WlPriority { get; set; }
    public string? WlReasonDescription { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? GuaranteeCodeDesc { get; set; }
    public string? Comments { get; set; }
    public string? SpecialRequests { get; set; }
    public string? Products { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public string? ExternalReference { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? Balance { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? NameTaxType { get; set; }
    public string? NameTaxDescription { get; set; }
    public string? TaxExemptNo { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Persons { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? MyRoomRate { get; set; }
    public decimal? SharePrcnt { get; set; }
    public decimal? CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string? SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public string? OriginOfBooking { get; set; }
    public string? OriginOfBookingDesc { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketDesc { get; set; }
    public string? RateCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? BlockCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? BookedRoomCategory { get; set; }
    public string? BookedRoomCategoryLabel { get; set; }
    public string? PsuedoRoomType { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? Room { get; set; }
    public string? RoomNo { get; set; }
    public decimal? OriginalBaseRate { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? RoomCost { get; set; }
    public decimal? EffectiveRateAmount { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? ShareId { get; set; }
    public string? SysStatus { get; set; }
    public string? PreferredRoom { get; set; }
    public string? PreferredRoomType { get; set; }
    public string? LastRoom { get; set; }
    public string? Vip { get; set; }
    public decimal? ContactNameId { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? NoOfStays { get; set; }
    public string? RbStatus { get; set; }
    public decimal? DepositPaid { get; set; }
    public string? BillToAddress { get; set; }
    public string? City { get; set; }
    public string? ComplimentaryYn { get; set; }
    public string? HouseUseYn { get; set; }
    public string? CheckOutTime { get; set; }
    public decimal? FixedCharges { get; set; }
    public string? RoutingYn { get; set; }
    public string? AuthorisedBillingYn { get; set; }
    public string? PostingAllowedYn { get; set; }
    public string? VideoCheckoutYn { get; set; }
    public string? RoomFeatures { get; set; }
    public DateTime? TruncBegin { get; set; }
    public DateTime? TruncEnd { get; set; }
    public string? NewSguestName { get; set; }
    public string? CTSName { get; set; }
    public string? ExchangePostingType { get; set; }
    public string? ArrivalTransportType { get; set; }
    public string? ArrivalStationCode { get; set; }
    public string? ArrivalCarrierCode { get; set; }
    public string? ArrivalTransportCode { get; set; }
    public string? ArrivalTranportationYn { get; set; }
    public string? DepartureTransportType { get; set; }
    public string? DepartureStationCode { get; set; }
    public string? DepartureCarrierCode { get; set; }
    public string? DepartureTransportCode { get; set; }
    public string? DepartureTransportationYn { get; set; }
    public string? RoomClass { get; set; }
    public decimal? PhysicalQuantity { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public string? SharedYn { get; set; }
    public string? IsSharedYn { get; set; }
    public decimal? StayRooms { get; set; }
    public string? GuestPreferences { get; set; }
    public string? Channel { get; set; }
    public string? WlTelephoneNo { get; set; }
    public string? RoomResort { get; set; }
    public string? IataCorpNo { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string? Promotions { get; set; }
    public string? CreditCardExpDateStr { get; set; }
    public string? CreditCardNumberStr { get; set; }
    public string? AccompanyingYn { get; set; }
    public string? AccompanyingNames { get; set; }
    public string? PartyCode { get; set; }
    public string? Sxname { get; set; }
    public string? SxfirstName { get; set; }
    public string? Xname { get; set; }
    public string? XfirstName { get; set; }
    public string? Xtitle { get; set; }
    public string? Xsalutation { get; set; }
    public string? XdisplayName { get; set; }
    public DateTime? PurgeDate { get; set; }
    public DateTime? LastDirectBillBatchDate { get; set; }
    public DateTime? LastPeriodicFolioDate { get; set; }
    public decimal? PeriodicFolioFreq { get; set; }
    public decimal? ConfirmationLegNo { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? CheckinDuration { get; set; }
    public string? GuestStatus { get; set; }
    public string? GuestType { get; set; }
    public DateTime? ExchangeDate { get; set; }
    public decimal? LastOnlinePrintSeq { get; set; }
    public string? EntryPoint { get; set; }
    public DateTime? EntryDate { get; set; }
    public string? FolioText1 { get; set; }
    public string? FolioText2 { get; set; }
    public string? InvItemCodes { get; set; }
    public string? InvItemIds { get; set; }
    public string? GdsRecordLocator { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? AmountPercent { get; set; }
    public string? Xlanguage { get; set; }
    public string? CompTypeCode { get; set; }
    public string? UniCardId { get; set; }
    public string? KeyOptions { get; set; }
    public DateTime? OriginalArrival { get; set; }
    public string? OwnerFfFlag { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? ExtensionId { get; set; }
    public string? ExtnNumber { get; set; }
    public string? ExtnType { get; set; }
    public string? MultipleExtensionsYn { get; set; }
    public string? PostCoFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepReservationView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RESERVATION_VIEW");

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

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountPercent)
                .HasColumnName("AMOUNT_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalCarrierCode)
                .HasColumnName("ARRIVAL_CARRIER_CODE")
                .HasMaxLength(20)
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
                .HasMaxLength(75)
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

            entity.Property(e => e.AuthorisedBillingYn)
                .HasColumnName("AUTHORISED_BILLING_YN")
                .IsUnicode(false);

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillToAddress)
                .HasColumnName("BILL_TO_ADDRESS")
                .IsUnicode(false);

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

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CTSName)
                .HasColumnName("C_T_S_NAME")
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

            entity.Property(e => e.CheckOutTime)
                .HasColumnName("CHECK_OUT_TIME")
                .IsUnicode(false);

            entity.Property(e => e.CheckinDuration)
                .HasColumnName("CHECKIN_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLegNo)
                .HasColumnName("CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardExpDateStr)
                .HasColumnName("CREDIT_CARD_EXP_DATE_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

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
                .HasMaxLength(75)
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

            entity.Property(e => e.DepositPaid)
                .HasColumnName("DEPOSIT_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ExchangeDate)
                .HasColumnName("EXCHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
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

            entity.Property(e => e.FixedCharges)
                .HasColumnName("FIXED_CHARGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioText1)
                .HasColumnName("FOLIO_TEXT1")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FolioText2)
                .HasColumnName("FOLIO_TEXT2")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
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

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguage)
                .HasColumnName("GUEST_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestMiddleName)
                .HasColumnName("GUEST_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestPhone)
                .HasColumnName("GUEST_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.GuestPreferences)
                .HasColumnName("GUEST_PREFERENCES")
                .IsUnicode(false);

            entity.Property(e => e.GuestStatus)
                .HasColumnName("GUEST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.InvItemCodes)
                .HasColumnName("INV_ITEM_CODES")
                .IsUnicode(false);

            entity.Property(e => e.InvItemIds)
                .HasColumnName("INV_ITEM_IDS")
                .IsUnicode(false);

            entity.Property(e => e.IsSharedYn)
                .HasColumnName("IS_SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.KeyOptions)
                .HasColumnName("KEY_OPTIONS")
                .IsUnicode(false);

            entity.Property(e => e.LastDirectBillBatchDate)
                .HasColumnName("LAST_DIRECT_BILL_BATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastOnlinePrintSeq)
                .HasColumnName("LAST_ONLINE_PRINT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastPeriodicFolioDate)
                .HasColumnName("LAST_PERIODIC_FOLIO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleExtensionsYn)
                .HasColumnName("MULTIPLE_EXTENSIONS_YN")
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

            entity.Property(e => e.NameUsageType)
                .IsRequired()
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewSguestName)
                .HasColumnName("NEW_SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfStays)
                .HasColumnName("NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginOfBookingDesc)
                .HasColumnName("ORIGIN_OF_BOOKING_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OriginalArrival)
                .HasColumnName("ORIGINAL_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.OriginalBaseRate)
                .HasColumnName("ORIGINAL_BASE_RATE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalQuantity)
                .HasColumnName("PHYSICAL_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostCoFlag)
                .HasColumnName("POST_CO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoom)
                .HasColumnName("PREFERRED_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoomType)
                .HasColumnName("PREFERRED_ROOM_TYPE")
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

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RbStatus)
                .HasColumnName("RB_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
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
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingYn)
                .HasColumnName("ROUTING_YN")
                .IsUnicode(false);

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
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

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
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

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

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
                .HasColumnType("CHAR(7)");

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TruncBegin)
                .HasColumnName("TRUNC_BEGIN")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEnd)
                .HasColumnName("TRUNC_END")
                .HasColumnType("DATE");

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

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
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

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
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
        });
	}
}

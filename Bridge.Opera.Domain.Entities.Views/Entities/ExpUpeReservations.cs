namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeReservations
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Resort { get; set; }
    public string ResvStatus { get; set; }
    public decimal? GuestNameId { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public string ConfirmationNo { get; set; }
    public string GuaranteeCode { get; set; }
    public string DepositYn { get; set; }
    public string WalkinYn { get; set; }
    public string ScheduleCheckoutYn { get; set; }
    public string PreRegisteredYn { get; set; }
    public string PaymentMethod { get; set; }
    public string CheckedInOrigin { get; set; }
    public string CheckedOutOrigin { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? GuestBalance { get; set; }
    public decimal? GuestDebit { get; set; }
    public decimal? GuestCredit { get; set; }
    public DateTime? OriginalArrival { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? BillingContactId { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public string Channel { get; set; }
    public string OriginOfBooking { get; set; }
    public string MarketCode { get; set; }
    public string MarketMainGroup { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDescription { get; set; }
    public decimal? ShareAmount { get; set; }
    public string ComplimentaryYn { get; set; }
    public decimal? RateTotal { get; set; }
    public string FixedRateYn { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? AmountPercent { get; set; }
    public string NameTaxType { get; set; }
    public string TaxExemptNo { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string Room { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string BookedRoomCategoryLabel { get; set; }
    public string Udfc02 { get; set; }
    public string DoNotMoveRoom { get; set; }
    public string TarsResNumber { get; set; }
    public string TarsFileNumber { get; set; }
    public string TarsTk { get; set; }
    public string ExternalReference { get; set; }
    public string CancellationNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationReasonCode { get; set; }
    public string CancellationReasonDesc { get; set; }
    public string ArrivalTransportType { get; set; }
    public string ArrivalStationCode { get; set; }
    public string ArrivalCarrierCode { get; set; }
    public string ArrivalTransportCode { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public string ArrivalTranportationYn { get; set; }
    public string ArrivalComments { get; set; }
    public string DepartureTransportType { get; set; }
    public string DepartureStationCode { get; set; }
    public string DepartureCarrierCode { get; set; }
    public string DepartureTransportCode { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public string DepartureTransportationYn { get; set; }
    public string DepartureComments { get; set; }
    public decimal? CommissionPaid { get; set; }
    public string CommissionPayoutTo { get; set; }
    public string CommissionCode { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPrcnt { get; set; }
    public string DiscountReasonCode { get; set; }
    public string WlPriority { get; set; }
    public string WlReasonCode { get; set; }
    public string WlReasonDescription { get; set; }
    public string Udfc04 { get; set; }
    public string Udfc05 { get; set; }
    public string Udfc06 { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public string PartyCode { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? ExtensionId { get; set; }
    public string MasterShare { get; set; }
    public string PurposeOfStay { get; set; }
    public string NameUsageType { get; set; }
    public string GuestCountry { get; set; }
    public string NameType { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? SourceId { get; set; }
    public string RoomCategory { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? FinCount { get; set; }
    public decimal? CxlCount { get; set; }
    public decimal? ClFolCount { get; set; }
    public string CurrencyCode { get; set; }
    public DateTime? ExchangeDate { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeReservations>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESERVATIONS");

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
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalCarrierCode)
                .HasColumnName("ARRIVAL_CARRIER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalComments)
                .HasColumnName("ARRIVAL_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalStationCode)
                .HasColumnName("ARRIVAL_STATION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTranportationYn)
                .HasColumnName("ARRIVAL_TRANPORTATION_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTransportCode)
                .HasColumnName("ARRIVAL_TRANSPORT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTransportType)
                .HasColumnName("ARRIVAL_TRANSPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedRoomCategoryLabel)
                .HasColumnName("BOOKED_ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonCode)
                .HasColumnName("CANCELLATION_REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonDesc)
                .HasColumnName("CANCELLATION_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CheckedInOrigin)
                .HasColumnName("CHECKED_IN_ORIGIN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CheckedOutOrigin)
                .HasColumnName("CHECKED_OUT_ORIGIN")
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.ClFolCount)
                .HasColumnName("CL_FOL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionPayoutTo)
                .HasColumnName("COMMISSION_PAYOUT_TO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CxlCount)
                .HasColumnName("CXL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureCarrierCode)
                .HasColumnName("DEPARTURE_CARRIER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureComments)
                .HasColumnName("DEPARTURE_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureStationCode)
                .HasColumnName("DEPARTURE_STATION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportCode)
                .HasColumnName("DEPARTURE_TRANSPORT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportType)
                .HasColumnName("DEPARTURE_TRANSPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTransportationYn)
                .HasColumnName("DEPARTURE_TRANSPORTATION_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepositYn)
                .HasColumnName("DEPOSIT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPrcnt)
                .HasColumnName("DISCOUNT_PRCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DoNotMoveRoom)
                .HasColumnName("DO_NOT_MOVE_ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeDate)
                .HasColumnName("EXCHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtensionId)
                .HasColumnName("EXTENSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FinCount)
                .HasColumnName("FIN_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestBalance)
                .HasColumnName("GUEST_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestCredit)
                .HasColumnName("GUEST_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestDebit)
                .HasColumnName("GUEST_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainGroup)
                .HasColumnName("MARKET_MAIN_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameUsageType)
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OriginalArrival)
                .HasColumnName("ORIGINAL_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreRegisteredYn)
                .HasColumnName("PRE_REGISTERED_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PurposeOfStay)
                .HasColumnName("PURPOSE_OF_STAY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDescription)
                .HasColumnName("RATE_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateTotal)
                .HasColumnName("RATE_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleCheckoutYn)
                .HasColumnName("SCHEDULE_CHECKOUT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TarsFileNumber)
                .HasColumnName("TARS_FILE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TarsResNumber)
                .HasColumnName("TARS_RES_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TarsTk)
                .HasColumnName("TARS_TK")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
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

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WlPriority)
                .HasColumnName("WL_PRIORITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonCode)
                .HasColumnName("WL_REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonDescription)
                .HasColumnName("WL_REASON_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

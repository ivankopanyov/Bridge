namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResv
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? AirlineFee { get; set; }
    public decimal? RcTaxinclusive { get; set; }
    public decimal? Numberofrooms { get; set; }
    public decimal? Hurdle { get; set; }
    public decimal? RateableValue { get; set; }
    public decimal? DepositAmount { get; set; }
    public decimal? NumNightsReqd { get; set; }
    public decimal? DepOffsetUnitMult { get; set; }
    public decimal? TotalCostStay { get; set; }
    public decimal? TotalTaxAmount { get; set; }
    public decimal? TaxRateAmount { get; set; }
    public decimal? ArrTransportationYn { get; set; }
    public decimal? DepTranportationYn { get; set; }
    public decimal? ExtRefNumber { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? GcIsperroom { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ResvNights { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? AccomSeqNum { get; set; }
    public string? InsertUser { get; set; }
    public string? UpdateUser { get; set; }
    public string? ResvStatus { get; set; }
    public string? Udfc29 { get; set; }
    public string? Channel { get; set; }
    public string? AirlineCode { get; set; }
    public string? AirlineFeeCode { get; set; }
    public string? AirlineInd { get; set; }
    public string? AirlineCurrencyCode { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? Promotions { get; set; }
    public string? RoomType { get; set; }
    public string? RateCode { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomCategory { get; set; }
    public string? HurdleOverride { get; set; }
    public string? ResvType { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? IfcCcType { get; set; }
    public string? CreditCardExpirationDate { get; set; }
    public string? PaymentType { get; set; }
    public string? CardHolderName { get; set; }
    public string? PymtTranType { get; set; }
    public string? DirectBill { get; set; }
    public string? DepCurrencyCode { get; set; }
    public string? DepositPercnt { get; set; }
    public string? DepOffsetTimeUnit { get; set; }
    public string? DepOffsetDropTime { get; set; }
    public string? LocalCurrencyCode { get; set; }
    public string? TaxPercnt { get; set; }
    public string? TaxType { get; set; }
    public string? TaxTypeDesc { get; set; }
    public string? LoyaltyMemNumber { get; set; }
    public string? LoyaltyMemType { get; set; }
    public string? SplReqCode { get; set; }
    public string? SplReqCodeDesc { get; set; }
    public string? SplReqText { get; set; }
    public string? CompanyName { get; set; }
    public string? TravelAgentName { get; set; }
    public string? ArrTransportType { get; set; }
    public string? ArrCarrierCode { get; set; }
    public string? ArrStationCode { get; set; }
    public string? PuArrivalTime { get; set; }
    public string? DepTransportType { get; set; }
    public string? DepCarrierCode { get; set; }
    public string? DepStationCode { get; set; }
    public string? DoDepartTime { get; set; }
    public string? BlockId { get; set; }
    public string? BlockCode { get; set; }
    public string? GroupName { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CancelNumber { get; set; }
    public string? ReasonCode { get; set; }
    public string? ExtCancelNumber { get; set; }
    public string? CancelSource { get; set; }
    public string? Resort { get; set; }
    public string? ExternalReference { get; set; }
    public string? InclInResvElementYn { get; set; }
    public string? InclInStayElementYn { get; set; }
    public string? RoomClass { get; set; }
    public string? Udfc31 { get; set; }
    public string? RateCurrencyCode { get; set; }
    public string? ResvContactName { get; set; }
    public string? ComplimentaryYn { get; set; }
    public string? WalkinYn { get; set; }
    public string? Room { get; set; }
    public string? ReasonDesc { get; set; }
    public string? Udfc28 { get; set; }
    public string? BrEventId { get; set; }
    public string? BrMembershipId { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public DateTime? DepDueDt { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public DateTime? ActualArrivalDate { get; set; }
    public DateTime? ActualDepartureDate { get; set; }
    public DateTime? OriginalDepartureDate { get; set; }
    public DateTime? CancelDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV");

            entity.Property(e => e.AccomSeqNum)
                .HasColumnName("ACCOM_SEQ_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualArrivalDate)
                .HasColumnName("ACTUAL_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualDepartureDate)
                .HasColumnName("ACTUAL_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineCode)
                .HasColumnName("AIRLINE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineCurrencyCode)
                .HasColumnName("AIRLINE_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineFee)
                .HasColumnName("AIRLINE_FEE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineFeeCode)
                .HasColumnName("AIRLINE_FEE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineInd)
                .HasColumnName("AIRLINE_IND")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrCarrierCode)
                .HasColumnName("ARR_CARRIER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrStationCode)
                .HasColumnName("ARR_STATION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrTransportType)
                .HasColumnName("ARR_TRANSPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrTransportationYn)
                .HasColumnName("ARR_TRANSPORTATION_YN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BrEventId)
                .HasColumnName("BR_EVENT_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BrMembershipId)
                .HasColumnName("BR_MEMBERSHIP_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelNumber)
                .HasColumnName("CANCEL_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancelSource)
                .HasColumnName("CANCEL_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CardHolderName)
                .HasColumnName("CARD_HOLDER_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
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

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepCarrierCode)
                .HasColumnName("DEP_CARRIER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepCurrencyCode)
                .HasColumnName("DEP_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepDueDt)
                .HasColumnName("DEP_DUE_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.DepOffsetDropTime)
                .HasColumnName("DEP_OFFSET_DROP_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepOffsetTimeUnit)
                .HasColumnName("DEP_OFFSET_TIME_UNIT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepOffsetUnitMult)
                .HasColumnName("DEP_OFFSET_UNIT_MULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepStationCode)
                .HasColumnName("DEP_STATION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepTranportationYn)
                .HasColumnName("DEP_TRANPORTATION_YN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepTransportType)
                .HasColumnName("DEP_TRANSPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositPercnt)
                .HasColumnName("DEPOSIT_PERCNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DirectBill)
                .HasColumnName("DIRECT_BILL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DoDepartTime)
                .HasColumnName("DO_DEPART_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtCancelNumber)
                .HasColumnName("EXT_CANCEL_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExtRefNumber)
                .HasColumnName("EXT_REF_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GcIsperroom)
                .HasColumnName("GC_ISPERROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleOverride)
                .HasColumnName("HURDLE_OVERRIDE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IfcCcType)
                .HasColumnName("IFC_CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInResvElementYn)
                .HasColumnName("INCL_IN_RESV_ELEMENT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInStayElementYn)
                .HasColumnName("INCL_IN_STAY_ELEMENT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LocalCurrencyCode)
                .HasColumnName("LOCAL_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemNumber)
                .HasColumnName("LOYALTY_MEM_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemType)
                .HasColumnName("LOYALTY_MEM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NumNightsReqd)
                .HasColumnName("NUM_NIGHTS_REQD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Numberofrooms)
                .HasColumnName("NUMBEROFROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalDepartureDate)
                .HasColumnName("ORIGINAL_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Promotions)
                .HasColumnName("PROMOTIONS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PuArrivalTime)
                .HasColumnName("PU_ARRIVAL_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PymtTranType)
                .HasColumnName("PYMT_TRAN_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCurrencyCode)
                .HasColumnName("RATE_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RcTaxinclusive)
                .HasColumnName("RC_TAXINCLUSIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReasonDesc)
                .HasColumnName("REASON_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvContactName)
                .HasColumnName("RESV_CONTACT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNights)
                .HasColumnName("RESV_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvType)
                .HasColumnName("RESV_TYPE")
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

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SplReqCode)
                .HasColumnName("SPL_REQ_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SplReqCodeDesc)
                .HasColumnName("SPL_REQ_CODE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SplReqText)
                .HasColumnName("SPL_REQ_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxPercnt)
                .HasColumnName("TAX_PERCNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxRateAmount)
                .HasColumnName("TAX_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxTypeDesc)
                .HasColumnName("TAX_TYPE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalCostStay)
                .HasColumnName("TOTAL_COST_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxAmount)
                .HasColumnName("TOTAL_TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}

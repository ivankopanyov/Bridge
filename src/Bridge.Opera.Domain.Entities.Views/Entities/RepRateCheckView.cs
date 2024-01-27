namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRateCheckView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ComputedResvStatus { get; set; }
    public string ResvStatus { get; set; }
    public string Arrival { get; set; }
    public string ArrivalTime { get; set; }
    public decimal? Nights { get; set; }
    public string Departure { get; set; }
    public string DepartureTime { get; set; }
    public string PaymentMethod { get; set; }
    public string ConfirmationNo { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string FullName { get; set; }
    public string FullNameNoShrInd { get; set; }
    public string GuestPhone { get; set; }
    public decimal GuestNameId { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public string DepartureComments { get; set; }
    public string Comments { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Persons { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? MyRoomRate { get; set; }
    public decimal? CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public string MarketCode { get; set; }
    public string MarketDesc { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string RoomClass { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string Room { get; set; }
    public string RoomNo { get; set; }
    public decimal? OriginalBaseRate { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? RoomCost { get; set; }
    public decimal? RateAmount { get; set; }
    public DateTime ReservationDate { get; set; }
    public string LastRoom { get; set; }
    public string Vip { get; set; }
    public string RateLabel { get; set; }
    public string PkgTrxCode { get; set; }
    public string PackageYn { get; set; }
    public decimal? FixedCharges { get; set; }
    public string Address { get; set; }
    public string OriginOfBooking { get; set; }
    public string OriginOfBookingDesc { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ShareBaseRate { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPrcnt { get; set; }
    public string DiscountReasonCode { get; set; }
    public string FixedRateYn { get; set; }
    public string SubgpTrxCode { get; set; }
    public string BillingInstrnCode { get; set; }
    public string BlockCode { get; set; }
    public string GuaranteeCode { get; set; }
    public string TaxExemptNo { get; set; }
    public string RoutingInstrn { get; set; }
    public string CTSName { get; set; }
    public string ComplimentaryYn { get; set; }
    public string HouseUseYn { get; set; }
    public string CreditCardNo { get; set; }
    public DateTime? CreditCardExpDate { get; set; }
    public string CreditCardType { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string ExchangePostingType { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public decimal ShareId { get; set; }
    public string SharedYn { get; set; }
    public decimal? Primary01 { get; set; }
    public string PseudoYn { get; set; }
    public string RackRateCode { get; set; }
    public decimal? EffectiveRateAmount { get; set; }
    public string Channel { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string Products { get; set; }
    public string BookedRoomCategory { get; set; }
    public string BlockRateCode { get; set; }
    public string BlockCurrencyCode { get; set; }
    public decimal? RateCodeRateAmount { get; set; }
    public string RateCodeRateCurrency { get; set; }
    public string NameTaxType { get; set; }
    public string NameTaxDescription { get; set; }
    public decimal? RackRateAmount { get; set; }
    public string CreditCardExpDateStr { get; set; }
    public string CreditCardNumberStr { get; set; }
    public string AccompanyingYn { get; set; }
    public string AccompanyingNames { get; set; }
    public string XdisplayName { get; set; }
    public string BookedRoomCategoryLabel { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public string RoomResort { get; set; }
    public string RhMarketCode { get; set; }
    public string RhMarketDesc { get; set; }
    public string Udfc08 { get; set; }
    public decimal? AllShareAmount { get; set; }
    public decimal? AllShareRateCodeAmount { get; set; }
    public decimal? PackageEffect { get; set; }
    public decimal? AllSharePackageEffect { get; set; }
    public string SguestName { get; set; }
    public string SguestFirstname { get; set; }
    public string Udfc07 { get; set; }
    public string Udfc09 { get; set; }
    public string SpecialRequests { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRateCheckView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RATE_CHECK_VIEW");

            entity.Property(e => e.AccompanyingNames)
                .HasColumnName("ACCOMPANYING_NAMES")
                .IsUnicode(false);

            entity.Property(e => e.AccompanyingYn)
                .HasColumnName("ACCOMPANYING_YN")
                .IsUnicode(false);

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllShareAmount)
                .HasColumnName("ALL_SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllSharePackageEffect)
                .HasColumnName("ALL_SHARE_PACKAGE_EFFECT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllShareRateCodeAmount)
                .HasColumnName("ALL_SHARE_RATE_CODE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BlockCurrencyCode)
                .HasColumnName("BLOCK_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockRateCode)
                .HasColumnName("BLOCK_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategory)
                .IsRequired()
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategoryLabel)
                .HasColumnName("BOOKED_ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.CTSName)
                .HasColumnName("C_T_S_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
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

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
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

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardExpDateStr)
                .HasColumnName("CREDIT_CARD_EXP_DATE_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNo)
                .HasColumnName("CREDIT_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.DepartureComments)
                .HasColumnName("DEPARTURE_COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(75)
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

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedCharges)
                .HasColumnName("FIXED_CHARGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FullNameNoShrInd)
                .HasColumnName("FULL_NAME_NO_SHR_IND")
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

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
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

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
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

            entity.Property(e => e.PackageEffect)
                .HasColumnName("PACKAGE_EFFECT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageYn)
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Primary01)
                .HasColumnName("PRIMARY_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RackRateAmount)
                .HasColumnName("RACK_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RackRateCode)
                .HasColumnName("RACK_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeRateAmount)
                .HasColumnName("RATE_CODE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCodeRateCurrency)
                .HasColumnName("RATE_CODE_RATE_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateLabel)
                .HasColumnName("RATE_LABEL")
                .HasMaxLength(20)
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

            entity.Property(e => e.RhMarketCode)
                .HasColumnName("RH_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RhMarketDesc)
                .HasColumnName("RH_MARKET_DESC")
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

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingInstrn)
                .HasColumnName("ROUTING_INSTRN")
                .IsUnicode(false);

            entity.Property(e => e.SguestFirstname)
                .HasColumnName("SGUEST_FIRSTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareBaseRate)
                .HasColumnName("SHARE_BASE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
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

            entity.Property(e => e.SubgpTrxCode)
                .HasColumnName("SUBGP_TRX_CODE")
                .IsUnicode(false);

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

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);
        });
	}
}

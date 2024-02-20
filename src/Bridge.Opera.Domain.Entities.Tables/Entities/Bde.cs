namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Bde
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RecordId { get; set; }
    public string? ChainCode { get; set; }
    public string? ResvStatus { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? ConfirmationLegNo { get; set; }
    public string? GdsRecordLocator { get; set; }
    public string? CancellationNo { get; set; }
    public string? FrequentFlyerNumber { get; set; }
    public string? FrequentFlyerType { get; set; }
    public string? FrequentFlyerLevel { get; set; }
    public DateTime? FrequentFlyerExpiryDate { get; set; }
    public decimal? BookingLeadTime { get; set; }
    public DateTime? ResvCenterTrxDate { get; set; }
    public DateTime? Arrival { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? SmokingPreference { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? DecimalPositions { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalRoomRevenueTax { get; set; }
    public string? CommisionAmount { get; set; }
    public string? CommisionPctFlt { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? PromotionCode { get; set; }
    public string? Promotions { get; set; }
    public string? MarketCode { get; set; }
    public string? RateCode { get; set; }
    public string? GroupCode { get; set; }
    public string? BlockCode { get; set; }
    public string? RateDescription { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public decimal? RateLevel { get; set; }
    public string? OriginOfBooking { get; set; }
    public string? OwnerAirline { get; set; }
    public string? OperatorId { get; set; }
    public string? ResvCenterId { get; set; }
    public string? SpecialRequests { get; set; }
    public string? TravelAgentPhone { get; set; }
    public string? GuestBusinessPhone { get; set; }
    public string? GuestHomePhone { get; set; }
    public string? GuestFax { get; set; }
    public string? GuestMobile { get; set; }
    public string? TravelAgentEmail { get; set; }
    public string? GuestBusinessEmail { get; set; }
    public string? GuestHomeEmail { get; set; }
    public string? GuestOtherEmail { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? TravelAgentCode { get; set; }
    public string? TravelAgentName { get; set; }
    public string? TravelAgentAddress1 { get; set; }
    public string? TravelAgentAddress2 { get; set; }
    public string? TravelAgentAddress3 { get; set; }
    public string? TravelAgentAddress4 { get; set; }
    public string? TravelAgentCity { get; set; }
    public string? TravelAgentCsp { get; set; }
    public string? TravelAgentPostalCode { get; set; }
    public string? TravelAgentCountryCode { get; set; }
    public decimal? CorporateId { get; set; }
    public string? CorporateCode { get; set; }
    public string? CorporateName { get; set; }
    public string? CorporateAddress1 { get; set; }
    public string? CorporateAddress2 { get; set; }
    public string? CorporateAddress3 { get; set; }
    public string? CorporateAddress4 { get; set; }
    public string? CorporateCity { get; set; }
    public string? CorporateCsp { get; set; }
    public string? CorporatePostalCode { get; set; }
    public string? CorporateCountryCode { get; set; }
    public string? GuestTitle { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestLastName { get; set; }
    public decimal? GuestId { get; set; }
    public string? GuestAddress1 { get; set; }
    public string? GuestAddress2 { get; set; }
    public string? GuestAddress3 { get; set; }
    public string? GuestAddress4 { get; set; }
    public string? GuestCity { get; set; }
    public string? GuestCsp { get; set; }
    public string? GuestPostalCode { get; set; }
    public string? GuestCountryCode { get; set; }
    public string? BookerClientId { get; set; }
    public string? BookerIdType { get; set; }
    public string? Subchannel { get; set; }
    public string? CancellationCode { get; set; }
    public decimal? ShareId { get; set; }
    public string? SourceName { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Fpc { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public string? GuestMiddleName { get; set; }
    public string? LoyaltyNumber { get; set; }
    public string? LoyaltyType { get; set; }
    public string? LoyaltyLevel { get; set; }
    public DateTime? LoyaltyExpiryDate { get; set; }
    public string? Products { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Bde>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.RecordId })
                .HasName("BDE_PK");

            entity.ToTable("BDE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookerClientId)
                .HasColumnName("BOOKER_CLIENT_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BookerIdType)
                .HasColumnName("BOOKER_ID_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BookingLeadTime)
                .HasColumnName("BOOKING_LEAD_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationCode)
                .HasColumnName("CANCELLATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommisionAmount)
                .HasColumnName("COMMISION_AMOUNT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommisionPctFlt)
                .HasColumnName("COMMISION_PCT_FLT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLegNo)
                .HasColumnName("CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CorporateAddress1)
                .HasColumnName("CORPORATE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CorporateAddress2)
                .HasColumnName("CORPORATE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CorporateAddress3)
                .HasColumnName("CORPORATE_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CorporateAddress4)
                .HasColumnName("CORPORATE_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CorporateCity)
                .HasColumnName("CORPORATE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CorporateCode)
                .HasColumnName("CORPORATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CorporateCountryCode)
                .HasColumnName("CORPORATE_COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CorporateCsp)
                .HasColumnName("CORPORATE_CSP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CorporateId)
                .HasColumnName("CORPORATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CorporateName)
                .HasColumnName("CORPORATE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CorporatePostalCode)
                .HasColumnName("CORPORATE_POSTAL_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Fpc)
                .HasColumnName("FPC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerExpiryDate)
                .HasColumnName("FREQUENT_FLYER_EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FrequentFlyerLevel)
                .HasColumnName("FREQUENT_FLYER_LEVEL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerNumber)
                .HasColumnName("FREQUENT_FLYER_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerType)
                .HasColumnName("FREQUENT_FLYER_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsRecordLocator)
                .HasColumnName("GDS_RECORD_LOCATOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress1)
                .HasColumnName("GUEST_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress2)
                .HasColumnName("GUEST_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress3)
                .HasColumnName("GUEST_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress4)
                .HasColumnName("GUEST_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestBusinessEmail)
                .HasColumnName("GUEST_BUSINESS_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestBusinessPhone)
                .HasColumnName("GUEST_BUSINESS_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestCity)
                .HasColumnName("GUEST_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestCountryCode)
                .HasColumnName("GUEST_COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestCsp)
                .HasColumnName("GUEST_CSP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestFax)
                .HasColumnName("GUEST_FAX")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestHomeEmail)
                .HasColumnName("GUEST_HOME_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestHomePhone)
                .HasColumnName("GUEST_HOME_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestId)
                .HasColumnName("GUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestMiddleName)
                .HasColumnName("GUEST_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestMobile)
                .HasColumnName("GUEST_MOBILE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestOtherEmail)
                .HasColumnName("GUEST_OTHER_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestPostalCode)
                .HasColumnName("GUEST_POSTAL_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyExpiryDate)
                .HasColumnName("LOYALTY_EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LoyaltyLevel)
                .HasColumnName("LOYALTY_LEVEL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyNumber)
                .HasColumnName("LOYALTY_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyType)
                .HasColumnName("LOYALTY_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerAirline)
                .HasColumnName("OWNER_AIRLINE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Promotions)
                .HasColumnName("PROMOTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDescription)
                .HasColumnName("RATE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateLevel)
                .HasColumnName("RATE_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvCenterId)
                .HasColumnName("RESV_CENTER_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvCenterTrxDate)
                .HasColumnName("RESV_CENTER_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SmokingPreference)
                .HasColumnName("SMOKING_PREFERENCE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequests)
                .HasColumnName("SPECIAL_REQUESTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Subchannel)
                .HasColumnName("SUBCHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenueTax)
                .HasColumnName("TOTAL_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentAddress1)
                .HasColumnName("TRAVEL_AGENT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentAddress2)
                .HasColumnName("TRAVEL_AGENT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentAddress3)
                .HasColumnName("TRAVEL_AGENT_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentAddress4)
                .HasColumnName("TRAVEL_AGENT_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentCity)
                .HasColumnName("TRAVEL_AGENT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentCode)
                .HasColumnName("TRAVEL_AGENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentCountryCode)
                .HasColumnName("TRAVEL_AGENT_COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentCsp)
                .HasColumnName("TRAVEL_AGENT_CSP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentEmail)
                .HasColumnName("TRAVEL_AGENT_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentPhone)
                .HasColumnName("TRAVEL_AGENT_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentPostalCode)
                .HasColumnName("TRAVEL_AGENT_POSTAL_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}

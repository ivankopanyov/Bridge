namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGl2000
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public string? ExportType { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestTitleCode { get; set; }
    public string? CompanyName { get; set; }
    public string? GuestPosition { get; set; }
    public string? GuestAddress1 { get; set; }
    public string? GuestAddress2 { get; set; }
    public string? GuestCity { get; set; }
    public string? GuestPostalCode { get; set; }
    public string? GuestTelephone { get; set; }
    public decimal? LeadDays { get; set; }
    public string? GuestProfession { get; set; }
    public decimal? RoomNightsTotal { get; set; }
    public decimal? GuestNightsTotal { get; set; }
    public string? GroupFlag { get; set; }
    public decimal? AgentIataNo { get; set; }
    public decimal? CompanyCorpId { get; set; }
    public decimal? LoyaltyMemberNo { get; set; }
    public decimal? AirlineMemberNo { get; set; }
    public string? AirlineBonusPoints { get; set; }
    public string? GuestLanguage { get; set; }
    public string? SourceCode { get; set; }
    public string? Geo1Code { get; set; }
    public string? Geo2Code { get; set; }
    public string? ChannelCode { get; set; }
    public string? CrsConfirmationNo { get; set; }
    public string? GuestCountryCode { get; set; }
    public string? GuestStateCode { get; set; }
    public string? GuestBusinessTitle { get; set; }
    public string? GuestSpecialsCodes { get; set; }
    public string? PaymentCode { get; set; }
    public decimal? RevenueAmount1 { get; set; }
    public decimal? RevenueAmount2 { get; set; }
    public decimal? RevenueAmount3 { get; set; }
    public decimal? RevenueAmount4 { get; set; }
    public decimal? RevenueAmount5 { get; set; }
    public decimal? RevenueAmount6 { get; set; }
    public decimal? RevenueAmount7 { get; set; }
    public decimal? RevenueAmount8 { get; set; }
    public decimal? RevenueAmount9 { get; set; }
    public decimal? RevenueAmount10 { get; set; }
    public string? MarketCode1 { get; set; }
    public string? MarketCode2 { get; set; }
    public string? MarketCode3 { get; set; }
    public decimal? MktRoomNights1 { get; set; }
    public decimal? MktRoomNights2 { get; set; }
    public decimal? MktRoomNights3 { get; set; }
    public decimal? MktRoomRevenue1 { get; set; }
    public decimal? MktRoomRevenue2 { get; set; }
    public decimal? MktRoomRevenue3 { get; set; }
    public string? ReservationStatusFlag { get; set; }
    public string? GuestCompanyName { get; set; }
    public string? RoomType { get; set; }
    public string? RateCode { get; set; }
    public decimal? AgentProfileNo { get; set; }
    public decimal? CompanyProfileNo { get; set; }
    public decimal? GuestProfileNo { get; set; }
    public decimal? CreditCardNo { get; set; }
    public decimal? ArAccountNo { get; set; }
    public string? ContactName { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string? LoyaltyMemberType { get; set; }
    public string? AirlineMemberType { get; set; }
    public string? ErrorFlag1 { get; set; }
    public string? ErrorFlag2 { get; set; }
    public string? ErrorFlag3 { get; set; }
    public string? ErrorFlag4 { get; set; }
    public string? PropertyCode { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? CurrencyDecimals { get; set; }
    public string? PmsVersion { get; set; }
    public decimal? ExpRoomNightsTotal { get; set; }
    public decimal? ErrorFlag1Count { get; set; }
    public decimal? ErrorFlag2Count { get; set; }
    public decimal? ErrorFlag3Count { get; set; }
    public decimal? ErrorFlag4Count { get; set; }
    public string? ReservationInsertUser { get; set; }
    public string? ReservationStatus { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? GuestAddressId { get; set; }
    public decimal? TotalErrorCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGl2000>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GL2000");

            entity.Property(e => e.AgentIataNo)
                .HasColumnName("AGENT_IATA_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentProfileNo)
                .HasColumnName("AGENT_PROFILE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineBonusPoints)
                .HasColumnName("AIRLINE_BONUS_POINTS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineMemberNo)
                .HasColumnName("AIRLINE_MEMBER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineMemberType)
                .HasColumnName("AIRLINE_MEMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArAccountNo)
                .HasColumnName("AR_ACCOUNT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyCorpId)
                .HasColumnName("COMPANY_CORP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyProfileNo)
                .HasColumnName("COMPANY_PROFILE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNo)
                .HasColumnName("CREDIT_CARD_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsConfirmationNo)
                .HasColumnName("CRS_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDecimals)
                .HasColumnName("CURRENCY_DECIMALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorFlag1)
                .HasColumnName("ERROR_FLAG_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ErrorFlag1Count)
                .HasColumnName("ERROR_FLAG_1_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorFlag2)
                .HasColumnName("ERROR_FLAG_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ErrorFlag2Count)
                .HasColumnName("ERROR_FLAG_2_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorFlag3)
                .HasColumnName("ERROR_FLAG_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ErrorFlag3Count)
                .HasColumnName("ERROR_FLAG_3_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorFlag4)
                .HasColumnName("ERROR_FLAG_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ErrorFlag4Count)
                .HasColumnName("ERROR_FLAG_4_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpRoomNightsTotal)
                .HasColumnName("EXP_ROOM_NIGHTS_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Geo1Code)
                .HasColumnName("GEO1_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Geo2Code)
                .HasColumnName("GEO2_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupFlag)
                .HasColumnName("GROUP_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress1)
                .HasColumnName("GUEST_ADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress2)
                .HasColumnName("GUEST_ADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddressId)
                .HasColumnName("GUEST_ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestBusinessTitle)
                .HasColumnName("GUEST_BUSINESS_TITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestCity)
                .HasColumnName("GUEST_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestCompanyName)
                .HasColumnName("GUEST_COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestCountryCode)
                .HasColumnName("GUEST_COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguage)
                .HasColumnName("GUEST_LANGUAGE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNightsTotal)
                .HasColumnName("GUEST_NIGHTS_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestPosition)
                .HasColumnName("GUEST_POSITION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestPostalCode)
                .HasColumnName("GUEST_POSTAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestProfession)
                .HasColumnName("GUEST_PROFESSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestProfileNo)
                .HasColumnName("GUEST_PROFILE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestSpecialsCodes)
                .HasColumnName("GUEST_SPECIALS_CODES")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestStateCode)
                .HasColumnName("GUEST_STATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestTelephone)
                .HasColumnName("GUEST_TELEPHONE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitleCode)
                .HasColumnName("GUEST_TITLE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltyMemberNo)
                .HasColumnName("LOYALTY_MEMBER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltyMemberType)
                .HasColumnName("LOYALTY_MEMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode1)
                .HasColumnName("MARKET_CODE_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode2)
                .HasColumnName("MARKET_CODE_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode3)
                .HasColumnName("MARKET_CODE_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MktRoomNights1)
                .HasColumnName("MKT_ROOM_NIGHTS_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktRoomNights2)
                .HasColumnName("MKT_ROOM_NIGHTS_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktRoomNights3)
                .HasColumnName("MKT_ROOM_NIGHTS_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktRoomRevenue1)
                .HasColumnName("MKT_ROOM_REVENUE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktRoomRevenue2)
                .HasColumnName("MKT_ROOM_REVENUE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktRoomRevenue3)
                .HasColumnName("MKT_ROOM_REVENUE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentCode)
                .HasColumnName("PAYMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservationInsertUser)
                .HasColumnName("RESERVATION_INSERT_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatusFlag)
                .HasColumnName("RESERVATION_STATUS_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount1)
                .HasColumnName("REVENUE_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount10)
                .HasColumnName("REVENUE_AMOUNT_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount2)
                .HasColumnName("REVENUE_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount3)
                .HasColumnName("REVENUE_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount4)
                .HasColumnName("REVENUE_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount5)
                .HasColumnName("REVENUE_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount6)
                .HasColumnName("REVENUE_AMOUNT_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount7)
                .HasColumnName("REVENUE_AMOUNT_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount8)
                .HasColumnName("REVENUE_AMOUNT_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount9)
                .HasColumnName("REVENUE_AMOUNT_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsTotal)
                .HasColumnName("ROOM_NIGHTS_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalErrorCount)
                .HasColumnName("TOTAL_ERROR_COUNT")
                .HasColumnType("NUMBER");
        });
	}
}

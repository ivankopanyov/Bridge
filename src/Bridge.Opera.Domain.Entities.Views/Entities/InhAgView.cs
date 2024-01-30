namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InhAgView
{
    public string? RoomResort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? SharedYn { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? ResvStatus { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? Nights { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? Room { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? Balance { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? CompanyName { get; set; }
    public string? GroupName { get; set; }
    public string? TravelAgentName { get; set; }
    public string? SourceName { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? BlockCode { get; set; }
    public DateTime? TruncArrival { get; set; }
    public string? MasterShare { get; set; }
    public string? Resort { get; set; }
    public string? AccompanyingYn { get; set; }
    public string? MessageYn { get; set; }
    public string? RoutingYn { get; set; }
    public string? FolioYn { get; set; }
    public string? TraceYn { get; set; }
    public string? LocatorYn { get; set; }
    public string? Comments { get; set; }
    public string? AuthorisedBillingYn { get; set; }
    public decimal? FixedCharge { get; set; }
    public string? XlastName { get; set; }
    public string? XfirstName { get; set; }
    public string? PartyCode { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? SguestName { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? CompanyId { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? PostCoFlag { get; set; }
    public string? PreChargingYn { get; set; }
    public string? PostChargingYn { get; set; }
    public string? PostingAllowedYn { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? CreditCardNumberStr { get; set; }
    public decimal? CreditCardId { get; set; }
    public string? NameType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InhAgView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INH_AG_VIEW");

            entity.Property(e => e.AccompanyingYn)
                .HasColumnName("ACCOMPANYING_YN")
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.AuthorisedBillingYn)
                .HasColumnName("AUTHORISED_BILLING_YN")
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
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

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
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

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FixedCharge)
                .HasColumnName("FIXED_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioYn)
                .HasColumnName("FOLIO_YN")
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
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocatorYn)
                .HasColumnName("LOCATOR_YN")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MessageYn)
                .HasColumnName("MESSAGE_YN")
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostChargingYn)
                .HasColumnName("POST_CHARGING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostCoFlag)
                .HasColumnName("POST_CO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreChargingYn)
                .HasColumnName("PRE_CHARGING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
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

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingYn)
                .HasColumnName("ROUTING_YN")
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
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

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

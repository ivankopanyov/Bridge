namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvBatchBalanceView
{
    public string? Resort { get; set; }
    public decimal? Balance { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestMiddleName { get; set; }
    public string? ResvStatus { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? GuestTitle { get; set; }
    public string? CompanyName { get; set; }
    public decimal? CompanyId { get; set; }
    public string? TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string? SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? NameUsageType { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? ConsumerYn { get; set; }
    public string? FinanciallyResponsibleYn { get; set; }
    public string? IntermediaryYn { get; set; }
    public string? PaymentMethod { get; set; }
    public string? PostingAllowedYn { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? Room { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? MarketCode { get; set; }
    public string? CurrencyCode { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? NameTaxType { get; set; }
    public string? RbStatus { get; set; }
    public string? Vip { get; set; }
    public DateTime? TruncArrival { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? RoomResort { get; set; }
    public string? SguestName { get; set; }
    public string? RoomClass { get; set; }
    public DateTime? LastPeriodicFolioDate { get; set; }
    public DateTime? LastDirectBillBatchDate { get; set; }
    public decimal? PeriodicFolioFreq { get; set; }
    public decimal? ShareAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvBatchBalanceView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_BATCH_BALANCE_VIEW");

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConsumerYn)
                .HasColumnName("CONSUMER_YN")
                .HasMaxLength(1)
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
                .HasColumnType("DATE");

            entity.Property(e => e.FinanciallyResponsibleYn)
                .HasColumnName("FINANCIALLY_RESPONSIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestMiddleName)
                .HasColumnName("GUEST_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IntermediaryYn)
                .HasColumnName("INTERMEDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastDirectBillBatchDate)
                .HasColumnName("LAST_DIRECT_BILL_BATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastPeriodicFolioDate)
                .HasColumnName("LAST_PERIODIC_FOLIO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PeriodicFolioFreq)
                .HasColumnName("PERIODIC_FOLIO_FREQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RbStatus)
                .HasColumnName("RB_STATUS")
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

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
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

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

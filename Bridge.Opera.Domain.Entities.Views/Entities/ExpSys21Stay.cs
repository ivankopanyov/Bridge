namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Stay
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? StayId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? LastAdults { get; set; }
    public decimal? LastChildren { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? IsTaAttached01 { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? ShareAmountLocal { get; set; }
    public string Resort { get; set; }
    public string ResvStatus { get; set; }
    public string Room { get; set; }
    public string ExtConfirmationNo { get; set; }
    public string ReservationStatus { get; set; }
    public string WalkinYn { get; set; }
    public string RateCode { get; set; }
    public string CompHouseStatus { get; set; }
    public string MarketCode { get; set; }
    public string HotelCode { get; set; }
    public string GnrNum { get; set; }
    public string GuaranteeType { get; set; }
    public string PaymentMethod { get; set; }
    public string TaName { get; set; }
    public string TaAddress1 { get; set; }
    public string TaAddress2 { get; set; }
    public string TaCity { get; set; }
    public string TaState { get; set; }
    public string TaCountry { get; set; }
    public string TaPostalCode { get; set; }
    public string TaIataCorpNo { get; set; }
    public string StayReason { get; set; }
    public string ExtLegNo { get; set; }
    public string PrintRateYn { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string TravelReasonCode { get; set; }
    public string AllotmentCode { get; set; }
    public string Channel { get; set; }
    public string Udfc08 { get; set; }
    public string Udfc20 { get; set; }
    public string Udfc21 { get; set; }
    public string Udfc22 { get; set; }
    public string Udfc23 { get; set; }
    public string Udfc24 { get; set; }
    public string Udfc27 { get; set; }
    public string Udfc28 { get; set; }
    public string Udfc30 { get; set; }
    public string Udfc31 { get; set; }
    public string Udfc34 { get; set; }
    public string RateCodeDesc { get; set; }
    public DateTime? FirstArrival { get; set; }
    public DateTime? LastDeparture { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public DateTime? CancellationDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public DateTime? AllotmentStartDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Stay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_STAY");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentStartDate)
                .HasColumnName("ALLOTMENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompHouseStatus)
                .HasColumnName("COMP_HOUSE_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtConfirmationNo)
                .HasColumnName("EXT_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExtLegNo)
                .HasColumnName("EXT_LEG_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstArrival)
                .HasColumnName("FIRST_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.GnrNum)
                .HasColumnName("GNR_NUM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeType)
                .HasColumnName("GUARANTEE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsTaAttached01)
                .HasColumnName("IS_TA_ATTACHED_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastAdults)
                .HasColumnName("LAST_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastChildren)
                .HasColumnName("LAST_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastDeparture)
                .HasColumnName("LAST_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDesc)
                .HasColumnName("RATE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareAmountLocal)
                .HasColumnName("SHARE_AMOUNT_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayId)
                .HasColumnName("STAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayReason)
                .HasColumnName("STAY_REASON")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress1)
                .HasColumnName("TA_ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaAddress2)
                .HasColumnName("TA_ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaCity)
                .HasColumnName("TA_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaCountry)
                .HasColumnName("TA_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaIataCorpNo)
                .HasColumnName("TA_IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaName)
                .HasColumnName("TA_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaPostalCode)
                .HasColumnName("TA_POSTAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaState)
                .HasColumnName("TA_STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelReasonCode)
                .HasColumnName("TRAVEL_REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
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

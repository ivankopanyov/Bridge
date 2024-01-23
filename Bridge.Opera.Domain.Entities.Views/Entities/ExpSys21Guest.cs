namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Guest
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? StayId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? LastAdults { get; set; }
    public decimal? LastChildren { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? DirectBillWindowNo { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string Middle { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public string AirlineCardType { get; set; }
    public string AirlineCardNo { get; set; }
    public string WalkinYn { get; set; }
    public string GuestStatus { get; set; }
    public string CompIataCorpNo { get; set; }
    public string ExtConfirmationNo { get; set; }
    public string ConfirmationNo { get; set; }
    public string RoomCategory { get; set; }
    public string PrintRateYn { get; set; }
    public string Resort { get; set; }
    public string IdNumber { get; set; }
    public string TaIataCorpNo { get; set; }
    public string GuaranteeCode { get; set; }
    public string GuaranteeCodePreCi { get; set; }
    public string PaymentMethod { get; set; }
    public string CreditcardType { get; set; }
    public string DirectBillName { get; set; }
    public string CurrencyCode { get; set; }
    public string CompanyName { get; set; }
    public string TravelAgentName { get; set; }
    public string GroupName { get; set; }
    public string ArNo { get; set; }
    public string IsoLanguageCode { get; set; }
    public string Udfc02 { get; set; }
    public string Email { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Guest>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_GUEST");

            entity.Property(e => e.AirlineCardNo)
                .HasColumnName("AIRLINE_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineCardType)
                .HasColumnName("AIRLINE_CARD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompIataCorpNo)
                .HasColumnName("COMP_IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditcardType)
                .HasColumnName("CREDITCARD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DirectBillName)
                .HasColumnName("DIRECT_BILL_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DirectBillWindowNo)
                .HasColumnName("DIRECT_BILL_WINDOW_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtConfirmationNo)
                .HasColumnName("EXT_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCodePreCi)
                .HasColumnName("GUARANTEE_CODE_PRE_CI")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestStatus)
                .HasColumnName("GUEST_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsoLanguageCode)
                .HasColumnName("ISO_LANGUAGE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastAdults)
                .HasColumnName("LAST_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastChildren)
                .HasColumnName("LAST_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
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

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayId)
                .HasColumnName("STAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaIataCorpNo)
                .HasColumnName("TA_IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
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

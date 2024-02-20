namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpBtrRecordsDay
{
    public decimal? ExportId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RowSequence { get; set; }
    public decimal? RecordType { get; set; }
    public decimal? FolioView { get; set; }
    public string? ExportType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? ConfNo { get; set; }
    public string? AccProdId { get; set; }
    public string? PseudoYn { get; set; }
    public string? ShareYn { get; set; }
    public string? MrNumber { get; set; }
    public string? MrLevel { get; set; }
    public string? MrPref { get; set; }
    public string? FfCode { get; set; }
    public string? FfType { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CcType { get; set; }
    public string? CreditCard { get; set; }
    public DateTime? CcExpy { get; set; }
    public string? CcAuthCode { get; set; }
    public decimal? NameId { get; set; }
    public decimal? CcAuthAmt { get; set; }
    public string? OppNo { get; set; }
    public string? SwipeYn { get; set; }
    public string? ResvStatus { get; set; }
    public string? BtrType { get; set; }
    public DateTime? QueueDate { get; set; }
    public string? QueueTime { get; set; }
    public string? EarlyDepYn { get; set; }
    public string? WalkinYn { get; set; }
    public string? HostmultInd { get; set; }
    public string? BlockCode { get; set; }
    public string? BlockId { get; set; }
    public string? Specials { get; set; }
    public string? RoomPref { get; set; }
    public string? ArAccount { get; set; }
    public string? AwardCode { get; set; }
    public string? B2cProgType { get; set; }
    public string? B2cEmail { get; set; }
    public string? PrintYn { get; set; }
    public decimal? TotalDebit { get; set; }
    public decimal? TotalCredit { get; set; }
    public DateTime? ResvDailyDate { get; set; }
    public string? Origin { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public decimal? Amount { get; set; }
    public string? CurrencyCode { get; set; }
    public string? Room { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomType { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? ProfType { get; set; }
    public string? AccName { get; set; }
    public string? AccAddress1 { get; set; }
    public string? AccAddress2 { get; set; }
    public string? AccCity { get; set; }
    public string? AccState { get; set; }
    public string? AccZip { get; set; }
    public string? AccCountry { get; set; }
    public string? AccContact { get; set; }
    public string? AccConPhone { get; set; }
    public string? IataNumber { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? TrxDesc { get; set; }
    public string? TrxRef { get; set; }
    public DateTime? TrxInsertDate { get; set; }
    public decimal? NetAmount { get; set; }
    public string? RetailYn { get; set; }
    public string? UserCode { get; set; }
    public DateTime? PhoneDate { get; set; }
    public string? PhoneNo { get; set; }
    public string? PhoneDuration { get; set; }
    public string? TrxSuppl { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? IntLink { get; set; }
    public decimal? TrxNoTax { get; set; }
    public string? TrxMrEligYn { get; set; }
    public string? Cashier { get; set; }
    public string? DbAccount { get; set; }
    public string? Certificate { get; set; }
    public string? IsUpgrade { get; set; }
    public string? CcAuthStatus { get; set; }
    public string? PptNo { get; set; }
    public string? PptLang { get; set; }
    public DateTime? PptBirthDate { get; set; }
    public string? PptCountry { get; set; }
    public DateTime? PptIssueDate { get; set; }
    public DateTime? PptExpDate { get; set; }
    public string? PptPlace { get; set; }
    public DateTime? ResvInsertDate { get; set; }
    public string? EmailAddress { get; set; }
    public decimal? FromResvId { get; set; }
    public DateTime? FromResvInsertDate { get; set; }
    public string? ResvStatFlag { get; set; }
    public string? CheckNo { get; set; }
    public string? OrigRoom { get; set; }
    public string? HotelCode { get; set; }
    public string? ExtRefNo { get; set; }
    public string? MrBonusCode { get; set; }
    public decimal? MrEligRevenue { get; set; }
    public string? DepositYn { get; set; }
    public string? CustomReference { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpBtrRecordsDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_BTR_RECORDS_DAY");

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccConPhone)
                .HasColumnName("ACC_CON_PHONE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccContact)
                .HasColumnName("ACC_CONTACT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccProdId)
                .HasColumnName("ACC_PROD_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccZip)
                .HasColumnName("ACC_ZIP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArAccount)
                .HasColumnName("AR_ACCOUNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.B2cEmail)
                .HasColumnName("B2C_EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.B2cProgType)
                .HasColumnName("B2C_PROG_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BtrType)
                .HasColumnName("BTR_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Cashier)
                .HasColumnName("CASHIER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcAuthAmt)
                .HasColumnName("CC_AUTH_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcAuthCode)
                .HasColumnName("CC_AUTH_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcAuthStatus)
                .HasColumnName("CC_AUTH_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcExpy)
                .HasColumnName("CC_EXPY")
                .HasColumnType("DATE");

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Certificate)
                .HasColumnName("CERTIFICATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfNo)
                .HasColumnName("CONF_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCard)
                .HasColumnName("CREDIT_CARD")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CustomReference)
                .HasColumnName("CUSTOM_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DbAccount)
                .HasColumnName("DB_ACCOUNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositYn)
                .HasColumnName("DEPOSIT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EarlyDepYn)
                .HasColumnName("EARLY_DEP_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExtRefNo)
                .HasColumnName("EXT_REF_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FfCode)
                .HasColumnName("FF_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FfType)
                .HasColumnName("FF_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvInsertDate)
                .HasColumnName("FROM_RESV_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HostmultInd)
                .HasColumnName("HOSTMULT_IND")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IataNumber)
                .HasColumnName("IATA_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IntLink)
                .HasColumnName("INT_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsUpgrade)
                .HasColumnName("IS_UPGRADE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MrBonusCode)
                .HasColumnName("MR_BONUS_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MrEligRevenue)
                .HasColumnName("MR_ELIG_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MrLevel)
                .HasColumnName("MR_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MrNumber)
                .HasColumnName("MR_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MrPref)
                .HasColumnName("MR_PREF")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OppNo)
                .HasColumnName("OPP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrigRoom)
                .HasColumnName("ORIG_ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Origin)
                .HasColumnName("ORIGIN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneDate)
                .HasColumnName("PHONE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PhoneDuration)
                .HasColumnName("PHONE_DURATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PptBirthDate)
                .HasColumnName("PPT_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PptCountry)
                .HasColumnName("PPT_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PptExpDate)
                .HasColumnName("PPT_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PptIssueDate)
                .HasColumnName("PPT_ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PptLang)
                .HasColumnName("PPT_LANG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PptNo)
                .HasColumnName("PPT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PptPlace)
                .HasColumnName("PPT_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .HasColumnName("PRINT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProfType)
                .HasColumnName("PROF_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.QueueDate)
                .HasColumnName("QUEUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QueueTime)
                .HasColumnName("QUEUE_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvDailyDate)
                .HasColumnName("RESV_DAILY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvInsertDate)
                .HasColumnName("RESV_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatFlag)
                .HasColumnName("RESV_STAT_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RetailYn)
                .HasColumnName("RETAIL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomPref)
                .HasColumnName("ROOM_PREF")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareYn)
                .HasColumnName("SHARE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Specials)
                .HasColumnName("SPECIALS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SwipeYn)
                .HasColumnName("SWIPE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalCredit)
                .HasColumnName("TOTAL_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDebit)
                .HasColumnName("TOTAL_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxInsertDate)
                .HasColumnName("TRX_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxMrEligYn)
                .HasColumnName("TRX_MR_ELIG_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoTax)
                .HasColumnName("TRX_NO_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxRef)
                .HasColumnName("TRX_REF")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxSuppl)
                .HasColumnName("TRX_SUPPL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UserCode)
                .HasColumnName("USER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}

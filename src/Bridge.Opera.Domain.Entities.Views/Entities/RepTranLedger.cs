namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepTranLedger
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ResvStatus { get; set; }
    public string? Arrival { get; set; }
    public string? Departure { get; set; }
    public string? PaymentMethod { get; set; }
    public string? GuestFullName { get; set; }
    public string? RoomNo { get; set; }
    public string? Room { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public string? FtGeneratedType { get; set; }
    public string? FtSubtype { get; set; }
    public string? BusinessFormatDate { get; set; }
    public string? BusinessTime { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? Amount { get; set; }
    public int? FolioView { get; set; }
    public decimal? FolioNumber { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Currency { get; set; }
    public decimal? TrxNoAdjust { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public decimal? TrxNoHeader { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? CashierId { get; set; }
    public string? TclCode1 { get; set; }
    public string? TclCode2 { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? ArCredit { get; set; }
    public decimal? ArDebit { get; set; }
    public string? ArState { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? NameId { get; set; }
    public string? MarketCode { get; set; }
    public string? RateCode { get; set; }
    public string? DeferredYn { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? DepLedDebit { get; set; }
    public string? HotelAcct { get; set; }
    public string? IndAdjustmentYn { get; set; }
    public string? ReasonCode { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? FinDmlSeqNo { get; set; }
    public decimal? RoutingInstrnId { get; set; }
    public decimal? FromResvId { get; set; }
    public string? PasserByName { get; set; }
    public decimal? RevenueAmt { get; set; }
    public string? IndRevenueGp { get; set; }
    public string? IndCash { get; set; }
    public string? TcTransactionType { get; set; }
    public string? IndDepositYn { get; set; }
    public string? IndAr { get; set; }
    public string? IndBilling { get; set; }
    public string? CcCode { get; set; }
    public string? CcType { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? OpenBalance { get; set; }
    public string? CreditCardDescription { get; set; }
    public DateTime? CreditCardExpiryDate { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public string? PostCoFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepTranLedger>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_TRAN_LEDGER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArCredit)
                .HasColumnName("AR_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArDebit)
                .HasColumnName("AR_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArState)
                .HasColumnName("AR_STATE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessFormatDate)
                .HasColumnName("BUSINESS_FORMAT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTime)
                .HasColumnName("BUSINESS_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardDescription)
                .HasColumnName("CREDIT_CARD_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpiryDate)
                .HasColumnName("CREDIT_CARD_EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeferredYn)
                .IsRequired()
                .HasColumnName("DEFERRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FinDmlSeqNo)
                .HasColumnName("FIN_DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNumber)
                .HasColumnName("FOLIO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtGeneratedType)
                .HasColumnName("FT_GENERATED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestFullName)
                .HasColumnName("GUEST_FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.HotelAcct)
                .HasColumnName("HOTEL_ACCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IndAdjustmentYn)
                .HasColumnName("IND_ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndAr)
                .HasColumnName("IND_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndBilling)
                .HasColumnName("IND_BILLING")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndCash)
                .HasColumnName("IND_CASH")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndDepositYn)
                .HasColumnName("IND_DEPOSIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalance)
                .HasColumnName("OPEN_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PasserByName)
                .HasColumnName("PASSER_BY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostCoFlag)
                .HasColumnName("POST_CO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

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

            entity.Property(e => e.RevenueAmt)
                .HasColumnName("REVENUE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoutingInstrnId)
                .HasColumnName("ROUTING_INSTRN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcTransactionType)
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TclCode1)
                .HasColumnName("TCL_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCode2)
                .HasColumnName("TCL_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAdjust)
                .HasColumnName("TRX_NO_ADJUST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoHeader)
                .HasColumnName("TRX_NO_HEADER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

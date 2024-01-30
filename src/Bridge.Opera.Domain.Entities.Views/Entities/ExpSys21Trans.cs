namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Trans
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? MasterTrxNo { get; set; }
    public decimal? TbAmountNet { get; set; }
    public decimal? TbAmountGross { get; set; }
    public decimal? SignQualifier { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? OccupancyCount { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FromResvId { get; set; }
    public decimal? StayId { get; set; }
    public decimal? OriginalStayId { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ClosureNo { get; set; }
    public decimal? CurrExResvNameId { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public decimal? OriginalResvNameId { get; set; }
    public string? TrxCode { get; set; }
    public string? ChargeCategory { get; set; }
    public string? AccountingCategory { get; set; }
    public string? IsRoutedYn { get; set; }
    public string? RoutedToAccount { get; set; }
    public string? MarketCode { get; set; }
    public string? EntryType { get; set; }
    public string? TrxType { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CcCode { get; set; }
    public string? CcApprovalCode { get; set; }
    public string? ChequeNumber { get; set; }
    public string? UserLastName { get; set; }
    public string? UserFirstName { get; set; }
    public string? FtSubtype { get; set; }
    public string? LocalCurrency { get; set; }
    public string? TrxCodeAddedBy { get; set; }
    public string? PrimaryEntryType { get; set; }
    public string? RecptType { get; set; }
    public string? Currency { get; set; }
    public string? IsCurrencyExchangeYn { get; set; }
    public string? TransAccountType { get; set; }
    public string? PkgCommissionable { get; set; }
    public string? ArAccountCode { get; set; }
    public string? TravelReasonCode { get; set; }
    public string? InclInArTransYn { get; set; }
    public string? InclInOtherTransYn { get; set; }
    public string? GlDeptCode { get; set; }
    public string? GlAccountCode { get; set; }
    public string? TransactionDescription { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public string? TransPaymentMethod { get; set; }
    public string? TrxNoAgainstDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? TrxDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Trans>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_TRANS");

            entity.Property(e => e.AccountingCategory)
                .HasColumnName("ACCOUNTING_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArAccountCode)
                .HasColumnName("AR_ACCOUNT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeCategory)
                .HasColumnName("CHARGE_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrExResvNameId)
                .HasColumnName("CURR_EX_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EntryType)
                .HasColumnName("ENTRY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GlAccountCode)
                .HasColumnName("GL_ACCOUNT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GlDeptCode)
                .HasColumnName("GL_DEPT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInArTransYn)
                .HasColumnName("INCL_IN_AR_TRANS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInOtherTransYn)
                .HasColumnName("INCL_IN_OTHER_TRANS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsCurrencyExchangeYn)
                .HasColumnName("IS_CURRENCY_EXCHANGE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsRoutedYn)
                .HasColumnName("IS_ROUTED_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LocalCurrency)
                .HasColumnName("LOCAL_CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MasterTrxNo)
                .HasColumnName("MASTER_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupancyCount)
                .HasColumnName("OCCUPANCY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalResvNameId)
                .HasColumnName("ORIGINAL_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalStayId)
                .HasColumnName("ORIGINAL_STAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgCommissionable)
                .HasColumnName("PKG_COMMISSIONABLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryEntryType)
                .HasColumnName("PRIMARY_ENTRY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecptType)
                .HasColumnName("RECPT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutedToAccount)
                .HasColumnName("ROUTED_TO_ACCOUNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SignQualifier)
                .HasColumnName("SIGN_QUALIFIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayId)
                .HasColumnName("STAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountGross)
                .HasColumnName("TB_AMOUNT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountNet)
                .HasColumnName("TB_AMOUNT_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransAccountType)
                .HasColumnName("TRANS_ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransPaymentMethod)
                .HasColumnName("TRANS_PAYMENT_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDescription)
                .HasColumnName("TRANSACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TravelReasonCode)
                .HasColumnName("TRAVEL_REASON_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeAddedBy)
                .HasColumnName("TRX_CODE_ADDED_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstDesc)
                .HasColumnName("TRX_NO_AGAINST_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UserFirstName)
                .HasColumnName("USER_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UserLastName)
                .HasColumnName("USER_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}

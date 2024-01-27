namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinancialTransactionsView
{
    public string Resort { get; set; }
    public DateTime TrxDate { get; set; }
    public string TrxCode { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? InternalDbPayments { get; set; }
    public decimal? ArLedCredit { get; set; }
    public decimal? RevenueAmt { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NonRevenueAmount { get; set; }
    public decimal? InhCredit { get; set; }
    public decimal? InhDebit { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? Quantity { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string RoomClass { get; set; }
    public string InvoiceType { get; set; }
    public string TaxInclusiveYn { get; set; }
    public decimal? RecptNo { get; set; }
    public string RecptType { get; set; }
    public string ChequeNumber { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public decimal TrxNo { get; set; }
    public string FtSubtype { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public decimal? ArNumber { get; set; }
    public DateTime BusinessDate { get; set; }
    public string Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? CashierId { get; set; }
    public int? FolioView { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? NameId { get; set; }
    public string RateCode { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? RoutingInstrnId { get; set; }
    public decimal? FromResvId { get; set; }
    public string Product { get; set; }
    public string ArState { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public DateTime? TrnsActivityDate { get; set; }
    public decimal? TrnsFromAcct { get; set; }
    public decimal? TrnsToAcct { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? RevisionNo { get; set; }
    public string TargetResort { get; set; }
    public string FolioType { get; set; }
    public string CompressedYn { get; set; }
    public decimal? ArrangementId { get; set; }
    public string ArrangementCode { get; set; }
    public string ArrangementType { get; set; }
    public string TransactionDescription { get; set; }
    public string IndAdjustmentYn { get; set; }
    public string ReasonCode { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string DeferredYn { get; set; }
    public string TaxGeneratedYn { get; set; }
    public string TaCommissionableYn { get; set; }
    public string FixedChargesYn { get; set; }
    public string TaxElements { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public string PasserbyName { get; set; }
    public string RoomType { get; set; }
    public string CashierName { get; set; }
    public string CcCode { get; set; }
    public string TcTransactionType { get; set; }
    public string TrxCodeType { get; set; }
    public string TrxType { get; set; }
    public string TrxTypeDescription { get; set; }
    public decimal? TrxTypeSort { get; set; }
    public decimal? TbAmountNet { get; set; }
    public decimal? TbAmountGross { get; set; }
    public decimal? IsDebit01 { get; set; }
    public decimal? IsCredit01 { get; set; }
    public string IsInternalYn { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string ApprovalCode { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public string ApprovalStatus { get; set; }
    public string ApprovalStatusDesc { get; set; }
    public string AppUser { get; set; }
    public string DisplayYn { get; set; }
    public decimal? LinkTrxNo { get; set; }
    public string SummRefCode { get; set; }
    public string ActualPostingDateTime { get; set; }
    public string ForexType { get; set; }
    public decimal? ForexCommPerc { get; set; }
    public decimal? ForexCommAmount { get; set; }
    public decimal? ActualExchangeRate { get; set; }
    public decimal? ArticleId { get; set; }
    public string ArticleCode { get; set; }
    public string CompYn { get; set; }
    public decimal? FinDmlSeqNo { get; set; }
    public string CcType { get; set; }
    public decimal? CompLinkTrxNo { get; set; }
    public string CompLinkTrxCode { get; set; }
    public string AccTypeFlag { get; set; }
    public string FiscalBillNo { get; set; }
    public decimal? PackageAllowance { get; set; }
    public decimal? OrgArLedDebit { get; set; }
    public string SettlementFlag { get; set; }
    public DateTime? PostingDate { get; set; }
    public string TrxCodeAddedBy { get; set; }
    public string AdvGenerateAdjustment { get; set; }
    public string AdvGenerateTrxCode { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? ParallelGuestCredit { get; set; }
    public decimal? ParallelGuestDebit { get; set; }
    public string ParallelCurrency { get; set; }
    public string ExchangeDifferenceYn { get; set; }
    public decimal? Installments { get; set; }
    public string NumberDialed { get; set; }
    public string Covers { get; set; }
    public DateTime? TzInsertDate { get; set; }
    public string AsbFlag { get; set; }
    public string ProfitLossFlag { get; set; }
    public string IsInternalPkgTaxYn { get; set; }
    public string IsExclProfitLossYn { get; set; }
    public string PostitYn { get; set; }
    public decimal? PostitNo { get; set; }
    public decimal? ChangeDue { get; set; }
    public string AutoSettleYn { get; set; }
    public string PostingType { get; set; }
    public string IndCash { get; set; }
    public string DepTaxTransferedYn { get; set; }
    public decimal? OriginalResvNameId { get; set; }
    public string DeferredTaxesYn { get; set; }
    public string PostingRhythm { get; set; }
    public string AutoCreditbillYn { get; set; }
    public decimal? BonusCheckId { get; set; }
    public string FbaCertificateNumber { get; set; }
    public decimal? OwnerLedDebit { get; set; }
    public decimal? OwnerLedCredit { get; set; }
    public string AsbTaxFlag { get; set; }
    public string AsbOnlyPostTaxesOnceYn { get; set; }
    public decimal? ClosureNo { get; set; }
    public string DepPostingFlag { get; set; }
    public string PackageArrangementCode { get; set; }
    public string CorrectionYn { get; set; }
    public string RoutedYn { get; set; }
    public decimal? ReversePaymentTrxNo { get; set; }
    public string AdvanceBillYn { get; set; }
    public string AdvanceBillReversedYn { get; set; }
    public string GpAwardCode { get; set; }
    public string GpAwardCancelCode { get; set; }
    public decimal? OrgPostedAmount { get; set; }
    public string IncTaxDeductedYn { get; set; }
    public decimal? DepNetAmount { get; set; }
    public decimal? DepGrossAmount { get; set; }
    public string InternalYn { get; set; }
    public decimal? DepNetTaxAmt { get; set; }
    public string CcRefundPosting { get; set; }
    public decimal? ElectronicVoucherNo { get; set; }
    public string NameTaxType { get; set; }
    public decimal? TrxNoAdjust { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinancialTransactionsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FINANCIAL_TRANSACTIONS_VIEW");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ActualExchangeRate)
                .HasColumnName("ACTUAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualPostingDateTime)
                .HasColumnName("ACTUAL_POSTING_DATE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.AdvGenerateAdjustment)
                .HasColumnName("ADV_GENERATE_ADJUSTMENT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AdvGenerateTrxCode)
                .HasColumnName("ADV_GENERATE_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdvanceBillReversedYn)
                .HasColumnName("ADVANCE_BILL_REVERSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AdvanceBillYn)
                .HasColumnName("ADVANCE_BILL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalDate)
                .HasColumnName("APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalStatus)
                .HasColumnName("APPROVAL_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalStatusDesc)
                .HasColumnName("APPROVAL_STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArState)
                .HasColumnName("AR_STATE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrangementType)
                .HasColumnName("ARRANGEMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArticleCode)
                .HasColumnName("ARTICLE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AsbFlag)
                .HasColumnName("ASB_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AsbOnlyPostTaxesOnceYn)
                .HasColumnName("ASB_ONLY_POST_TAXES_ONCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AsbTaxFlag)
                .HasColumnName("ASB_TAX_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoCreditbillYn)
                .HasColumnName("AUTO_CREDITBILL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoSettleYn)
                .HasColumnName("AUTO_SETTLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusCheckId)
                .HasColumnName("BONUS_CHECK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierName)
                .HasColumnName("CASHIER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcRefundPosting)
                .HasColumnName("CC_REFUND_POSTING")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ChangeDue)
                .HasColumnName("CHANGE_DUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompLinkTrxCode)
                .HasColumnName("COMP_LINK_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompLinkTrxNo)
                .HasColumnName("COMP_LINK_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompressedYn)
                .HasColumnName("COMPRESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CorrectionYn)
                .HasColumnName("CORRECTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeferredTaxesYn)
                .HasColumnName("DEFERRED_TAXES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeferredYn)
                .IsRequired()
                .HasColumnName("DEFERRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepGrossAmount)
                .HasColumnName("DEP_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepNetAmount)
                .HasColumnName("DEP_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepNetTaxAmt)
                .HasColumnName("DEP_NET_TAX_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepPostingFlag)
                .HasColumnName("DEP_POSTING_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepTaxTransferedYn)
                .HasColumnName("DEP_TAX_TRANSFERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ElectronicVoucherNo)
                .HasColumnName("ELECTRONIC_VOUCHER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeDifferenceYn)
                .HasColumnName("EXCHANGE_DIFFERENCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FbaCertificateNumber)
                .HasColumnName("FBA_CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FinDmlSeqNo)
                .HasColumnName("FIN_DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FixedChargesYn)
                .HasColumnName("FIXED_CHARGES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.ForexCommAmount)
                .HasColumnName("FOREX_COMM_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexCommPerc)
                .HasColumnName("FOREX_COMM_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexType)
                .HasColumnName("FOREX_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GpAwardCancelCode)
                .HasColumnName("GP_AWARD_CANCEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpAwardCode)
                .HasColumnName("GP_AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IncTaxDeductedYn)
                .HasColumnName("INC_TAX_DEDUCTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndAdjustmentYn)
                .HasColumnName("IND_ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndCash)
                .HasColumnName("IND_CASH")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhCredit)
                .HasColumnName("INH_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhDebit)
                .HasColumnName("INH_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Installments)
                .HasColumnName("INSTALLMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalDbPayments)
                .HasColumnName("INTERNAL_DB_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.IsCredit01)
                .HasColumnName("IS_CREDIT_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsDebit01)
                .HasColumnName("IS_DEBIT_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsExclProfitLossYn)
                .HasColumnName("IS_EXCL_PROFIT_LOSS_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.IsInternalPkgTaxYn)
                .HasColumnName("IS_INTERNAL_PKG_TAX_YN")
                .IsUnicode(false);

            entity.Property(e => e.IsInternalYn)
                .HasColumnName("IS_INTERNAL_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.LinkTrxNo)
                .HasColumnName("LINK_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueAmount)
                .HasColumnName("NON_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberDialed)
                .HasColumnName("NUMBER_DIALED")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrgArLedDebit)
                .HasColumnName("ORG_AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgPostedAmount)
                .HasColumnName("ORG_POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OriginalResvNameId)
                .HasColumnName("ORIGINAL_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerLedCredit)
                .HasColumnName("OWNER_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerLedDebit)
                .HasColumnName("OWNER_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageAllowance)
                .HasColumnName("PACKAGE_ALLOWANCE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageArrangementCode)
                .HasColumnName("PACKAGE_ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ParallelCurrency)
                .HasColumnName("PARALLEL_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParallelGuestCredit)
                .HasColumnName("PARALLEL_GUEST_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ParallelGuestDebit)
                .HasColumnName("PARALLEL_GUEST_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PasserbyName)
                .HasColumnName("PASSERBY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostingType)
                .HasColumnName("POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitYn)
                .HasColumnName("POSTIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfitLossFlag)
                .HasColumnName("PROFIT_LOSS_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.RecptNo)
                .HasColumnName("RECPT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecptType)
                .HasColumnName("RECPT_TYPE")
                .HasMaxLength(3)
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

            entity.Property(e => e.RevenueAmt)
                .HasColumnName("REVENUE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ReversePaymentTrxNo)
                .HasColumnName("REVERSE_PAYMENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RoutedYn)
                .HasColumnName("ROUTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoutingInstrnId)
                .HasColumnName("ROUTING_INSTRN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SettlementFlag)
                .HasColumnName("SETTLEMENT_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SummRefCode)
                .HasColumnName("SUMM_REF_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionableYn)
                .HasColumnName("TA_COMMISSIONABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.TaxGeneratedYn)
                .HasColumnName("TAX_GENERATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TbAmountGross)
                .HasColumnName("TB_AMOUNT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountNet)
                .HasColumnName("TB_AMOUNT_NET")
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

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionDescription)
                .HasColumnName("TRANSACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrnsActivityDate)
                .HasColumnName("TRNS_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnsFromAcct)
                .HasColumnName("TRNS_FROM_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsToAcct)
                .HasColumnName("TRNS_TO_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeAddedBy)
                .HasColumnName("TRX_CODE_ADDED_BY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
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

            entity.Property(e => e.TrxNoAdjust)
                .HasColumnName("TRX_NO_ADJUST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.TrxTypeDescription)
                .HasColumnName("TRX_TYPE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TrxTypeSort)
                .HasColumnName("TRX_TYPE_SORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TzInsertDate)
                .HasColumnName("TZ_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

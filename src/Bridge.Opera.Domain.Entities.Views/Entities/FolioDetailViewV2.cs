namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioDetailViewV2
{
    public decimal? ResvNameIdDetail { get; set; }
    public decimal? SourceResvNameId { get; set; }
    public decimal? FolioNoDetail { get; set; }
    public decimal? BillNumberDetail { get; set; }
    public decimal? RevisionNumberDetail { get; set; }
    public decimal? WindowNo { get; set; }
    public string? FolioStyle { get; set; }
    public string? PhoneDetails { get; set; }
    public string? RoomNumberDetail { get; set; }
    public string? TrxDate { get; set; }
    public string? TransactionCode { get; set; }
    public decimal? Quantity { get; set; }
    public string? Reference { get; set; }
    public string? Description { get; set; }
    public string? Supplement { get; set; }
    public string? Debit { get; set; }
    public string? Credit { get; set; }
    public string? EuroDebit { get; set; }
    public string? EuroCredit { get; set; }
    public string? ExchangeRate { get; set; }
    public string? DetailCurrencyDebit { get; set; }
    public string? DetailCurrencyCredit { get; set; }
    public string? DetailCurrency { get; set; }
    public decimal? DetailCurrencyExchangeRt { get; set; }
    public string? CcApprovalCode { get; set; }
    public DateTime? ExpiryDateDetail { get; set; }
    public string? CurrencyDetail { get; set; }
    public decimal? ExchRate { get; set; }
    public decimal? EuroExchRate { get; set; }
    public decimal? PostedAmount { get; set; }
    public string? PostedAmountChar { get; set; }
    public string? CurrFormatMask { get; set; }
    public string? Refinvo { get; set; }
    public string? ChequeNumber { get; set; }
    public string? NetAmount { get; set; }
    public string? GrossAmount { get; set; }
    public string? EuroNetAmount { get; set; }
    public string? EuroGrossAmount { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? TranActionId { get; set; }
    public DateTime? DirectTrxDate { get; set; }
    public decimal? FolioViewDetail { get; set; }
    public decimal? DirectDebit { get; set; }
    public decimal? DirectCredit { get; set; }
    public decimal? DirectEuroDebit { get; set; }
    public decimal? DirectEuroCredit { get; set; }
    public decimal? DirectDetailCurrencyDebit { get; set; }
    public decimal? DirectDetailCurrencyCredit { get; set; }
    public decimal? DirectNetAmount { get; set; }
    public decimal? DirectGross { get; set; }
    public decimal? DirectEuroNet { get; set; }
    public decimal? DirectEuroGross { get; set; }
    public string? RecordType { get; set; }
    public string? SourceRoomNumber { get; set; }
    public string? TrxCodeType { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TargetResort { get; set; }
    public decimal? TotalInclusiveTax { get; set; }
    public string? TaxElements { get; set; }
    public decimal? NameIdDetail { get; set; }
    public string? GuestName { get; set; }
    public string? NetPrice { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? InvoiceNumber { get; set; }
    public string? TcTransactionType { get; set; }
    public string? TaxInclusiveYn { get; set; }
    public decimal? PricePerUnit { get; set; }
    public string? Tax1Amt { get; set; }
    public string? Tax2Amt { get; set; }
    public string? Tax3Amt { get; set; }
    public string? Tax4Amt { get; set; }
    public string? Tax5Amt { get; set; }
    public string? Tax6Amt { get; set; }
    public string? Tax7Amt { get; set; }
    public string? Tax8Amt { get; set; }
    public string? Tax9Amt { get; set; }
    public string? Tax10Amt { get; set; }
    public string? Tax11Amt { get; set; }
    public string? Tax12Amt { get; set; }
    public string? Tax13Amt { get; set; }
    public string? Tax14Amt { get; set; }
    public string? Tax15Amt { get; set; }
    public string? Tax16Amt { get; set; }
    public string? Tax17Amt { get; set; }
    public string? Tax18Amt { get; set; }
    public string? Tax19Amt { get; set; }
    public string? Tax20Amt { get; set; }
    public string? TotalNetPrice { get; set; }
    public string? FiscalTrxCodeType { get; set; }
    public string? ArrangementCode { get; set; }
    public string? ArrangementDescription { get; set; }
    public string? TaxCodeNo { get; set; }
    public string? ActualPostingDateTime { get; set; }
    public string? CreditCardNumberDetail { get; set; }
    public string? ExpiryDateCharDetail { get; set; }
    public string? BonusCheckNumberDetail { get; set; }
    public string? CouponNo { get; set; }
    public string? CreditDebitAmount { get; set; }
    public string? ParallelDebit { get; set; }
    public string? ParallelCredit { get; set; }
    public decimal? DirectParallelDebit { get; set; }
    public decimal? DirectParallelCredit { get; set; }
    public decimal? InstallmentsDetail { get; set; }
    public string? CreditCardNo { get; set; }
    public decimal? Taxamount { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? RoundingAmount { get; set; }
    public string? RevenuePaymentType { get; set; }
    public string? TrxServiceType { get; set; }
    public string? TrxTaxTypeCode { get; set; }
    public string? DataType { get; set; }
    public string? Comments { get; set; }
    public string? MemberPointEligibileInd { get; set; }
    public string? InstRedemptionEligibileInd { get; set; }
    public string? OriginalRoom { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioDetailViewV2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_DETAIL_VIEW_V2");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualPostingDateTime)
                .HasColumnName("ACTUAL_POSTING_DATE_TIME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementDescription)
                .HasColumnName("ARRANGEMENT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BillNumberDetail)
                .HasColumnName("BILL_NUMBER_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusCheckNumberDetail)
                .HasColumnName("BONUS_CHECK_NUMBER_DETAIL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CouponNo)
                .HasColumnName("COUPON_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNo)
                .HasColumnName("CREDIT_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberDetail)
                .HasColumnName("CREDIT_CARD_NUMBER_DETAIL")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.CreditDebitAmount)
                .HasColumnName("CREDIT_DEBIT_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.CurrFormatMask)
                .HasColumnName("CURR_FORMAT_MASK")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDetail)
                .HasColumnName("CURRENCY_DETAIL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrency)
                .HasColumnName("DETAIL_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyCredit)
                .HasColumnName("DETAIL_CURRENCY_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyDebit)
                .HasColumnName("DETAIL_CURRENCY_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyExchangeRt)
                .HasColumnName("DETAIL_CURRENCY_EXCHANGE_RT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectCredit)
                .HasColumnName("DIRECT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDebit)
                .HasColumnName("DIRECT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDetailCurrencyCredit)
                .HasColumnName("DIRECT_DETAIL_CURRENCY_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDetailCurrencyDebit)
                .HasColumnName("DIRECT_DETAIL_CURRENCY_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroCredit)
                .HasColumnName("DIRECT_EURO_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroDebit)
                .HasColumnName("DIRECT_EURO_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroGross)
                .HasColumnName("DIRECT_EURO_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroNet)
                .HasColumnName("DIRECT_EURO_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectGross)
                .HasColumnName("DIRECT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectNetAmount)
                .HasColumnName("DIRECT_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectParallelCredit)
                .HasColumnName("DIRECT_PARALLEL_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectParallelDebit)
                .HasColumnName("DIRECT_PARALLEL_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTrxDate)
                .HasColumnName("DIRECT_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EuroCredit)
                .HasColumnName("EURO_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.EuroDebit)
                .HasColumnName("EURO_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.EuroExchRate)
                .HasColumnName("EURO_EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroGrossAmount)
                .HasColumnName("EURO_GROSS_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.EuroNetAmount)
                .HasColumnName("EURO_NET_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.ExchRate)
                .HasColumnName("EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDateCharDetail)
                .HasColumnName("EXPIRY_DATE_CHAR_DETAIL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDateDetail)
                .HasColumnName("EXPIRY_DATE_DETAIL")
                .HasColumnType("DATE");

            entity.Property(e => e.FiscalTrxCodeType)
                .HasColumnName("FISCAL_TRX_CODE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioNoDetail)
                .HasColumnName("FOLIO_NO_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioViewDetail)
                .HasColumnName("FOLIO_VIEW_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstRedemptionEligibileInd)
                .HasColumnName("INST_REDEMPTION_ELIGIBILE_IND")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.InstallmentsDetail)
                .HasColumnName("INSTALLMENTS_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNumber)
                .HasColumnName("INVOICE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemberPointEligibileInd)
                .HasColumnName("MEMBER_POINT_ELIGIBILE_IND")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.NameIdDetail)
                .HasColumnName("NAME_ID_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.NetPrice)
                .HasColumnName("NET_PRICE")
                .IsUnicode(false);

            entity.Property(e => e.OriginalRoom)
                .HasColumnName("ORIGINAL_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParallelCredit)
                .HasColumnName("PARALLEL_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.ParallelDebit)
                .HasColumnName("PARALLEL_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.PhoneDetails)
                .HasColumnName("PHONE_DETAILS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmountChar)
                .HasColumnName("POSTED_AMOUNT_CHAR")
                .IsUnicode(false);

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Refinvo)
                .HasColumnName("REFINVO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameIdDetail)
                .HasColumnName("RESV_NAME_ID_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenuePaymentType)
                .HasColumnName("REVENUE_PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevisionNumberDetail)
                .HasColumnName("REVISION_NUMBER_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNumberDetail)
                .HasColumnName("ROOM_NUMBER_DETAIL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoundingAmount)
                .HasColumnName("ROUNDING_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceResvNameId)
                .HasColumnName("SOURCE_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRoomNumber)
                .HasColumnName("SOURCE_ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax10Amt)
                .HasColumnName("TAX10_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax11Amt)
                .HasColumnName("TAX11_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax12Amt)
                .HasColumnName("TAX12_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax13Amt)
                .HasColumnName("TAX13_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax14Amt)
                .HasColumnName("TAX14_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax15Amt)
                .HasColumnName("TAX15_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax16Amt)
                .HasColumnName("TAX16_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax17Amt)
                .HasColumnName("TAX17_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax18Amt)
                .HasColumnName("TAX18_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax19Amt)
                .HasColumnName("TAX19_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax1Amt)
                .HasColumnName("TAX1_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax20Amt)
                .HasColumnName("TAX20_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax2Amt)
                .HasColumnName("TAX2_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax3Amt)
                .HasColumnName("TAX3_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax4Amt)
                .HasColumnName("TAX4_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax5Amt)
                .HasColumnName("TAX5_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax6Amt)
                .HasColumnName("TAX6_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax7Amt)
                .HasColumnName("TAX7_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax8Amt)
                .HasColumnName("TAX8_AMT")
                .IsUnicode(false);

            entity.Property(e => e.Tax9Amt)
                .HasColumnName("TAX9_AMT")
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeNo)
                .HasColumnName("TAX_CODE_NO")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Taxamount)
                .HasColumnName("TAXAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcTransactionType)
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalInclusiveTax)
                .HasColumnName("TOTAL_INCLUSIVE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetPrice)
                .HasColumnName("TOTAL_NET_PRICE")
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxServiceType)
                .HasColumnName("TRX_SERVICE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxTaxTypeCode)
                .HasColumnName("TRX_TAX_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WindowNo)
                .HasColumnName("WINDOW_NO")
                .HasColumnType("NUMBER");
        });
	}
}

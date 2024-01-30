namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkDocCcFolioList
{
    public decimal? WorkingDocId { get; set; }
    public decimal? ResvNameIdMerchant { get; set; }
    public int? FolioViewMerchant { get; set; }
    public decimal? FolioNoMerchant { get; set; }
    public decimal? BillNumberMerchant { get; set; }
    public decimal? RevisionNumberMerchant { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? LedgerAmount { get; set; }
    public string? ApprovalCode { get; set; }
    public string? CreditCardType { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditTransType { get; set; }
    public decimal? ApprovalAmount { get; set; }
    public string? MerchantNumberMerchant { get; set; }
    public string? ExpiryDateMerchant { get; set; }
    public string? RespRef { get; set; }
    public string? RespType { get; set; }
    public string? TrxAmountMask { get; set; }
    public string? ApprovalAmountMask { get; set; }
    public string? CcCurrencyCode { get; set; }
    public decimal? CcExchangeRate { get; set; }
    public string? CcCurrencyAmount { get; set; }
    public decimal? DccReceiptNo { get; set; }
    public decimal? InstallmentsMerchant { get; set; }
    public string? PromotionalText1 { get; set; }
    public string? PromotionalText2 { get; set; }
    public string? CurrencyCodeMerchant { get; set; }
    public decimal? SettlementAmountFc { get; set; }
    public string? SettlementAmountFcMask { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkDocCcFolioList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WORK_DOC_CC_FOLIO_LIST");

            entity.HasIndex(e => e.WorkingDocId)
                .HasName("WDCCFL_FOL_STYLE_IDX");

            entity.Property(e => e.ApprovalAmount)
                .HasColumnName("APPROVAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountMask)
                .HasColumnName("APPROVAL_AMOUNT_MASK")
                .IsUnicode(false);

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillNumberMerchant)
                .HasColumnName("BILL_NUMBER_MERCHANT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcCurrencyAmount)
                .HasColumnName("CC_CURRENCY_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.CcCurrencyCode)
                .HasColumnName("CC_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcExchangeRate)
                .HasColumnName("CC_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditTransType)
                .HasColumnName("CREDIT_TRANS_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCodeMerchant)
                .HasColumnName("CURRENCY_CODE_MERCHANT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DccReceiptNo)
                .HasColumnName("DCC_RECEIPT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpiryDateMerchant)
                .HasColumnName("EXPIRY_DATE_MERCHANT")
                .IsUnicode(false);

            entity.Property(e => e.FolioNoMerchant)
                .HasColumnName("FOLIO_NO_MERCHANT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioViewMerchant)
                .HasColumnName("FOLIO_VIEW_MERCHANT")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.InstallmentsMerchant)
                .HasColumnName("INSTALLMENTS_MERCHANT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LedgerAmount)
                .HasColumnName("LEDGER_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MerchantNumberMerchant)
                .HasColumnName("MERCHANT_NUMBER_MERCHANT")
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText1)
                .HasColumnName("PROMOTIONAL_TEXT1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText2)
                .HasColumnName("PROMOTIONAL_TEXT2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RespRef)
                .HasColumnName("RESP_REF")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespType)
                .HasColumnName("RESP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameIdMerchant)
                .HasColumnName("RESV_NAME_ID_MERCHANT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNumberMerchant)
                .HasColumnName("REVISION_NUMBER_MERCHANT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SettlementAmountFc)
                .HasColumnName("SETTLEMENT_AMOUNT_FC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SettlementAmountFcMask)
                .HasColumnName("SETTLEMENT_AMOUNT_FC_MASK")
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxAmountMask)
                .HasColumnName("TRX_AMOUNT_MASK")
                .IsUnicode(false);

            entity.Property(e => e.WorkingDocId)
                .HasColumnName("WORKING_DOC_ID")
                .HasColumnType("NUMBER");
        });
	}
}

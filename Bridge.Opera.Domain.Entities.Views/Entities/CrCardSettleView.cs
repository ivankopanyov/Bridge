namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CrCardSettleView
{
    public decimal CcSetId { get; set; }
    public string Resort { get; set; }
    public string CcApprovalCode { get; set; }
    public decimal? CashierId { get; set; }
    public DateTime? SettleDatetime { get; set; }
    public decimal? CreditCardId { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? FinTrxNo { get; set; }
    public decimal? ResvRecptId { get; set; }
    public string RespCode { get; set; }
    public string RespRefer { get; set; }
    public string RespType { get; set; }
    public string Room { get; set; }
    public string Track2Data { get; set; }
    public decimal? SettlementAmt { get; set; }
    public decimal? FolioNumber { get; set; }
    public decimal? NameId { get; set; }
    public string TrxCode { get; set; }
    public string IncludeYn { get; set; }
    public DateTime? TrxDate { get; set; }
    public string OriginFlag { get; set; }
    public string PromotionalText2 { get; set; }
    public string PromotionalText1 { get; set; }
    public decimal? ArAccountNumber { get; set; }
    public decimal? ArFolioNo { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string IssueNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public decimal? FolioView { get; set; }
    public string DccYn { get; set; }
    public decimal? DccReceiptNo { get; set; }
    public string CcCurrencyCode { get; set; }
    public decimal? CcExchangeRate { get; set; }
    public decimal? CcCurrencyAmount { get; set; }
    public string CcControlId { get; set; }
    public string ChipPinPfields { get; set; }
    public decimal? AuthSequenceNo { get; set; }
    public string CpCardYn { get; set; }
    public string TransactionType { get; set; }
    public decimal? BatchId { get; set; }
    public string OfflineSettlementYn { get; set; }
    public DateTime? SettleBusinessDate { get; set; }
    public string VendorTranId { get; set; }
    public decimal? ArNumber { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? SettlementAmountFc { get; set; }
    public string CardPresentYn { get; set; }
    public string LoyaltyRedemptionReference { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CrCardSettleView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CR_CARD_SETTLE_VIEW");

            entity.Property(e => e.ArAccountNumber)
                .HasColumnName("AR_ACCOUNT_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArFolioNo)
                .HasColumnName("AR_FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthSequenceNo)
                .HasColumnName("AUTH_SEQUENCE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CardPresentYn)
                .HasColumnName("CARD_PRESENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcControlId)
                .HasColumnName("CC_CONTROL_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcCurrencyAmount)
                .HasColumnName("CC_CURRENCY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcCurrencyCode)
                .HasColumnName("CC_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcExchangeRate)
                .HasColumnName("CC_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcSetId)
                .HasColumnName("CC_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChipPinPfields)
                .HasColumnName("CHIP_PIN_PFIELDS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.CpCardYn)
                .HasColumnName("CP_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DccReceiptNo)
                .HasColumnName("DCC_RECEIPT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DccYn)
                .HasColumnName("DCC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinTrxNo)
                .HasColumnName("FIN_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNumber)
                .HasColumnName("FOLIO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IncludeYn)
                .HasColumnName("INCLUDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyRedemptionReference)
                .HasColumnName("LOYALTY_REDEMPTION_REFERENCE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OfflineSettlementYn)
                .HasColumnName("OFFLINE_SETTLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OriginFlag)
                .HasColumnName("ORIGIN_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText1)
                .HasColumnName("PROMOTIONAL_TEXT1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText2)
                .HasColumnName("PROMOTIONAL_TEXT2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespCode)
                .HasColumnName("RESP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespRefer)
                .HasColumnName("RESP_REFER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespType)
                .HasColumnName("RESP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvRecptId)
                .HasColumnName("RESV_RECPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SettleBusinessDate)
                .HasColumnName("SETTLE_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SettleDatetime)
                .HasColumnName("SETTLE_DATETIME")
                .HasColumnType("DATE");

            entity.Property(e => e.SettlementAmountFc)
                .HasColumnName("SETTLEMENT_AMOUNT_FC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SettlementAmt)
                .HasColumnName("SETTLEMENT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Track2Data)
                .HasColumnName("TRACK2_DATA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VendorTranId)
                .HasColumnName("VENDOR_TRAN_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

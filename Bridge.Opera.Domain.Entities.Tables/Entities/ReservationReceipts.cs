namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationReceipts
{
    public ReservationReceipts()
    {
        CrCardSettle = new HashSet<CrCardSettle>();
    }

    public string Resort { get; set; }
    public decimal ResvReceiptId { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal ResvNameId { get; set; }
    public string OriginFlag { get; set; }
    public string Track2Data { get; set; }
    public string IssueNumber { get; set; }
    public decimal? Amount { get; set; }
    public DateTime? ReceiptDate { get; set; }
    public string ExtendedPayment { get; set; }
    public decimal? ReceiptBatchId { get; set; }
    public string Comments { get; set; }
    public string UcfFlag { get; set; }
    public DateTime? DateToProcess { get; set; }
    public string OriginalApprovalCode { get; set; }
    public string ApprovalCode { get; set; }
    public decimal? ApprovalAmount { get; set; }
    public decimal? ReceiptId { get; set; }
    public decimal? CallHeaderId { get; set; }
    public string CheckNumber { get; set; }
    public string CashReceiptType { get; set; }
    public string ReferenceNumber { get; set; }
    public string ManuallyEnteredYn { get; set; }
    public string PromotionData1 { get; set; }
    public string PromotionData2 { get; set; }
    public decimal AuthorisationCount { get; set; }
    public decimal? PreSettlementAuthAmount { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string SwipedYn { get; set; }
    public string DccYn { get; set; }
    public string CcCurrencyCode { get; set; }
    public decimal? CcExchangeRate { get; set; }
    public decimal? CcCurrencyAmount { get; set; }
    public string CcControlId { get; set; }
    public decimal? FolioView { get; set; }
    public string CcCryptogram { get; set; }
    public decimal? IncidentalApprovalAmount { get; set; }
    public decimal? AuthSequenceNo { get; set; }
    public string CpCardYn { get; set; }
    public string TransactionType { get; set; }
    public string VendorTranId { get; set; }
    public decimal? ArNumber { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? ApprovalAmountFc { get; set; }
    public decimal? IncidentalApprovalAmountFc { get; set; }
    public decimal? RecptNo { get; set; }
    public string CardPresentYn { get; set; }
    public string LoyaltyRedemptionReference { get; set; }

    public virtual ArAccount ArAccount { get; set; }
    public virtual NameCreditCard CreditCard { get; set; }
    public virtual ReservationName Res { get; set; }
    public virtual ICollection<CrCardSettle> CrCardSettle { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationReceipts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvReceiptId })
                .HasName("RESERVATION_RECEIPTS_PK");

            entity.ToTable("RESERVATION_RECEIPTS");

            entity.HasIndex(e => e.CreditCardId)
                .HasName("RESV_RECEIPTS_CC_CARD_FK_I");

            entity.HasIndex(e => new { e.Resort, e.ArNumber })
                .HasName("RESV_RECEIPTS_AR_FKI");

            entity.HasIndex(e => new { e.Resort, e.RecptNo })
                .HasName("RESV_RECEIPTS_RECPT_NO_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.FolioView, e.CreditCardId })
                .HasName("RESV_RECEIPTS_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvReceiptId)
                .HasColumnName("RESV_RECEIPT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovalAmount)
                .HasColumnName("APPROVAL_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovalAmountFc)
                .HasColumnName("APPROVAL_AMOUNT_FC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthSequenceNo)
                .HasColumnName("AUTH_SEQUENCE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorisationCount)
                .HasColumnName("AUTHORISATION_COUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CallHeaderId)
                .HasColumnName("CALL_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardPresentYn)
                .HasColumnName("CARD_PRESENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CashReceiptType)
                .HasColumnName("CASH_RECEIPT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcControlId)
                .HasColumnName("CC_CONTROL_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcCryptogram)
                .HasColumnName("CC_CRYPTOGRAM")
                .HasMaxLength(1000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcCurrencyAmount)
                .HasColumnName("CC_CURRENCY_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcCurrencyCode)
                .HasColumnName("CC_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcExchangeRate)
                .HasColumnName("CC_EXCHANGE_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CheckNumber)
                .HasColumnName("CHECK_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CpCardYn)
                .HasColumnName("CP_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DateToProcess)
                .HasColumnName("DATE_TO_PROCESS")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DccYn)
                .HasColumnName("DCC_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtendedPayment)
                .HasColumnName("EXTENDED_PAYMENT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncidentalApprovalAmount)
                .HasColumnName("INCIDENTAL_APPROVAL_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncidentalApprovalAmountFc)
                .HasColumnName("INCIDENTAL_APPROVAL_AMOUNT_FC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LoyaltyRedemptionReference)
                .HasColumnName("LOYALTY_REDEMPTION_REFERENCE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ManuallyEnteredYn)
                .HasColumnName("MANUALLY_ENTERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginFlag)
                .HasColumnName("ORIGIN_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginalApprovalCode)
                .HasColumnName("ORIGINAL_APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreSettlementAuthAmount)
                .HasColumnName("PRE_SETTLEMENT_AUTH_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromotionData1)
                .HasColumnName("PROMOTION_DATA1")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromotionData2)
                .HasColumnName("PROMOTION_DATA2")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReceiptBatchId)
                .HasColumnName("RECEIPT_BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReceiptDate)
                .HasColumnName("RECEIPT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReceiptId)
                .HasColumnName("RECEIPT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecptNo)
                .HasColumnName("RECPT_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferenceNumber)
                .HasColumnName("REFERENCE_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SwipedYn)
                .HasColumnName("SWIPED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Track2Data)
                .HasColumnName("TRACK2_DATA")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UcfFlag)
                .HasColumnName("UCF_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VendorTranId)
                .HasColumnName("VENDOR_TRAN_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(NameCreditCard)))
				entity.Ignore(e => e.CreditCard);
			else
	            entity.HasOne(d => d.CreditCard)
	                .WithMany(p => p.ReservationReceipts)
	                .HasForeignKey(d => d.CreditCardId)
	                .HasConstraintName("RESV_RECEIPTS_CC_CARD_FK");

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccount);
			else
	            entity.HasOne(d => d.ArAccount)
	                .WithMany(p => p.ReservationReceipts)
	                .HasForeignKey(d => new { d.Resort, d.ArNumber })
	                .HasConstraintName("RESV_RECEIPTS_AR_FK");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationReceipts)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_RECEIPT_RN_FK");
        
			if (!types.Contains(typeof(CrCardSettle)))
				entity.Ignore(e => e.CrCardSettle);
		});
	}
}

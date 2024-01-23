namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranGuestLedgerCheque1
{
    public string Resort { get; set; }
    public decimal? ChequeCount { get; set; }
    public decimal? ResvNameId { get; set; }
    public int? FolioView { get; set; }
    public decimal? TrxNo { get; set; }
    public string TrxCode { get; set; }
    public decimal? Quantity { get; set; }
    public string ChequeNumber { get; set; }
    public string TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? Amount { get; set; }
    public string ExchangeRate { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string FtGeneratedType { get; set; }
    public string FtSubtype { get; set; }
    public decimal? PricePerUnit { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string TclCode1 { get; set; }
    public string TclCode2 { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? RevisionNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string TargetResort { get; set; }
    public string FolioType { get; set; }
    public string DeferredTaxesYn { get; set; }
    public string CheckFileId { get; set; }
    public decimal? ParallelAmount { get; set; }
    public decimal? ContractAmount { get; set; }
    public DateTime? PostingDate { get; set; }
    public DateTime? ChequeDate { get; set; }
    public string AsbFlag { get; set; }
    public string DepTaxTransferedYn { get; set; }
    public string FbaCertificateNumber { get; set; }
    public string AsbTaxFlag { get; set; }
    public decimal? RoundLinkTrxno { get; set; }
    public string DepPostingFlag { get; set; }
    public decimal? ReversePaymentTrxNo { get; set; }
    public string AdvanceBillYn { get; set; }
    public string AdvanceBillReversedYn { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string GpAwardCode { get; set; }
    public string GpAwardCancelCode { get; set; }
    public string GpAwardCancelledYn { get; set; }
    public string ExchangeDifferenceYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranGuestLedgerCheque1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_GUEST_LEDGER_CHEQUE1");

            entity.Property(e => e.AdvanceBillReversedYn)
                .HasColumnName("ADVANCE_BILL_REVERSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AdvanceBillYn)
                .HasColumnName("ADVANCE_BILL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AsbFlag)
                .HasColumnName("ASB_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AsbTaxFlag)
                .HasColumnName("ASB_TAX_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckFileId)
                .HasColumnName("CHECK_FILE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCount)
                .HasColumnName("CHEQUE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChequeDate)
                .HasColumnName("CHEQUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContractAmount)
                .HasColumnName("CONTRACT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeferredTaxesYn)
                .HasColumnName("DEFERRED_TAXES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepPostingFlag)
                .HasColumnName("DEP_POSTING_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepTaxTransferedYn)
                .HasColumnName("DEP_TAX_TRANSFERED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeDifferenceYn)
                .HasColumnName("EXCHANGE_DIFFERENCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .IsUnicode(false);

            entity.Property(e => e.FbaCertificateNumber)
                .HasColumnName("FBA_CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.FtGeneratedType)
                .HasColumnName("FT_GENERATED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GpAwardCancelCode)
                .HasColumnName("GP_AWARD_CANCEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GpAwardCancelledYn)
                .HasColumnName("GP_AWARD_CANCELLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpAwardCode)
                .HasColumnName("GP_AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParallelAmount)
                .HasColumnName("PARALLEL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReversePaymentTrxNo)
                .HasColumnName("REVERSE_PAYMENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoundLinkTrxno)
                .HasColumnName("ROUND_LINK_TRXNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.TrxCode)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

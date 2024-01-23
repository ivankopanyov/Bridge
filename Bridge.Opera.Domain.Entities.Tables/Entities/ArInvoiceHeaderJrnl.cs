namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArInvoiceHeaderJrnl
{
    public string Resort { get; set; }
    public string JrnlOperation { get; set; }
    public DateTime? JrnlTime { get; set; }
    public string JrnlDesc { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? NameId { get; set; }
    public string Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public string TrxCode { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string InvStatus { get; set; }
    public decimal? TranActionId { get; set; }
    public string PurgeYn { get; set; }
    public decimal? AgingBucket { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? ArLedCredit { get; set; }
    public string AdjustmentYn { get; set; }
    public DateTime? CheckOutDate { get; set; }
    public decimal? CashierId { get; set; }
    public string InvoiceType { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public DateTime? TrnsActivityDate { get; set; }
    public decimal? TrnsFromAcct { get; set; }
    public decimal? TrnsToAcct { get; set; }
    public decimal? BillNo { get; set; }
    public string FolioType { get; set; }
    public decimal? MasterInvoiceNo { get; set; }
    public string CompressedYn { get; set; }
    public DateTime? CompressDate { get; set; }
    public decimal? ReminderCycle { get; set; }
    public DateTime? ReminderDate { get; set; }
    public string InvoiceClosedBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public string InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string UpdateUser { get; set; }
    public string FiscalBillNo { get; set; }
    public string AccTypeFlag { get; set; }
    public decimal? CreditedToTrxNo { get; set; }
    public string PrintedYn { get; set; }
    public DateTime? PrintedDate { get; set; }
    public string OwnerRoom { get; set; }
    public decimal? StatementNo { get; set; }
    public string FolioText1 { get; set; }
    public string FolioText2 { get; set; }
    public decimal? OrgAmtCurrDiff { get; set; }
    public decimal? OrgAmtParallel { get; set; }
    public decimal? OrgAmtContract { get; set; }
    public string ContractCurrencyCode { get; set; }
    public string ParallelCurrencyCode { get; set; }
    public decimal? ParallelCurrDiff { get; set; }
    public decimal? ContractCurrDiff { get; set; }
    public string ExpOriginalInvoice { get; set; }
    public string ExpInvoiceType { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public decimal? JrnlUser { get; set; }
    public string PaymentNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArInvoiceHeaderJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_INVOICE_HEADER_JRNL");

            entity.HasIndex(e => e.JrnlTime)
                .HasName("AIHJ_TIME_IDX");

            entity.HasIndex(e => new { e.InvoiceNo, e.Resort })
                .HasName("AIHJ_INVOICE_IDX");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentYn)
                .HasColumnName("ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgingBucket)
                .HasColumnName("AGING_BUCKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckOutDate)
                .HasColumnName("CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompressDate)
                .HasColumnName("COMPRESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompressedYn)
                .HasColumnName("COMPRESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContractCurrDiff)
                .HasColumnName("CONTRACT_CURR_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractCurrencyCode)
                .HasColumnName("CONTRACT_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditedToTrxNo)
                .HasColumnName("CREDITED_TO_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpInvoiceType)
                .HasColumnName("EXP_INVOICE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ExpOriginalInvoice)
                .HasColumnName("EXP_ORIGINAL_INVOICE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioText1)
                .HasColumnName("FOLIO_TEXT1")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FolioText2)
                .HasColumnName("FOLIO_TEXT2")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceClosedBy)
                .HasColumnName("INVOICE_CLOSED_BY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.JrnlDesc)
                .HasColumnName("JRNL_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.JrnlOperation)
                .HasColumnName("JRNL_OPERATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JrnlTime)
                .HasColumnName("JRNL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.JrnlUser)
                .HasColumnName("JRNL_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterInvoiceNo)
                .HasColumnName("MASTER_INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmtContract)
                .HasColumnName("ORG_AMT_CONTRACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmtCurrDiff)
                .HasColumnName("ORG_AMT_CURR_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmtParallel)
                .HasColumnName("ORG_AMT_PARALLEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerRoom)
                .HasColumnName("OWNER_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParallelCurrDiff)
                .HasColumnName("PARALLEL_CURR_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParallelCurrencyCode)
                .HasColumnName("PARALLEL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PaymentNo)
                .HasColumnName("PAYMENT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintedDate)
                .HasColumnName("PRINTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintedYn)
                .HasColumnName("PRINTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PurgeYn)
                .HasColumnName("PURGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReminderCycle)
                .HasColumnName("REMINDER_CYCLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReminderDate)
                .HasColumnName("REMINDER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StatementNo)
                .HasColumnName("STATEMENT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsActivityDate)
                .HasColumnName("TRNS_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnsFromAcct)
                .HasColumnName("TRNS_FROM_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsToAcct)
                .HasColumnName("TRNS_TO_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

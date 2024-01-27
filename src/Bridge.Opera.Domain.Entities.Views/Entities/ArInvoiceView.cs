namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArInvoiceView
{
    public string Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string AccountName { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string GuestName { get; set; }
    public decimal? NameId { get; set; }
    public string Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public string TrxCode { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Aropen { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string AdjustYn { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PostedAmount { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string InvStatus { get; set; }
    public decimal? TranActionId { get; set; }
    public string InvoiceType { get; set; }
    public decimal? InvoiceAge { get; set; }
    public DateTime? UpdDate { get; set; }
    public decimal? LedgerDebit { get; set; }
    public decimal? LedgerCredit { get; set; }
    public decimal? AgingBucket { get; set; }
    public string PurgeYn { get; set; }
    public DateTime? TrnsActivityDate { get; set; }
    public decimal? TrnsFromAcct { get; set; }
    public decimal? TrnsToAcct { get; set; }
    public decimal? BillNumber { get; set; }
    public string FolioType { get; set; }
    public decimal? MasterInvoiceNo { get; set; }
    public decimal? ReminderCycle { get; set; }
    public DateTime? ReminderDate { get; set; }
    public string CompressedYn { get; set; }
    public DateTime? CompressDate { get; set; }
    public string FiscalBillNo { get; set; }
    public decimal? CreditedToTrxNo { get; set; }
    public string PrintedYn { get; set; }
    public string OwnerRoom { get; set; }
    public decimal? StatementNo { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public string AddresseeName { get; set; }
    public string XaddresseeName { get; set; }
    public string PaymentNo { get; set; }
    public DateTime? CheckOutDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArInvoiceView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_INVOICE_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeName)
                .HasColumnName("ADDRESSEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgingBucket)
                .HasColumnName("AGING_BUCKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
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

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditedToTrxNo)
                .HasColumnName("CREDITED_TO_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.LedgerCredit)
                .HasColumnName("LEDGER_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LedgerDebit)
                .HasColumnName("LEDGER_DEBIT")
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

            entity.Property(e => e.OwnerRoom)
                .HasColumnName("OWNER_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentNo)
                .HasColumnName("PAYMENT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
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

            entity.Property(e => e.UpdDate)
                .HasColumnName("UPD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.XaddresseeName)
                .HasColumnName("XADDRESSEE_NAME")
                .IsUnicode(false);
        });
	}
}

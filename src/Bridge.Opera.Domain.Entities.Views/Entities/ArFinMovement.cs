namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFinMovement
{
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public string? AccountNo { get; set; }
    public decimal? AccountTypeId { get; set; }
    public decimal? NameId { get; set; }
    public string? Room { get; set; }
    public string? GuestName { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? Payments { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public string? InvoiceNumber { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? Paid { get; set; }
    public DateTime? BillingDate { get; set; }
    public DateTime? BillingDateTime { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? ArDebit { get; set; }
    public decimal? ArCredit { get; set; }
    public decimal? TranActionId { get; set; }
    public DateTime? PaymentAppliedDate { get; set; }
    public decimal? LineBalance { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FolioView { get; set; }
    public string? PrintedYn { get; set; }
    public decimal? StatementNo { get; set; }
    public string? PurgeYn { get; set; }
    public string? AppliedPaymentNo { get; set; }
    public string? FolioType { get; set; }
    public string? InvoiceType { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InvoicesCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFinMovement>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FIN_MOVEMENT");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedPaymentNo)
                .HasColumnName("APPLIED_PAYMENT_NO")
                .IsUnicode(false);

            entity.Property(e => e.ArCredit)
                .HasColumnName("AR_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArDebit)
                .HasColumnName("AR_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingDate)
                .HasColumnName("BILLING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingDateTime)
                .HasColumnName("BILLING_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAmount)
                .HasColumnName("INVOICE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNumber)
                .HasColumnName("INVOICE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.InvoicesCount)
                .HasColumnName("INVOICES_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LineBalance)
                .HasColumnName("LINE_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalance)
                .HasColumnName("OPEN_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentAppliedDate)
                .HasColumnName("PAYMENT_APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Payments)
                .HasColumnName("PAYMENTS")
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
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
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

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}

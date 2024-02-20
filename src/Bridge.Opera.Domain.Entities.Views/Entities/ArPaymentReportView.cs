namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArPaymentReportView
{
    public decimal? PaymentTrx { get; set; }
    public decimal? ArNumber { get; set; }
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public string? GuestName { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? PaidAmount { get; set; }
    public string? AppUser { get; set; }
    public string? Reference { get; set; }
    public string? Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? AppliedAmt { get; set; }
    public DateTime? AppliedDate { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string? InvGuestName { get; set; }
    public decimal? InvoiceAmt { get; set; }
    public string? InvReference { get; set; }
    public string? InvAppUser { get; set; }
    public decimal? BillNo { get; set; }
    public string? AccTypeFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArPaymentReportView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_PAYMENT_REPORT_VIEW");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .IsUnicode(false);

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvAppUser)
                .HasColumnName("INV_APP_USER")
                .IsUnicode(false);

            entity.Property(e => e.InvGuestName)
                .HasColumnName("INV_GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvReference)
                .HasColumnName("INV_REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAmt)
                .HasColumnName("INVOICE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidAmount)
                .HasColumnName("PAID_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PaymentTrx)
                .HasColumnName("PAYMENT_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .IsUnicode(false);
        });
	}
}

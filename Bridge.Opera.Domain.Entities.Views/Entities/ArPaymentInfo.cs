namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArPaymentInfo
{
    public decimal? ConsInvoiceNo { get; set; }
    public decimal? PayInvoiceNo { get; set; }
    public decimal? ConsBillNo { get; set; }
    public decimal? PayBillNo { get; set; }
    public string ConsFolioType { get; set; }
    public string PayFolioType { get; set; }
    public DateTime? ConsBusinessDate { get; set; }
    public DateTime? PayBusinessDate { get; set; }
    public decimal? ConsAmount { get; set; }
    public decimal? PayAmount { get; set; }
    public decimal? ConsArDebit { get; set; }
    public decimal? PayArDebit { get; set; }
    public decimal? ConsArCredit { get; set; }
    public decimal? PayArCredit { get; set; }
    public decimal ConsumptionTrx { get; set; }
    public decimal PaymentTrx { get; set; }
    public decimal AppliedAmt { get; set; }
    public DateTime AppliedDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArPaymentInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_PAYMENT_INFO");

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConsAmount)
                .HasColumnName("CONS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsArCredit)
                .HasColumnName("CONS_AR_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsArDebit)
                .HasColumnName("CONS_AR_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsBillNo)
                .HasColumnName("CONS_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsBusinessDate)
                .HasColumnName("CONS_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConsFolioType)
                .HasColumnName("CONS_FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsInvoiceNo)
                .HasColumnName("CONS_INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionTrx)
                .HasColumnName("CONSUMPTION_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayAmount)
                .HasColumnName("PAY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayArCredit)
                .HasColumnName("PAY_AR_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayArDebit)
                .HasColumnName("PAY_AR_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayBillNo)
                .HasColumnName("PAY_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayBusinessDate)
                .HasColumnName("PAY_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PayFolioType)
                .HasColumnName("PAY_FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PayInvoiceNo)
                .HasColumnName("PAY_INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentTrx)
                .HasColumnName("PAYMENT_TRX")
                .HasColumnType("NUMBER");
        });
	}
}

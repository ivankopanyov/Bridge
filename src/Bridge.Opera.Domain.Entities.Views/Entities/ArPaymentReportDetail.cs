namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArPaymentReportDetail
{
    public decimal? PaymentTrx { get; set; }
    public decimal? AppliedAmt { get; set; }
    public DateTime? AppliedDate { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string? GuestName { get; set; }
    public decimal? InvoiceAmt { get; set; }
    public string? Reference { get; set; }
    public string? Currency { get; set; }
    public string? AppUser { get; set; }
    public decimal? BillNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArPaymentReportDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_PAYMENT_REPORT_DETAIL");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .IsUnicode(false);

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAmt)
                .HasColumnName("INVOICE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentTrx)
                .HasColumnName("PAYMENT_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}

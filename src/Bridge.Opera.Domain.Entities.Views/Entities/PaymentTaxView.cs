namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PaymentTaxView
{
    public string Resort { get; set; }
    public string TaxInvNo { get; set; }
    public string TaxInvNoLink { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? TrxNo { get; set; }
    public string TrxCode { get; set; }
    public string PaymentType { get; set; }
    public decimal? PaymentAmount { get; set; }
    public decimal? VatableAmount { get; set; }
    public decimal? NonVatableAmount { get; set; }
    public decimal? VatPaid { get; set; }
    public decimal? CreditApplied { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? PayeeNameId { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string FinActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentTaxView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PAYMENT_TAX_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditApplied)
                .HasColumnName("CREDIT_APPLIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinActionType)
                .HasColumnName("FIN_ACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonVatableAmount)
                .HasColumnName("NON_VATABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentAmount)
                .HasColumnName("PAYMENT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentType)
                .IsRequired()
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxInvNo)
                .IsRequired()
                .HasColumnName("TAX_INV_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxInvNoLink)
                .HasColumnName("TAX_INV_NO_LINK")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.VatPaid)
                .HasColumnName("VAT_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatableAmount)
                .HasColumnName("VATABLE_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}

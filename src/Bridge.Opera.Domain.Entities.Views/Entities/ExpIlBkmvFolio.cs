namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpIlBkmvFolio
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? PayeeNameId { get; set; }
    public decimal? RevisionNo { get; set; }
    public int? FolioView { get; set; }
    public decimal? InvoiceNo { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal TrxNo { get; set; }
    public string FolioType { get; set; }
    public DateTime? InsertDateFoliotax { get; set; }
    public decimal? InsertUserFoliotax { get; set; }
    public DateTime? UpdateDateFoliotax { get; set; }
    public decimal? UpdateUserFoliotax { get; set; }
    public decimal? CashierId { get; set; }
    public string CurrencyCode { get; set; }
    public string PropertyTaxId { get; set; }
    public string TrxCode { get; set; }
    public decimal? TrxAmountNetIls { get; set; }
    public decimal? TaxAmountIls { get; set; }
    public decimal? PaymentAmountIls { get; set; }
    public decimal? FoltaxTotalNetIls { get; set; }
    public decimal? FoltaxTotalTaxIls { get; set; }
    public string TransactionDescription { get; set; }
    public string ChequeNumber { get; set; }
    public string Reference { get; set; }
    public string Remark { get; set; }
    public string PackageArrangementCode { get; set; }
    public string TaxElements { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public string TaxInclusiveYn { get; set; }
    public decimal? Installments { get; set; }
    public string PaymentMethodType { get; set; }
    public string CreditCardCode { get; set; }
    public string FtSubtype { get; set; }
    public string DeferredTaxesYn { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public string TaxRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpIlBkmvFolio>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_IL_BKMV_FOLIO");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
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

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardCode)
                .HasColumnName("CREDIT_CARD_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeferredTaxesYn)
                .HasColumnName("DEFERRED_TAXES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.FoltaxTotalNetIls)
                .HasColumnName("FOLTAX_TOTAL_NET_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoltaxTotalTaxIls)
                .HasColumnName("FOLTAX_TOTAL_TAX_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InsertDateFoliotax)
                .HasColumnName("INSERT_DATE_FOLIOTAX")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUserFoliotax)
                .HasColumnName("INSERT_USER_FOLIOTAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Installments)
                .HasColumnName("INSTALLMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageArrangementCode)
                .HasColumnName("PACKAGE_ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentAmountIls)
                .HasColumnName("PAYMENT_AMOUNT_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethodType)
                .HasColumnName("PAYMENT_METHOD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyTaxId)
                .HasColumnName("PROPERTY_TAX_ID")
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxAmountIls)
                .HasColumnName("TAX_AMOUNT_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .IsUnicode(false);

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaxRate)
                .HasColumnName("TAX_RATE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDescription)
                .HasColumnName("TRANSACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmountNetIls)
                .HasColumnName("TRX_AMOUNT_NET_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDateFoliotax)
                .HasColumnName("UPDATE_DATE_FOLIOTAX")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUserFoliotax)
                .HasColumnName("UPDATE_USER_FOLIOTAX")
                .HasColumnType("NUMBER");
        });
	}
}

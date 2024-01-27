namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinancialTransactionsExport
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string TrxCode { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal? DepLedCredit { get; set; }
    public string FtSubtype { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public string Product { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? BillNo { get; set; }
    public string RateCode { get; set; }
    public string PostingType { get; set; }
    public decimal TrxNo { get; set; }
    public decimal? FolioView { get; set; }
    public string FixedChargesYn { get; set; }
    public decimal? PkgBillNo { get; set; }
    public decimal? FtBillNo { get; set; }
    public decimal? PostingSourceNameId { get; set; }
    public string ChequeNumber { get; set; }
    public string Covers { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinancialTransactionsExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FINANCIAL_TRANSACTIONS_EXPORT");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FixedChargesYn)
                .HasColumnName("FIXED_CHARGES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtBillNo)
                .HasColumnName("FT_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PkgBillNo)
                .HasColumnName("PKG_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingSourceNameId)
                .HasColumnName("POSTING_SOURCE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingType)
                .HasColumnName("POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
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

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");
        });
	}
}

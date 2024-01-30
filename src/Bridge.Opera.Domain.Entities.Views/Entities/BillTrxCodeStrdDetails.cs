namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BillTrxCodeStrdDetails
{
    public decimal? ExportId { get; set; }
    public decimal? BillNo { get; set; }
    public string? ExportType { get; set; }
    public string? Resort { get; set; }
    public string? FolioType { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? CalcGrossAmount { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? FtSubtype { get; set; }
    public string? Taxcode { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? TaxAmt { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string? MarketCode { get; set; }
    public string? TaxPercent { get; set; }
    public decimal? Covers { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? TrxNoHeader { get; set; }
    public string? GrossSign { get; set; }
    public string? TaxDescription { get; set; }
    public decimal? TaxNo { get; set; }
    public string? Commission { get; set; }
    public string? CcType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BillTrxCodeStrdDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BILL_TRX_CODE_STRD_DETAILS");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalcGrossAmount)
                .HasColumnName("CALC_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossSign)
                .HasColumnName("GROSS_SIGN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxAmt)
                .HasColumnName("TAX_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxDescription)
                .HasColumnName("TAX_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPercent)
                .HasColumnName("TAX_PERCENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Taxcode)
                .HasColumnName("TAXCODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoHeader)
                .HasColumnName("TRX_NO_HEADER")
                .HasColumnType("NUMBER");
        });
	}
}

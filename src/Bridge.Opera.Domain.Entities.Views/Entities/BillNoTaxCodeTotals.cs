namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BillNoTaxCodeTotals
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? BillNo { get; set; }
    public string? FolioType { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Room { get; set; }
    public decimal? Cashpay { get; set; }
    public decimal? Clpay { get; set; }
    public decimal? Deposit { get; set; }
    public decimal? Ccpay { get; set; }
    public decimal? FolioGrossAmount { get; set; }
    public decimal? FolioNetAmount { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? TaxNo { get; set; }
    public decimal? TaxAmt { get; set; }
    public decimal? NetAmt { get; set; }
    public decimal? GrossAmt { get; set; }
    public decimal? TaxRate { get; set; }
    public string? TaxCodeDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BillNoTaxCodeTotals>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BILL_NO_TAX_CODE_TOTALS");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Cashpay)
                .HasColumnName("CASHPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ccpay)
                .HasColumnName("CCPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clpay)
                .HasColumnName("CLPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Deposit)
                .HasColumnName("DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioGrossAmount)
                .HasColumnName("FOLIO_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNetAmount)
                .HasColumnName("FOLIO_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmt)
                .HasColumnName("GROSS_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmt)
                .HasColumnName("NET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxAmt)
                .HasColumnName("TAX_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxCodeDescription)
                .HasColumnName("TAX_CODE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxRate)
                .HasColumnName("TAX_RATE")
                .HasColumnType("NUMBER");
        });
	}
}

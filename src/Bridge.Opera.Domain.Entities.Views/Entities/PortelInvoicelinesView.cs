namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PortelInvoicelinesView
{
    public decimal? TrxNo { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? Intid { get; set; }
    public decimal? Invoiceintid { get; set; }
    public decimal? Invoiceid { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Amount { get; set; }
    public string? Unitcode { get; set; }
    public decimal? Unitprice { get; set; }
    public decimal? Taxamount { get; set; }
    public decimal? Taxrate { get; set; }
    public string? Currencycode { get; set; }
    public decimal? Withholdingtax { get; set; }
    public decimal? Withholdingrate { get; set; }
    public decimal? Taxexemption { get; set; }
    public decimal? Taxexemptionrate { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Discountamount { get; set; }
    public decimal? Discountrate { get; set; }
    public decimal? Foreignamount { get; set; }
    public decimal? Foreigntaxamount { get; set; }
    public decimal? Foreignwithholdingtax { get; set; }
    public decimal? Foreigntaxexemption { get; set; }
    public decimal? Foreigndiscountamount { get; set; }
    public string? TaxElements { get; set; }
    public string? FtSubtype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PortelInvoicelinesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PORTEL_INVOICELINES_VIEW");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currencycode)
                .HasColumnName("CURRENCYCODE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Discountamount)
                .HasColumnName("DISCOUNTAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discountrate)
                .HasColumnName("DISCOUNTRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foreignamount)
                .HasColumnName("FOREIGNAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foreigndiscountamount)
                .HasColumnName("FOREIGNDISCOUNTAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foreigntaxamount)
                .HasColumnName("FOREIGNTAXAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foreigntaxexemption)
                .HasColumnName("FOREIGNTAXEXEMPTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foreignwithholdingtax)
                .HasColumnName("FOREIGNWITHHOLDINGTAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Intid)
                .HasColumnName("INTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invoiceid)
                .HasColumnName("INVOICEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invoiceintid)
                .HasColumnName("INVOICEINTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .IsUnicode(false);

            entity.Property(e => e.Taxamount)
                .HasColumnName("TAXAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Taxexemption)
                .HasColumnName("TAXEXEMPTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Taxexemptionrate)
                .HasColumnName("TAXEXEMPTIONRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Taxrate)
                .HasColumnName("TAXRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Unitcode)
                .HasColumnName("UNITCODE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.Unitprice)
                .HasColumnName("UNITPRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Withholdingrate)
                .HasColumnName("WITHHOLDINGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Withholdingtax)
                .HasColumnName("WITHHOLDINGTAX")
                .HasColumnType("NUMBER");
        });
	}
}

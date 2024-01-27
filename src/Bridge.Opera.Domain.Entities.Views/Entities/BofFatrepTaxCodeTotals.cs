namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofFatrepTaxCodeTotals
{
    public string Resort { get; set; }
    public string BillType { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? TaxNo { get; set; }
    public decimal? TaxPerc { get; set; }
    public string TaxCodeDescription { get; set; }
    public decimal? TotalTaxAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public decimal? TotalGrossAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofFatrepTaxCodeTotals>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_FATREP_TAX_CODE_TOTALS");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillType)
                .HasColumnName("BILL_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeDescription)
                .HasColumnName("TAX_CODE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPerc)
                .HasColumnName("TAX_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrossAmount)
                .HasColumnName("TOTAL_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetAmount)
                .HasColumnName("TOTAL_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxAmount)
                .HasColumnName("TOTAL_TAX_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}

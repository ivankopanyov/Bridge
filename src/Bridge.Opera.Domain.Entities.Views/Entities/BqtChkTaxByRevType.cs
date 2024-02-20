namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkTaxByRevType
{
    public string? TaxPBreak { get; set; }
    public string? RevenueType { get; set; }
    public decimal? TaxOrderBy { get; set; }
    public string? TaxDesc { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? TaxAmountToDisplay { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkTaxByRevType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_TAX_BY_REV_TYPE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxAmountToDisplay)
                .HasColumnName("TAX_AMOUNT_TO_DISPLAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxDesc)
                .HasColumnName("TAX_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxOrderBy)
                .HasColumnName("TAX_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPBreak)
                .HasColumnName("TAX_P_BREAK")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}

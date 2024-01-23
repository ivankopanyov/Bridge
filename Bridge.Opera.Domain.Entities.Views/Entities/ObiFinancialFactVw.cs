namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiFinancialFactVw
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string TrxcodeId { get; set; }
    public string MarketCode { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? CNetAmount { get; set; }
    public decimal? CGrossAmount { get; set; }
    public decimal? BudgetAmount { get; set; }
    public decimal? CBudgetAmount { get; set; }
    public decimal? ForecastAmount { get; set; }
    public decimal? CForecastAmount { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiFinancialFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_FINANCIAL_FACT_VW");

            entity.Property(e => e.BudgetAmount)
                .HasColumnName("BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CBudgetAmount)
                .HasColumnName("C_BUDGET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastAmount)
                .HasColumnName("C_FORECAST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CGrossAmount)
                .HasColumnName("C_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNetAmount)
                .HasColumnName("C_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastAmount)
                .HasColumnName("FORECAST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxcodeId)
                .HasColumnName("TRXCODE_ID")
                .IsUnicode(false);
        });
	}
}

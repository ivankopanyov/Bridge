namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EvForecastRevenue1
{
    public decimal EvForecastid { get; set; }
    public string RevType { get; set; }
    public decimal? RevAmount { get; set; }
    public string FlatYn { get; set; }
    public decimal? BudgetSplit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvForecastRevenue1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EV_FORECAST_REVENUE");

            entity.Property(e => e.BudgetSplit)
                .HasColumnName("BUDGET_SPLIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvForecastid)
                .HasColumnName("EV_FORECASTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatYn)
                .HasColumnName("FLAT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevAmount)
                .HasColumnName("REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

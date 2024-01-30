namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiBudgetMonthlyFact
{
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BudgetNights { get; set; }
    public decimal? BudgetNightsCatY { get; set; }
    public decimal? BudgetNightsCatN { get; set; }
    public decimal? BudgetRev { get; set; }
    public decimal? BudgetRevCatY { get; set; }
    public decimal? BudgetRevCatN { get; set; }
    public decimal? BudgetAvgRate { get; set; }
    public decimal? BudgetAvgRateCatY { get; set; }
    public decimal? BudgetAvgRateCatN { get; set; }
    public decimal? BudgetFbRev { get; set; }
    public decimal? BudgetFbRevCatY { get; set; }
    public decimal? BudgetFbRevCatN { get; set; }
    public decimal? BudgetOtherRev { get; set; }
    public decimal? BudgetOtherRevCatY { get; set; }
    public decimal? BudgetOtherRevCatN { get; set; }
    public decimal? ForecastNights { get; set; }
    public decimal? ForecastNightsCatY { get; set; }
    public decimal? ForecastNightsCatN { get; set; }
    public decimal? ForecastRev { get; set; }
    public decimal? ForecastRevCatY { get; set; }
    public decimal? ForecastRevCatN { get; set; }
    public decimal? ForecastAvgRate { get; set; }
    public decimal? ForecastAvgRateCatY { get; set; }
    public decimal? ForecastAvgRateCatN { get; set; }
    public decimal? ForecastFbRev { get; set; }
    public decimal? ForecastFbRevCatY { get; set; }
    public decimal? ForecastFbRevCatN { get; set; }
    public decimal? ForecastOtherRev { get; set; }
    public decimal? ForecastOtherRevCatY { get; set; }
    public decimal? ForecastOtherRevCatN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiBudgetMonthlyFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_BUDGET_MONTHLY_FACT");

            entity.Property(e => e.BudgetAvgRate)
                .HasColumnName("BUDGET_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAvgRateCatN)
                .HasColumnName("BUDGET_AVG_RATE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAvgRateCatY)
                .HasColumnName("BUDGET_AVG_RATE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetFbRev)
                .HasColumnName("BUDGET_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetFbRevCatN)
                .HasColumnName("BUDGET_FB_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetFbRevCatY)
                .HasColumnName("BUDGET_FB_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetNights)
                .HasColumnName("BUDGET_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetNightsCatN)
                .HasColumnName("BUDGET_NIGHTS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetNightsCatY)
                .HasColumnName("BUDGET_NIGHTS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetOtherRev)
                .HasColumnName("BUDGET_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetOtherRevCatN)
                .HasColumnName("BUDGET_OTHER_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetOtherRevCatY)
                .HasColumnName("BUDGET_OTHER_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRev)
                .HasColumnName("BUDGET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevCatN)
                .HasColumnName("BUDGET_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevCatY)
                .HasColumnName("BUDGET_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ForecastAvgRate)
                .HasColumnName("FORECAST_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastAvgRateCatN)
                .HasColumnName("FORECAST_AVG_RATE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastAvgRateCatY)
                .HasColumnName("FORECAST_AVG_RATE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastFbRev)
                .HasColumnName("FORECAST_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastFbRevCatN)
                .HasColumnName("FORECAST_FB_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastFbRevCatY)
                .HasColumnName("FORECAST_FB_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastNights)
                .HasColumnName("FORECAST_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastNightsCatN)
                .HasColumnName("FORECAST_NIGHTS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastNightsCatY)
                .HasColumnName("FORECAST_NIGHTS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastOtherRev)
                .HasColumnName("FORECAST_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastOtherRevCatN)
                .HasColumnName("FORECAST_OTHER_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastOtherRevCatY)
                .HasColumnName("FORECAST_OTHER_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRev)
                .HasColumnName("FORECAST_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevCatN)
                .HasColumnName("FORECAST_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevCatY)
                .HasColumnName("FORECAST_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}

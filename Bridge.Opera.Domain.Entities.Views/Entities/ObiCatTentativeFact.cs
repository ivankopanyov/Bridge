namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCatTentativeFact
{
    public string Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public string RevType { get; set; }
    public string RevGroup { get; set; }
    public decimal? BookId { get; set; }
    public decimal EventId { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ForecastRevenueCatY { get; set; }
    public decimal? ForecastRevenueCatN { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? ExpectedRevenueCatY { get; set; }
    public decimal? ExpectedRevenueCatN { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? GuaranteedRevenueCatY { get; set; }
    public decimal? GuaranteedRevenueCatN { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? ActualRevenueCatY { get; set; }
    public decimal? ActualRevenueCatN { get; set; }
    public decimal? BilledRevenue { get; set; }
    public decimal? BilledRevenueCatY { get; set; }
    public decimal? BilledRevenueCatN { get; set; }
    public decimal? OtbRevenue { get; set; }
    public decimal? OtbRevenueCatY { get; set; }
    public decimal? OtbRevenueCatN { get; set; }
    public decimal? ExpectedCost { get; set; }
    public decimal? ExpectedCostCatY { get; set; }
    public decimal? ExpectedCostCatN { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? GuaranteedCostCatY { get; set; }
    public decimal? GuaranteedCostCatN { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? ActualCostCatY { get; set; }
    public decimal? ActualCostCatN { get; set; }
    public decimal? ExpectedMargin { get; set; }
    public decimal? ExpectedMarginCatY { get; set; }
    public decimal? ExpectedMarginCatN { get; set; }
    public decimal? GuaranteedMargin { get; set; }
    public decimal? GuaranteedMarginCatY { get; set; }
    public decimal? GuaranteedMarginCatN { get; set; }
    public decimal? ActualMargin { get; set; }
    public decimal? ActualMarginCatY { get; set; }
    public decimal? ActualMarginCatN { get; set; }
    public decimal? CatCovers { get; set; }
    public decimal? CatCoversCatY { get; set; }
    public decimal? CatCoversCatN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCatTentativeFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CAT_TENTATIVE_FACT");

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCostCatN)
                .HasColumnName("ACTUAL_COST_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCostCatY)
                .HasColumnName("ACTUAL_COST_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMargin)
                .HasColumnName("ACTUAL_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMarginCatN)
                .HasColumnName("ACTUAL_MARGIN_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMarginCatY)
                .HasColumnName("ACTUAL_MARGIN_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueCatN)
                .HasColumnName("ACTUAL_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueCatY)
                .HasColumnName("ACTUAL_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenue)
                .HasColumnName("BILLED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueCatN)
                .HasColumnName("BILLED_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueCatY)
                .HasColumnName("BILLED_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCovers)
                .HasColumnName("CAT_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCoversCatN)
                .HasColumnName("CAT_COVERS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCoversCatY)
                .HasColumnName("CAT_COVERS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCostCatN)
                .HasColumnName("EXPECTED_COST_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCostCatY)
                .HasColumnName("EXPECTED_COST_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMargin)
                .HasColumnName("EXPECTED_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMarginCatN)
                .HasColumnName("EXPECTED_MARGIN_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMarginCatY)
                .HasColumnName("EXPECTED_MARGIN_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueCatN)
                .HasColumnName("EXPECTED_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueCatY)
                .HasColumnName("EXPECTED_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueCatN)
                .HasColumnName("FORECAST_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueCatY)
                .HasColumnName("FORECAST_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCostCatN)
                .HasColumnName("GUARANTEED_COST_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCostCatY)
                .HasColumnName("GUARANTEED_COST_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMargin)
                .HasColumnName("GUARANTEED_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMarginCatN)
                .HasColumnName("GUARANTEED_MARGIN_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMarginCatY)
                .HasColumnName("GUARANTEED_MARGIN_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenueCatN)
                .HasColumnName("GUARANTEED_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenueCatY)
                .HasColumnName("GUARANTEED_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenue)
                .HasColumnName("OTB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenueCatN)
                .HasColumnName("OTB_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenueCatY)
                .HasColumnName("OTB_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}

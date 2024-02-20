namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScCateringRevenueFact
{
    public decimal? EventId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Room { get; set; }
    public string? EvType { get; set; }
    public string? EvStatus { get; set; }
    public string? RevType { get; set; }
    public string? RevGroup { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? BilledRevenue { get; set; }
    public string? CoverableYn { get; set; }
    public string? CustomYn { get; set; }
    public string? FlatYn { get; set; }
    public string? ForecastEditedYn { get; set; }
    public string? IgnoreForecastYn { get; set; }
    public string? PkgRevenueYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? CatCurrency { get; set; }
    public string? PropertyCurrency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? OtbRevenue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? InsertUserName { get; set; }
    public string? UpdateUserName { get; set; }
    public decimal? ForecastRevenueInactive { get; set; }
    public decimal? ExpectedRevenueInactive { get; set; }
    public decimal? GuaranteedRevenueInactive { get; set; }
    public decimal? ExpectedCost { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? ExpectedMargin { get; set; }
    public decimal? GuaranteedMargin { get; set; }
    public decimal? ActualMargin { get; set; }
    public decimal? RegAttendees { get; set; }
    public decimal? AttendeesSummary { get; set; }
    public decimal? RegAttendeesSummary { get; set; }
    public decimal? ActualCostCatOnlyY { get; set; }
    public decimal? ActualCostCatOnlyN { get; set; }
    public decimal? ActualMarginCatOnlyY { get; set; }
    public decimal? ActualMarginCatOnlyN { get; set; }
    public decimal? ActualRevenueCatOnlyY { get; set; }
    public decimal? ActualRevenueCatOnlyN { get; set; }
    public decimal? BilledRevenueCatOnlyY { get; set; }
    public decimal? BilledRevenueCatOnlyN { get; set; }
    public decimal? ExchangeRateCatOnlyY { get; set; }
    public decimal? ExchangeRateCatOnlyN { get; set; }
    public decimal? AttendeesCatOnlyY { get; set; }
    public decimal? AttendeesCatOnlyN { get; set; }
    public decimal? AttendeesSummaryCatOnlyY { get; set; }
    public decimal? AttendeesSummaryCatOnlyN { get; set; }
    public decimal? ExpectedCostCatOnlyY { get; set; }
    public decimal? ExpectedCostCatOnlyN { get; set; }
    public decimal? ExpectedMarginCatOnlyY { get; set; }
    public decimal? ExpectedMarginCatOnlyN { get; set; }
    public decimal? ExpectedRevenueCatOnlyY { get; set; }
    public decimal? ExpectedRevenueCatOnlyN { get; set; }
    public decimal? ExpRevInactiveCatOnlyY { get; set; }
    public decimal? ExpRevInactiveCatOnlyN { get; set; }
    public decimal? ForecastRevenueCatOnlyY { get; set; }
    public decimal? ForecastRevenueCatOnlyN { get; set; }
    public decimal? ForRevInactiveCatOnlyY { get; set; }
    public decimal? ForRevInactiveCatOnlyN { get; set; }
    public decimal? GuaranteedCostCatOnlyY { get; set; }
    public decimal? GuaranteedCostCatOnlyN { get; set; }
    public decimal? GuaranteedMarginCatOnlyY { get; set; }
    public decimal? GuaranteedMarginCatOnlyN { get; set; }
    public decimal? GuaranteedRevenueCatOnlyY { get; set; }
    public decimal? GuaranteedRevenueCatOnlyN { get; set; }
    public decimal? GuaRevInactiveCatOnlyY { get; set; }
    public decimal? GuaRevInactiveCatOnlyN { get; set; }
    public decimal? OtbRevenueCatOnlyY { get; set; }
    public decimal? OtbRevenueCatOnlyN { get; set; }
    public decimal? RegAttendeesCatOnlyY { get; set; }
    public decimal? RegAttendeesCatOnlyN { get; set; }
    public decimal? RegAttsSummCatOnlyY { get; set; }
    public decimal? RegAttsSummCatOnlyN { get; set; }
    public decimal? Guaranteed { get; set; }
    public decimal? GuaranteedCatOnlyY { get; set; }
    public decimal? GuaranteedCatOnlyN { get; set; }
    public decimal? GuaranteedSummary { get; set; }
    public decimal? GuaranteedSummaryCatOnlyY { get; set; }
    public decimal? GuaranteedSummaryCatOnlyN { get; set; }
    public decimal? ActualAtt { get; set; }
    public decimal? ActualAttCatOnlyY { get; set; }
    public decimal? ActualAttCatOnlyN { get; set; }
    public decimal? ActualAttSummary { get; set; }
    public decimal? ActualAttSummaryCatOnlyY { get; set; }
    public decimal? ActualAttSummaryCatOnlyN { get; set; }
    public decimal? SetAtt { get; set; }
    public decimal? SetAttCatOnlyY { get; set; }
    public decimal? SetAttCatOnlyN { get; set; }
    public decimal? SetAttSummary { get; set; }
    public decimal? SetAttSummaryCatOnlyY { get; set; }
    public decimal? SetAttSummaryCatOnlyN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScCateringRevenueFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_CATERING_REVENUE_FACT");

            entity.Property(e => e.ActualAtt)
                .HasColumnName("ACTUAL_ATT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttCatOnlyN)
                .HasColumnName("ACTUAL_ATT_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttCatOnlyY)
                .HasColumnName("ACTUAL_ATT_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttSummary)
                .HasColumnName("ACTUAL_ATT_SUMMARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttSummaryCatOnlyN)
                .HasColumnName("ACTUAL_ATT_SUMMARY_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttSummaryCatOnlyY)
                .HasColumnName("ACTUAL_ATT_SUMMARY_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCostCatOnlyN)
                .HasColumnName("ACTUAL_COST_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCostCatOnlyY)
                .HasColumnName("ACTUAL_COST_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMargin)
                .HasColumnName("ACTUAL_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMarginCatOnlyN)
                .HasColumnName("ACTUAL_MARGIN_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualMarginCatOnlyY)
                .HasColumnName("ACTUAL_MARGIN_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueCatOnlyN)
                .HasColumnName("ACTUAL_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueCatOnlyY)
                .HasColumnName("ACTUAL_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesCatOnlyN)
                .HasColumnName("ATTENDEES_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesCatOnlyY)
                .HasColumnName("ATTENDEES_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesSummary)
                .HasColumnName("ATTENDEES_SUMMARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesSummaryCatOnlyN)
                .HasColumnName("ATTENDEES_SUMMARY_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesSummaryCatOnlyY)
                .HasColumnName("ATTENDEES_SUMMARY_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenue)
                .HasColumnName("BILLED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueCatOnlyN)
                .HasColumnName("BILLED_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueCatOnlyY)
                .HasColumnName("BILLED_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCurrency)
                .HasColumnName("CAT_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.CoverableYn)
                .HasColumnName("COVERABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CustomYn)
                .IsRequired()
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvStatus)
                .HasColumnName("EV_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .HasColumnName("EV_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRateCatOnlyN)
                .HasColumnName("EXCHANGE_RATE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRateCatOnlyY)
                .HasColumnName("EXCHANGE_RATE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpRevInactiveCatOnlyN)
                .HasColumnName("EXP_REV_INACTIVE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpRevInactiveCatOnlyY)
                .HasColumnName("EXP_REV_INACTIVE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCostCatOnlyN)
                .HasColumnName("EXPECTED_COST_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCostCatOnlyY)
                .HasColumnName("EXPECTED_COST_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMargin)
                .HasColumnName("EXPECTED_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMarginCatOnlyN)
                .HasColumnName("EXPECTED_MARGIN_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedMarginCatOnlyY)
                .HasColumnName("EXPECTED_MARGIN_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueCatOnlyN)
                .HasColumnName("EXPECTED_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueCatOnlyY)
                .HasColumnName("EXPECTED_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueInactive)
                .HasColumnName("EXPECTED_REVENUE_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatYn)
                .HasColumnName("FLAT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForRevInactiveCatOnlyN)
                .HasColumnName("FOR_REV_INACTIVE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForRevInactiveCatOnlyY)
                .HasColumnName("FOR_REV_INACTIVE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastEditedYn)
                .HasColumnName("FORECAST_EDITED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueCatOnlyN)
                .HasColumnName("FORECAST_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueCatOnlyY)
                .HasColumnName("FORECAST_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueInactive)
                .HasColumnName("FORECAST_REVENUE_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaRevInactiveCatOnlyN)
                .HasColumnName("GUA_REV_INACTIVE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaRevInactiveCatOnlyY)
                .HasColumnName("GUA_REV_INACTIVE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCatOnlyN)
                .HasColumnName("GUARANTEED_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCatOnlyY)
                .HasColumnName("GUARANTEED_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCostCatOnlyN)
                .HasColumnName("GUARANTEED_COST_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCostCatOnlyY)
                .HasColumnName("GUARANTEED_COST_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMargin)
                .HasColumnName("GUARANTEED_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMarginCatOnlyN)
                .HasColumnName("GUARANTEED_MARGIN_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedMarginCatOnlyY)
                .HasColumnName("GUARANTEED_MARGIN_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenueCatOnlyN)
                .HasColumnName("GUARANTEED_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenueCatOnlyY)
                .HasColumnName("GUARANTEED_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenueInactive)
                .HasColumnName("GUARANTEED_REVENUE_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedSummary)
                .HasColumnName("GUARANTEED_SUMMARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedSummaryCatOnlyN)
                .HasColumnName("GUARANTEED_SUMMARY_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedSummaryCatOnlyY)
                .HasColumnName("GUARANTEED_SUMMARY_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IgnoreForecastYn)
                .HasColumnName("IGNORE_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenue)
                .HasColumnName("OTB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenueCatOnlyN)
                .HasColumnName("OTB_REVENUE_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevenueCatOnlyY)
                .HasColumnName("OTB_REVENUE_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRevenueYn)
                .IsRequired()
                .HasColumnName("PKG_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrency)
                .HasColumnName("PROPERTY_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.RegAttendees)
                .HasColumnName("REG_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegAttendeesCatOnlyN)
                .HasColumnName("REG_ATTENDEES_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegAttendeesCatOnlyY)
                .HasColumnName("REG_ATTENDEES_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegAttendeesSummary)
                .HasColumnName("REG_ATTENDEES_SUMMARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegAttsSummCatOnlyN)
                .HasColumnName("REG_ATTS_SUMM_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegAttsSummCatOnlyY)
                .HasColumnName("REG_ATTS_SUMM_CAT_ONLY_Y")
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

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.SetAtt)
                .HasColumnName("SET_ATT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetAttCatOnlyN)
                .HasColumnName("SET_ATT_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetAttCatOnlyY)
                .HasColumnName("SET_ATT_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetAttSummary)
                .HasColumnName("SET_ATT_SUMMARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetAttSummaryCatOnlyN)
                .HasColumnName("SET_ATT_SUMMARY_CAT_ONLY_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetAttSummaryCatOnlyY)
                .HasColumnName("SET_ATT_SUMMARY_CAT_ONLY_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .IsUnicode(false);
        });
	}
}

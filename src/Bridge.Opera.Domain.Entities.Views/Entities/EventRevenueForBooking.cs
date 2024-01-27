namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventRevenueForBooking
{
    public string BlockResort { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public string RevType { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? BilledRevenue { get; set; }
    public decimal? BilledCost { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? SummCost { get; set; }
    public decimal? SummRevenue { get; set; }
    public decimal? SummMargin { get; set; }
    public decimal? SummMarginPerc { get; set; }
    public decimal? DetRevenue1 { get; set; }
    public decimal? DetCost1 { get; set; }
    public decimal? DetMargin1 { get; set; }
    public decimal? DetMargin1Perc { get; set; }
    public decimal? DetRevenue2 { get; set; }
    public decimal? DetCost2 { get; set; }
    public decimal? DetMargin2 { get; set; }
    public decimal? DetMargin2Perc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventRevenueForBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_REVENUE_FOR_BOOKING");

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledCost)
                .HasColumnName("BILLED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenue)
                .HasColumnName("BILLED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockResort)
                .IsRequired()
                .HasColumnName("BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetCost1)
                .HasColumnName("DET_COST1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetCost2)
                .HasColumnName("DET_COST2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetMargin1)
                .HasColumnName("DET_MARGIN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetMargin1Perc)
                .HasColumnName("DET_MARGIN1_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetMargin2)
                .HasColumnName("DET_MARGIN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetMargin2Perc)
                .HasColumnName("DET_MARGIN2_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetRevenue1)
                .HasColumnName("DET_REVENUE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetRevenue2)
                .HasColumnName("DET_REVENUE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SummCost)
                .HasColumnName("SUMM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummMargin)
                .HasColumnName("SUMM_MARGIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummMarginPerc)
                .HasColumnName("SUMM_MARGIN_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummRevenue)
                .HasColumnName("SUMM_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}

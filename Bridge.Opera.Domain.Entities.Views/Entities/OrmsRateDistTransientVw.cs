namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsRateDistTransientVw
{
    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public DateTime TruncArrivalDate { get; set; }
    public byte Los { get; set; }
    public decimal PricesliceId { get; set; }
    public decimal BookingClassId { get; set; }
    public bool MilestoneId { get; set; }
    public decimal? YResvActual { get; set; }
    public decimal? YResvAdjustedActual { get; set; }
    public decimal? YResvHistory { get; set; }
    public decimal? YResvForecast { get; set; }
    public decimal? YResvCounter { get; set; }
    public decimal? NyResvActual { get; set; }
    public decimal? NyResvAdjustedActual { get; set; }
    public decimal? NyResvHistory { get; set; }
    public decimal? NyResvForecast { get; set; }
    public decimal? NyResvCounter { get; set; }
    public decimal? YCnclActual { get; set; }
    public decimal? YCnclAdjustedActual { get; set; }
    public decimal? YCnclHistory { get; set; }
    public decimal? YCnclForecast { get; set; }
    public decimal? YCnclCounter { get; set; }
    public decimal? NyCnclActual { get; set; }
    public decimal? NyCnclAdjustedActual { get; set; }
    public decimal? NyCnclHistory { get; set; }
    public decimal? NyCnclForecast { get; set; }
    public decimal? NyCnclCounter { get; set; }
    public decimal? ResvActual { get; set; }
    public decimal? ResvAdjustedActual { get; set; }
    public decimal? ResvHistory { get; set; }
    public decimal? ResvForecast { get; set; }
    public decimal? ResvCounter { get; set; }
    public decimal? CnclActual { get; set; }
    public decimal? CnclAdjustedActual { get; set; }
    public decimal? CnclHistory { get; set; }
    public decimal? CnclForecast { get; set; }
    public decimal? CnclCounter { get; set; }
    public decimal? YFinalActual { get; set; }
    public decimal? YFinalAdjustedActual { get; set; }
    public decimal? YFinalHistory { get; set; }
    public decimal? YFinalForecast { get; set; }
    public decimal? YFinalCounter { get; set; }
    public decimal? NyFinalActual { get; set; }
    public decimal? NyFinalAdjustedActual { get; set; }
    public decimal? NyFinalHistory { get; set; }
    public decimal? NyFinalForecast { get; set; }
    public decimal? NyFinalCounter { get; set; }
    public decimal? FinalActual { get; set; }
    public decimal? FinalAdjustedActual { get; set; }
    public decimal? FinalHistory { get; set; }
    public decimal? FinalForecast { get; set; }
    public decimal? FinalCounter { get; set; }
    public decimal? YResvRemaingfore { get; set; }
    public decimal? NyResvRemaingfore { get; set; }
    public decimal? ResvRemaingfore { get; set; }
    public decimal? YCnclRemaingfore { get; set; }
    public decimal? NyCnclRemaingfore { get; set; }
    public decimal? CnclRemaingfore { get; set; }
    public decimal? YFinalRemaingfore { get; set; }
    public decimal? NyFinalRemaingfore { get; set; }
    public decimal? FinalRemaingfore { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? DemandTransfered { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRateDistTransientVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_RATE_DIST_TRANSIENT_VW");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclActual)
                .HasColumnName("CNCL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclAdjustedActual)
                .HasColumnName("CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclCounter)
                .HasColumnName("CNCL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecast)
                .HasColumnName("CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclHistory)
                .HasColumnName("CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclRemaingfore)
                .HasColumnName("CNCL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DemandTransfered)
                .HasColumnName("DEMAND_TRANSFERED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalActual)
                .HasColumnName("FINAL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalAdjustedActual)
                .HasColumnName("FINAL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalCounter)
                .HasColumnName("FINAL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalForecast)
                .HasColumnName("FINAL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalHistory)
                .HasColumnName("FINAL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalRemaingfore)
                .HasColumnName("FINAL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los).HasColumnName("LOS");

            entity.Property(e => e.MilestoneId).HasColumnName("MILESTONE_ID");

            entity.Property(e => e.NyCnclActual)
                .HasColumnName("NY_CNCL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclAdjustedActual)
                .HasColumnName("NY_CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclCounter)
                .HasColumnName("NY_CNCL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclForecast)
                .HasColumnName("NY_CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclHistory)
                .HasColumnName("NY_CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclRemaingfore)
                .HasColumnName("NY_CNCL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalActual)
                .HasColumnName("NY_FINAL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalAdjustedActual)
                .HasColumnName("NY_FINAL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalCounter)
                .HasColumnName("NY_FINAL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalForecast)
                .HasColumnName("NY_FINAL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalHistory)
                .HasColumnName("NY_FINAL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyFinalRemaingfore)
                .HasColumnName("NY_FINAL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvActual)
                .HasColumnName("NY_RESV_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvAdjustedActual)
                .HasColumnName("NY_RESV_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvCounter)
                .HasColumnName("NY_RESV_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvForecast)
                .HasColumnName("NY_RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvHistory)
                .HasColumnName("NY_RESV_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvRemaingfore)
                .HasColumnName("NY_RESV_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvActual)
                .HasColumnName("RESV_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvAdjustedActual)
                .HasColumnName("RESV_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvCounter)
                .HasColumnName("RESV_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecast)
                .HasColumnName("RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvHistory)
                .HasColumnName("RESV_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvRemaingfore)
                .HasColumnName("RESV_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclActual)
                .HasColumnName("Y_CNCL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclAdjustedActual)
                .HasColumnName("Y_CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclCounter)
                .HasColumnName("Y_CNCL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclForecast)
                .HasColumnName("Y_CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclHistory)
                .HasColumnName("Y_CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclRemaingfore)
                .HasColumnName("Y_CNCL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalActual)
                .HasColumnName("Y_FINAL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalAdjustedActual)
                .HasColumnName("Y_FINAL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalCounter)
                .HasColumnName("Y_FINAL_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalForecast)
                .HasColumnName("Y_FINAL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalHistory)
                .HasColumnName("Y_FINAL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YFinalRemaingfore)
                .HasColumnName("Y_FINAL_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvActual)
                .HasColumnName("Y_RESV_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvAdjustedActual)
                .HasColumnName("Y_RESV_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvCounter)
                .HasColumnName("Y_RESV_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvForecast)
                .HasColumnName("Y_RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvHistory)
                .HasColumnName("Y_RESV_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvRemaingfore)
                .HasColumnName("Y_RESV_REMAINGFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsResvcnclDistVw
{
    public string? Resort { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public decimal? BookingClassId { get; set; }
    public byte LeadDay { get; set; }
    public string? Dowseason { get; set; }
    public decimal? ResvActual { get; set; }
    public decimal? ResvAdjustedActual { get; set; }
    public decimal? ResvHistory { get; set; }
    public decimal? ResvForecast { get; set; }
    public decimal? ResvForecastModel1 { get; set; }
    public decimal? ResvForecastModel2 { get; set; }
    public decimal? ResvForecastModel3 { get; set; }
    public decimal? ResvForecastModel4 { get; set; }
    public decimal? ResvMinForecast { get; set; }
    public decimal? ResvMaxForecast { get; set; }
    public decimal? ResvEventImpact { get; set; }
    public decimal? CnclActual { get; set; }
    public decimal? CnclAdjustedActual { get; set; }
    public decimal? CnclHistory { get; set; }
    public decimal? CnclForecast { get; set; }
    public decimal? CnclForecastModel1 { get; set; }
    public decimal? CnclForecastModel2 { get; set; }
    public decimal? CnclForecastModel3 { get; set; }
    public decimal? CnclForecastModel4 { get; set; }
    public decimal? CnclMinForecast { get; set; }
    public decimal? CnclMaxForecast { get; set; }
    public decimal? CnclEventImpact { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResvcnclDistVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_RESVCNCL_DIST_VW");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclActual)
                .HasColumnName("CNCL_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclAdjustedActual)
                .HasColumnName("CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclEventImpact)
                .HasColumnName("CNCL_EVENT_IMPACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecast)
                .HasColumnName("CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecastModel1)
                .HasColumnName("CNCL_FORECAST_MODEL1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecastModel2)
                .HasColumnName("CNCL_FORECAST_MODEL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecastModel3)
                .HasColumnName("CNCL_FORECAST_MODEL3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclForecastModel4)
                .HasColumnName("CNCL_FORECAST_MODEL4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclHistory)
                .HasColumnName("CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclMaxForecast)
                .HasColumnName("CNCL_MAX_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclMinForecast)
                .HasColumnName("CNCL_MIN_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LeadDay).HasColumnName("LEAD_DAY");

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

            entity.Property(e => e.ResvEventImpact)
                .HasColumnName("RESV_EVENT_IMPACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecast)
                .HasColumnName("RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecastModel1)
                .HasColumnName("RESV_FORECAST_MODEL1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecastModel2)
                .HasColumnName("RESV_FORECAST_MODEL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecastModel3)
                .HasColumnName("RESV_FORECAST_MODEL3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvForecastModel4)
                .HasColumnName("RESV_FORECAST_MODEL4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvHistory)
                .HasColumnName("RESV_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvMaxForecast)
                .HasColumnName("RESV_MAX_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvMinForecast)
                .HasColumnName("RESV_MIN_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");
        });
	}
}

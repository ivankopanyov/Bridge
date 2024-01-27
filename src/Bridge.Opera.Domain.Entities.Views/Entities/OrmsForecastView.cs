namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsForecastView
{
    public string Resort { get; set; }
    public DateTime TruncArrivalDate { get; set; }
    public decimal BookingClassId { get; set; }
    public byte LeadDay { get; set; }
    public string Dowseason { get; set; }
    public decimal? EventImpact { get; set; }
    public decimal? Actual { get; set; }
    public decimal? AdjustedActual { get; set; }
    public decimal? History { get; set; }
    public decimal? Forecast { get; set; }
    public decimal? CurrentForecast { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsForecastView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_FORECAST_VIEW");

            entity.Property(e => e.Actual)
                .HasColumnName("ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustedActual)
                .HasColumnName("ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentForecast)
                .HasColumnName("CURRENT_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EventImpact)
                .HasColumnName("EVENT_IMPACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Forecast)
                .HasColumnName("FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.History)
                .HasColumnName("HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDay).HasColumnName("LEAD_DAY");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");
        });
	}
}

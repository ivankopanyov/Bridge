namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempOldBusProfileData
{
    public decimal? ProfileId { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? AverageRate { get; set; }
    public string? Currency { get; set; }
    public decimal? DestinationId { get; set; }
    public string? DestinationResort { get; set; }
    public decimal? DurationNo { get; set; }
    public string? DurationUnit { get; set; }
    public DateTime? EndPeriod { get; set; }
    public string? Features { get; set; }
    public string? ForecastYn { get; set; }
    public string? Frequency { get; set; }
    public string? GeoPreferences { get; set; }
    public string? HotelType { get; set; }
    public decimal? LeadTimeNo { get; set; }
    public string? LeadTimeUnit { get; set; }
    public string? MarketingCity { get; set; }
    public string? MarketingRegion { get; set; }
    public string? MarketCode { get; set; }
    public string? Months { get; set; }
    public decimal? PeakRooms { get; set; }
    public string? ProfName { get; set; }
    public string? ProfType { get; set; }
    public string? RateCode { get; set; }
    public DateTime? StartPeriod { get; set; }
    public string? Tracecode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempOldBusProfileData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_OLD_BUS_PROFILE_DATA");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AverageRate)
                .HasColumnName("AVERAGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DestinationResort)
                .HasColumnName("DESTINATION_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DurationNo)
                .HasColumnName("DURATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationUnit)
                .HasColumnName("DURATION_UNIT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndPeriod)
                .HasColumnName("END_PERIOD")
                .HasColumnType("DATE");

            entity.Property(e => e.Features)
                .HasColumnName("FEATURES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ForecastYn)
                .HasColumnName("FORECAST_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GeoPreferences)
                .HasColumnName("GEO_PREFERENCES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HotelType)
                .HasColumnName("HOTEL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadTimeNo)
                .HasColumnName("LEAD_TIME_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadTimeUnit)
                .HasColumnName("LEAD_TIME_UNIT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketingCity)
                .HasColumnName("MARKETING_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketingRegion)
                .HasColumnName("MARKETING_REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Months)
                .HasColumnName("MONTHS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PeakRooms)
                .HasColumnName("PEAK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfName)
                .HasColumnName("PROF_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProfType)
                .HasColumnName("PROF_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartPeriod)
                .HasColumnName("START_PERIOD")
                .HasColumnType("DATE");

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

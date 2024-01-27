namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsResvcnclDist
{
    public string Resort { get; set; }
    public string ResvCnclFlag { get; set; }
    public DateTime TruncArrivalDate { get; set; }
    public decimal BookingClassId { get; set; }
    public byte LeadDay { get; set; }
    public string Dowseason { get; set; }
    public decimal? Actual { get; set; }
    public decimal? AdjustedActual { get; set; }
    public decimal? History { get; set; }
    public decimal? Forecast { get; set; }
    public decimal? OverrideForecast { get; set; }
    public decimal? ForecastModel1 { get; set; }
    public decimal? ForecastModel2 { get; set; }
    public decimal? ForecastModel3 { get; set; }
    public decimal? ForecastModel4 { get; set; }
    public decimal? MinForecast { get; set; }
    public decimal? MaxForecast { get; set; }
    public decimal? EventImpact { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsBookingClass BookingClass { get; set; }
    public virtual OrmsResvData OrmsResvData { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResvcnclDist>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvCnclFlag, e.TruncArrivalDate, e.BookingClassId, e.LeadDay })
                .HasName("ORMS_RESVCNCL_DIST_PK");

            entity.ToTable("ORMS_RESVCNCL_DIST");

            entity.HasIndex(e => e.BookingClassId)
                .HasName("ORMS_RESVCNCL_DIST_IND1");

            entity.HasIndex(e => new { e.Resort, e.TruncArrivalDate, e.LeadDay })
                .HasName("ORMS_RESVCNCL_DIST_ARRDT");

            entity.HasIndex(e => new { e.Resort, e.ResvCnclFlag, e.Dowseason, e.LeadDay, e.BookingClassId })
                .HasName("ORMS_RESVCNCL_DIST_DOW");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvCnclFlag)
                .HasColumnName("RESV_CNCL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'R'");

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDay).HasColumnName("LEAD_DAY");

            entity.Property(e => e.Actual)
                .HasColumnName("ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustedActual)
                .HasColumnName("ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventImpact)
                .HasColumnName("EVENT_IMPACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Forecast)
                .HasColumnName("FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastModel1)
                .HasColumnName("FORECAST_MODEL1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastModel2)
                .HasColumnName("FORECAST_MODEL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastModel3)
                .HasColumnName("FORECAST_MODEL3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastModel4)
                .HasColumnName("FORECAST_MODEL4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.History)
                .HasColumnName("HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxForecast)
                .HasColumnName("MAX_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinForecast)
                .HasColumnName("MIN_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideForecast)
                .HasColumnName("OVERRIDE_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsBookingClass)))
				entity.Ignore(e => e.BookingClass);
			else
	            entity.HasOne(d => d.BookingClass)
	                .WithMany(p => p.OrmsResvcnclDist)
	                .HasForeignKey(d => d.BookingClassId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RESVCNCL_DIST_ORMS_B_FK1");

			if (!types.Contains(typeof(OrmsResvData)))
				entity.Ignore(e => e.OrmsResvData);
			else
	            entity.HasOne(d => d.OrmsResvData)
	                .WithMany(p => p.OrmsResvcnclDist)
	                .HasForeignKey(d => new { d.Resort, d.TruncArrivalDate })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RESVCNCL_DIST_FK1");
        });
	}
}

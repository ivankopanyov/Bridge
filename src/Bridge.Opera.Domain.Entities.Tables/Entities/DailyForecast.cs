namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DailyForecast
{
    public DailyForecast()
    {
        DailyForecastRevtypes = new HashSet<DailyForecastRevtypes>();
    }

    public decimal? ForecastId { get; set; }
    public string? Resort { get; set; }
    public DateTime? ForecastDate { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgRate { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<DailyForecastRevtypes> DailyForecastRevtypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DailyForecast>(entity =>
        {
            entity.HasKey(e => e.ForecastId)
                .HasName("DF_PK");

            entity.ToTable("DAILY$FORECAST");

            entity.HasIndex(e => new { e.Resort, e.ForecastDate })
                .HasName("DF_RESORT_FK_I");

            entity.Property(e => e.ForecastId)
                .HasColumnName("FORECAST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastDate)
                .HasColumnName("FORECAST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomAvgRate)
                .HasColumnName("ROOM_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.DailyForecast)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("DF_RESORT_FK");
        
			if (!types.Contains(typeof(DailyForecastRevtypes)))
				entity.Ignore(e => e.DailyForecastRevtypes);
		});
	}
}

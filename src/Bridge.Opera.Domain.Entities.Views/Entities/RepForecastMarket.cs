namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepForecastMarket
{
    public DateTime? ConsideredDate { get; set; }
    public string DayDesc { get; set; }
    public string DayDescription { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDesc { get; set; }
    public decimal? IndRmsMkt { get; set; }
    public decimal? OpenBlkMkt { get; set; }
    public decimal? GrpRmsMarket { get; set; }
    public decimal? InitialBlkMkt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepForecastMarket>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_FORECAST_MARKET");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayDesc)
                .HasColumnName("DAY_DESC")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.DayDescription)
                .HasColumnName("DAY_DESCRIPTION")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.GrpRmsMarket)
                .HasColumnName("GRP_RMS_MARKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRmsMkt)
                .HasColumnName("IND_RMS_MKT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InitialBlkMkt)
                .HasColumnName("INITIAL_BLK_MKT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OpenBlkMkt)
                .HasColumnName("OPEN_BLK_MKT")
                .HasColumnType("NUMBER");
        });
	}
}

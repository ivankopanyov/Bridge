namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EvForecastRevenue
{
    public decimal EvForecastid { get; set; }
    public string RevType { get; set; }
    public decimal? RevAmount { get; set; }
    public string FlatYn { get; set; }
    public decimal? BudgetSplit { get; set; }

    public virtual EvForecast EvForecast { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvForecastRevenue>(entity =>
        {
            entity.HasKey(e => new { e.EvForecastid, e.RevType })
                .HasName("EFR_PK");

            entity.ToTable("EV$FORECAST_REVENUE");

            entity.HasIndex(e => e.RevType)
                .HasName("EFR_REVTYPE_IDX");

            entity.Property(e => e.EvForecastid)
                .HasColumnName("EV_FORECASTID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BudgetSplit)
                .HasColumnName("BUDGET_SPLIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatYn)
                .HasColumnName("FLAT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevAmount)
                .HasColumnName("REV_AMOUNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(EvForecast)))
				entity.Ignore(e => e.EvForecast);
			else
	            entity.HasOne(d => d.EvForecast)
	                .WithMany(p => p.EvForecastRevenue)
	                .HasForeignKey(d => d.EvForecastid)
	                .HasConstraintName("EFR_EVFCAST_FK");
        });
	}
}

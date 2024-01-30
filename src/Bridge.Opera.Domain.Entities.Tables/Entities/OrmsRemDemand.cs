namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsRemDemand
{
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public DateTime? HurdleDate { get; set; }
    public decimal? Los { get; set; }
    public decimal? HurdleStepPricesliceId { get; set; }
    public decimal? HurdleStepAmount { get; set; }
    public decimal? RemForecast { get; set; }
    public decimal? OptimalDemand { get; set; }
    public decimal? HurdleCeiling { get; set; }
    public decimal? Price { get; set; }
    public decimal? PricesliceId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRemDemand>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.HurdleDate, e.Los, e.HurdleStepPricesliceId })
                .HasName("ORMS_REM_DEMAND_PK");

            entity.ToTable("ORMS_REM_DEMAND");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleStepPricesliceId)
                .HasColumnName("HURDLE_STEP_PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleCeiling)
                .HasColumnName("HURDLE_CEILING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleStepAmount)
                .HasColumnName("HURDLE_STEP_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptimalDemand)
                .HasColumnName("OPTIMAL_DEMAND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RemForecast)
                .HasColumnName("REM_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCatBudByMtypeCFact
{
    public string Resort { get; set; }
    public DateTime StartDate { get; set; }
    public string MealType { get; set; }
    public string RevType { get; set; }
    public string RevGroup { get; set; }
    public decimal? BudgetRevenue { get; set; }
    public decimal? BudgetRevenueCatY { get; set; }
    public decimal? BudgetRevenueCatN { get; set; }
    public decimal? BudgetCovers { get; set; }
    public decimal? BudgetCoversCatY { get; set; }
    public decimal? BudgetCoversCatN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCatBudByMtypeCFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CAT_BUD_BY_MTYPE_C_FACT");

            entity.Property(e => e.BudgetCovers)
                .HasColumnName("BUDGET_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCoversCatN)
                .HasColumnName("BUDGET_COVERS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCoversCatY)
                .HasColumnName("BUDGET_COVERS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevenue)
                .HasColumnName("BUDGET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevenueCatN)
                .HasColumnName("BUDGET_REVENUE_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevenueCatY)
                .HasColumnName("BUDGET_REVENUE_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType)
                .HasColumnName("MEAL_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}

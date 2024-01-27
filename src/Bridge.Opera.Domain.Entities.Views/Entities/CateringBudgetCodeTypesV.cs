namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CateringBudgetCodeTypesV
{
    public string TypeCode { get; set; }
    public string Descr { get; set; }
    public string BudgetType { get; set; }
    public string ImportCode { get; set; }
    public string CateringOnlyYn { get; set; }
    public string ActiveYn { get; set; }
    public string IsEventType { get; set; }
    public string IsMarketGroupType { get; set; }
    public string IsMealType { get; set; }
    public string IsRevenueType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringBudgetCodeTypesV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CATERING_BUDGET_CODE_TYPES_V");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.BudgetType)
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringOnlyYn)
                .HasColumnName("CATERING_ONLY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Descr)
                .HasColumnName("DESCR")
                .HasMaxLength(52)
                .IsUnicode(false);

            entity.Property(e => e.ImportCode)
                .HasColumnName("IMPORT_CODE")
                .HasColumnType("CHAR(4)");

            entity.Property(e => e.IsEventType)
                .HasColumnName("IS_EVENT_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.IsMarketGroupType)
                .HasColumnName("IS_MARKET_GROUP_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.IsMealType)
                .HasColumnName("IS_MEAL_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.IsRevenueType)
                .HasColumnName("IS_REVENUE_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

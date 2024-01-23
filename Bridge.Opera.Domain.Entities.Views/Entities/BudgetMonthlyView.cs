namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BudgetMonthlyView
{
    public string Resort { get; set; }
    public decimal AccountingYear { get; set; }
    public string AccountingType { get; set; }
    public string BudgetType { get; set; }
    public string BudgetCodeType { get; set; }
    public string BudgetCodeValue { get; set; }
    public string BudgetMonth { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? StartMonth { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BudgetMonthlyView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUDGET_MONTHLY_VIEW");

            entity.Property(e => e.AccountingType)
                .IsRequired()
                .HasColumnName("ACCOUNTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountingYear)
                .HasColumnName("ACCOUNTING_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCodeType)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCodeValue)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_VALUE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BudgetMonth)
                .HasColumnName("BUDGET_MONTH")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.BudgetType)
                .IsRequired()
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartMonth)
                .HasColumnName("START_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}

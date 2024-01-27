namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BudgetCodeLov
{
    public string BudgetCode { get; set; }
    public string BudgetCodeType { get; set; }
    public string ParentBudgetCodeType { get; set; }
    public string Resort { get; set; }
    public string Description { get; set; }
    public string OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BudgetCodeLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUDGET_CODE_LOV");

            entity.Property(e => e.BudgetCode)
                .IsRequired()
                .HasColumnName("BUDGET_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCodeType)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .IsUnicode(false);

            entity.Property(e => e.ParentBudgetCodeType)
                .HasColumnName("PARENT_BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CustomBudgetCodeLov
{
    public string? BudgetCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CustomBudgetCodeLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CUSTOM_BUDGET_CODE_LOV");

            entity.Property(e => e.BudgetCode)
                .HasColumnName("BUDGET_CODE")
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}

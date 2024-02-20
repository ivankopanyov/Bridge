namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CateringBudgetTypesV
{
    public string? BudgetTypeCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringBudgetTypesV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CATERING_BUDGET_TYPES_V");

            entity.Property(e => e.BudgetTypeCode)
                .HasColumnName("BUDGET_TYPE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UpsellRuleFormulaVw
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellRuleFormulaVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("UPSELL_RULE_FORMULA_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(900)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasColumnType("CHAR(3)");
        });
	}
}

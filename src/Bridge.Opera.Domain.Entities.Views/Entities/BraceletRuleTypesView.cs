namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BraceletRuleTypesView
{
    public string? RuleTypeCode { get; set; }
    public string? RuleTypeDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BraceletRuleTypesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BRACELET_RULE_TYPES_VIEW");

            entity.Property(e => e.RuleTypeCode)
                .HasColumnName("RULE_TYPE_CODE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.RuleTypeDescription)
                .HasColumnName("RULE_TYPE_DESCRIPTION")
                .IsUnicode(false);
        });
	}
}

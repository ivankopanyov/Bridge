namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisMembershipLevelRules
{
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public decimal? MembershipRuleNo { get; set; }
    public string? RuleType { get; set; }
    public string? RuleBasedOn { get; set; }
    public decimal? UnitsRequired { get; set; }
    public decimal? Months { get; set; }
    public decimal? MonthsEffective { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisMembershipLevelRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_MEMBERSHIP_LEVEL_RULES");

            entity.Property(e => e.MembershipLevel)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipRuleNo)
                .HasColumnName("MEMBERSHIP_RULE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Months)
                .HasColumnName("MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthsEffective)
                .HasColumnName("MONTHS_EFFECTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RuleBasedOn)
                .IsRequired()
                .HasColumnName("RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UnitsRequired)
                .HasColumnName("UNITS_REQUIRED")
                .HasColumnType("NUMBER");
        });
	}
}

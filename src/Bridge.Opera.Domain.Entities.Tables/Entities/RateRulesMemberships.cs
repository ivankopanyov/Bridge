namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateRulesMemberships
{
    public string? Resort { get; set; }
    public string? RuleCode { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }

    public virtual RateRules R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateRulesMemberships>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_RULES_MEMBERSHIPS");

            entity.HasIndex(e => new { e.Resort, e.RuleCode })
                .HasName("RATE_RULES_MEMBERSHIPS_FKI");

            entity.HasIndex(e => new { e.RuleCode, e.MembershipType, e.Resort, e.MembershipLevel })
                .HasName("RATE_RULES_MEMBERSHIPS_UK")
                .IsUnique();

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .IsRequired()
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(RateRules)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RuleCode })
	                .HasConstraintName("RATE_RULES_MEMBERSHIPS_FK");
        });
	}
}

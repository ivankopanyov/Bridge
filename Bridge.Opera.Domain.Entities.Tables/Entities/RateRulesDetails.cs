namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateRulesDetails
{
    public string Resort { get; set; }
    public string RuleCode { get; set; }
    public string RateCode { get; set; }

    public virtual RateRules R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateRulesDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RuleCode, e.RateCode })
                .HasName("RATE_RULES_DETAILS_PK");

            entity.ToTable("RATE_RULES_DETAILS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(RateRules)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateRulesDetails)
	                .HasForeignKey(d => new { d.Resort, d.RuleCode })
	                .HasConstraintName("RATE_RULES_DETAILS_FK");
        });
	}
}

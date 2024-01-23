namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternetCinRulesSpecials
{
    public decimal RuleId { get; set; }
    public decimal PreferenceSeqId { get; set; }

    public virtual InternetCinRules Rule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternetCinRulesSpecials>(entity =>
        {
            entity.HasKey(e => new { e.RuleId, e.PreferenceSeqId })
                .HasName("INTERNET_CIN_RULES_SPECIALS_PK");

            entity.ToTable("INTERNET_CIN_RULES_SPECIALS");

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferenceSeqId)
                .HasColumnName("PREFERENCE_SEQ_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(InternetCinRules)))
				entity.Ignore(e => e.Rule);
			else
	            entity.HasOne(d => d.Rule)
	                .WithMany(p => p.InternetCinRulesSpecials)
	                .HasForeignKey(d => d.RuleId)
	                .HasConstraintName("INTERNET_CIN_RULES_SPECIALS_FK");
        });
	}
}

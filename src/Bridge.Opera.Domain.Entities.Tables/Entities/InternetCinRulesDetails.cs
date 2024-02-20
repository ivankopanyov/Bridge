namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternetCinRulesDetails
{
    public decimal? RuleId { get; set; }
    public string? RuleType { get; set; }
    public string? Code { get; set; }

    public virtual InternetCinRules Rule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternetCinRulesDetails>(entity =>
        {
            entity.HasKey(e => new { e.RuleId, e.Code, e.RuleType })
                .HasName("INTERNET_CIN_GUARANTEE_PK");

            entity.ToTable("INTERNET_CIN_RULES_DETAILS");

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(InternetCinRules)))
				entity.Ignore(e => e.Rule);
			else
	            entity.HasOne(d => d.Rule)
	                .WithMany(p => p.InternetCinRulesDetails)
	                .HasForeignKey(d => d.RuleId)
	                .HasConstraintName("INTERNET_CIN_RULES_RES_FK");
        });
	}
}

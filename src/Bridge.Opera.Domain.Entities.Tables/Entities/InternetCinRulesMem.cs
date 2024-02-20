namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternetCinRulesMem
{
    public decimal? RuleId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }

    public virtual InternetCinRules Rule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternetCinRulesMem>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INTERNET_CIN_RULES_MEM");

            entity.HasIndex(e => new { e.RuleId, e.MembershipType, e.MembershipLevel })
                .HasName("INTERNET_CIN_RULES_MEM_UK")
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

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(InternetCinRules)))
				entity.Ignore(e => e.Rule);
			else
	            entity.HasOne(d => d.Rule)
	                .WithMany()
	                .HasForeignKey(d => d.RuleId)
	                .HasConstraintName("INTERNET_CIN_RULES_FK");
        });
	}
}

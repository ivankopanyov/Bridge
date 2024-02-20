namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternetCinRules
{
    public InternetCinRules()
    {
        InternetCinRulesDetails = new HashSet<InternetCinRulesDetails>();
        InternetCinRulesSpecials = new HashSet<InternetCinRulesSpecials>();
    }

    public decimal? RuleId { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }
    public string? RuleType { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? AllowRestrict { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual InternetCinRulesTime InternetCinRulesTime { get; set; }
    public virtual ICollection<InternetCinRulesDetails> InternetCinRulesDetails { get; set; }
    public virtual ICollection<InternetCinRulesSpecials> InternetCinRulesSpecials { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternetCinRules>(entity =>
        {
            entity.HasKey(e => e.RuleId)
                .HasName("INTERNET_CIN_RULES_PK");

            entity.ToTable("INTERNET_CIN_RULES");

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllowRestrict)
                .IsRequired()
                .HasColumnName("ALLOW_RESTRICT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            if (!types.Contains(typeof(InternetCinRulesTime)))
                entity.Ignore(e => e.InternetCinRulesTime);

            if (!types.Contains(typeof(InternetCinRulesDetails)))
				entity.Ignore(e => e.InternetCinRulesDetails);

			if (!types.Contains(typeof(InternetCinRulesSpecials)))
				entity.Ignore(e => e.InternetCinRulesSpecials);
		});
	}
}

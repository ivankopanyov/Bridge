namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateRules
{
    public RateRules()
    {
        RateRulesDetails = new HashSet<RateRulesDetails>();
    }

    public string? Resort { get; set; }
    public string? RuleCode { get; set; }
    public string? Description { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ActiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? GuaranteedYn { get; set; }
    public DateTime? LatestTob { get; set; }
    public decimal? DaysToDoa { get; set; }

    public virtual ICollection<RateRulesDetails> RateRulesDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateRules>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RuleCode })
                .HasName("RATE_RULES_PK");

            entity.ToTable("RATE_RULES");

            entity.HasIndex(e => new { e.Resort, e.BeginDate, e.EndDate })
                .HasName("RATE_RULES_INDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DaysToDoa)
                .HasColumnName("DAYS_TO_DOA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteedYn)
                .HasColumnName("GUARANTEED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LatestTob)
                .HasColumnName("LATEST_TOB")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RateRulesDetails)))
				entity.Ignore(e => e.RateRulesDetails);
		});
	}
}

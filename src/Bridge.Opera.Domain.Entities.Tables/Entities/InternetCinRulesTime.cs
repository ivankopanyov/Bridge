namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InternetCinRulesTime
{
    public decimal RuleId { get; set; }
    public string AbsoluteYn { get; set; }
    public decimal? AbsoluteEarliestCinDays { get; set; }
    public DateTime? AbsoluteEarliestCinTime { get; set; }
    public decimal? AbsoluteLatestCinDays { get; set; }
    public DateTime? AbsoluteLatestCinTime { get; set; }
    public decimal? RelativeEarliestCinTime { get; set; }
    public decimal? RelativeLatestCinTime { get; set; }

    public virtual InternetCinRules Rule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InternetCinRulesTime>(entity =>
        {
            entity.HasKey(e => e.RuleId)
                .HasName("INTERNET_CIN_RULES_TIME_PK");

            entity.ToTable("INTERNET_CIN_RULES_TIME");

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsoluteEarliestCinDays)
                .HasColumnName("ABSOLUTE_EARLIEST_CIN_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsoluteEarliestCinTime)
                .HasColumnName("ABSOLUTE_EARLIEST_CIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.AbsoluteLatestCinDays)
                .HasColumnName("ABSOLUTE_LATEST_CIN_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsoluteLatestCinTime)
                .HasColumnName("ABSOLUTE_LATEST_CIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.AbsoluteYn)
                .IsRequired()
                .HasColumnName("ABSOLUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelativeEarliestCinTime)
                .HasColumnName("RELATIVE_EARLIEST_CIN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelativeLatestCinTime)
                .HasColumnName("RELATIVE_LATEST_CIN_TIME")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(InternetCinRules)))
				entity.Ignore(e => e.Rule);
			else
	            entity.HasOne(d => d.Rule)
	                .WithOne(p => p.InternetCinRulesTime)
	                .HasForeignKey<InternetCinRulesTime>(d => d.RuleId)
	                .HasConstraintName("INTERNET_CIN_RULES_TIMES_FK");
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaEcertGenRules
{
    public decimal? RuleId { get; set; }
    public string? CertCode { get; set; }
    public string? ChainCode { get; set; }
    public string? RuleBasedOn { get; set; }
    public decimal? UnitsRequired { get; set; }
    public decimal? MinNoOfChains { get; set; }
    public decimal? EvaluationMonths { get; set; }
    public string? EvaluationPeriod { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? LastProcessedDate { get; set; }
    public decimal? LastProcessedId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? UniqueRbo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaEcertGenRules>(entity =>
        {
            entity.HasKey(e => e.RuleId)
                .HasName("OEGR_PK");

            entity.ToTable("OPERA_ECERT_GEN_RULES");

            entity.HasIndex(e => new { e.CertCode, e.ChainCode })
                .HasName("OPERA_ECERT_GEN_IDX1");

            entity.Property(e => e.RuleId)
                .HasColumnName("RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertCode)
                .IsRequired()
                .HasColumnName("CERT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvaluationMonths)
                .HasColumnName("EVALUATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvaluationPeriod)
                .HasColumnName("EVALUATION_PERIOD")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastProcessedDate)
                .HasColumnName("LAST_PROCESSED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastProcessedId)
                .HasColumnName("LAST_PROCESSED_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinNoOfChains)
                .HasColumnName("MIN_NO_OF_CHAINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RuleBasedOn)
                .IsRequired()
                .HasColumnName("RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UniqueRbo)
                .HasColumnName("UNIQUE_RBO")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UnitsRequired)
                .HasColumnName("UNITS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

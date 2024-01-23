namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipLevelRules
{
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public decimal MembershipRuleNo { get; set; }
    public string RuleType { get; set; }
    public string RuleBasedOn { get; set; }
    public decimal UnitsRequired { get; set; }
    public decimal? UnitsThreshold { get; set; }
    public decimal? Months { get; set; }
    public decimal? MonthsEffective { get; set; }
    public string RecordType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ChainCode { get; set; }
    public decimal? NoOfChains { get; set; }
    public string OrgMembershipLevel { get; set; }

    public virtual MembershipLevels MembershipLevels { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipLevelRules>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel, e.MembershipRuleNo })
                .HasName("MEMBERSHIP_LEVEL_RULES_PK");

            entity.ToTable("MEMBERSHIP_LEVEL_RULES");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.OrgMembershipLevel })
                .HasName("MEM_LEVEL_RULE_IDX01");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipRuleNo)
                .HasColumnName("MEMBERSHIP_RULE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Months)
                .HasColumnName("MONTHS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MonthsEffective)
                .HasColumnName("MONTHS_EFFECTIVE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfChains)
                .HasColumnName("NO_OF_CHAINS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrgMembershipLevel)
                .HasColumnName("ORG_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleBasedOn)
                .IsRequired()
                .HasColumnName("RULE_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitsRequired)
                .HasColumnName("UNITS_REQUIRED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitsThreshold)
                .HasColumnName("UNITS_THRESHOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(MembershipLevels)))
				entity.Ignore(e => e.MembershipLevels);
			else
	            entity.HasOne(d => d.MembershipLevels)
	                .WithMany(p => p.MembershipLevelRules)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType, d.MembershipLevel })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ML_MEMBERSHIP_LEVELS_FK");
        });
	}
}

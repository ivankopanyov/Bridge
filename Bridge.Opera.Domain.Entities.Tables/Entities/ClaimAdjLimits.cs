namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ClaimAdjLimits
{
    public string ClaimAdjLimitCode { get; set; }
    public decimal? AwPtsLowerLimit { get; set; }
    public decimal? AwPtsUpperLimit { get; set; }
    public decimal? TierPtsStayLowerLimit { get; set; }
    public decimal? TierPtsStayUpperLimit { get; set; }
    public decimal? TierPtsNightsLowerLimit { get; set; }
    public decimal? TierPtsNightsUpperLimit { get; set; }
    public decimal? TierPtsRevLowerLimit { get; set; }
    public decimal? TierPtsRevUpperLimit { get; set; }
    public string BillingGroup { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ClaimAdjLimits>(entity =>
        {
            entity.HasKey(e => e.ClaimAdjLimitCode)
                .HasName("CLAIM_ADJ_LIMITS_PK");

            entity.ToTable("CLAIM_ADJ_LIMITS");

            entity.Property(e => e.ClaimAdjLimitCode)
                .HasColumnName("CLAIM_ADJ_LIMIT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwPtsLowerLimit)
                .HasColumnName("AW_PTS_LOWER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPtsUpperLimit)
                .HasColumnName("AW_PTS_UPPER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsNightsLowerLimit)
                .HasColumnName("TIER_PTS_NIGHTS_LOWER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsNightsUpperLimit)
                .HasColumnName("TIER_PTS_NIGHTS_UPPER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsRevLowerLimit)
                .HasColumnName("TIER_PTS_REV_LOWER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsRevUpperLimit)
                .HasColumnName("TIER_PTS_REV_UPPER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsStayLowerLimit)
                .HasColumnName("TIER_PTS_STAY_LOWER_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPtsStayUpperLimit)
                .HasColumnName("TIER_PTS_STAY_UPPER_LIMIT")
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

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipPointsAccruedVw
{
    public decimal? CostPerPoint { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public string? MembershipType { get; set; }
    public decimal? MembershipPointsSeqno { get; set; }
    public decimal? Points { get; set; }
    public string? TypeOfPoints { get; set; }
    public string? BillingGroup { get; set; }
    public decimal? AwBucketQuantity { get; set; }
    public decimal? TierBucketQuantity { get; set; }
    public decimal? AwPoints { get; set; }
    public decimal? TierPoints { get; set; }
    public string? RuleGroup { get; set; }
    public decimal? DaysFromEnroll { get; set; }
    public string? PointsRatioPercentYn { get; set; }
    public string? PointsRatioRoundingFlg { get; set; }
    public string? RtcYn { get; set; }
    public decimal? CentralQualifiedRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPointsAccruedVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_POINTS_ACCRUED_VW");

            entity.Property(e => e.AwBucketQuantity)
                .HasColumnName("AW_BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPoints)
                .HasColumnName("AW_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralQualifiedRevenue)
                .HasColumnName("CENTRAL_QUALIFIED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostPerPoint)
                .HasColumnName("COST_PER_POINT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DaysFromEnroll)
                .HasColumnName("DAYS_FROM_ENROLL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRatioPercentYn)
                .HasColumnName("POINTS_RATIO_PERCENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsRatioRoundingFlg)
                .HasColumnName("POINTS_RATIO_ROUNDING_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RtcYn)
                .HasColumnName("RTC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RuleGroup)
                .HasColumnName("RULE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TierBucketQuantity)
                .HasColumnName("TIER_BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPoints)
                .HasColumnName("TIER_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeOfPoints)
                .HasColumnName("TYPE_OF_POINTS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

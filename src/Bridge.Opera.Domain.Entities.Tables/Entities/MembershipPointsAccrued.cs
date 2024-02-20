namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipPointsAccrued
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
    public decimal? CentralQualifiedRevenue { get; set; }

    public virtual MembershipTransactions MembershipTrx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPointsAccrued>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxId, e.MembershipType, e.MembershipPointsSeqno })
                .HasName("MEMBERSHIP_POINTS_ACCRUED_PK");

            entity.ToTable("MEMBERSHIP_POINTS_ACCRUED");

            entity.HasIndex(e => e.BillingGroup)
                .HasName("MEMBERSHIP_POINTS_ACCRUED_IND2");

            entity.HasIndex(e => new { e.MembershipType, e.MembershipPointsSeqno })
                .HasName("MEMBERSHIP_POINTS_ACCRUED_IND1");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

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

			if (!types.Contains(typeof(MembershipTransactions)))
				entity.Ignore(e => e.MembershipTrx);
			else
	            entity.HasOne(d => d.MembershipTrx)
	                .WithMany(p => p.MembershipPointsAccrued)
	                .HasForeignKey(d => d.MembershipTrxId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_BONUS_FK");
        });
	}
}

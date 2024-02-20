namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayMemberships
{
    public decimal? StageStayRecordId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipNumber { get; set; }
    public decimal? BasePoints { get; set; }
    public decimal? BaseRevenue { get; set; }
    public decimal? BonusPoints { get; set; }
    public decimal? BonusRevenue { get; set; }
    public string? ValidYn { get; set; }
    public string? PointsEligibleYn { get; set; }

    public virtual StageStayRecords StageStayRecord { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayMemberships>(entity =>
        {
            entity.HasKey(e => new { e.StageStayRecordId, e.MembershipType })
                .HasName("STAGE_STAY_MEMBERSHIPS_PK");

            entity.ToTable("STAGE_STAY_MEMBERSHIPS");

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BasePoints)
                .HasColumnName("BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BaseRevenue)
                .HasColumnName("BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusPoints)
                .HasColumnName("BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BonusRevenue)
                .HasColumnName("BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PointsEligibleYn)
                .HasColumnName("POINTS_ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageStayRecords)))
				entity.Ignore(e => e.StageStayRecord);
			else
	            entity.HasOne(d => d.StageStayRecord)
	                .WithMany(p => p.StageStayMemberships)
	                .HasForeignKey(d => d.StageStayRecordId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_STAY_MEMBERSHIPS_FK");
        });
	}
}

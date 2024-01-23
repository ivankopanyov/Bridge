namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StayRecordsMemberships
{
    public decimal StayRecordId { get; set; }
    public string MembershipType { get; set; }
    public string RecordType { get; set; }
    public string MembershipNumber { get; set; }
    public string MembershipLevel { get; set; }
    public decimal? NameId { get; set; }
    public string NameRole { get; set; }
    public decimal? TotalPoints { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public decimal? PointsCost { get; set; }
    public DateTime? PointsComputedDate { get; set; }
    public string PromotionCode1 { get; set; }
    public string PromotionCode2 { get; set; }
    public string PromotionCode3 { get; set; }
    public string PopulationMethod { get; set; }
    public string ValidYn { get; set; }
    public string PointsEligibleYn { get; set; }
    public string ProcessingMessage { get; set; }
    public string ErrorMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StayRecordsMemberships>(entity =>
        {
            entity.HasKey(e => new { e.StayRecordId, e.MembershipType, e.RecordType })
                .HasName("STAY_MEMBERSHIPS_PK");

            entity.ToTable("STAY_RECORDS_MEMBERSHIPS");

            entity.HasIndex(e => e.NameId)
                .HasName("STAY_RECORDS_MEM_IDX1");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.MembershipBaseNights)
                .HasColumnName("MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseRevenue)
                .HasColumnName("MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseStay)
                .HasColumnName("MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusNights)
                .HasColumnName("MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusRevenue)
                .HasColumnName("MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusStay)
                .HasColumnName("MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameRole)
                .HasColumnName("NAME_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsComputedDate)
                .HasColumnName("POINTS_COMPUTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsCost)
                .HasColumnName("POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsEligibleYn)
                .HasColumnName("POINTS_ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PopulationMethod)
                .HasColumnName("POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode1)
                .HasColumnName("PROMOTION_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode2)
                .HasColumnName("PROMOTION_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode3)
                .HasColumnName("PROMOTION_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

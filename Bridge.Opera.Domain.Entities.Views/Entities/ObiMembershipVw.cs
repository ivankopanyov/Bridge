namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiMembershipVw
{
    public decimal NameId { get; set; }
    public decimal MembershipId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string MembershipCardNo { get; set; }
    public string MemTypeDesc { get; set; }
    public string MemClassDesc { get; set; }
    public string LoyaltyProgramYn { get; set; }
    public string FrequentFlyerYn { get; set; }
    public string NameOnCard { get; set; }
    public DateTime? JoinedDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string EnrollmentCode { get; set; }
    public string MembershipStatus { get; set; }
    public string MembershipClass { get; set; }
    public string CalculationMethod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? ExpirationMonth { get; set; }
    public string AwardGenerationMethod { get; set; }
    public string EnrollmentSource { get; set; }
    public string EnrolledAt { get; set; }
    public string MembershipLevelId { get; set; }
    public string PrimaryMembershipYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiMembershipVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_MEMBERSHIP_VW");

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMethod)
                .HasColumnName("CALCULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EnrolledAt)
                .HasColumnName("ENROLLED_AT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentSource)
                .HasColumnName("ENROLLMENT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpirationMonth)
                .HasColumnName("EXPIRATION_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FrequentFlyerYn)
                .HasColumnName("FREQUENT_FLYER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LoyaltyProgramYn)
                .HasColumnName("LOYALTY_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemClassDesc)
                .IsRequired()
                .HasColumnName("MEM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MemTypeDesc)
                .HasColumnName("MEM_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipClass)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelId)
                .HasColumnName("MEMBERSHIP_LEVEL_ID")
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameOnCard)
                .IsRequired()
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryMembershipYn)
                .HasColumnName("PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

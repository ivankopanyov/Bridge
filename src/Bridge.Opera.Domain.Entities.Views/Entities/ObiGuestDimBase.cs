namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiGuestDimBase
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RegionCode { get; set; }
    public string? RegionDesc { get; set; }
    public string? CountryId { get; set; }
    public string? CountryCode { get; set; }
    public string? CountryDesc { get; set; }
    public string? StateId { get; set; }
    public string? State { get; set; }
    public string? StateDesc { get; set; }
    public string? FfMembershipType { get; set; }
    public string? FfMembershipDesc { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipDesc { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? NameOnCard { get; set; }
    public DateTime? JoinedDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string? EnrollmentCode { get; set; }
    public string? MembershipStatus { get; set; }
    public string? MembershipClass { get; set; }
    public string? CalculationMethod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? ExpirationMonth { get; set; }
    public string? AwardGenerationMethod { get; set; }
    public string? EnrollmentSource { get; set; }
    public string? EnrolledAt { get; set; }
    public string? FfMembershipLevel { get; set; }
    public string? FfMembershipLevelDesc { get; set; }
    public string? FfMembershipLevelId { get; set; }
    public string? MembershipLevel { get; set; }
    public string? MembershipLevelDesc { get; set; }
    public string? MembershipLevelId { get; set; }
    public decimal? NameId { get; set; }
    public string? GuestName { get; set; }
    public string? NameIdChar { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? VipStatus { get; set; }
    public string? VipName { get; set; }
    public string? Nationality { get; set; }
    public string? NationalityDesc { get; set; }
    public string? ResortId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiGuestDimBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_GUEST_DIM_BASE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .IsUnicode(false);

            entity.Property(e => e.CalculationMethod)
                .HasColumnName("CALCULATION_METHOD")
                .IsUnicode(false);

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CountryId)
                .HasColumnName("COUNTRY_ID")
                .IsUnicode(false);

            entity.Property(e => e.EnrolledAt)
                .HasColumnName("ENROLLED_AT")
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentSource)
                .HasColumnName("ENROLLMENT_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpirationMonth)
                .HasColumnName("EXPIRATION_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FfMembershipDesc)
                .HasColumnName("FF_MEMBERSHIP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipLevel)
                .HasColumnName("FF_MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipLevelDesc)
                .HasColumnName("FF_MEMBERSHIP_LEVEL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipLevelId)
                .HasColumnName("FF_MEMBERSHIP_LEVEL_ID")
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipType)
                .HasColumnName("FF_MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.MembershipClass)
                .HasColumnName("MEMBERSHIP_CLASS")
                .IsUnicode(false);

            entity.Property(e => e.MembershipDesc)
                .HasColumnName("MEMBERSHIP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelDesc)
                .HasColumnName("MEMBERSHIP_LEVEL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelId)
                .HasColumnName("MEMBERSHIP_LEVEL_ID")
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameIdChar)
                .HasColumnName("NAME_ID_CHAR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameOnCard)
                .HasColumnName("NAME_ON_CARD")
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .IsUnicode(false);

            entity.Property(e => e.NationalityDesc)
                .HasColumnName("NATIONALITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.StateId)
                .HasColumnName("STATE_ID")
                .IsUnicode(false);

            entity.Property(e => e.VipName)
                .HasColumnName("VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .IsUnicode(false);
        });
	}
}

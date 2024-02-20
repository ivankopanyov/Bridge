namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileMemberships
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Membershipcategorycode { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public DateTime? JoinedDate { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }
    public string? ResortRegistered { get; set; }
    public string? EnrollmentCode { get; set; }
    public string? NameOnCard { get; set; }
    public string? MembershipStatus { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? PointIndicator { get; set; }
    public string? EnrollmentSource { get; set; }
    public string? EnrolledAt { get; set; }
    public string? DeviceCode { get; set; }
    public DateTime? DeviceDisableDate { get; set; }
    public string? UpdateExistingMembershipYn { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileMemberships>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.MembershipType, e.MembershipCardNo })
                .HasName("STAGE_PROF_MEMBERS_PK");

            entity.ToTable("STAGE_PROFILE_MEMBERSHIPS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeviceCode)
                .HasColumnName("DEVICE_CODE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DeviceDisableDate)
                .HasColumnName("DEVICE_DISABLE_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Membershipcategorycode)
                .HasColumnName("MEMBERSHIPCATEGORYCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameOnCard)
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointIndicator)
                .HasColumnName("POINT_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateExistingMembershipYn)
                .HasColumnName("UPDATE_EXISTING_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.StageProfileMemberships)
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROF_MEMB_FK1");
        });
	}
}

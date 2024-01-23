namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbMemberships
{
    public decimal MembershipId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public string NameOnCard { get; set; }
    public string Comments { get; set; }
    public DateTime? JoinedDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public decimal? CreditLimit { get; set; }
    public string PrimaryAirlinePartner { get; set; }
    public string PointIndicator { get; set; }
    public decimal? CurrentPoints { get; set; }
    public string MemberIndicator { get; set; }
    public string MemberSubtype { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? ProcessExpirationDate { get; set; }
    public string EnrollmentCode { get; set; }
    public string GracePeriodIndicator { get; set; }
    public string MembershipStatus { get; set; }
    public string TrackData { get; set; }
    public string EarningPreference { get; set; }
    public string ChainCode { get; set; }
    public string EnrollmentSource { get; set; }
    public string EnrolledAt { get; set; }
    public string DeviceCode { get; set; }
    public DateTime? DeviceDisableDate { get; set; }
    public decimal? RankValue { get; set; }
    public decimal? PartnerMembershipId { get; set; }
    public DateTime? MbrprefChangedDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbMemberships>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_MEMBERSHIPS");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentPoints)
                .HasColumnName("CURRENT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeviceCode)
                .HasColumnName("DEVICE_CODE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DeviceDisableDate)
                .HasColumnName("DEVICE_DISABLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EarningPreference)
                .HasColumnName("EARNING_PREFERENCE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.GracePeriodIndicator)
                .HasColumnName("GRACE_PERIOD_INDICATOR")
                .HasMaxLength(20)
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

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MbrprefChangedDate)
                .HasColumnName("MBRPREF_CHANGED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemberIndicator)
                .HasColumnName("MEMBER_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberSubtype)
                .HasColumnName("MEMBER_SUBTYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartnerMembershipId)
                .HasColumnName("PARTNER_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointIndicator)
                .HasColumnName("POINT_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryAirlinePartner)
                .HasColumnName("PRIMARY_AIRLINE_PARTNER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessExpirationDate)
                .HasColumnName("PROCESS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrackData)
                .HasColumnName("TRACK_DATA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}

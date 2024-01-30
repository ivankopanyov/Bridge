namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpMembershipsCore
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public DateTime? RowInsertDate { get; set; }
    public DateTime? RowUpdateDate { get; set; }
    public decimal? MembershipId { get; set; }
    public string? MembershipIdKey { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? MembershipClass { get; set; }
    public string? MembershipClassDesc { get; set; }
    public string? MembershipLevelKey { get; set; }
    public string? MembershipLevel { get; set; }
    public string? MembershipLevelDesc { get; set; }
    public string? MembershipStatus { get; set; }
    public string? MembershipStatusDesc { get; set; }
    public string? MembershipTypeKey { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipTypeDesc { get; set; }
    public string? MemberIndicator { get; set; }
    public string? MemberInfoDispSet { get; set; }
    public string? MemberSubtype { get; set; }
    public decimal? MultipleRoomsLimit { get; set; }
    public decimal? NameId { get; set; }
    public string? GuestName { get; set; }
    public string? NameOnCard { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public decimal? Age { get; set; }
    public string? AllowDupCardYn { get; set; }
    public string? AllId { get; set; }
    public string? AutoCardNoBasedOn { get; set; }
    public string? AwardGenerationMethod { get; set; }
    public decimal? BatchDelayPeriod { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? BookerProgramYn { get; set; }
    public string? CalculationMethod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? CardValidYears { get; set; }
    public string? CentralSetupYn { get; set; }
    public string? ChainCode { get; set; }
    public string? ChipAndPinYn { get; set; }
    public string? City { get; set; }
    public string? Comments { get; set; }
    public string? Country { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? CurrentPoints { get; set; }
    public string? DefaultMemStatus { get; set; }
    public string? DeviceCode { get; set; }
    public DateTime? DeviceDisableDate { get; set; }
    public string? EarningPreference { get; set; }
    public string? EmailAddress { get; set; }
    public string? EnrolledAt { get; set; }
    public string? EnrollmentCode { get; set; }
    public string? EnrollmentCodeReqYn { get; set; }
    public string? EnrollmentGroup { get; set; }
    public string? EnrollmentSource { get; set; }
    public string? ExceptionType { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string? ExpirationDateRequired { get; set; }
    public decimal? ExpirationMonth { get; set; }
    public decimal? ExternalProcessDays { get; set; }
    public string? FrequentFlyerYn { get; set; }
    public string? Gender { get; set; }
    public string? GracePeriodIndicator { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? InactiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? JoinedDate { get; set; }
    public string? LangCode { get; set; }
    public string? LevelRequired { get; set; }
    public string? LoyaltyProgramYn { get; set; }
    public DateTime? MbrprefChangedDate { get; set; }
    public string? Nationality { get; set; }
    public string? NumericValidation { get; set; }
    public string? PartnerAccountNo { get; set; }
    public decimal? PartnerMembershipId { get; set; }
    public string? PartnerType { get; set; }
    public string? PhoneNumber { get; set; }
    public string? PointsLabel { get; set; }
    public string? PointIndicator { get; set; }
    public string? PrimaryAirlinePartner { get; set; }
    public string? PrimaryMembershipYn { get; set; }
    public DateTime? ProcessExpirationDate { get; set; }
    public decimal? RankValue { get; set; }
    public string? Region { get; set; }
    public string? Resort { get; set; }
    public string? State { get; set; }
    public string? TrackData { get; set; }
    public string? TscDateFlag { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ValidationByIfc { get; set; }
    public decimal? YearsToExpire { get; set; }
    public string? ZipCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpMembershipsCore>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_MEMBERSHIPS_CORE");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Age)
                .HasColumnName("AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllId)
                .HasColumnName("ALL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AllowDupCardYn)
                .HasColumnName("ALLOW_DUP_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoCardNoBasedOn)
                .HasColumnName("AUTO_CARD_NO_BASED_ON")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchDelayPeriod)
                .HasColumnName("BATCH_DELAY_PERIOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookerProgramYn)
                .HasColumnName("BOOKER_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMethod)
                .HasColumnName("CALCULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CardValidYears)
                .HasColumnName("CARD_VALID_YEARS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralSetupYn)
                .HasColumnName("CENTRAL_SETUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChipAndPinYn)
                .HasColumnName("CHIP_AND_PIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentPoints)
                .HasColumnName("CURRENT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultMemStatus)
                .HasColumnName("DEFAULT_MEM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EnrolledAt)
                .HasColumnName("ENROLLED_AT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCodeReqYn)
                .HasColumnName("ENROLLMENT_CODE_REQ_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentGroup)
                .HasColumnName("ENROLLMENT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentSource)
                .HasColumnName("ENROLLMENT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionType)
                .HasColumnName("EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpirationDateRequired)
                .HasColumnName("EXPIRATION_DATE_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationMonth)
                .HasColumnName("EXPIRATION_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalProcessDays)
                .HasColumnName("EXTERNAL_PROCESS_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FrequentFlyerYn)
                .HasColumnName("FREQUENT_FLYER_YN")
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GracePeriodIndicator)
                .HasColumnName("GRACE_PERIOD_INDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LangCode)
                .HasColumnName("LANG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LevelRequired)
                .HasColumnName("LEVEL_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyProgramYn)
                .HasColumnName("LOYALTY_PROGRAM_YN")
                .IsUnicode(false);

            entity.Property(e => e.MbrprefChangedDate)
                .HasColumnName("MBRPREF_CHANGED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MemberIndicator)
                .HasColumnName("MEMBER_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberInfoDispSet)
                .HasColumnName("MEMBER_INFO_DISP_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MemberSubtype)
                .HasColumnName("MEMBER_SUBTYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipClass)
                .HasColumnName("MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipClassDesc)
                .HasColumnName("MEMBERSHIP_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipIdKey)
                .HasColumnName("MEMBERSHIP_ID_KEY")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelDesc)
                .HasColumnName("MEMBERSHIP_LEVEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelKey)
                .HasColumnName("MEMBERSHIP_LEVEL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatusDesc)
                .HasColumnName("MEMBERSHIP_STATUS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTypeDesc)
                .HasColumnName("MEMBERSHIP_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTypeKey)
                .HasColumnName("MEMBERSHIP_TYPE_KEY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultipleRoomsLimit)
                .HasColumnName("MULTIPLE_ROOMS_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameOnCard)
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumericValidation)
                .HasColumnName("NUMERIC_VALIDATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PartnerAccountNo)
                .HasColumnName("PARTNER_ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.PartnerMembershipId)
                .HasColumnName("PARTNER_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartnerType)
                .HasColumnName("PARTNER_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PointIndicator)
                .HasColumnName("POINT_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsLabel)
                .HasColumnName("POINTS_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryAirlinePartner)
                .HasColumnName("PRIMARY_AIRLINE_PARTNER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryMembershipYn)
                .HasColumnName("PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessExpirationDate)
                .HasColumnName("PROCESS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowInsertDate)
                .HasColumnName("ROW_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.RowUpdateDate)
                .HasColumnName("ROW_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TrackData)
                .HasColumnName("TRACK_DATA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TscDateFlag)
                .HasColumnName("TSC_DATE_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidationByIfc)
                .HasColumnName("VALIDATION_BY_IFC")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YearsToExpire)
                .HasColumnName("YEARS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

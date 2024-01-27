namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SpgGuestLookup
{
    public decimal LookupSeqId { get; set; }
    public string LookupRequestId { get; set; }
    public string MembershipNo { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string Resort { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleInitial { get; set; }
    public string PrefName { get; set; }
    public string BusinessTitle { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public string CommName { get; set; }
    public string EmailAddress { get; set; }
    public string EmailPrefCodes { get; set; }
    public string LanguageCode { get; set; }
    public string SetNumber { get; set; }
    public decimal? SpgMileage { get; set; }
    public decimal? SpgBalance { get; set; }
    public string SpgStatus { get; set; }
    public string SpgStatusDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? CrsNameid { get; set; }
    public decimal? CpiNumber { get; set; }
    public decimal? SuiteNightAwardsBalance { get; set; }
    public string LoyaltySegments { get; set; }
    public string FullName { get; set; }
    public string AltFirstName { get; set; }
    public string AltLastName { get; set; }
    public string AltFullName { get; set; }
    public string AltAddress1 { get; set; }
    public string AltAddress2 { get; set; }
    public string AltCity { get; set; }
    public string AltState { get; set; }
    public string AltZipCode { get; set; }
    public string AltCountry { get; set; }
    public string PhoneType { get; set; }
    public string PhoneNumber { get; set; }
    public string PhoneCountry { get; set; }
    public decimal? YtdStays { get; set; }
    public decimal? YtdNights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgGuestLookup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SPG_GUEST_LOOKUP");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS_1")
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS_2")
                .IsUnicode(false);

            entity.Property(e => e.AltAddress1)
                .HasColumnName("ALT_ADDRESS_1")
                .IsUnicode(false);

            entity.Property(e => e.AltAddress2)
                .HasColumnName("ALT_ADDRESS_2")
                .IsUnicode(false);

            entity.Property(e => e.AltCity)
                .HasColumnName("ALT_CITY")
                .IsUnicode(false);

            entity.Property(e => e.AltCountry)
                .HasColumnName("ALT_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.AltFirstName)
                .HasColumnName("ALT_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AltFullName)
                .HasColumnName("ALT_FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.AltLastName)
                .HasColumnName("ALT_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AltState)
                .HasColumnName("ALT_STATE")
                .IsUnicode(false);

            entity.Property(e => e.AltZipCode)
                .HasColumnName("ALT_ZIP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CommName)
                .HasColumnName("COMM_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CpiNumber)
                .HasColumnName("CPI_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsNameid)
                .HasColumnName("CRS_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.EmailPrefCodes)
                .HasColumnName("EMAIL_PREF_CODES")
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LookupRequestId)
                .IsRequired()
                .HasColumnName("LOOKUP_REQUEST_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LookupSeqId)
                .HasColumnName("LOOKUP_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltySegments)
                .HasColumnName("LOYALTY_SEGMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MiddleInitial)
                .HasColumnName("MIDDLE_INITIAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PhoneCountry)
                .HasColumnName("PHONE_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PrefName)
                .HasColumnName("PREF_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetNumber)
                .HasColumnName("SET_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpgBalance)
                .HasColumnName("SPG_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpgMileage)
                .HasColumnName("SPG_MILEAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpgStatus)
                .HasColumnName("SPG_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpgStatusDesc)
                .HasColumnName("SPG_STATUS_DESC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.SuiteNightAwardsBalance)
                .HasColumnName("SUITE_NIGHT_AWARDS_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdNights)
                .HasColumnName("YTD_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdStays)
                .HasColumnName("YTD_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .IsUnicode(false);
        });
	}
}

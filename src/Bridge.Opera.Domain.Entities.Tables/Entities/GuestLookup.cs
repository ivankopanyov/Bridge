namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestLookup
{
    public GuestLookup()
    {
        GuestLookupPref = new HashSet<GuestLookupPref>();
    }

    public decimal? LookupSeqId { get; set; }
    public string? LookupRequestId { get; set; }
    public string? MembershipNo { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Mpcode { get; set; }
    public string? Resort { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleInitial { get; set; }
    public string? PrefName { get; set; }
    public string? BusinessTitle { get; set; }
    public string? HomeOrBusinessFlag { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? HomePhone { get; set; }
    public string? BusinessPhone { get; set; }
    public string? BusinessExt { get; set; }
    public string? CommName { get; set; }
    public string? EmailAddress { get; set; }
    public string? EmailPrefCode { get; set; }
    public string? LanguageCode { get; set; }
    public string? CurrencyCode { get; set; }
    public string? PassportNumber { get; set; }
    public string? CountryBirth { get; set; }
    public string? CountryCitizen { get; set; }
    public string? CountryPassport { get; set; }
    public string? CcNo { get; set; }
    public string? CcType { get; set; }
    public DateTime? CcExpirationDate { get; set; }
    public string? SetNumber { get; set; }
    public decimal? SpgMileage { get; set; }
    public decimal? SpgBalance { get; set; }
    public string? SpgStatus { get; set; }
    public string? SpgStatusDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? CrsNameid { get; set; }
    public decimal? CpiNumber { get; set; }
    public string? CcExpirationDateStr { get; set; }
    public string? TmpCcn { get; set; }
    public string? TmpEds { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? SuiteNightAwardsBalance { get; set; }
    public string? LoyaltySegments { get; set; }
    public string? AltLastName { get; set; }
    public string? AltFirstName { get; set; }
    public string? AltMiddleInitial { get; set; }
    public string? AltPrefName { get; set; }
    public string? AltLanguageCode { get; set; }
    public decimal? YtdStays { get; set; }
    public decimal? YtdNights { get; set; }

    public virtual ICollection<GuestLookupPref> GuestLookupPref { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLookup>(entity =>
        {
            entity.HasKey(e => e.LookupSeqId)
                .HasName("GUEST_LOOKUP_PK");

            entity.ToTable("GUEST$_LOOKUP");

            entity.HasIndex(e => e.LookupRequestId)
                .HasName("GUEST_LOOKUP_REQUESTID_IDX");

            entity.Property(e => e.LookupSeqId)
                .HasColumnName("LOOKUP_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS_1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS_2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AltFirstName)
                .HasColumnName("ALT_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AltLanguageCode)
                .HasColumnName("ALT_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AltLastName)
                .HasColumnName("ALT_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AltMiddleInitial)
                .HasColumnName("ALT_MIDDLE_INITIAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AltPrefName)
                .HasColumnName("ALT_PREF_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BusinessExt)
                .HasColumnName("BUSINESS_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessPhone)
                .HasColumnName("BUSINESS_PHONE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcExpirationDate)
                .HasColumnName("CC_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcExpirationDateStr)
                .HasColumnName("CC_EXPIRATION_DATE_STR")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcNo)
                .HasColumnName("CC_NO")
                .HasMaxLength(65)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CommName)
                .HasColumnName("COMM_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryBirth)
                .HasColumnName("COUNTRY_BIRTH")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryCitizen)
                .HasColumnName("COUNTRY_CITIZEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryPassport)
                .HasColumnName("COUNTRY_PASSPORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CpiNumber)
                .HasColumnName("CPI_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsNameid)
                .HasColumnName("CRS_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmailPrefCode)
                .HasColumnName("EMAIL_PREF_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.HomeOrBusinessFlag)
                .HasColumnName("HOME_OR_BUSINESS_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasColumnName("HOME_PHONE")
                .HasMaxLength(20)
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

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PassportNumber)
                .HasColumnName("PASSPORT_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuiteNightAwardsBalance)
                .HasColumnName("SUITE_NIGHT_AWARDS_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TmpCcn)
                .HasColumnName("TMP_CCN")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.TmpEds)
                .HasColumnName("TMP_EDS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.YtdNights)
                .HasColumnName("YTD_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdStays)
                .HasColumnName("YTD_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GuestLookupPref)))
				entity.Ignore(e => e.GuestLookupPref);
		});
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScAllContactsByBusblock
{
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public string? ConRelationship { get; set; }
    public string? ConRelationshipDesc { get; set; }
    public string? ConPrimaryYn { get; set; }
    public decimal? ConId { get; set; }
    public string? ConName { get; set; }
    public string? ConLast { get; set; }
    public string? ConFirst { get; set; }
    public string? ConMiddle { get; set; }
    public string? ConBusinessGreeting { get; set; }
    public string? ConAddress1 { get; set; }
    public string? ConAddress2 { get; set; }
    public string? ConAddress3 { get; set; }
    public string? ConAddress4 { get; set; }
    public string? ConState { get; set; }
    public string? ConCountry { get; set; }
    public string? ConCountryDesc { get; set; }
    public string? ConCity { get; set; }
    public string? ConCityExt { get; set; }
    public string? ContactZipcode { get; set; }
    public string? ContactPhone { get; set; }
    public string? ContactFax { get; set; }
    public string? ContactEmail { get; set; }
    public string? ConLetterGreeting { get; set; }
    public string? ConPosition { get; set; }
    public string? ConDepartment { get; set; }
    public string? ConXfirst { get; set; }
    public string? ConXlast { get; set; }
    public string? ConXname { get; set; }
    public string? ConXtitle { get; set; }
    public string? ConXsalutation { get; set; }
    public string? ConXletterGreeting { get; set; }
    public string? ConActioncode { get; set; }
    public string? ConActiveYn { get; set; }
    public DateTime? ConBirthDate { get; set; }
    public string? ConCashBlInd { get; set; }
    public string? ConContactYn { get; set; }
    public string? ConInfluence { get; set; }
    public string? ConLanguage { get; set; }
    public string? ConLanguageDesc { get; set; }
    public string? ConMarkets { get; set; }
    public string? ConProductInterest { get; set; }
    public string? ConScope { get; set; }
    public string? ConScopeCity { get; set; }
    public string? ConSfirst { get; set; }
    public string? ConSname { get; set; }
    public string? ConSrepId { get; set; }
    public string? ConSrepName { get; set; }
    public string? ConSxfirstName { get; set; }
    public string? ConSxname { get; set; }
    public string? ConTerritory { get; set; }
    public string? ConTitle { get; set; }
    public string? ConXlanguage { get; set; }
    public string? ConXlanguageDesc { get; set; }
    public string? LoggedSrepCode { get; set; }
    public string? ConDefaultPrintYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScAllContactsByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_ALL_CONTACTS_BY_BUSBLOCK");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConActioncode)
                .HasColumnName("CON_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.ConActiveYn)
                .HasColumnName("CON_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress1)
                .HasColumnName("CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress2)
                .HasColumnName("CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress3)
                .HasColumnName("CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress4)
                .HasColumnName("CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConBirthDate)
                .HasColumnName("CON_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConBusinessGreeting)
                .HasColumnName("CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConCashBlInd)
                .HasColumnName("CON_CASH_BL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCityExt)
                .HasColumnName("CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConContactYn)
                .IsRequired()
                .HasColumnName("CON_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConCountryDesc)
                .HasColumnName("CON_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ConDefaultPrintYn)
                .HasColumnName("CON_DEFAULT_PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConDepartment)
                .HasColumnName("CON_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConFirst)
                .HasColumnName("CON_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConId)
                .HasColumnName("CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConInfluence)
                .HasColumnName("CON_INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConLanguage)
                .HasColumnName("CON_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConLanguageDesc)
                .HasColumnName("CON_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ConLast)
                .HasColumnName("CON_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConLetterGreeting)
                .HasColumnName("CON_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConMarkets)
                .HasColumnName("CON_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConMiddle)
                .HasColumnName("CON_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConName)
                .HasColumnName("CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConPosition)
                .HasColumnName("CON_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConPrimaryYn)
                .HasColumnName("CON_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConProductInterest)
                .HasColumnName("CON_PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.ConRelationship)
                .HasColumnName("CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationshipDesc)
                .HasColumnName("CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConScope)
                .HasColumnName("CON_SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConScopeCity)
                .HasColumnName("CON_SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConSfirst)
                .HasColumnName("CON_SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConSname)
                .IsRequired()
                .HasColumnName("CON_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConSrepId)
                .HasColumnName("CON_SREP_ID")
                .IsUnicode(false);

            entity.Property(e => e.ConSrepName)
                .HasColumnName("CON_SREP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConState)
                .HasColumnName("CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConSxfirstName)
                .HasColumnName("CON_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConSxname)
                .HasColumnName("CON_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConTerritory)
                .HasColumnName("CON_TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConTitle)
                .HasColumnName("CON_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConXfirst)
                .HasColumnName("CON_XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConXlanguage)
                .HasColumnName("CON_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConXlanguageDesc)
                .HasColumnName("CON_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ConXlast)
                .HasColumnName("CON_XLAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConXletterGreeting)
                .HasColumnName("CON_XLETTER_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConXname)
                .HasColumnName("CON_XNAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.ConXsalutation)
                .HasColumnName("CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConXtitle)
                .HasColumnName("CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmail)
                .HasColumnName("CONTACT_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.ContactFax)
                .HasColumnName("CONTACT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.ContactPhone)
                .HasColumnName("CONTACT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.ContactZipcode)
                .HasColumnName("CONTACT_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
                .IsUnicode(false);
        });
	}
}

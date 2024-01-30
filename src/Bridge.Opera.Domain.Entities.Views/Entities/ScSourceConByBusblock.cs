namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScSourceConByBusblock
{
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public string? SourceConRelationship { get; set; }
    public string? SourceConRelationshipDesc { get; set; }
    public string? SourceConPrimaryYn { get; set; }
    public decimal? SourceConId { get; set; }
    public string? SourceConName { get; set; }
    public string? SourceConLast { get; set; }
    public string? SourceConFirst { get; set; }
    public string? SourceConMiddle { get; set; }
    public string? SourceConBusinessGreeting { get; set; }
    public string? SourceConAddress1 { get; set; }
    public string? SourceConAddress2 { get; set; }
    public string? SourceConAddress3 { get; set; }
    public string? SourceConAddress4 { get; set; }
    public string? SourceConState { get; set; }
    public string? SourceConCountry { get; set; }
    public string? SourceConCountryDesc { get; set; }
    public string? SourceConCity { get; set; }
    public string? SourceConCityExt { get; set; }
    public string? SourceConZipcode { get; set; }
    public string? SourceConPhone { get; set; }
    public string? SourceConFax { get; set; }
    public string? SourceConEmail { get; set; }
    public string? SourceConLetterGreeting { get; set; }
    public string? SourceConPosition { get; set; }
    public string? SourceConDepartment { get; set; }
    public string? SourceConXfirst { get; set; }
    public string? SourceConXlast { get; set; }
    public string? SourceConXname { get; set; }
    public string? SourceConXtitle { get; set; }
    public string? SourceConXsalutation { get; set; }
    public string? SourceConXletterGreeting { get; set; }
    public string? SourceConActioncode { get; set; }
    public string? SourceConActiveYn { get; set; }
    public DateTime? SourceConBirthDate { get; set; }
    public string? SourceConBirthDateStr { get; set; }
    public string? SourceConCashBlInd { get; set; }
    public string? SourceConContactYn { get; set; }
    public string? SourceConInfluence { get; set; }
    public string? SourceConLanguage { get; set; }
    public string? SourceConLanguageDesc { get; set; }
    public string? SourceConMarkets { get; set; }
    public string? SourceConProductInterest { get; set; }
    public string? SourceConScope { get; set; }
    public string? SourceConScopeCity { get; set; }
    public string? SourceConSfirst { get; set; }
    public string? SourceConSname { get; set; }
    public string? SourceConSrepId { get; set; }
    public string? SourceConSrepName { get; set; }
    public string? SourceConSxfirstName { get; set; }
    public string? SourceConSxname { get; set; }
    public string? SourceConTerritory { get; set; }
    public string? SourceConTitle { get; set; }
    public string? SourceConXlanguage { get; set; }
    public string? SourceConXlanguageDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScSourceConByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_SOURCE_CON_BY_BUSBLOCK");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConActioncode)
                .HasColumnName("SOURCE_CON_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.SourceConActiveYn)
                .HasColumnName("SOURCE_CON_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceConAddress1)
                .HasColumnName("SOURCE_CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConAddress2)
                .HasColumnName("SOURCE_CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConAddress3)
                .HasColumnName("SOURCE_CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConAddress4)
                .HasColumnName("SOURCE_CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConBirthDate)
                .HasColumnName("SOURCE_CON_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SourceConBirthDateStr)
                .HasColumnName("SOURCE_CON_BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConBusinessGreeting)
                .HasColumnName("SOURCE_CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceConCashBlInd)
                .HasColumnName("SOURCE_CON_CASH_BL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceConCity)
                .HasColumnName("SOURCE_CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConCityExt)
                .HasColumnName("SOURCE_CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConContactYn)
                .IsRequired()
                .HasColumnName("SOURCE_CON_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceConCountry)
                .HasColumnName("SOURCE_CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConCountryDesc)
                .HasColumnName("SOURCE_CON_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceConDepartment)
                .HasColumnName("SOURCE_CON_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceConEmail)
                .HasColumnName("SOURCE_CON_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SourceConFax)
                .HasColumnName("SOURCE_CON_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SourceConFirst)
                .HasColumnName("SOURCE_CON_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConId)
                .HasColumnName("SOURCE_CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceConInfluence)
                .HasColumnName("SOURCE_CON_INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceConLanguage)
                .HasColumnName("SOURCE_CON_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConLanguageDesc)
                .HasColumnName("SOURCE_CON_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceConLast)
                .HasColumnName("SOURCE_CON_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConLetterGreeting)
                .HasColumnName("SOURCE_CON_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceConMarkets)
                .HasColumnName("SOURCE_CON_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceConMiddle)
                .HasColumnName("SOURCE_CON_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConName)
                .HasColumnName("SOURCE_CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConPhone)
                .HasColumnName("SOURCE_CON_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SourceConPosition)
                .HasColumnName("SOURCE_CON_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConPrimaryYn)
                .HasColumnName("SOURCE_CON_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceConProductInterest)
                .HasColumnName("SOURCE_CON_PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.SourceConRelationship)
                .HasColumnName("SOURCE_CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConRelationshipDesc)
                .HasColumnName("SOURCE_CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceConScope)
                .HasColumnName("SOURCE_CON_SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceConScopeCity)
                .HasColumnName("SOURCE_CON_SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceConSfirst)
                .HasColumnName("SOURCE_CON_SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConSname)
                .IsRequired()
                .HasColumnName("SOURCE_CON_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConSrepId)
                .HasColumnName("SOURCE_CON_SREP_ID")
                .IsUnicode(false);

            entity.Property(e => e.SourceConSrepName)
                .HasColumnName("SOURCE_CON_SREP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SourceConState)
                .HasColumnName("SOURCE_CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConSxfirstName)
                .HasColumnName("SOURCE_CON_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConSxname)
                .HasColumnName("SOURCE_CON_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConTerritory)
                .HasColumnName("SOURCE_CON_TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConTitle)
                .HasColumnName("SOURCE_CON_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXfirst)
                .HasColumnName("SOURCE_CON_XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXlanguage)
                .HasColumnName("SOURCE_CON_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXlanguageDesc)
                .HasColumnName("SOURCE_CON_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceConXlast)
                .HasColumnName("SOURCE_CON_XLAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXletterGreeting)
                .HasColumnName("SOURCE_CON_XLETTER_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXname)
                .HasColumnName("SOURCE_CON_XNAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXsalutation)
                .HasColumnName("SOURCE_CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceConXtitle)
                .HasColumnName("SOURCE_CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceConZipcode)
                .HasColumnName("SOURCE_CON_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

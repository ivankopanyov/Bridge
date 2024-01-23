namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScAgentConByBusblock
{
    public string BusblockProperty { get; set; }
    public decimal BusblockId { get; set; }
    public string AgentConRelationship { get; set; }
    public string AgentConRelationshipDesc { get; set; }
    public string AgentConPrimaryYn { get; set; }
    public decimal AgentConId { get; set; }
    public string AgentConName { get; set; }
    public string AgentConLast { get; set; }
    public string AgentConFirst { get; set; }
    public string AgentConMiddle { get; set; }
    public string AgentConBusinessGreeting { get; set; }
    public string AgentConAddress1 { get; set; }
    public string AgentConAddress2 { get; set; }
    public string AgentConAddress3 { get; set; }
    public string AgentConAddress4 { get; set; }
    public string AgentConState { get; set; }
    public string AgentConCountry { get; set; }
    public string AgentConCountryDesc { get; set; }
    public string AgentConCity { get; set; }
    public string AgentConCityExt { get; set; }
    public string AgentConZipcode { get; set; }
    public string AgentConPhone { get; set; }
    public string AgentConFax { get; set; }
    public string AgentConEmail { get; set; }
    public string AgentConLetterGreeting { get; set; }
    public string AgentConPosition { get; set; }
    public string AgentConDepartment { get; set; }
    public string AgentConXfirst { get; set; }
    public string AgentConXlast { get; set; }
    public string AgentConXname { get; set; }
    public string AgentConXtitle { get; set; }
    public string AgentConXsalutation { get; set; }
    public string AgentConXletterGreeting { get; set; }
    public string AgentConActioncode { get; set; }
    public string AgentConActiveYn { get; set; }
    public DateTime? AgentConBirthDate { get; set; }
    public string AgentConBirthDateStr { get; set; }
    public string AgentConCashBlInd { get; set; }
    public string AgentConContactYn { get; set; }
    public string AgentConInfluence { get; set; }
    public string AgentConLanguage { get; set; }
    public string AgentConLanguageDesc { get; set; }
    public string AgentConMarkets { get; set; }
    public string AgentConProductInterest { get; set; }
    public string AgentConScope { get; set; }
    public string AgentConScopeCity { get; set; }
    public string AgentConSfirst { get; set; }
    public string AgentConSname { get; set; }
    public string AgentConSrepId { get; set; }
    public string AgentConSrepName { get; set; }
    public string AgentConSxfirstName { get; set; }
    public string AgentConSxname { get; set; }
    public string AgentConTerritory { get; set; }
    public string AgentConTitle { get; set; }
    public string AgentConXlanguage { get; set; }
    public string AgentConXlanguageDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScAgentConByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_AGENT_CON_BY_BUSBLOCK");

            entity.Property(e => e.AgentConActioncode)
                .HasColumnName("AGENT_CON_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.AgentConActiveYn)
                .HasColumnName("AGENT_CON_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentConAddress1)
                .HasColumnName("AGENT_CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConAddress2)
                .HasColumnName("AGENT_CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConAddress3)
                .HasColumnName("AGENT_CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConAddress4)
                .HasColumnName("AGENT_CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConBirthDate)
                .HasColumnName("AGENT_CON_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AgentConBirthDateStr)
                .HasColumnName("AGENT_CON_BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConBusinessGreeting)
                .HasColumnName("AGENT_CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AgentConCashBlInd)
                .HasColumnName("AGENT_CON_CASH_BL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentConCity)
                .HasColumnName("AGENT_CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConCityExt)
                .HasColumnName("AGENT_CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConContactYn)
                .IsRequired()
                .HasColumnName("AGENT_CON_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentConCountry)
                .HasColumnName("AGENT_CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConCountryDesc)
                .HasColumnName("AGENT_CON_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AgentConDepartment)
                .HasColumnName("AGENT_CON_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentConEmail)
                .HasColumnName("AGENT_CON_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AgentConFax)
                .HasColumnName("AGENT_CON_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AgentConFirst)
                .HasColumnName("AGENT_CON_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConId)
                .HasColumnName("AGENT_CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentConInfluence)
                .HasColumnName("AGENT_CON_INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AgentConLanguage)
                .HasColumnName("AGENT_CON_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConLanguageDesc)
                .HasColumnName("AGENT_CON_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AgentConLast)
                .HasColumnName("AGENT_CON_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConLetterGreeting)
                .HasColumnName("AGENT_CON_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AgentConMarkets)
                .HasColumnName("AGENT_CON_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AgentConMiddle)
                .HasColumnName("AGENT_CON_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConName)
                .HasColumnName("AGENT_CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConPhone)
                .HasColumnName("AGENT_CON_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AgentConPosition)
                .HasColumnName("AGENT_CON_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConPrimaryYn)
                .HasColumnName("AGENT_CON_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentConProductInterest)
                .HasColumnName("AGENT_CON_PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.AgentConRelationship)
                .HasColumnName("AGENT_CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConRelationshipDesc)
                .HasColumnName("AGENT_CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentConScope)
                .HasColumnName("AGENT_CON_SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AgentConScopeCity)
                .HasColumnName("AGENT_CON_SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AgentConSfirst)
                .HasColumnName("AGENT_CON_SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConSname)
                .IsRequired()
                .HasColumnName("AGENT_CON_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConSrepId)
                .HasColumnName("AGENT_CON_SREP_ID")
                .IsUnicode(false);

            entity.Property(e => e.AgentConSrepName)
                .HasColumnName("AGENT_CON_SREP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AgentConState)
                .HasColumnName("AGENT_CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConSxfirstName)
                .HasColumnName("AGENT_CON_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConSxname)
                .HasColumnName("AGENT_CON_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConTerritory)
                .HasColumnName("AGENT_CON_TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConTitle)
                .HasColumnName("AGENT_CON_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXfirst)
                .HasColumnName("AGENT_CON_XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXlanguage)
                .HasColumnName("AGENT_CON_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXlanguageDesc)
                .HasColumnName("AGENT_CON_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AgentConXlast)
                .HasColumnName("AGENT_CON_XLAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXletterGreeting)
                .HasColumnName("AGENT_CON_XLETTER_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXname)
                .HasColumnName("AGENT_CON_XNAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXsalutation)
                .HasColumnName("AGENT_CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AgentConXtitle)
                .HasColumnName("AGENT_CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentConZipcode)
                .HasColumnName("AGENT_CON_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

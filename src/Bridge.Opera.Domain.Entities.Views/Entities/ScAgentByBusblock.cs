namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScAgentByBusblock
{
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public string? AgentRelationship { get; set; }
    public string? AgentRelationshipDesc { get; set; }
    public string? AgentPrimaryYn { get; set; }
    public decimal? AgentId { get; set; }
    public string? AgentName { get; set; }
    public string? AgentName2 { get; set; }
    public string? AgentName3 { get; set; }
    public string? AgentAddress1 { get; set; }
    public string? AgentAddress2 { get; set; }
    public string? AgentState { get; set; }
    public string? AgentCountry { get; set; }
    public string? AgentCountryDesc { get; set; }
    public string? AgentCity { get; set; }
    public string? AgentCityExt { get; set; }
    public string? AgentZipcode { get; set; }
    public string? AgentPhone { get; set; }
    public string? AgentFax { get; set; }
    public string? AgentEmail { get; set; }
    public string? IataCorpNo { get; set; }
    public string? XagentName { get; set; }
    public string? AgentXfirstName { get; set; }
    public string? AgentXtitle { get; set; }
    public string? AgentXsalutation { get; set; }
    public string? AgentXdisplayName { get; set; }
    public string? AgentXenvelopeGreeting { get; set; }
    public string? AgentXlanguage { get; set; }
    public string? AgentXlanguageDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScAgentByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_AGENT_BY_BUSBLOCK");

            entity.Property(e => e.AgentAddress1)
                .HasColumnName("AGENT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentAddress2)
                .HasColumnName("AGENT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentCity)
                .HasColumnName("AGENT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentCityExt)
                .HasColumnName("AGENT_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentCountry)
                .HasColumnName("AGENT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentCountryDesc)
                .HasColumnName("AGENT_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AgentEmail)
                .HasColumnName("AGENT_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AgentFax)
                .HasColumnName("AGENT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName2)
                .HasColumnName("AGENT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName3)
                .HasColumnName("AGENT_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentPhone)
                .HasColumnName("AGENT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AgentPrimaryYn)
                .HasColumnName("AGENT_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentRelationship)
                .HasColumnName("AGENT_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentRelationshipDesc)
                .HasColumnName("AGENT_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentState)
                .HasColumnName("AGENT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentXdisplayName)
                .HasColumnName("AGENT_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.AgentXenvelopeGreeting)
                .HasColumnName("AGENT_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentXfirstName)
                .HasColumnName("AGENT_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentXlanguage)
                .HasColumnName("AGENT_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentXlanguageDesc)
                .HasColumnName("AGENT_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AgentXsalutation)
                .HasColumnName("AGENT_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AgentXtitle)
                .HasColumnName("AGENT_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentZipcode)
                .HasColumnName("AGENT_ZIPCODE")
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

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XagentName)
                .HasColumnName("XAGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}

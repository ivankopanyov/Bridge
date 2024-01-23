namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScNameByBusblock
{
    public string BusblockProperty { get; set; }
    public decimal BusblockId { get; set; }
    public string AccRelationship { get; set; }
    public string AccRelationshipDesc { get; set; }
    public decimal? AccId { get; set; }
    public string AccName { get; set; }
    public string AccName2 { get; set; }
    public string AccName3 { get; set; }
    public string AccBusinessGreeting { get; set; }
    public string AccAddress1 { get; set; }
    public string AccAddress2 { get; set; }
    public string AccZipcode { get; set; }
    public string AccState { get; set; }
    public string AccCountry { get; set; }
    public string AccCity { get; set; }
    public string AccCityExt { get; set; }
    public string AccPhone { get; set; }
    public string AccFax { get; set; }
    public string AccEmail { get; set; }
    public string ConRelationship { get; set; }
    public string ConRelationshipDesc { get; set; }
    public decimal? ConId { get; set; }
    public string ConName { get; set; }
    public string ConLast { get; set; }
    public string ConFirst { get; set; }
    public string ConMiddle { get; set; }
    public string ConBusinessGreeting { get; set; }
    public string ConAddress1 { get; set; }
    public string ConAddress2 { get; set; }
    public string ConState { get; set; }
    public string ConCountry { get; set; }
    public string ConCity { get; set; }
    public string ConCityExt { get; set; }
    public string ContactZipcode { get; set; }
    public string ContactPhone { get; set; }
    public string ContactFax { get; set; }
    public string ContactEmail { get; set; }
    public string ConLetterGreeting { get; set; }
    public string ConPosition { get; set; }
    public string ConDepartment { get; set; }
    public string AgentRelationship { get; set; }
    public string AgentRelationshipDesc { get; set; }
    public decimal? AgentId { get; set; }
    public string AgentName { get; set; }
    public string AgentName2 { get; set; }
    public string AgentName3 { get; set; }
    public string AgentAddress1 { get; set; }
    public string AgentAddress2 { get; set; }
    public string AgentState { get; set; }
    public string AgentCountry { get; set; }
    public string AgentCity { get; set; }
    public string AgentCityExt { get; set; }
    public string AgentZipcode { get; set; }
    public string AgentPhone { get; set; }
    public string AgentFax { get; set; }
    public string AgentEmail { get; set; }
    public string IataCorpNo { get; set; }
    public string SourceRelationship { get; set; }
    public string SourceRelationshipDesc { get; set; }
    public string SourcePrimaryYn { get; set; }
    public decimal? SourceId { get; set; }
    public string SourceName { get; set; }
    public string SourceName2 { get; set; }
    public string SourceName3 { get; set; }
    public string SourceBusinessGreeting { get; set; }
    public string SourceAddress1 { get; set; }
    public string SourceAddress2 { get; set; }
    public string SourceState { get; set; }
    public string SourceCountry { get; set; }
    public string SourceCity { get; set; }
    public string SourceCityExt { get; set; }
    public string SourceZipcode { get; set; }
    public string SourcePhone { get; set; }
    public string SourceFax { get; set; }
    public string SourceEmail { get; set; }
    public string BusblockNoteTitle { get; set; }
    public string BusblockNoteInternal { get; set; }
    public string BusblockNotes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScNameByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_NAME_BY_BUSBLOCK");

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccBusinessGreeting)
                .HasColumnName("ACC_BUSINESS_GREETING")
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccCityExt)
                .HasColumnName("ACC_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccEmail)
                .HasColumnName("ACC_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AccFax)
                .HasColumnName("ACC_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName2)
                .HasColumnName("ACC_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName3)
                .HasColumnName("ACC_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccPhone)
                .HasColumnName("ACC_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AccRelationship)
                .HasColumnName("ACC_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccRelationshipDesc)
                .HasColumnName("ACC_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccZipcode)
                .HasColumnName("ACC_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

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

            entity.Property(e => e.AgentZipcode)
                .HasColumnName("AGENT_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockNoteInternal)
                .HasColumnName("BUSBLOCK_NOTE_INTERNAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusblockNoteTitle)
                .HasColumnName("BUSBLOCK_NOTE_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BusblockNotes)
                .HasColumnName("BUSBLOCK_NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress1)
                .HasColumnName("CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress2)
                .HasColumnName("CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConBusinessGreeting)
                .HasColumnName("CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCityExt)
                .HasColumnName("CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
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

            entity.Property(e => e.ConLast)
                .HasColumnName("CON_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConLetterGreeting)
                .HasColumnName("CON_LETTER_GREETING")
                .HasMaxLength(60)
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

            entity.Property(e => e.ConRelationship)
                .HasColumnName("CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationshipDesc)
                .HasColumnName("CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConState)
                .HasColumnName("CON_STATE")
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

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress1)
                .HasColumnName("SOURCE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress2)
                .HasColumnName("SOURCE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceBusinessGreeting)
                .HasColumnName("SOURCE_BUSINESS_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceCity)
                .HasColumnName("SOURCE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceCityExt)
                .HasColumnName("SOURCE_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCountry)
                .HasColumnName("SOURCE_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceEmail)
                .HasColumnName("SOURCE_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SourceFax)
                .HasColumnName("SOURCE_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName2)
                .HasColumnName("SOURCE_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName3)
                .HasColumnName("SOURCE_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourcePhone)
                .HasColumnName("SOURCE_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SourcePrimaryYn)
                .HasColumnName("SOURCE_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationship)
                .HasColumnName("SOURCE_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationshipDesc)
                .HasColumnName("SOURCE_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceState)
                .HasColumnName("SOURCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceZipcode)
                .HasColumnName("SOURCE_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccConAgentByBooking
{
    public string Resort { get; set; }
    public decimal BookingId { get; set; }
    public decimal? AccountId { get; set; }
    public string AccountName { get; set; }
    public string AccountName2 { get; set; }
    public string AccountName3 { get; set; }
    public string AccountBusinessGreeting { get; set; }
    public string AccountAddress1 { get; set; }
    public string AccountAddress2 { get; set; }
    public string AccountZipCode { get; set; }
    public string AccountFaxNo { get; set; }
    public string AccountPhoneNo { get; set; }
    public string AccountState { get; set; }
    public string AccountCountry { get; set; }
    public string AccountCity { get; set; }
    public string AccountCityExt { get; set; }
    public string AccountEmailId { get; set; }
    public string XaccountName { get; set; }
    public decimal? ContactId { get; set; }
    public string ContactFullName { get; set; }
    public string ContactName { get; set; }
    public string ContactFirstName { get; set; }
    public string ContactMiddleName { get; set; }
    public string ContactBusinessGreeting { get; set; }
    public string ContactLetterGreeting { get; set; }
    public string ContactPosition { get; set; }
    public string ContactDepartment { get; set; }
    public string ContactAddress1 { get; set; }
    public string ContactAddress2 { get; set; }
    public string ContactAddress3 { get; set; }
    public string ContactAddress4 { get; set; }
    public string ContactState { get; set; }
    public string ConCountry { get; set; }
    public string ConCity { get; set; }
    public string ConCityExt { get; set; }
    public string ContactZipCode { get; set; }
    public string ContactFaxNo { get; set; }
    public string ContactPhoneNo { get; set; }
    public string ContactEmailId { get; set; }
    public string ConRelationship { get; set; }
    public string ConRelationDescription { get; set; }
    public string XcontactFullName { get; set; }
    public string ConXfirstName { get; set; }
    public string ConXlastName { get; set; }
    public string ConXtitle { get; set; }
    public string ConXsalutation { get; set; }
    public string ConXenvelopeGreeting { get; set; }
    public decimal? SecContactId { get; set; }
    public string SecContactFullName { get; set; }
    public string SecContactName { get; set; }
    public string SecContactFirstName { get; set; }
    public string SecContactMiddleName { get; set; }
    public string SecContactBusinessGreeting { get; set; }
    public string SecContactEnvelopeGreeting { get; set; }
    public string SecContactPosition { get; set; }
    public string SecContactDepartment { get; set; }
    public string SecContactAddress1 { get; set; }
    public string SecContactAddress2 { get; set; }
    public string SecContactAddress3 { get; set; }
    public string SecContactAddress4 { get; set; }
    public string SecContactState { get; set; }
    public string SecConCountry { get; set; }
    public string SecConCity { get; set; }
    public string SecConCityExt { get; set; }
    public string SecContactZipCode { get; set; }
    public string SecContactFaxNo { get; set; }
    public string SecContactPhoneNo { get; set; }
    public string SecContactEmailId { get; set; }
    public string SecConRelationship { get; set; }
    public string SecConRelationDescription { get; set; }
    public string SecXcontactFullName { get; set; }
    public string SecConXfirstName { get; set; }
    public string SecConXlastName { get; set; }
    public string SecConXtitle { get; set; }
    public string SecConXsalutation { get; set; }
    public string SecConXenvelopeGreeting { get; set; }
    public decimal? AgentId { get; set; }
    public string AgentName { get; set; }
    public string AgentName3 { get; set; }
    public string AgentName2 { get; set; }
    public string AgentAddress1 { get; set; }
    public string AgentAddress2 { get; set; }
    public string AgentState { get; set; }
    public string AgentCountry { get; set; }
    public string AgentCity { get; set; }
    public string AgentCityExt { get; set; }
    public string AgentZipCode { get; set; }
    public string AgentFaxNo { get; set; }
    public string AgentPhoneNo { get; set; }
    public string AgentEmailId { get; set; }
    public string AgentIataCorpNo { get; set; }
    public string XagentName { get; set; }
    public decimal? SourceId { get; set; }
    public string SourceName { get; set; }
    public string SourceName2 { get; set; }
    public string SourceName3 { get; set; }
    public string SourceBusinessGreeting { get; set; }
    public string SourceAddress1 { get; set; }
    public string SourceAddress2 { get; set; }
    public string SourceZipCode { get; set; }
    public string SourceFaxNo { get; set; }
    public string SourcePhoneNo { get; set; }
    public string SourceState { get; set; }
    public string SourceCountry { get; set; }
    public string SourceCity { get; set; }
    public string SourceCityExt { get; set; }
    public string SourceEmailId { get; set; }
    public string XsourceName { get; set; }
    public string OwnerTitle { get; set; }
    public string OwnerPhone { get; set; }
    public string OwnerEmail { get; set; }
    public string OwnerFax { get; set; }
    public string RmsOwnerTitle { get; set; }
    public string RmsOwnerPhone { get; set; }
    public string RmsOwnerEmail { get; set; }
    public string RmsOwnerFax { get; set; }
    public string CatOwnerTitle { get; set; }
    public string CatOwnerPhone { get; set; }
    public string CatOwnerEmail { get; set; }
    public string CatOwnerFax { get; set; }
    public string ArrivalTime { get; set; }
    public string DepartureTime { get; set; }
    public string CompRoomsFixedYn { get; set; }
    public decimal? CompRooms { get; set; }
    public string CompPerStayYn { get; set; }
    public decimal? CompRoomValue { get; set; }
    public decimal? AgentConId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccConAgentByBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACC_CON_AGENT_BY_BOOKING");

            entity.Property(e => e.AccountAddress1)
                .HasColumnName("ACCOUNT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountAddress2)
                .HasColumnName("ACCOUNT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountBusinessGreeting)
                .HasColumnName("ACCOUNT_BUSINESS_GREETING")
                .IsUnicode(false);

            entity.Property(e => e.AccountCity)
                .HasColumnName("ACCOUNT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountCityExt)
                .HasColumnName("ACCOUNT_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountCountry)
                .HasColumnName("ACCOUNT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountEmailId)
                .HasColumnName("ACCOUNT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AccountFaxNo)
                .HasColumnName("ACCOUNT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountName2)
                .HasColumnName("ACCOUNT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountName3)
                .HasColumnName("ACCOUNT_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountPhoneNo)
                .HasColumnName("ACCOUNT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountState)
                .HasColumnName("ACCOUNT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountZipCode)
                .HasColumnName("ACCOUNT_ZIP_CODE")
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

            entity.Property(e => e.AgentConId)
                .HasColumnName("AGENT_CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentCountry)
                .HasColumnName("AGENT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentEmailId)
                .HasColumnName("AGENT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AgentFaxNo)
                .HasColumnName("AGENT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.AgentIataCorpNo)
                .HasColumnName("AGENT_IATA_CORP_NO")
                .HasMaxLength(20)
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

            entity.Property(e => e.AgentPhoneNo)
                .HasColumnName("AGENT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AgentState)
                .HasColumnName("AGENT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentZipCode)
                .HasColumnName("AGENT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwnerEmail)
                .HasColumnName("CAT_OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerFax)
                .HasColumnName("CAT_OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerPhone)
                .HasColumnName("CAT_OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerTitle)
                .HasColumnName("CAT_OWNER_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompPerStayYn)
                .HasColumnName("COMP_PER_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompRoomValue)
                .HasColumnName("COMP_ROOM_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRooms)
                .HasColumnName("COMP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomsFixedYn)
                .HasColumnName("COMP_ROOMS_FIXED_YN")
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

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationDescription)
                .HasColumnName("CON_RELATION_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationship)
                .HasColumnName("CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConXenvelopeGreeting)
                .HasColumnName("CON_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConXfirstName)
                .HasColumnName("CON_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConXlastName)
                .HasColumnName("CON_XLAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConXsalutation)
                .HasColumnName("CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConXtitle)
                .HasColumnName("CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress1)
                .HasColumnName("CONTACT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress2)
                .HasColumnName("CONTACT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress3)
                .HasColumnName("CONTACT_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress4)
                .HasColumnName("CONTACT_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactBusinessGreeting)
                .HasColumnName("CONTACT_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactDepartment)
                .HasColumnName("CONTACT_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmailId)
                .HasColumnName("CONTACT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxNo)
                .HasColumnName("CONTACT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.ContactFirstName)
                .HasColumnName("CONTACT_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactFullName)
                .HasColumnName("CONTACT_FULL_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactLetterGreeting)
                .HasColumnName("CONTACT_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ContactMiddleName)
                .HasColumnName("CONTACT_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactPhoneNo)
                .HasColumnName("CONTACT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.ContactPosition)
                .HasColumnName("CONTACT_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactState)
                .HasColumnName("CONTACT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactZipCode)
                .HasColumnName("CONTACT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.OwnerEmail)
                .HasColumnName("OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.OwnerFax)
                .HasColumnName("OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.OwnerPhone)
                .HasColumnName("OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.OwnerTitle)
                .HasColumnName("OWNER_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerEmail)
                .HasColumnName("RMS_OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerFax)
                .HasColumnName("RMS_OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerPhone)
                .HasColumnName("RMS_OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerTitle)
                .HasColumnName("RMS_OWNER_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConCity)
                .HasColumnName("SEC_CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConCityExt)
                .HasColumnName("SEC_CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConCountry)
                .HasColumnName("SEC_CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConRelationDescription)
                .HasColumnName("SEC_CON_RELATION_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecConRelationship)
                .HasColumnName("SEC_CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConXenvelopeGreeting)
                .HasColumnName("SEC_CON_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecConXfirstName)
                .HasColumnName("SEC_CON_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConXlastName)
                .HasColumnName("SEC_CON_XLAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConXsalutation)
                .HasColumnName("SEC_CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SecConXtitle)
                .HasColumnName("SEC_CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecContactAddress1)
                .HasColumnName("SEC_CONTACT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactAddress2)
                .HasColumnName("SEC_CONTACT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactAddress3)
                .HasColumnName("SEC_CONTACT_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactAddress4)
                .HasColumnName("SEC_CONTACT_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactBusinessGreeting)
                .HasColumnName("SEC_CONTACT_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecContactDepartment)
                .HasColumnName("SEC_CONTACT_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecContactEmailId)
                .HasColumnName("SEC_CONTACT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.SecContactEnvelopeGreeting)
                .HasColumnName("SEC_CONTACT_ENVELOPE_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SecContactFaxNo)
                .HasColumnName("SEC_CONTACT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.SecContactFirstName)
                .HasColumnName("SEC_CONTACT_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecContactFullName)
                .HasColumnName("SEC_CONTACT_FULL_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.SecContactId)
                .HasColumnName("SEC_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SecContactMiddleName)
                .HasColumnName("SEC_CONTACT_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecContactName)
                .HasColumnName("SEC_CONTACT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactPhoneNo)
                .HasColumnName("SEC_CONTACT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.SecContactPosition)
                .HasColumnName("SEC_CONTACT_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecContactState)
                .HasColumnName("SEC_CONTACT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecContactZipCode)
                .HasColumnName("SEC_CONTACT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.SecXcontactFullName)
                .HasColumnName("SEC_XCONTACT_FULL_NAME")
                .HasMaxLength(122)
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

            entity.Property(e => e.SourceEmailId)
                .HasColumnName("SOURCE_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.SourceFaxNo)
                .HasColumnName("SOURCE_FAX_NO")
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

            entity.Property(e => e.SourcePhoneNo)
                .HasColumnName("SOURCE_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.SourceState)
                .HasColumnName("SOURCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceZipCode)
                .HasColumnName("SOURCE_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.XaccountName)
                .HasColumnName("XACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XagentName)
                .HasColumnName("XAGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XcontactFullName)
                .HasColumnName("XCONTACT_FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XsourceName)
                .HasColumnName("XSOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}

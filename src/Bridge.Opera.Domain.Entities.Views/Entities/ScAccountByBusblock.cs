namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScAccountByBusblock
{
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public string? AccRelationship { get; set; }
    public string? AccRelationshipDesc { get; set; }
    public string? AccPrimaryYn { get; set; }
    public decimal? AccId { get; set; }
    public string? AccName { get; set; }
    public string? AccName2 { get; set; }
    public string? AccName3 { get; set; }
    public string? AccBusinessGreeting { get; set; }
    public string? AccAddress1 { get; set; }
    public string? AccAddress2 { get; set; }
    public string? AccAddress3 { get; set; }
    public string? AccAddress4 { get; set; }
    public string? AccState { get; set; }
    public string? AccCountry { get; set; }
    public string? AccCountryDesc { get; set; }
    public string? AccCity { get; set; }
    public string? AccCityExt { get; set; }
    public string? AccZipcode { get; set; }
    public string? AccPhone { get; set; }
    public string? AccFax { get; set; }
    public string? AccEmail { get; set; }
    public string? XaccName { get; set; }
    public string? AccSource { get; set; }
    public string? AccType { get; set; }
    public string? AccActioncode { get; set; }
    public string? AccActiveYn { get; set; }
    public string? AccArNo { get; set; }
    public string? AccAvailoverYn { get; set; }
    public string? AccBlMsg { get; set; }
    public string? AccCblInd { get; set; }
    public string? AccCommissionCode { get; set; }
    public string? AccCompetitionCode { get; set; }
    public string? AccHistoryYn { get; set; }
    public string? AccHoldCode { get; set; }
    public string? AccIataCompType { get; set; }
    public string? AccIndustryCode { get; set; }
    public string? AccKeyword { get; set; }
    public string? AccLanguage { get; set; }
    public string? AccLanguageDesc { get; set; }
    public string? AccMailList { get; set; }
    public string? AccMailType { get; set; }
    public string? AccMarkets { get; set; }
    public string? AccNameKeywords { get; set; }
    public string? AccNameType { get; set; }
    public decimal? AccPhoneId { get; set; }
    public string? AccPhoneNo { get; set; }
    public string? AccPriority { get; set; }
    public string? AccProductInterest { get; set; }
    public string? AccRateInd { get; set; }
    public string? AccRoomsPotential { get; set; }
    public string? AccScope { get; set; }
    public string? AccScopeCity { get; set; }
    public string? AccSname { get; set; }
    public string? AccSrepCode { get; set; }
    public string? AccSxname { get; set; }
    public string? AccTerritory { get; set; }
    public string? AccXfirstName { get; set; }
    public string? AccXtitle { get; set; }
    public string? AccXsalutation { get; set; }
    public string? AccXdisplayName { get; set; }
    public string? AccXenvelopeGreeting { get; set; }
    public string? AccXlanguage { get; set; }
    public string? AccXlanguageDesc { get; set; }
    public string? LoggedSrepCode { get; set; }
    public string? AccDefaultPrintYn { get; set; }
    public string? AccAddressType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScAccountByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_ACCOUNT_BY_BUSBLOCK");

            entity.Property(e => e.AccActioncode)
                .HasColumnName("ACC_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.AccActiveYn)
                .HasColumnName("ACC_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress3)
                .HasColumnName("ACC_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress4)
                .HasColumnName("ACC_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddressType)
                .HasColumnName("ACC_ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccArNo)
                .HasColumnName("ACC_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccAvailoverYn)
                .HasColumnName("ACC_AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccBlMsg)
                .HasColumnName("ACC_BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccBusinessGreeting)
                .HasColumnName("ACC_BUSINESS_GREETING")
                .IsUnicode(false);

            entity.Property(e => e.AccCblInd)
                .HasColumnName("ACC_CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccCityExt)
                .HasColumnName("ACC_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccCommissionCode)
                .HasColumnName("ACC_COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccCompetitionCode)
                .HasColumnName("ACC_COMPETITION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccCountryDesc)
                .HasColumnName("ACC_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccDefaultPrintYn)
                .HasColumnName("ACC_DEFAULT_PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccEmail)
                .HasColumnName("ACC_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AccFax)
                .HasColumnName("ACC_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AccHistoryYn)
                .HasColumnName("ACC_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccHoldCode)
                .HasColumnName("ACC_HOLD_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccIataCompType)
                .HasColumnName("ACC_IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccIndustryCode)
                .HasColumnName("ACC_INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccKeyword)
                .HasColumnName("ACC_KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.AccLanguage)
                .HasColumnName("ACC_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccLanguageDesc)
                .HasColumnName("ACC_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccMailList)
                .HasColumnName("ACC_MAIL_LIST")
                .IsUnicode(false);

            entity.Property(e => e.AccMailType)
                .HasColumnName("ACC_MAIL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccMarkets)
                .HasColumnName("ACC_MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

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

            entity.Property(e => e.AccNameKeywords)
                .HasColumnName("ACC_NAME_KEYWORDS")
                .IsUnicode(false);

            entity.Property(e => e.AccNameType)
                .IsRequired()
                .HasColumnName("ACC_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccPhone)
                .HasColumnName("ACC_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AccPhoneId)
                .HasColumnName("ACC_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccPhoneNo)
                .HasColumnName("ACC_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccPrimaryYn)
                .HasColumnName("ACC_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccPriority)
                .HasColumnName("ACC_PRIORITY")
                .IsUnicode(false);

            entity.Property(e => e.AccProductInterest)
                .HasColumnName("ACC_PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.AccRateInd)
                .HasColumnName("ACC_RATE_IND")
                .IsUnicode(false);

            entity.Property(e => e.AccRelationship)
                .HasColumnName("ACC_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccRelationshipDesc)
                .HasColumnName("ACC_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccRoomsPotential)
                .HasColumnName("ACC_ROOMS_POTENTIAL")
                .IsUnicode(false);

            entity.Property(e => e.AccScope)
                .HasColumnName("ACC_SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccScopeCity)
                .HasColumnName("ACC_SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccSname)
                .IsRequired()
                .HasColumnName("ACC_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccSource)
                .HasColumnName("ACC_SOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccSrepCode)
                .HasColumnName("ACC_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccSxname)
                .HasColumnName("ACC_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccTerritory)
                .HasColumnName("ACC_TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccType)
                .HasColumnName("ACC_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccXdisplayName)
                .HasColumnName("ACC_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.AccXenvelopeGreeting)
                .HasColumnName("ACC_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccXfirstName)
                .HasColumnName("ACC_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccXlanguage)
                .HasColumnName("ACC_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccXlanguageDesc)
                .HasColumnName("ACC_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccXsalutation)
                .HasColumnName("ACC_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AccXtitle)
                .HasColumnName("ACC_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccZipcode)
                .HasColumnName("ACC_ZIPCODE")
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

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.XaccName)
                .HasColumnName("XACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}

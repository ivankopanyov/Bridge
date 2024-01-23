namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpCompanyDimBase
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RegionCode { get; set; }
    public string RegionDesc { get; set; }
    public string CountryId { get; set; }
    public string CountryCode { get; set; }
    public string CountryDesc { get; set; }
    public string StateId { get; set; }
    public string State { get; set; }
    public string StateDesc { get; set; }
    public decimal Company { get; set; }
    public string CompanyDesc { get; set; }
    public decimal CompanyId { get; set; }
    public string CompanyCharId { get; set; }
    public string ResortId { get; set; }
    public string Accountsource { get; set; }
    public string AccountType { get; set; }
    public string Actioncode { get; set; }
    public string ActiveYn { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public decimal? AddressId { get; set; }
    public string AddressType { get; set; }
    public string City { get; set; }
    public string CityExt { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string AllOwners { get; set; }
    public string ArNo { get; set; }
    public string AutoenrollMemberYn { get; set; }
    public string AvailoverYn { get; set; }
    public string BlMsg { get; set; }
    public string CblInd { get; set; }
    public string CisHistory { get; set; }
    public string CommissionCode { get; set; }
    public string CompetitionCode { get; set; }
    public string ContactYn { get; set; }
    public string CreditRating { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrentNegotiatedRates { get; set; }
    public DateTime? DownloadDate { get; set; }
    public string DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public string Email { get; set; }
    public decimal? EmailId { get; set; }
    public string EmailYn { get; set; }
    public decimal? FaxId { get; set; }
    public string FaxNo { get; set; }
    public string GuestPrivYn { get; set; }
    public string HistoryYn { get; set; }
    public string HoldCode { get; set; }
    public string IataCompType { get; set; }
    public string IataCorpNo { get; set; }
    public string InactiveReason { get; set; }
    public string IndustryCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string InsertUserName { get; set; }
    public string Keyword { get; set; }
    public string Language { get; set; }
    public string LanguageDesc { get; set; }
    public string LoggedSrepCode { get; set; }
    public string MailList { get; set; }
    public string MailType { get; set; }
    public string MailYn { get; set; }
    public string Markets { get; set; }
    public string MarketResearchYn { get; set; }
    public string Name { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public decimal NameId { get; set; }
    public string NameKeywords { get; set; }
    public string NameType { get; set; }
    public string NegotiatedRates { get; set; }
    public string Owner { get; set; }
    public decimal? PhoneId { get; set; }
    public string PhoneNo { get; set; }
    public string PhoneYn { get; set; }
    public string Priority { get; set; }
    public string ProductInterest { get; set; }
    public string ProfilePrivacyFlg { get; set; }
    public string PropertyActioncode { get; set; }
    public string PropertyCompetitionCode { get; set; }
    public string PropertyPriority { get; set; }
    public string PropertyRoomsPotential { get; set; }
    public string Protected { get; set; }
    public string RateCode { get; set; }
    public string RateInd { get; set; }
    public string Relationship { get; set; }
    public string ResortRegistered { get; set; }
    public string RoomsPotential { get; set; }
    public string Scope { get; set; }
    public string ScopeCity { get; set; }
    public string SmsYn { get; set; }
    public string Sname { get; set; }
    public string SrepCode { get; set; }
    public string SrepId { get; set; }
    public string Subsidiary { get; set; }
    public string Sxname { get; set; }
    public string Territory { get; set; }
    public string ThirdPartyYn { get; set; }
    public string Tracecode { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string UpdateUserName { get; set; }
    public DateTime? UploadDate { get; set; }
    public string WebPage { get; set; }
    public string XaccdisplayName { get; set; }
    public string XaccenvelopeGreeting { get; set; }
    public string XaccfirstName { get; set; }
    public string XacclanguageDesc { get; set; }
    public string Xaccsalutation { get; set; }
    public string Xacctitle { get; set; }
    public string XaccName { get; set; }
    public string Xlanguage { get; set; }
    public string XlastName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpCompanyDimBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_COMPANY_DIM_BASE");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accountsource)
                .HasColumnName("ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllOwners)
                .HasColumnName("ALL_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AutoenrollMemberYn)
                .HasColumnName("AUTOENROLL_MEMBER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AvailoverYn)
                .HasColumnName("AVAILOVER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlMsg)
                .HasColumnName("BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CblInd)
                .HasColumnName("CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CisHistory)
                .HasColumnName("CIS_HISTORY")
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyCharId)
                .HasColumnName("COMPANY_CHAR_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyDesc)
                .HasColumnName("COMPANY_DESC")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .IsRequired()
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CountryId)
                .HasColumnName("COUNTRY_ID")
                .IsUnicode(false);

            entity.Property(e => e.CreditRating)
                .HasColumnName("CREDIT_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrentNegotiatedRates)
                .HasColumnName("CURRENT_NEGOTIATED_RATES")
                .IsUnicode(false);

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveReason)
                .HasColumnName("INACTIVE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MailType)
                .HasColumnName("MAIL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchYn)
                .HasColumnName("MARKET_RESEARCH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Markets)
                .HasColumnName("MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameKeywords)
                .HasColumnName("NAME_KEYWORDS")
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedRates)
                .HasColumnName("NEGOTIATED_RATES")
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductInterest)
                .HasColumnName("PRODUCT_INTEREST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProfilePrivacyFlg)
                .HasColumnName("PROFILE_PRIVACY_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropertyActioncode)
                .HasColumnName("PROPERTY_ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCompetitionCode)
                .HasColumnName("PROPERTY_COMPETITION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyPriority)
                .HasColumnName("PROPERTY_PRIORITY")
                .IsUnicode(false);

            entity.Property(e => e.PropertyRoomsPotential)
                .HasColumnName("PROPERTY_ROOMS_POTENTIAL")
                .IsUnicode(false);

            entity.Property(e => e.Protected)
                .HasColumnName("PROTECTED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RateInd)
                .HasColumnName("RATE_IND")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ScopeCity)
                .HasColumnName("SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SmsYn)
                .HasColumnName("SMS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.StateId)
                .HasColumnName("STATE_ID")
                .IsUnicode(false);

            entity.Property(e => e.Subsidiary)
                .HasColumnName("SUBSIDIARY")
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WebPage)
                .HasColumnName("WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.XaccName)
                .HasColumnName("XACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XaccdisplayName)
                .HasColumnName("XACCDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XaccenvelopeGreeting)
                .HasColumnName("XACCENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XaccfirstName)
                .HasColumnName("XACCFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XacclanguageDesc)
                .HasColumnName("XACCLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Xaccsalutation)
                .HasColumnName("XACCSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Xacctitle)
                .HasColumnName("XACCTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .IsUnicode(false);
        });
	}
}

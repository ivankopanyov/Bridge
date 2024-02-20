namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfiles
{
    public StageProfiles()
    {
        StageProfileErrors = new HashSet<StageProfileErrors>();
        StageProfileKeywords = new HashSet<StageProfileKeywords>();
        StageProfileMatches = new HashSet<StageProfileMatches>();
        StageProfileMemberships = new HashSet<StageProfileMemberships>();
        StageProfilePhones = new HashSet<StageProfilePhones>();
        StageProfileUdfs = new HashSet<StageProfileUdfs>();
    }

    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? NameType { get; set; }
    public string? NameId { get; set; }
    public string? NameCode { get; set; }
    public string? Prefix { get; set; }
    public string? Last { get; set; }
    public string? First { get; set; }
    public string? Title { get; set; }
    public string? Nameordered { get; set; }
    public string? Company { get; set; }
    public string? LastUl { get; set; }
    public string? FirstUl { get; set; }
    public string? CompanyUl { get; set; }
    public string? GenderMf { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Version { get; set; }
    public string? Consortiumcode { get; set; }
    public string? Commissionplancode { get; set; }
    public string? Preferredrateplancode { get; set; }
    public string? Preferredroomtype { get; set; }
    public string? Corporateposition { get; set; }
    public string? Pin { get; set; }
    public string? PassportNo { get; set; }
    public string? Nationality { get; set; }
    public DateTime? Birthday { get; set; }
    public string? PrimaryLanguage { get; set; }
    public string? Alternatelanguageids { get; set; }
    public string? VipStatus { get; set; }
    public string? ArNumber { get; set; }
    public string? MasterAccount { get; set; }
    public string? Blacklist { get; set; }
    public string? BlkListMessage { get; set; }
    public string? Occupation { get; set; }
    public string? ContactLast { get; set; }
    public string? ContactFirst { get; set; }
    public string? StageStatus { get; set; }
    public string? StageErrorDesc { get; set; }
    public string? StageSuspenseReason { get; set; }
    public DateTime? ImportDate { get; set; }
    public string? ImportNever { get; set; }
    public string? ImportWhenBlank { get; set; }
    public string? MatchStatus { get; set; }
    public string? GuestPrivYn { get; set; }
    public string? EmailYn { get; set; }
    public string? MailYn { get; set; }
    public string? CommissionCurrencyCode { get; set; }
    public string? PassiveYn { get; set; }
    public string? Firma { get; set; }
    public string? FirmaUl { get; set; }
    public string? Region { get; set; }
    public string? ResortCountry { get; set; }
    public string? ResortComment { get; set; }
    public string? InterfaceId { get; set; }
    public string? Xlast { get; set; }
    public string? Xfirst { get; set; }
    public string? Xcompany { get; set; }
    public string? Xtitle { get; set; }
    public string? Xsalutation { get; set; }
    public string? ContactYn { get; set; }
    public decimal? CompanyContactId { get; set; }
    public string? BirthPlace { get; set; }
    public string? Protected { get; set; }
    public string? SmsYn { get; set; }
    public string? Middle { get; set; }
    public string? IncognitoName { get; set; }
    public string? IncognitoFirst { get; set; }
    public string? PhoneYn { get; set; }
    public decimal? TitleSuffix { get; set; }
    public string? BusinessTitle { get; set; }
    public string? Accountsource { get; set; }
    public string? Markets { get; set; }
    public string? Priority { get; set; }
    public string? IndustryCode { get; set; }
    public string? RoomsPotential { get; set; }
    public string? AccountType { get; set; }
    public string? IdType { get; set; }
    public string? MfIdNumber { get; set; }
    public string? MfIdPlace { get; set; }
    public string? MfIdCountry { get; set; }
    public DateTime? MfIdDate { get; set; }
    public string? PseudoYn { get; set; }
    public string? MiniYn { get; set; }
    public string? CreditRating { get; set; }
    public string? Scope { get; set; }
    public string? ScopeCity { get; set; }
    public string? CompetitionCode { get; set; }
    public string? Influence { get; set; }
    public string? HistoryYn { get; set; }
    public string? MarketResearchYn { get; set; }
    public string? ThirdPartyYn { get; set; }
    public string? AutoenrollMemberYn { get; set; }
    public string? Actioncode { get; set; }
    public string? TaxType { get; set; }
    public string? TaxId { get; set; }
    public string? ReplaceAddress { get; set; }
    public string? AcctContact { get; set; }
    public string? Department { get; set; }
    public string? Territory { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? ValidYn { get; set; }
    public string? BirthDateStr { get; set; }

    public virtual ICollection<StageProfileErrors> StageProfileErrors { get; set; }
    public virtual ICollection<StageProfileKeywords> StageProfileKeywords { get; set; }
    public virtual ICollection<StageProfileMatches> StageProfileMatches { get; set; }
    public virtual ICollection<StageProfileMemberships> StageProfileMemberships { get; set; }
    public virtual ICollection<StageProfilePhones> StageProfilePhones { get; set; }
    public virtual ICollection<StageProfileUdfs> StageProfileUdfs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfiles>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILES_PK");

            entity.ToTable("STAGE_PROFILES");

            entity.HasIndex(e => e.Region)
                .HasName("STAGE_PROFILES_IND2");

            entity.HasIndex(e => e.ResortCountry)
                .HasName("STAGE_PROFILES_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accountsource)
                .HasColumnName("ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Alternatelanguageids)
                .HasColumnName("ALTERNATELANGUAGEIDS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.AutoenrollMemberYn)
                .HasColumnName("AUTOENROLL_MEMBER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BirthDateStr)
                .HasColumnName("BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Birthday)
                .HasColumnName("BIRTHDAY")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Blacklist)
                .HasColumnName("BLACKLIST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlkListMessage)
                .HasColumnName("BLK_LIST_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCurrencyCode)
                .HasColumnName("COMMISSION_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Commissionplancode)
                .HasColumnName("COMMISSIONPLANCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyUl)
                .HasColumnName("COMPANY_UL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Consortiumcode)
                .HasColumnName("CONSORTIUMCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasColumnName("CONTACT_FIRST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast)
                .HasColumnName("CONTACT_LAST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Corporateposition)
                .HasColumnName("CORPORATEPOSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CreditRating)
                .HasColumnName("CREDIT_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Department)
                .HasColumnName("DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Firma)
                .HasColumnName("FIRMA")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirmaUl)
                .HasColumnName("FIRMA_UL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstUl)
                .HasColumnName("FIRST_UL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GenderMf)
                .HasColumnName("GENDER_MF")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportNever)
                .HasColumnName("IMPORT_NEVER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ImportWhenBlank)
                .HasColumnName("IMPORT_WHEN_BLANK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncognitoFirst)
                .HasColumnName("INCOGNITO_FIRST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IncognitoName)
                .HasColumnName("INCOGNITO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Influence)
                .HasColumnName("INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastUl)
                .HasColumnName("LAST_UL")
                .HasMaxLength(40)
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

            entity.Property(e => e.MasterAccount)
                .HasColumnName("MASTER_ACCOUNT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MatchStatus)
                .HasColumnName("MATCH_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MfIdCountry)
                .HasColumnName("MF_ID_COUNTRY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MfIdDate)
                .HasColumnName("MF_ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MfIdNumber)
                .HasColumnName("MF_ID_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MfIdPlace)
                .HasColumnName("MF_ID_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MiniYn)
                .HasColumnName("MINI_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nameordered)
                .HasColumnName("NAMEORDERED")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Occupation)
                .HasColumnName("OCCUPATION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PassiveYn)
                .HasColumnName("PASSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PassportNo)
                .HasColumnName("PASSPORT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Pin)
                .HasColumnName("PIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Preferredrateplancode)
                .HasColumnName("PREFERREDRATEPLANCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Preferredroomtype)
                .HasColumnName("PREFERREDROOMTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Prefix)
                .HasColumnName("PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryLanguage)
                .HasColumnName("PRIMARY_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Protected)
                .HasColumnName("PROTECTED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReplaceAddress)
                .HasColumnName("REPLACE_ADDRESS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortComment)
                .HasColumnName("RESORT_COMMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResortCountry)
                .HasColumnName("RESORT_COUNTRY")
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

            entity.Property(e => e.StageErrorDesc)
                .HasColumnName("STAGE_ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StageStatus)
                .HasColumnName("STAGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StageSuspenseReason)
                .HasColumnName("STAGE_SUSPENSE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TitleSuffix)
                .HasColumnName("TITLE_SUFFIX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Xcompany)
                .HasColumnName("XCOMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Xfirst)
                .HasColumnName("XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlast)
                .HasColumnName("XLAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(StageProfileErrors)))
				entity.Ignore(e => e.StageProfileErrors);

			if (!types.Contains(typeof(StageProfileKeywords)))
				entity.Ignore(e => e.StageProfileKeywords);

			if (!types.Contains(typeof(StageProfileMatches)))
				entity.Ignore(e => e.StageProfileMatches);

			if (!types.Contains(typeof(StageProfileMemberships)))
				entity.Ignore(e => e.StageProfileMemberships);

			if (!types.Contains(typeof(StageProfilePhones)))
				entity.Ignore(e => e.StageProfilePhones);

			if (!types.Contains(typeof(StageProfileUdfs)))
				entity.Ignore(e => e.StageProfileUdfs);
		});
	}
}

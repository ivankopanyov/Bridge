namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeProfiles
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? ProfileType { get; set; }
    public string? Country { get; set; }
    public string? NameTaxType { get; set; }
    public decimal? MembershipId { get; set; }
    public string? IataCorpNo { get; set; }
    public string? Name { get; set; }
    public string? LegalCompany { get; set; }
    public string? Language { get; set; }
    public string? IsoLanguage { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? IndexName { get; set; }
    public string? Title { get; set; }
    public string? BusinessTitle { get; set; }
    public string? Salutation { get; set; }
    public string? Nickname { get; set; }
    public string? Nationality { get; set; }
    public string? Priority { get; set; }
    public string? CurrencyCode { get; set; }
    public string? HoldCode { get; set; }
    public string? CommissionCode { get; set; }
    public string? TaxOffice { get; set; }
    public string? TaxType { get; set; }
    public string? TaxCategory { get; set; }
    public string? CreditRating { get; set; }
    public string? CblInd { get; set; }
    public string? SummRefCc { get; set; }
    public string? TourOperatorType { get; set; }
    public string? Region { get; set; }
    public string? RegionDescription { get; set; }
    public string? BillingProfileCode { get; set; }
    public string? GdsName { get; set; }
    public string? ContractNo { get; set; }
    public DateTime? ContractRecvDate { get; set; }
    public string? HistoryYn { get; set; }
    public string? VipStatus { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? InactiveReason { get; set; }
    public string? MasterAccountYn { get; set; }
    public string? MailList { get; set; }
    public string? MailType { get; set; }
    public string? AvailoverYn { get; set; }
    public string? BlMsg { get; set; }
    public string? IdType { get; set; }
    public string? IdTypeMapped { get; set; }
    public string? IdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public string? BirthPlace { get; set; }
    public string? BirthCountry { get; set; }
    public string? Profession { get; set; }
    public string? Passport { get; set; }
    public string? VisaNumber { get; set; }
    public string? IndustryCode { get; set; }
    public string? IndustryDesc { get; set; }
    public string? Interest { get; set; }
    public string? VehicleRegistration { get; set; }
    public string? Gender { get; set; }
    public string? ProfilePrivacyFlg { get; set; }
    public string? GuestPrivYn { get; set; }
    public string? PhoneYn { get; set; }
    public string? SmsYn { get; set; }
    public string? EmailYn { get; set; }
    public string? MailYn { get; set; }
    public string? MarketResearchYn { get; set; }
    public string? ThirdPartyYn { get; set; }
    public string? AutoenrollMemberYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Comm1Id { get; set; }
    public string? Comm1Type { get; set; }
    public string? Comm1Value { get; set; }
    public string? Comm1Desc { get; set; }
    public string? Comm2Id { get; set; }
    public string? Comm2Type { get; set; }
    public string? Comm2Value { get; set; }
    public string? Comm2Desc { get; set; }
    public string? Comm3Id { get; set; }
    public string? Comm3Type { get; set; }
    public string? Comm3Value { get; set; }
    public string? Comm3Desc { get; set; }
    public string? SrepCode { get; set; }
    public string? Territory { get; set; }
    public string? Keyword { get; set; }
    public string? ArNo { get; set; }
    public string? AcctContact { get; set; }
    public string? AccountType { get; set; }
    public string? Tax1No { get; set; }
    public string? PreferredRoomNo { get; set; }
    public string? CrsNameid { get; set; }
    public string? ChainCode { get; set; }
    public string? CompanyGroupId { get; set; }
    public string? IataCompType { get; set; }
    public string? IataConsortia { get; set; }
    public string? RoomsPotential { get; set; }
    public string? CompetitionCode { get; set; }
    public string? Scope { get; set; }
    public string? ScopeCity { get; set; }
    public string? VaComp { get; set; }
    public string? HasPreferenceYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeProfiles>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_PROFILES");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AutoenrollMemberYn)
                .HasColumnName("AUTOENROLL_MEMBER_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AvailoverYn)
                .HasColumnName("AVAILOVER_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingProfileCode)
                .HasColumnName("BILLING_PROFILE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BlMsg)
                .HasColumnName("BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CblInd)
                .HasColumnName("CBL_IND")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm1Desc)
                .HasColumnName("COMM1_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm1Id)
                .HasColumnName("COMM1_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm1Type)
                .HasColumnName("COMM1_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm1Value)
                .HasColumnName("COMM1_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Comm2Desc)
                .HasColumnName("COMM2_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm2Id)
                .HasColumnName("COMM2_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm2Type)
                .HasColumnName("COMM2_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm2Value)
                .HasColumnName("COMM2_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Comm3Desc)
                .HasColumnName("COMM3_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm3Id)
                .HasColumnName("COMM3_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm3Type)
                .HasColumnName("COMM3_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comm3Value)
                .HasColumnName("COMM3_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupId)
                .HasColumnName("COMPANY_GROUP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContractNo)
                .HasColumnName("CONTRACT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContractRecvDate)
                .HasColumnName("CONTRACT_RECV_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditRating)
                .HasColumnName("CREDIT_RATING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CrsNameid)
                .HasColumnName("CRS_NAMEID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GdsName)
                .HasColumnName("GDS_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HasPreferenceYn)
                .HasColumnName("HAS_PREFERENCE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IataConsortia)
                .HasColumnName("IATA_CONSORTIA")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdTypeMapped)
                .HasColumnName("ID_TYPE_MAPPED")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveReason)
                .HasColumnName("INACTIVE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IndexName)
                .HasColumnName("INDEX_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IndustryDesc)
                .HasColumnName("INDUSTRY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Interest)
                .HasColumnName("INTEREST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IsoLanguage)
                .HasColumnName("ISO_LANGUAGE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MailType)
                .HasColumnName("MAIL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchYn)
                .HasColumnName("MARKET_RESEARCH_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MasterAccountYn)
                .HasColumnName("MASTER_ACCOUNT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nickname)
                .HasColumnName("NICKNAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoomNo)
                .HasColumnName("PREFERRED_ROOM_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProfilePrivacyFlg)
                .HasColumnName("PROFILE_PRIVACY_FLG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RegionDescription)
                .HasColumnName("REGION_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ScopeCity)
                .HasColumnName("SCOPE_CITY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SmsYn)
                .HasColumnName("SMS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SummRefCc)
                .HasColumnName("SUMM_REF_CC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxCategory)
                .HasColumnName("TAX_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxOffice)
                .HasColumnName("TAX_OFFICE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TourOperatorType)
                .HasColumnName("TOUR_OPERATOR_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VaComp)
                .HasColumnName("VA_COMP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VehicleRegistration)
                .HasColumnName("VEHICLE_REGISTRATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VisaNumber)
                .HasColumnName("VISA_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberStatementExpMemVw
{
    public decimal StatementBatchId { get; set; }
    public DateTime StatementDate { get; set; }
    public DateTime PeriodEnding { get; set; }
    public string StatementHdrMemType { get; set; }
    public string StatementHdrStatus { get; set; }
    public string PrintIfNull { get; set; }
    public string IncludeIfNull { get; set; }
    public string LockStatement { get; set; }
    public decimal? AwPointsAbove { get; set; }
    public decimal? AwPointsBelow { get; set; }
    public string StatementHdrMemLevel { get; set; }
    public decimal? NoOfMembersIncluded { get; set; }
    public decimal? NoOfTrxIncluded { get; set; }
    public string StatementHdrErrorLog { get; set; }
    public string StatementHdrNotes { get; set; }
    public decimal MemberStatementId { get; set; }
    public decimal MembershipId { get; set; }
    public string PrintYn { get; set; }
    public string StatementDetStatus { get; set; }
    public decimal? OpeningBalance { get; set; }
    public decimal? StCreditPoints { get; set; }
    public decimal? StDebitPoints { get; set; }
    public decimal? ClosingBalance { get; set; }
    public decimal? StAwardsConsumed { get; set; }
    public decimal? YtdCreditPoints { get; set; }
    public decimal? YtdDebitPoints { get; set; }
    public decimal? YtdAwardsConsumed { get; set; }
    public decimal? TotalCreditPoints { get; set; }
    public decimal? TotalDebitPoints { get; set; }
    public decimal? TotalAwardsConsumed { get; set; }
    public decimal? StNoRecords { get; set; }
    public decimal? StStayPoints { get; set; }
    public decimal? StNightPoints { get; set; }
    public decimal? StRevenuePoints { get; set; }
    public decimal? YtdStayPoints { get; set; }
    public decimal? YtdNightPoints { get; set; }
    public decimal? YtdRevenuePoints { get; set; }
    public decimal? TotalStayPoints { get; set; }
    public decimal? TotalNightPoints { get; set; }
    public decimal? TotalRevenuePoints { get; set; }
    public decimal? StNameId { get; set; }
    public string StMembershipCardNo { get; set; }
    public string StMembershipLevel { get; set; }
    public string StDisplayName { get; set; }
    public string UserKeyword { get; set; }
    public string StatementDetNotes { get; set; }
    public string StatementDetErrorLog { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public string NameOnCard { get; set; }
    public string Comments { get; set; }
    public DateTime? JoinedDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string MemberIndicator { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string EnrollmentCode { get; set; }
    public string GracePeriodIndicator { get; set; }
    public string MembershipStatus { get; set; }
    public decimal? PointsAvailable { get; set; }
    public string PrimaryMembershipYn { get; set; }
    public string CentralSetupYn { get; set; }
    public string MembershipClass { get; set; }
    public string CalculationMethod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? ExpirationMonth { get; set; }
    public decimal? CardValidYears { get; set; }
    public decimal? YearsToExpire { get; set; }
    public string ExpirationDateRequired { get; set; }
    public string LevelRequired { get; set; }
    public string AwardGenerationMethod { get; set; }
    public decimal? BatchDelayPeriod { get; set; }
    public string SdUdfc01 { get; set; }
    public string SdUdfc02 { get; set; }
    public string SdUdfc03 { get; set; }
    public string SdUdfc04 { get; set; }
    public string SdUdfc05 { get; set; }
    public string SdUdfc06 { get; set; }
    public string SdUdfc07 { get; set; }
    public string SdUdfc08 { get; set; }
    public string SdUdfc09 { get; set; }
    public string SdUdfc10 { get; set; }
    public string SdUdfc11 { get; set; }
    public string SdUdfc12 { get; set; }
    public string SdUdfc13 { get; set; }
    public string SdUdfc14 { get; set; }
    public string SdUdfc15 { get; set; }
    public string SdUdfc16 { get; set; }
    public string SdUdfc17 { get; set; }
    public string SdUdfc18 { get; set; }
    public string SdUdfc19 { get; set; }
    public string SdUdfc20 { get; set; }
    public DateTime? SdUdfd01 { get; set; }
    public DateTime? SdUdfd02 { get; set; }
    public DateTime? SdUdfd03 { get; set; }
    public DateTime? SdUdfd04 { get; set; }
    public DateTime? SdUdfd05 { get; set; }
    public DateTime? SdUdfd06 { get; set; }
    public DateTime? SdUdfd07 { get; set; }
    public DateTime? SdUdfd08 { get; set; }
    public DateTime? SdUdfd09 { get; set; }
    public DateTime? SdUdfd10 { get; set; }
    public decimal? SdUdfn01 { get; set; }
    public decimal? SdUdfn02 { get; set; }
    public decimal? SdUdfn03 { get; set; }
    public decimal? SdUdfn04 { get; set; }
    public decimal? SdUdfn05 { get; set; }
    public decimal? SdUdfn06 { get; set; }
    public decimal? SdUdfn07 { get; set; }
    public decimal? SdUdfn08 { get; set; }
    public decimal? SdUdfn09 { get; set; }
    public decimal? SdUdfn10 { get; set; }
    public decimal? SdUdfn11 { get; set; }
    public decimal? SdUdfn12 { get; set; }
    public decimal? SdUdfn13 { get; set; }
    public decimal? SdUdfn14 { get; set; }
    public decimal? SdUdfn15 { get; set; }
    public decimal? SdUdfn16 { get; set; }
    public decimal? SdUdfn17 { get; set; }
    public decimal? SdUdfn18 { get; set; }
    public decimal? SdUdfn19 { get; set; }
    public decimal? SdUdfn20 { get; set; }
    public string Name { get; set; }
    public string First { get; set; }
    public string Middle { get; set; }
    public string DisplayName { get; set; }
    public string Salutation { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string Sname { get; set; }
    public string Sfirst { get; set; }
    public string NameType { get; set; }
    public string NameTypeDesc { get; set; }
    public string Title { get; set; }
    public string TitleName { get; set; }
    public string Position { get; set; }
    public string Profession { get; set; }
    public string LegalCompany { get; set; }
    public string ContactYn { get; set; }
    public string Street1 { get; set; }
    public string Street2 { get; set; }
    public string Street3 { get; set; }
    public string Street4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string StateDesc { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public string Zip { get; set; }
    public string CityExt { get; set; }
    public string AddrLanguageCode { get; set; }
    public string AddrLanguageDesc { get; set; }
    public string Addressindicator { get; set; }
    public string AddressTypeDesc { get; set; }
    public decimal? AddressId { get; set; }
    public string Preferredlanguage { get; set; }
    public string LanguageDesc { get; set; }
    public string Company { get; set; }
    public string Altname { get; set; }
    public string Altfirst { get; set; }
    public string Altlanguage { get; set; }
    public string Alttitle { get; set; }
    public string Altsalution { get; set; }
    public string Addresslanguage { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string XdisplayName { get; set; }
    public string XlanguageDesc { get; set; }
    public string Mailblock { get; set; }
    public string Passport { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Nationality { get; set; }
    public string NationalityDesc { get; set; }
    public decimal? PhoneId { get; set; }
    public string PhoneNo { get; set; }
    public string PhoneType { get; set; }
    public decimal? FaxId { get; set; }
    public string FaxNo { get; set; }
    public decimal? EmailId { get; set; }
    public string Email { get; set; }
    public decimal? HomePhoneId { get; set; }
    public string HomePhoneNumber { get; set; }
    public decimal? BusinessPhoneId { get; set; }
    public string BusinessPhoneNumber { get; set; }
    public decimal? MobilePhoneId { get; set; }
    public string MobilePhoneNumber { get; set; }
    public decimal? WebPageId { get; set; }
    public string WebPage { get; set; }
    public string ActiveYn { get; set; }
    public string HistoryYn { get; set; }
    public string AcctContact { get; set; }
    public string CblInd { get; set; }
    public string BlMsg { get; set; }
    public string VipStatus { get; set; }
    public string VipName { get; set; }
    public string ArNo { get; set; }
    public string IataCorpNo { get; set; }
    public string IataCompType { get; set; }
    public string NameKeywords { get; set; }
    public string Gender { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public decimal? CreditCardId { get; set; }
    public string CreditCardType { get; set; }
    public string CreditCardNumber { get; set; }
    public string CreditCardName { get; set; }
    public DateTime? CreditCardExpirationDate { get; set; }
    public DateTime? ProfileInactiveDate { get; set; }
    public string EnvelopeGreeting { get; set; }
    public string XenvelopeGreeting { get; set; }
    public string EmailYn { get; set; }
    public string PhoneYn { get; set; }
    public string SmsYn { get; set; }
    public string Protected { get; set; }
    public string Udfc01 { get; set; }
    public string Udfc02 { get; set; }
    public string Udfc03 { get; set; }
    public string Udfc04 { get; set; }
    public string Udfc05 { get; set; }
    public string Udfc06 { get; set; }
    public string Udfc07 { get; set; }
    public string Udfc08 { get; set; }
    public string Udfc09 { get; set; }
    public string Udfc10 { get; set; }
    public string Udfc11 { get; set; }
    public string Udfc12 { get; set; }
    public string Udfc13 { get; set; }
    public string Udfc14 { get; set; }
    public string Udfc15 { get; set; }
    public string Udfc16 { get; set; }
    public string Udfc17 { get; set; }
    public string Udfc18 { get; set; }
    public string Udfc19 { get; set; }
    public string Udfc20 { get; set; }
    public string Udfc21 { get; set; }
    public string Udfc22 { get; set; }
    public string Udfc23 { get; set; }
    public string Udfc24 { get; set; }
    public string Udfc25 { get; set; }
    public string Udfc26 { get; set; }
    public string Udfc27 { get; set; }
    public string Udfc28 { get; set; }
    public string Udfc29 { get; set; }
    public string Udfc30 { get; set; }
    public string Udfc31 { get; set; }
    public string Udfc32 { get; set; }
    public string Udfc33 { get; set; }
    public string Udfc34 { get; set; }
    public string Udfc35 { get; set; }
    public string Udfc36 { get; set; }
    public string Udfc37 { get; set; }
    public string Udfc38 { get; set; }
    public string Udfc39 { get; set; }
    public string Udfc40 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public decimal? Udfn16 { get; set; }
    public decimal? Udfn17 { get; set; }
    public decimal? Udfn18 { get; set; }
    public decimal? Udfn19 { get; set; }
    public decimal? Udfn20 { get; set; }
    public decimal? Udfn21 { get; set; }
    public decimal? Udfn22 { get; set; }
    public decimal? Udfn23 { get; set; }
    public decimal? Udfn24 { get; set; }
    public decimal? Udfn25 { get; set; }
    public decimal? Udfn26 { get; set; }
    public decimal? Udfn27 { get; set; }
    public decimal? Udfn28 { get; set; }
    public decimal? Udfn29 { get; set; }
    public decimal? Udfn30 { get; set; }
    public decimal? Udfn31 { get; set; }
    public decimal? Udfn32 { get; set; }
    public decimal? Udfn33 { get; set; }
    public decimal? Udfn34 { get; set; }
    public decimal? Udfn35 { get; set; }
    public decimal? Udfn36 { get; set; }
    public decimal? Udfn37 { get; set; }
    public decimal? Udfn38 { get; set; }
    public decimal? Udfn39 { get; set; }
    public decimal? Udfn40 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public DateTime? Udfd11 { get; set; }
    public DateTime? Udfd12 { get; set; }
    public DateTime? Udfd13 { get; set; }
    public DateTime? Udfd14 { get; set; }
    public DateTime? Udfd15 { get; set; }
    public DateTime? Udfd16 { get; set; }
    public DateTime? Udfd17 { get; set; }
    public DateTime? Udfd18 { get; set; }
    public DateTime? Udfd19 { get; set; }
    public DateTime? Udfd20 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberStatementExpMemVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_STATEMENT_EXP_MEM_VW");

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AddrLanguageCode)
                .HasColumnName("ADDR_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddrLanguageDesc)
                .HasColumnName("ADDR_LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressTypeDesc)
                .HasColumnName("ADDRESS_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Addressindicator)
                .HasColumnName("ADDRESSINDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Addresslanguage)
                .HasColumnName("ADDRESSLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Altfirst)
                .HasColumnName("ALTFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Altlanguage)
                .HasColumnName("ALTLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Altname)
                .HasColumnName("ALTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Altsalution)
                .HasColumnName("ALTSALUTION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Alttitle)
                .HasColumnName("ALTTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.AwPointsAbove)
                .HasColumnName("AW_POINTS_ABOVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPointsBelow)
                .HasColumnName("AW_POINTS_BELOW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchDelayPeriod)
                .HasColumnName("BATCH_DELAY_PERIOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BlMsg)
                .HasColumnName("BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessPhoneId)
                .HasColumnName("BUSINESS_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessPhoneNumber)
                .HasColumnName("BUSINESS_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CalculationMethod)
                .HasColumnName("CALCULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CardValidYears)
                .HasColumnName("CARD_VALID_YEARS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CblInd)
                .HasColumnName("CBL_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CentralSetupYn)
                .HasColumnName("CENTRAL_SETUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosingBalance)
                .HasColumnName("CLOSING_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
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

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

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

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpirationDateRequired)
                .HasColumnName("EXPIRATION_DATE_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationMonth)
                .HasColumnName("EXPIRATION_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GracePeriodIndicator)
                .HasColumnName("GRACE_PERIOD_INDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HomePhoneId)
                .HasColumnName("HOME_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HomePhoneNumber)
                .HasColumnName("HOME_PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncludeIfNull)
                .IsRequired()
                .HasColumnName("INCLUDE_IF_NULL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LevelRequired)
                .HasColumnName("LEVEL_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LockStatement)
                .IsRequired()
                .HasColumnName("LOCK_STATEMENT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Mailblock)
                .HasColumnName("MAILBLOCK")
                .IsUnicode(false);

            entity.Property(e => e.MemberIndicator)
                .HasColumnName("MEMBER_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipClass)
                .HasColumnName("MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipStatus)
                .HasColumnName("MEMBERSHIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MobilePhoneId)
                .HasColumnName("MOBILE_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MobilePhoneNumber)
                .HasColumnName("MOBILE_PHONE_NUMBER")
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

            entity.Property(e => e.NameOnCard)
                .IsRequired()
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTypeDesc)
                .HasColumnName("NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NationalityDesc)
                .HasColumnName("NATIONALITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NoOfMembersIncluded)
                .HasColumnName("NO_OF_MEMBERS_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfTrxIncluded)
                .HasColumnName("NO_OF_TRX_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpeningBalance)
                .HasColumnName("OPENING_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PeriodEnding)
                .HasColumnName("PERIOD_ENDING")
                .HasColumnType("DATE");

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsAvailable)
                .HasColumnName("POINTS_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Preferredlanguage)
                .HasColumnName("PREFERREDLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryMembershipYn)
                .HasColumnName("PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintIfNull)
                .IsRequired()
                .HasColumnName("PRINT_IF_NULL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .IsRequired()
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProfileInactiveDate)
                .HasColumnName("PROFILE_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Protected)
                .HasColumnName("PROTECTED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc01)
                .HasColumnName("SD_UDFC01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc02)
                .HasColumnName("SD_UDFC02")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc03)
                .HasColumnName("SD_UDFC03")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc04)
                .HasColumnName("SD_UDFC04")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc05)
                .HasColumnName("SD_UDFC05")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc06)
                .HasColumnName("SD_UDFC06")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc07)
                .HasColumnName("SD_UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc08)
                .HasColumnName("SD_UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc09)
                .HasColumnName("SD_UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc10)
                .HasColumnName("SD_UDFC10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc11)
                .HasColumnName("SD_UDFC11")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc12)
                .HasColumnName("SD_UDFC12")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc13)
                .HasColumnName("SD_UDFC13")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc14)
                .HasColumnName("SD_UDFC14")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc15)
                .HasColumnName("SD_UDFC15")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc16)
                .HasColumnName("SD_UDFC16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc17)
                .HasColumnName("SD_UDFC17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc18)
                .HasColumnName("SD_UDFC18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc19)
                .HasColumnName("SD_UDFC19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfc20)
                .HasColumnName("SD_UDFC20")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SdUdfd01)
                .HasColumnName("SD_UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd02)
                .HasColumnName("SD_UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd03)
                .HasColumnName("SD_UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd04)
                .HasColumnName("SD_UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd05)
                .HasColumnName("SD_UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd06)
                .HasColumnName("SD_UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd07)
                .HasColumnName("SD_UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd08)
                .HasColumnName("SD_UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd09)
                .HasColumnName("SD_UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfd10)
                .HasColumnName("SD_UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.SdUdfn01)
                .HasColumnName("SD_UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn02)
                .HasColumnName("SD_UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn03)
                .HasColumnName("SD_UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn04)
                .HasColumnName("SD_UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn05)
                .HasColumnName("SD_UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn06)
                .HasColumnName("SD_UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn07)
                .HasColumnName("SD_UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn08)
                .HasColumnName("SD_UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn09)
                .HasColumnName("SD_UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn10)
                .HasColumnName("SD_UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn11)
                .HasColumnName("SD_UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn12)
                .HasColumnName("SD_UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn13)
                .HasColumnName("SD_UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn14)
                .HasColumnName("SD_UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn15)
                .HasColumnName("SD_UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn16)
                .HasColumnName("SD_UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn17)
                .HasColumnName("SD_UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn18)
                .HasColumnName("SD_UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn19)
                .HasColumnName("SD_UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SdUdfn20)
                .HasColumnName("SD_UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
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

            entity.Property(e => e.StAwardsConsumed)
                .HasColumnName("ST_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StCreditPoints)
                .HasColumnName("ST_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StDebitPoints)
                .HasColumnName("ST_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StDisplayName)
                .HasColumnName("ST_DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StMembershipCardNo)
                .HasColumnName("ST_MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StMembershipLevel)
                .HasColumnName("ST_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StNameId)
                .HasColumnName("ST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNightPoints)
                .HasColumnName("ST_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNoRecords)
                .HasColumnName("ST_NO_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StRevenuePoints)
                .HasColumnName("ST_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StStayPoints)
                .HasColumnName("ST_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementDate)
                .HasColumnName("STATEMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatementDetErrorLog)
                .HasColumnName("STATEMENT_DET_ERROR_LOG")
                .IsUnicode(false);

            entity.Property(e => e.StatementDetNotes)
                .HasColumnName("STATEMENT_DET_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.StatementDetStatus)
                .IsRequired()
                .HasColumnName("STATEMENT_DET_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementHdrErrorLog)
                .HasColumnName("STATEMENT_HDR_ERROR_LOG")
                .IsUnicode(false);

            entity.Property(e => e.StatementHdrMemLevel)
                .HasColumnName("STATEMENT_HDR_MEM_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementHdrMemType)
                .IsRequired()
                .HasColumnName("STATEMENT_HDR_MEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementHdrNotes)
                .HasColumnName("STATEMENT_HDR_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.StatementHdrStatus)
                .IsRequired()
                .HasColumnName("STATEMENT_HDR_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Street1)
                .HasColumnName("STREET1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Street2)
                .HasColumnName("STREET2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Street3)
                .HasColumnName("STREET3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Street4)
                .HasColumnName("STREET4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TitleName)
                .HasColumnName("TITLE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TotalAwardsConsumed)
                .HasColumnName("TOTAL_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCreditPoints)
                .HasColumnName("TOTAL_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDebitPoints)
                .HasColumnName("TOTAL_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNightPoints)
                .HasColumnName("TOTAL_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenuePoints)
                .HasColumnName("TOTAL_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayPoints)
                .HasColumnName("TOTAL_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserKeyword)
                .HasColumnName("USER_KEYWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VipName)
                .HasColumnName("VIP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebPage)
                .HasColumnName("WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.WebPageId)
                .HasColumnName("WEB_PAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XlanguageDesc)
                .HasColumnName("XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.YearsToExpire)
                .HasColumnName("YEARS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdAwardsConsumed)
                .HasColumnName("YTD_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdCreditPoints)
                .HasColumnName("YTD_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdDebitPoints)
                .HasColumnName("YTD_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdNightPoints)
                .HasColumnName("YTD_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdRevenuePoints)
                .HasColumnName("YTD_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdStayPoints)
                .HasColumnName("YTD_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

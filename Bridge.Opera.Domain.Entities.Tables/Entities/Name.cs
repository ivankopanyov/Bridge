namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Name
{
    public Name()
    {
        AllotmentHeaderAgentName = new HashSet<AllotmentHeader>();
        AllotmentHeaderCompanyName = new HashSet<AllotmentHeader>();
        AllotmentHeaderMasterName = new HashSet<AllotmentHeader>();
        AllotmentHeaderSourceName = new HashSet<AllotmentHeader>();
        ApplicationUser = new HashSet<ApplicationUser>();
        ArAccount = new HashSet<ArAccount>();
        BookOwner = new HashSet<BookOwner>();
        BookingAttendees = new HashSet<BookingAttendees>();
        BusinessProfileLink = new HashSet<BusinessProfileLink>();
        BusinessProfileOwner = new HashSet<BusinessProfileOwner>();
        CommissionPayments = new HashSet<CommissionPayments>();
        ComputedCommissions = new HashSet<ComputedCommissions>();
        EventRegisteredAttendees = new HashSet<EventRegisteredAttendees>();
        GemItemVendor = new HashSet<GemItemVendor>();
        GemMenuitemVendor = new HashSet<GemMenuitemVendor>();
        Memberships = new HashSet<Memberships>();
        NameAddress = new HashSet<NameAddress>();
        NameCreditCard = new HashSet<NameCreditCard>();
        NameDocuments = new HashSet<NameDocuments>();
        NameGoal = new HashSet<NameGoal>();
        NameLoyaltySegments = new HashSet<NameLoyaltySegments>();
        NameNotes = new HashSet<NameNotes>();
        NameNotifications = new HashSet<NameNotifications>();
        NameOwner = new HashSet<NameOwner>();
        NamePhone = new HashSet<NamePhone>();
        NameResort = new HashSet<NameResort>();
        NameXrefName = new HashSet<NameXref>();
        NameXrefRelationToName = new HashSet<NameXref>();
        OvosOwnersUsers = new HashSet<OvosOwnersUsers>();
        ReservationConfLetter = new HashSet<ReservationConfLetter>();
        ReservationName = new HashSet<ReservationName>();
        Resort = new HashSet<Resort>();
        StayRecordHistory = new HashSet<StayRecordHistory>();
        TrackitItems = new HashSet<TrackitItems>();
        TrxRoutingInstructions = new HashSet<TrxRoutingInstructions>();
        YmNameAdjustments = new HashSet<YmNameAdjustments>();
    }

    public decimal NameId { get; set; }
    public string NameCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? PrimaryNameId { get; set; }
    public string RepeatGuestId { get; set; }
    public string MailList { get; set; }
    public string MailType { get; set; }
    public string FollowOn { get; set; }
    public string BusinessTitle { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? ArcUpdateDate { get; set; }
    public DateTime? UpdateFaxDate { get; set; }
    public DateTime? BirthDate { get; set; }
    public decimal? CollectionUserId { get; set; }
    public string Company { get; set; }
    public string SoundExCompany { get; set; }
    public string LegalCompany { get; set; }
    public string First { get; set; }
    public string Middle { get; set; }
    public string Last { get; set; }
    public string Nickname { get; set; }
    public string Title { get; set; }
    public string SoundExLast { get; set; }
    public string ExternalReferenceRequ { get; set; }
    public string VipStatus { get; set; }
    public string VipAuthorization { get; set; }
    public string BillingProfileCode { get; set; }
    public string RateStructure { get; set; }
    public string NameComment { get; set; }
    public string TourOperatorType { get; set; }
    public string Region { get; set; }
    public string TypeOf1099 { get; set; }
    public string Tax1No { get; set; }
    public decimal? CompanyNameId { get; set; }
    public string ExternalReferenceRequired { get; set; }
    public decimal? VendorId { get; set; }
    public decimal? VendorSiteId { get; set; }
    public string ArcOfficeType { get; set; }
    public string Tax2No { get; set; }
    public string ArcMailFlag { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string Salesrep { get; set; }
    public string Tracecode { get; set; }
    public string GeographicRegion { get; set; }
    public string GuestClassification { get; set; }
    public decimal? PrimaryAddressId { get; set; }
    public decimal? PrimaryPhoneId { get; set; }
    public string TaxExemptStatus { get; set; }
    public string GdsName { get; set; }
    public string GdsTransactionNo { get; set; }
    public string Nationality { get; set; }
    public string Language { get; set; }
    public string Salutation { get; set; }
    public string Passport { get; set; }
    public string HistoryYn { get; set; }
    public string ResvContact { get; set; }
    public string ContractNo { get; set; }
    public DateTime? ContractRecvDate { get; set; }
    public string AcctContact { get; set; }
    public string Priority { get; set; }
    public string IndustryCode { get; set; }
    public string RoomsPotential { get; set; }
    public string CompetitionCode { get; set; }
    public string Scope { get; set; }
    public string ScopeCity { get; set; }
    public string Territory { get; set; }
    public string Actioncode { get; set; }
    public string ActiveYn { get; set; }
    public string MasterAccountYn { get; set; }
    public string NameType { get; set; }
    public string Sname { get; set; }
    public string NameTaxType { get; set; }
    public string Sfirst { get; set; }
    public string ArNo { get; set; }
    public string AvailabilityOverride { get; set; }
    public string BillingCode { get; set; }
    public string CashBlInd { get; set; }
    public string BlMsg { get; set; }
    public string CurrencyCode { get; set; }
    public string CommissionCode { get; set; }
    public string HoldCode { get; set; }
    public string Interest { get; set; }
    public string SummRefCc { get; set; }
    public string IataCompType { get; set; }
    public string SrepCode { get; set; }
    public string Accountsource { get; set; }
    public string Markets { get; set; }
    public string ProductInterest { get; set; }
    public string Keyword { get; set; }
    public string LetterGreeting { get; set; }
    public string Influence { get; set; }
    public string DeptId { get; set; }
    public string Department { get; set; }
    public string ContactYn { get; set; }
    public string AccountType { get; set; }
    public string DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? DownloadDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? CrsNameid { get; set; }
    public string CommPayCentral { get; set; }
    public string CcProfileYn { get; set; }
    public string Gender { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public string Profession { get; set; }
    public string IdType { get; set; }
    public string IdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string IdPlace { get; set; }
    public string IdCountry { get; set; }
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
    public decimal? PaymentDueDays { get; set; }
    public string Suffix { get; set; }
    public string ExternalId { get; set; }
    public string GuestPrivYn { get; set; }
    public string EmailYn { get; set; }
    public string MailYn { get; set; }
    public string IndexName { get; set; }
    public string XlastName { get; set; }
    public string XfirstName { get; set; }
    public string XcompanyName { get; set; }
    public string Xtitle { get; set; }
    public string Xsalutation { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string LastUpdatedResort { get; set; }
    public string EnvelopeGreeting { get; set; }
    public string XenvelopeGreeting { get; set; }
    public string DirectBillBatchType { get; set; }
    public string ResortRegistered { get; set; }
    public string TaxOffice { get; set; }
    public string TaxType { get; set; }
    public string TaxCategory { get; set; }
    public string PreferredRoomNo { get; set; }
    public string PhoneYn { get; set; }
    public string SmsYn { get; set; }
    public string Protected { get; set; }
    public string Xlanguage { get; set; }
    public string MarketResearchYn { get; set; }
    public string ThirdPartyYn { get; set; }
    public string AutoenrollMemberYn { get; set; }
    public string ChainCode { get; set; }
    public string CreditRating { get; set; }
    public decimal? TitleSuffix { get; set; }
    public string CompanyGroupId { get; set; }
    public string InactiveReason { get; set; }
    public string IataConsortia { get; set; }
    public string IncludeIn1099Yn { get; set; }
    public string PsuedoProfileYn { get; set; }
    public string ProfilePrivacyFlg { get; set; }
    public string ReplaceAddress { get; set; }
    public string AlienRegistrationNo { get; set; }
    public string ImmigrationStatus { get; set; }
    public string VisaValidityType { get; set; }
    public decimal? IdDocumentAttachId { get; set; }
    public string SuperSearchIndexText { get; set; }
    public string BirthDateStr { get; set; }
    public decimal? OrigNameId { get; set; }
    public string DOptInMailListFlg { get; set; }
    public string DOptInMarketResearchFlg { get; set; }
    public string DOptInThirdPartyFlg { get; set; }
    public string DOptInAutoenrollMemberFlg { get; set; }
    public string DOptInEmailFlg { get; set; }
    public string DOptInPhoneFlg { get; set; }
    public string DOptInSmsFlg { get; set; }
    public string DOptInGuestPrivFlg { get; set; }
    public string ArCreditLimitYn { get; set; }
    public decimal? ProfileCreditLimit { get; set; }
    public string XmiddleName { get; set; }
    public string EInvoiceLiableYn { get; set; }
    public DateTime? EInvLiableLastUpdated { get; set; }
    public string InternalBillYn { get; set; }

    public virtual BmAccounts BmAccounts { get; set; }
    public virtual ICollection<AllotmentHeader> AllotmentHeaderAgentName { get; set; }
    public virtual ICollection<AllotmentHeader> AllotmentHeaderCompanyName { get; set; }
    public virtual ICollection<AllotmentHeader> AllotmentHeaderMasterName { get; set; }
    public virtual ICollection<AllotmentHeader> AllotmentHeaderSourceName { get; set; }
    public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    public virtual ICollection<ArAccount> ArAccount { get; set; }
    public virtual ICollection<BookOwner> BookOwner { get; set; }
    public virtual ICollection<BookingAttendees> BookingAttendees { get; set; }
    public virtual ICollection<BusinessProfileLink> BusinessProfileLink { get; set; }
    public virtual ICollection<BusinessProfileOwner> BusinessProfileOwner { get; set; }
    public virtual ICollection<CommissionPayments> CommissionPayments { get; set; }
    public virtual ICollection<ComputedCommissions> ComputedCommissions { get; set; }
    public virtual ICollection<EventRegisteredAttendees> EventRegisteredAttendees { get; set; }
    public virtual ICollection<GemItemVendor> GemItemVendor { get; set; }
    public virtual ICollection<GemMenuitemVendor> GemMenuitemVendor { get; set; }
    public virtual ICollection<Memberships> Memberships { get; set; }
    public virtual ICollection<NameAddress> NameAddress { get; set; }
    public virtual ICollection<NameCreditCard> NameCreditCard { get; set; }
    public virtual ICollection<NameDocuments> NameDocuments { get; set; }
    public virtual ICollection<NameGoal> NameGoal { get; set; }
    public virtual ICollection<NameLoyaltySegments> NameLoyaltySegments { get; set; }
    public virtual ICollection<NameNotes> NameNotes { get; set; }
    public virtual ICollection<NameNotifications> NameNotifications { get; set; }
    public virtual ICollection<NameOwner> NameOwner { get; set; }
    public virtual ICollection<NamePhone> NamePhone { get; set; }
    public virtual ICollection<NameResort> NameResort { get; set; }
    public virtual ICollection<NameXref> NameXrefName { get; set; }
    public virtual ICollection<NameXref> NameXrefRelationToName { get; set; }
    public virtual ICollection<OvosOwnersUsers> OvosOwnersUsers { get; set; }
    public virtual ICollection<ReservationConfLetter> ReservationConfLetter { get; set; }
    public virtual ICollection<ReservationName> ReservationName { get; set; }
    public virtual ICollection<Resort> Resort { get; set; }
    public virtual ICollection<StayRecordHistory> StayRecordHistory { get; set; }
    public virtual ICollection<TrackitItems> TrackitItems { get; set; }
    public virtual ICollection<TrxRoutingInstructions> TrxRoutingInstructions { get; set; }
    public virtual ICollection<YmNameAdjustments> YmNameAdjustments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Name>(entity =>
        {
            entity.ToTable("NAME");

            entity.HasIndex(e => e.Company)
                .HasName("NAME_COMPANY_IDX");

            entity.HasIndex(e => e.CompanyGroupId)
                .HasName("COMP_GROUP_ID_NAME_IDX");

            entity.HasIndex(e => e.CrsNameid)
                .HasName("CRS_NAMEID_IDX");

            entity.HasIndex(e => e.DirectBillBatchType)
                .HasName("NAME_DIRECT_BILL_IDX");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("NAME_INACTIVE_DATE_IDX");

            entity.HasIndex(e => e.IndexName)
                .HasName("INDEX_NAME_IDX");

            entity.HasIndex(e => e.Last)
                .HasName("NAME_LAST_IDX");

            entity.HasIndex(e => e.Passport)
                .HasName("NAME_PASSPORT_IND");

            entity.HasIndex(e => e.Sfirst)
                .HasName("SFIRST_IDX");

            entity.HasIndex(e => e.SrepCode)
                .HasName("NAME_SREP_IDX");

            entity.HasIndex(e => e.SxfirstName)
                .HasName("SEARCH_XFIRST_IDX");

            entity.HasIndex(e => new { e.NameCode, e.NameType })
                .HasName("NAME_CODE_IDX");

            entity.HasIndex(e => new { e.Sname, e.Sfirst })
                .HasName("SEARCH_NAME_IDX");

            entity.HasIndex(e => new { e.Sxname, e.SxfirstName })
                .HasName("SEARCH_XNAME_IDX");

            entity.HasIndex(e => new { e.ChainCode, e.NameType, e.Sname, e.Sfirst })
                .HasName("CHAIN_NAME_IDX");

            entity.HasIndex(e => new { e.ContactYn, e.NameType, e.Sname, e.Sfirst })
                .HasName("NAME_CONTACT_YN_IDX");

            entity.HasIndex(e => new { e.ResortRegistered, e.NameType, e.Sname, e.Sfirst })
                .HasName("RESORT_NAME_IDX");

            entity.HasIndex(e => new { e.HistoryYn, e.NameType, e.ContactYn, e.InactiveDate, e.UpdateDate, e.NameId })
                .HasName("NAME_HISTORY_YN_IDX");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Accountsource)
                .HasColumnName("ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlienRegistrationNo)
                .HasColumnName("ALIEN_REGISTRATION_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ArCreditLimitYn)
                .HasColumnName("AR_CREDIT_LIMIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArcMailFlag)
                .HasColumnName("ARC_MAIL_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArcOfficeType)
                .HasColumnName("ARC_OFFICE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArcUpdateDate)
                .HasColumnName("ARC_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AutoenrollMemberYn)
                .HasColumnName("AUTOENROLL_MEMBER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AvailabilityOverride)
                .HasColumnName("AVAILABILITY_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingCode)
                .HasColumnName("BILLING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillingProfileCode)
                .HasColumnName("BILLING_PROFILE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDateStr)
                .HasColumnName("BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BlMsg)
                .HasColumnName("BL_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CashBlInd)
                .HasColumnName("CASH_BL_IND")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcProfileYn)
                .HasColumnName("CC_PROFILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CollectionUserId)
                .HasColumnName("COLLECTION_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommPayCentral)
                .HasColumnName("COMM_PAY_CENTRAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompanyGroupId)
                .HasColumnName("COMPANY_GROUP_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContactYn)
                .IsRequired()
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ContractNo)
                .HasColumnName("CONTRACT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContractRecvDate)
                .HasColumnName("CONTRACT_RECV_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditRating)
                .HasColumnName("CREDIT_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsNameid)
                .HasColumnName("CRS_NAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DOptInAutoenrollMemberFlg)
                .HasColumnName("D_OPT_IN_AUTOENROLL_MEMBER_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInEmailFlg)
                .HasColumnName("D_OPT_IN_EMAIL_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInGuestPrivFlg)
                .HasColumnName("D_OPT_IN_GUEST_PRIV_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInMailListFlg)
                .HasColumnName("D_OPT_IN_MAIL_LIST_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInMarketResearchFlg)
                .HasColumnName("D_OPT_IN_MARKET_RESEARCH_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInPhoneFlg)
                .HasColumnName("D_OPT_IN_PHONE_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInSmsFlg)
                .HasColumnName("D_OPT_IN_SMS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DOptInThirdPartyFlg)
                .HasColumnName("D_OPT_IN_THIRD_PARTY_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Department)
                .HasColumnName("DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DirectBillBatchType)
                .HasColumnName("DIRECT_BILL_BATCH_TYPE")
                .HasMaxLength(40)
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

            entity.Property(e => e.EInvLiableLastUpdated)
                .HasColumnName("E_INV_LIABLE_LAST_UPDATED")
                .HasColumnType("DATE");

            entity.Property(e => e.EInvoiceLiableYn)
                .HasColumnName("E_INVOICE_LIABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalId)
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReferenceRequ)
                .HasColumnName("EXTERNAL_REFERENCE_REQU")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReferenceRequired)
                .HasColumnName("EXTERNAL_REFERENCE_REQUIRED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FollowOn)
                .HasColumnName("FOLLOW_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsName)
                .HasColumnName("GDS_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsTransactionNo)
                .HasColumnName("GDS_TRANSACTION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GeographicRegion)
                .HasColumnName("GEOGRAPHIC_REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestClassification)
                .HasColumnName("GUEST_CLASSIFICATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataConsortia)
                .HasColumnName("IATA_CONSORTIA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdDocumentAttachId)
                .HasColumnName("ID_DOCUMENT_ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImmigrationStatus)
                .HasColumnName("IMMIGRATION_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveReason)
                .HasColumnName("INACTIVE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncludeIn1099Yn)
                .HasColumnName("INCLUDE_IN_1099_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndexName)
                .HasColumnName("INDEX_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Influence)
                .HasColumnName("INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Interest)
                .HasColumnName("INTEREST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InternalBillYn)
                .HasColumnName("INTERNAL_BILL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastUpdatedResort)
                .HasColumnName("LAST_UPDATED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LetterGreeting)
                .HasColumnName("LETTER_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MasterAccountYn)
                .HasColumnName("MASTER_ACCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameComment)
                .HasColumnName("NAME_COMMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nickname)
                .HasColumnName("NICKNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrigNameId)
                .HasColumnName("ORIG_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDueDays)
                .HasColumnName("PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoomNo)
                .HasColumnName("PREFERRED_ROOM_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryAddressId)
                .HasColumnName("PRIMARY_ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryNameId)
                .HasColumnName("PRIMARY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryPhoneId)
                .HasColumnName("PRIMARY_PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductInterest)
                .HasColumnName("PRODUCT_INTEREST")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProfileCreditLimit)
                .HasColumnName("PROFILE_CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfilePrivacyFlg)
                .HasColumnName("PROFILE_PRIVACY_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Protected)
                .HasColumnName("PROTECTED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PsuedoProfileYn)
                .HasColumnName("PSUEDO_PROFILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateStructure)
                .HasColumnName("RATE_STRUCTURE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RepeatGuestId)
                .HasColumnName("REPEAT_GUEST_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReplaceAddress)
                .HasColumnName("REPLACE_ADDRESS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvContact)
                .HasColumnName("RESV_CONTACT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Salesrep)
                .HasColumnName("SALESREP")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScopeCity)
                .HasColumnName("SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmsYn)
                .HasColumnName("SMS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SoundExCompany)
                .HasColumnName("SOUND_EX_COMPANY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SoundExLast)
                .HasColumnName("SOUND_EX_LAST")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Suffix)
                .HasColumnName("SUFFIX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SummRefCc)
                .HasColumnName("SUMM_REF_CC")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SuperSearchIndexText)
                .HasColumnName("SUPER_SEARCH_INDEX_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaxCategory)
                .HasColumnName("TAX_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptStatus)
                .HasColumnName("TAX_EXEMPT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxOffice)
                .HasColumnName("TAX_OFFICE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.TourOperatorType)
                .HasColumnName("TOUR_OPERATOR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeOf1099)
                .HasColumnName("TYPE_OF_1099")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateFaxDate)
                .HasColumnName("UPDATE_FAX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VendorId)
                .HasColumnName("VENDOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VendorSiteId)
                .HasColumnName("VENDOR_SITE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipAuthorization)
                .HasColumnName("VIP_AUTHORIZATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VisaValidityType)
                .HasColumnName("VISA_VALIDITY_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XcompanyName)
                .HasColumnName("XCOMPANY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XmiddleName)
                .HasColumnName("XMIDDLE_NAME")
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
            
            if (!types.Contains(typeof(BmAccounts)))
                entity.Ignore(e => e.BmAccounts);

            if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeaderAgentName);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeaderCompanyName);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeaderMasterName);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeaderSourceName);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.ApplicationUser);

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccount);

			if (!types.Contains(typeof(BookOwner)))
				entity.Ignore(e => e.BookOwner);

			if (!types.Contains(typeof(BookingAttendees)))
				entity.Ignore(e => e.BookingAttendees);

			if (!types.Contains(typeof(BusinessProfileLink)))
				entity.Ignore(e => e.BusinessProfileLink);

			if (!types.Contains(typeof(BusinessProfileOwner)))
				entity.Ignore(e => e.BusinessProfileOwner);

			if (!types.Contains(typeof(CommissionPayments)))
				entity.Ignore(e => e.CommissionPayments);

			if (!types.Contains(typeof(ComputedCommissions)))
				entity.Ignore(e => e.ComputedCommissions);

			if (!types.Contains(typeof(EventRegisteredAttendees)))
				entity.Ignore(e => e.EventRegisteredAttendees);

			if (!types.Contains(typeof(GemItemVendor)))
				entity.Ignore(e => e.GemItemVendor);

			if (!types.Contains(typeof(GemMenuitemVendor)))
				entity.Ignore(e => e.GemMenuitemVendor);

			if (!types.Contains(typeof(Memberships)))
				entity.Ignore(e => e.Memberships);

			if (!types.Contains(typeof(NameAddress)))
				entity.Ignore(e => e.NameAddress);

			if (!types.Contains(typeof(NameCreditCard)))
				entity.Ignore(e => e.NameCreditCard);

			if (!types.Contains(typeof(NameDocuments)))
				entity.Ignore(e => e.NameDocuments);

			if (!types.Contains(typeof(NameGoal)))
				entity.Ignore(e => e.NameGoal);

			if (!types.Contains(typeof(NameLoyaltySegments)))
				entity.Ignore(e => e.NameLoyaltySegments);

			if (!types.Contains(typeof(NameNotes)))
				entity.Ignore(e => e.NameNotes);

			if (!types.Contains(typeof(NameNotifications)))
				entity.Ignore(e => e.NameNotifications);

			if (!types.Contains(typeof(NameOwner)))
				entity.Ignore(e => e.NameOwner);

			if (!types.Contains(typeof(NamePhone)))
				entity.Ignore(e => e.NamePhone);

			if (!types.Contains(typeof(NameResort)))
				entity.Ignore(e => e.NameResort);

			if (!types.Contains(typeof(NameXref)))
				entity.Ignore(e => e.NameXrefName);

			if (!types.Contains(typeof(NameXref)))
				entity.Ignore(e => e.NameXrefRelationToName);

			if (!types.Contains(typeof(OvosOwnersUsers)))
				entity.Ignore(e => e.OvosOwnersUsers);

			if (!types.Contains(typeof(ReservationConfLetter)))
				entity.Ignore(e => e.ReservationConfLetter);

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.ReservationName);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.Resort);

			if (!types.Contains(typeof(StayRecordHistory)))
				entity.Ignore(e => e.StayRecordHistory);

			if (!types.Contains(typeof(TrackitItems)))
				entity.Ignore(e => e.TrackitItems);

			if (!types.Contains(typeof(TrxRoutingInstructions)))
				entity.Ignore(e => e.TrxRoutingInstructions);

			if (!types.Contains(typeof(YmNameAdjustments)))
				entity.Ignore(e => e.YmNameAdjustments);
		});
	}
}

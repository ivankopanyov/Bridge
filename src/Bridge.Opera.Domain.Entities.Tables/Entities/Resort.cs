namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Resort
{
    public Resort()
    {
        AllotmentDetail = new HashSet<AllotmentDetail>();
        AllotmentRestrictions = new HashSet<AllotmentRestrictions>();
        AlternateResort = new HashSet<AlternateResort>();
        AppTrusteePermission = new HashSet<AppTrusteePermission>();
        AsciiFformat = new HashSet<AsciiFformat>();
        Building = new HashSet<Building>();
        Businessdate = new HashSet<Businessdate>();
        CommissionResvData = new HashSet<CommissionResvData>();
        CroChains = new HashSet<CroChains>();
        CroFeatures = new HashSet<CroFeatures>();
        DailyForecast = new HashSet<DailyForecast>();
        DatabaseResorts = new HashSet<DatabaseResorts>();
        Department = new HashSet<Department>();
        EvForecast = new HashSet<EvForecast>();
        FinTrxTranslation = new HashSet<FinTrxTranslation>();
        GemEvent = new HashSet<GemEvent>();
        HotelAccounts = new HashSet<HotelAccounts>();
        LeadDisplaySetup = new HashSet<LeadDisplaySetup>();
        MeetingRoomImages = new HashSet<MeetingRoomImages>();
        NightAuditProcedures = new HashSet<NightAuditProcedures>();
        OvosContracts = new HashSet<OvosContracts>();
        OvosFees = new HashSet<OvosFees>();
        OvosResortDoc = new HashSet<OvosResortDoc>();
        OvosResortInsurance = new HashSet<OvosResortInsurance>();
        PropertyPriceRange = new HashSet<PropertyPriceRange>();
        RateHeader = new HashSet<RateHeader>();
        RateTranslation = new HashSet<RateTranslation>();
        ReservationName = new HashSet<ReservationName>();
        ReservationRestrictions = new HashSet<ReservationRestrictions>();
        ResortAccess = new HashSet<ResortAccess>();
        ResortAttraction = new HashSet<ResortAttraction>();
        ResortCreditCard = new HashSet<ResortCreditCard>();
        ResortDayLabel = new HashSet<ResortDayLabel>();
        ResortFeature = new HashSet<ResortFeature>();
        ResortFnsRules = new HashSet<ResortFnsRules>();
        ResortGuarantees = new HashSet<ResortGuarantees>();
        ResortNotes = new HashSet<ResortNotes>();
        ResortOutlet = new HashSet<ResortOutlet>();
        ResortProducts = new HashSet<ResortProducts>();
        ResortRateCategory = new HashSet<ResortRateCategory>();
        ResortRateClasses = new HashSet<ResortRateClasses>();
        ResortRestaurants = new HashSet<ResortRestaurants>();
        ResortRoomCategory = new HashSet<ResortRoomCategory>();
        ResortRoomClasses = new HashSet<ResortRoomClasses>();
        ResortSpaceInfo = new HashSet<ResortSpaceInfo>();
        ResortSpaceSetup = new HashSet<ResortSpaceSetup>();
        ResortTransportation = new HashSet<ResortTransportation>();
        ScAttachment = new HashSet<ScAttachment>();
        ScFielddef = new HashSet<ScFielddef>();
        SfaChains = new HashSet<SfaChains>();
        UserCroAccessLink = new HashSet<UserCroAccessLink>();
    }

    public string? Resort1 { get; set; }
    public DateTime? BeginDate { get; set; }
    public string? Name { get; set; }
    public string? LegalOwner { get; set; }
    public string? CountryCode { get; set; }
    public string? CrsResort { get; set; }
    public string? Street { get; set; }
    public string? PostCode { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Telephone { get; set; }
    public string? Fax { get; set; }
    public string? Webaddress { get; set; }
    public string? Tollfree { get; set; }
    public string? Email { get; set; }
    public decimal? KeepAvailability { get; set; }
    public decimal? BudgetMonth { get; set; }
    public decimal? SaveProfiles { get; set; }
    public string? DefaultReservationType { get; set; }
    public string? Block { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? SourceCommission { get; set; }
    public string? TaCommission { get; set; }
    public DateTime? CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
    public decimal? LongStayControl { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? NumberRooms { get; set; }
    public decimal? NumberFloors { get; set; }
    public decimal? NumberBeds { get; set; }
    public decimal? RhythmSheets { get; set; }
    public decimal? RhythmTowels { get; set; }
    public string? BaseLanguage { get; set; }
    public string? FolioLanguage1 { get; set; }
    public string? FolioLanguage2 { get; set; }
    public string? FolioLanguage3 { get; set; }
    public string? FolioLanguage4 { get; set; }
    public decimal? WarningAmount { get; set; }
    public string? ThousandSeparator { get; set; }
    public string? PackageProfit { get; set; }
    public string? PackageLoss { get; set; }
    public decimal? DecimalPlaces { get; set; }
    public string? DecimalSeparator { get; set; }
    public string? ShortDateFormat { get; set; }
    public string? LongDateFormat { get; set; }
    public string? DateSeparator { get; set; }
    public decimal? Font { get; set; }
    public decimal? Copies { get; set; }
    public decimal? DefaultFolioStyle { get; set; }
    public decimal? IndividualRoomWarning { get; set; }
    public decimal? GroupRoomWarning { get; set; }
    public DateTime? VideoCoStart { get; set; }
    public DateTime? VideoCoStop { get; set; }
    public string? PasserbySource { get; set; }
    public string? PasserbyMarket { get; set; }
    public string? ArCompany { get; set; }
    public string? ArAgent { get; set; }
    public string? ArGroups { get; set; }
    public string? ArIndividuals { get; set; }
    public string? ArAcctNoMandYn { get; set; }
    public decimal? AgingLevel1 { get; set; }
    public decimal? AgingLevel2 { get; set; }
    public decimal? AgingLevel3 { get; set; }
    public decimal? AgingLevel4 { get; set; }
    public decimal? AgingLevel5 { get; set; }
    public string? ArAcctNoFormat { get; set; }
    public string? DateForAging { get; set; }
    public decimal? ZeroInvPurDays { get; set; }
    public decimal? MinDaysBet2ReminderLetter { get; set; }
    public string? AllowancePeriodAdj { get; set; }
    public string? HotelId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? CurrencyDecimals { get; set; }
    public string? ExchangePostingType { get; set; }
    public string? TurnawayCode { get; set; }
    public string? SummCurrencyCode { get; set; }
    public string? FaxNoFormat { get; set; }
    public string? TelephoneNoFormat { get; set; }
    public string? LocalCurrencyFormat { get; set; }
    public string? DefaultPropertyAddress { get; set; }
    public string? DefaultGuestAddress { get; set; }
    public string? LicenseCode { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? TimeFormat { get; set; }
    public decimal? NameIdLink { get; set; }
    public string? DutyManagerPager { get; set; }
    public string? ChainCode { get; set; }
    public string? ResortType { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Genmgr { get; set; }
    public string? Dirsales { get; set; }
    public string? Leadsend { get; set; }
    public string? Airport { get; set; }
    public string? AirportDistance { get; set; }
    public string? AirportTime { get; set; }
    public string? HotelType { get; set; }
    public string? Ownership { get; set; }
    public string? QuotedCurrency { get; set; }
    public string? ComMethod { get; set; }
    public string? ComAddress { get; set; }
    public string? InventoryYn { get; set; }
    public string? Notes { get; set; }
    public string? SglNum { get; set; }
    public decimal? SglRate1 { get; set; }
    public decimal? SglRate2 { get; set; }
    public string? DblNum { get; set; }
    public decimal? DblRate1 { get; set; }
    public decimal? DblRate2 { get; set; }
    public string? TplNum { get; set; }
    public decimal? TplRate1 { get; set; }
    public decimal? TplRate2 { get; set; }
    public string? SuiNum { get; set; }
    public decimal? SuiRate1 { get; set; }
    public decimal? SuiRate2 { get; set; }
    public short? TotRooms { get; set; }
    public string? Season1 { get; set; }
    public string? Season2 { get; set; }
    public string? Season3 { get; set; }
    public string? Season4 { get; set; }
    public string? Season5 { get; set; }
    public string? HotelFc { get; set; }
    public string? MeetingFc { get; set; }
    public string? BrArea { get; set; }
    public short? BrSeats { get; set; }
    public decimal? MeetSpace { get; set; }
    public byte? MeetRooms { get; set; }
    public short? MeetSeats { get; set; }
    public byte? Restaurant { get; set; }
    public decimal? ImgHotelId { get; set; }
    public decimal? ImgDirectionId { get; set; }
    public decimal? ImgMapId { get; set; }
    public string? AllowLoginYn { get; set; }
    public string? ArBalTrxCode { get; set; }
    public string? ArCreditTrxCode { get; set; }
    public string? ArTypewriter { get; set; }
    public string? ArSettleCode { get; set; }
    public string? CashShiftDrop { get; set; }
    public string? CheckExgPaidout { get; set; }
    public string? CheckShiftDrop { get; set; }
    public string? CheckTrxcode { get; set; }
    public string? CurrencyExgPaidout { get; set; }
    public string? DepositLedTrxCode { get; set; }
    public DateTime? FiscalStartDate { get; set; }
    public DateTime? FiscalEndDate { get; set; }
    public string? FiscalPeriodType { get; set; }
    public string? DefaultCommissionPercentage { get; set; }
    public string? DefaultPrepaidComm { get; set; }
    public string? DefaultTrxCommCode { get; set; }
    public string? FileTransferFormat { get; set; }
    public string? ConfigurationMode { get; set; }
    public string? ConfirmRegcardPrinter { get; set; }
    public string? DefaultPrinter { get; set; }
    public string? DefaultRegistrationCard { get; set; }
    public string? WeekendDays { get; set; }
    public string? DefaultGroupsRateCode { get; set; }
    public short? MaxNoNights { get; set; }
    public short? AwardsTimeout { get; set; }
    public string? DefaultPostingRoom { get; set; }
    public short? GuestLookupTimeout { get; set; }
    public string? VideocheckoutPrinter { get; set; }
    public short? WakeUpDelay { get; set; }
    public string? NightAuditCashierId { get; set; }
    public string? CompanyAddressType { get; set; }
    public string? CompanyPhoneType { get; set; }
    public string? DefaultFaxType { get; set; }
    public string? DefaultMembershipType { get; set; }
    public string? IndividualAddressType { get; set; }
    public string? IndividualPhoneType { get; set; }
    public string? DfltPkgTranCode { get; set; }
    public string? DfltTranCodeRateCode { get; set; }
    public short? MaxOccupancy { get; set; }
    public short? InactiveDaysForGuestProfil { get; set; }
    public string? DefaultRateCode { get; set; }
    public short? PerReservationRoomLimit { get; set; }
    public decimal? ScriptId { get; set; }
    public string? CroCode { get; set; }
    public string? FlowCode { get; set; }
    public string? ExtPropertyCode { get; set; }
    public string? ExtExpFileLocation { get; set; }
    public string? RegionCode { get; set; }
    public string? OpusCurrencyCode { get; set; }
    public decimal? ComNameXrefId { get; set; }
    public string? HotelCode { get; set; }
    public string? CurtainColor { get; set; }
    public DateTime? ReconcileDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public decimal? PathId { get; set; }
    public decimal? XresortNumber { get; set; }
    public string? Directions { get; set; }
    public string? DestinationId { get; set; }
    public decimal? MaxCreditDays { get; set; }
    public string? Path { get; set; }
    public string? AccessCode { get; set; }
    public string? Flags { get; set; }
    public string? TouristNumber { get; set; }
    public string? DisableLoginYn { get; set; }
    public string? IntTaxIncludedYn { get; set; }
    public string? DownloadRestYn { get; set; }
    public string? TimezoneRegion { get; set; }
    public string? PropinfoUrl { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string? TranslateMulticharYn { get; set; }
    public string? PropPicUrl { get; set; }
    public string? PropMapUrl { get; set; }
    public string? CateringCurrencyCode { get; set; }
    public string? CateringCurrencyFormat { get; set; }
    public decimal? QtySingleRooms { get; set; }
    public decimal? QtyDoubleRooms { get; set; }
    public decimal? QtyTwinRooms { get; set; }
    public decimal? QtySuites { get; set; }
    public decimal? QtyGuestRoomFloors { get; set; }
    public decimal? QtyGuestElevators { get; set; }
    public decimal? QtyNonSmokingRooms { get; set; }
    public decimal? QtyConnectingRooms { get; set; }
    public decimal? QtyHandicappedRooms { get; set; }
    public decimal? QtyFamilyRooms { get; set; }
    public decimal? MaxAdultsFamilyRoom { get; set; }
    public decimal? MaxChildrenFamilyRoom { get; set; }
    public string? FloorNumExecutiveFloor { get; set; }
    public string? RoomAmenity { get; set; }
    public string? ShopDescription { get; set; }
    public string? DefaultRatecodeRack { get; set; }
    public string? DefaultRatecodePcr { get; set; }
    public string? BlackoutPeriodNotes { get; set; }
    public string? ExternalScYn { get; set; }
    public string? SendLeadAsBookingYn { get; set; }
    public string? ExpHotelCode { get; set; }
    public byte[] LicRoomInfo { get; set; }
    public string? FnsTier { get; set; }

    public virtual Country CountryCodeNavigation { get; set; }
    public virtual Name NameIdLinkNavigation { get; set; }
    public virtual BmResorts BmResorts { get; set; }
    public virtual ICollection<AllotmentDetail> AllotmentDetail { get; set; }
    public virtual ICollection<AllotmentRestrictions> AllotmentRestrictions { get; set; }
    public virtual ICollection<AlternateResort> AlternateResort { get; set; }
    public virtual ICollection<AppTrusteePermission> AppTrusteePermission { get; set; }
    public virtual ICollection<AsciiFformat> AsciiFformat { get; set; }
    public virtual ICollection<Building> Building { get; set; }
    public virtual ICollection<Businessdate> Businessdate { get; set; }
    public virtual ICollection<CommissionResvData> CommissionResvData { get; set; }
    public virtual ICollection<CroChains> CroChains { get; set; }
    public virtual ICollection<CroFeatures> CroFeatures { get; set; }
    public virtual ICollection<DailyForecast> DailyForecast { get; set; }
    public virtual ICollection<DatabaseResorts> DatabaseResorts { get; set; }
    public virtual ICollection<Department> Department { get; set; }
    public virtual ICollection<EvForecast> EvForecast { get; set; }
    public virtual ICollection<FinTrxTranslation> FinTrxTranslation { get; set; }
    public virtual ICollection<GemEvent> GemEvent { get; set; }
    public virtual ICollection<HotelAccounts> HotelAccounts { get; set; }
    public virtual ICollection<LeadDisplaySetup> LeadDisplaySetup { get; set; }
    public virtual ICollection<MeetingRoomImages> MeetingRoomImages { get; set; }
    public virtual ICollection<NightAuditProcedures> NightAuditProcedures { get; set; }
    public virtual ICollection<OvosContracts> OvosContracts { get; set; }
    public virtual ICollection<OvosFees> OvosFees { get; set; }
    public virtual ICollection<OvosResortDoc> OvosResortDoc { get; set; }
    public virtual ICollection<OvosResortInsurance> OvosResortInsurance { get; set; }
    public virtual ICollection<PropertyPriceRange> PropertyPriceRange { get; set; }
    public virtual ICollection<RateHeader> RateHeader { get; set; }
    public virtual ICollection<RateTranslation> RateTranslation { get; set; }
    public virtual ICollection<ReservationName> ReservationName { get; set; }
    public virtual ICollection<ReservationRestrictions> ReservationRestrictions { get; set; }
    public virtual ICollection<ResortAccess> ResortAccess { get; set; }
    public virtual ICollection<ResortAttraction> ResortAttraction { get; set; }
    public virtual ICollection<ResortCreditCard> ResortCreditCard { get; set; }
    public virtual ICollection<ResortDayLabel> ResortDayLabel { get; set; }
    public virtual ICollection<ResortFeature> ResortFeature { get; set; }
    public virtual ICollection<ResortFnsRules> ResortFnsRules { get; set; }
    public virtual ICollection<ResortGuarantees> ResortGuarantees { get; set; }
    public virtual ICollection<ResortNotes> ResortNotes { get; set; }
    public virtual ICollection<ResortOutlet> ResortOutlet { get; set; }
    public virtual ICollection<ResortProducts> ResortProducts { get; set; }
    public virtual ICollection<ResortRateCategory> ResortRateCategory { get; set; }
    public virtual ICollection<ResortRateClasses> ResortRateClasses { get; set; }
    public virtual ICollection<ResortRestaurants> ResortRestaurants { get; set; }
    public virtual ICollection<ResortRoomCategory> ResortRoomCategory { get; set; }
    public virtual ICollection<ResortRoomClasses> ResortRoomClasses { get; set; }
    public virtual ICollection<ResortSpaceInfo> ResortSpaceInfo { get; set; }
    public virtual ICollection<ResortSpaceSetup> ResortSpaceSetup { get; set; }
    public virtual ICollection<ResortTransportation> ResortTransportation { get; set; }
    public virtual ICollection<ScAttachment> ScAttachment { get; set; }
    public virtual ICollection<ScFielddef> ScFielddef { get; set; }
    public virtual ICollection<SfaChains> SfaChains { get; set; }
    public virtual ICollection<UserCroAccessLink> UserCroAccessLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Resort>(entity =>
        {
            entity.HasKey(e => e.Resort1)
                .HasName("RESORT_PK");

            entity.ToTable("RESORT");

            entity.HasIndex(e => e.CountryCode)
                .HasName("RESORT_COUNTRY_FK1_IDX");

            entity.HasIndex(e => e.CrsResort)
                .HasName("RESORT_UK")
                .IsUnique();

            entity.HasIndex(e => e.CurrencyCode)
                .HasName("RESORT_CURRENCY_FK1_IDX");

            entity.HasIndex(e => e.NameIdLink)
                .HasName("RESORT_NAME_FK_IDX");

            entity.HasIndex(e => e.ResortType)
                .HasName("RESORTTYPE_IDX");

            entity.Property(e => e.Resort1)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgingLevel1)
                .HasColumnName("AGING_LEVEL1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgingLevel2)
                .HasColumnName("AGING_LEVEL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgingLevel3)
                .HasColumnName("AGING_LEVEL3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgingLevel4)
                .HasColumnName("AGING_LEVEL4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgingLevel5)
                .HasColumnName("AGING_LEVEL5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Airport)
                .HasColumnName("AIRPORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirportDistance)
                .HasColumnName("AIRPORT_DISTANCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AirportTime)
                .HasColumnName("AIRPORT_TIME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AllowLoginYn)
                .HasColumnName("ALLOW_LOGIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.AllowancePeriodAdj)
                .HasColumnName("ALLOWANCE_PERIOD_ADJ")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArAcctNoFormat)
                .HasColumnName("AR_ACCT_NO_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArAcctNoMandYn)
                .HasColumnName("AR_ACCT_NO_MAND_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ArAgent)
                .HasColumnName("AR_AGENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArBalTrxCode)
                .HasColumnName("AR_BAL_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArCompany)
                .HasColumnName("AR_COMPANY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArCreditTrxCode)
                .HasColumnName("AR_CREDIT_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArGroups)
                .HasColumnName("AR_GROUPS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArIndividuals)
                .HasColumnName("AR_INDIVIDUALS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArSettleCode)
                .HasColumnName("AR_SETTLE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArTypewriter)
                .HasColumnName("AR_TYPEWRITER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AwardsTimeout).HasColumnName("AWARDS_TIMEOUT");

            entity.Property(e => e.BaseLanguage)
                .HasColumnName("BASE_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BlackoutPeriodNotes)
                .HasColumnName("BLACKOUT_PERIOD_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Block)
                .HasColumnName("BLOCK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BrArea)
                .HasColumnName("BR_AREA")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BrSeats).HasColumnName("BR_SEATS");

            entity.Property(e => e.BudgetMonth)
                .HasColumnName("BUDGET_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashShiftDrop)
                .HasColumnName("CASH_SHIFT_DROP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringCurrencyCode)
                .HasColumnName("CATERING_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CateringCurrencyFormat)
                .HasColumnName("CATERING_CURRENCY_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CheckExgPaidout)
                .HasColumnName("CHECK_EXG_PAIDOUT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckInTime)
                .HasColumnName("CHECK_IN_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CheckOutTime)
                .HasColumnName("CHECK_OUT_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CheckShiftDrop)
                .HasColumnName("CHECK_SHIFT_DROP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckTrxcode)
                .HasColumnName("CHECK_TRXCODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComAddress)
                .HasColumnName("COM_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ComMethod)
                .HasColumnName("COM_METHOD")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ComNameXrefId)
                .HasColumnName("COM_NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyAddressType)
                .HasColumnName("COMPANY_ADDRESS_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyPhoneType)
                .HasColumnName("COMPANY_PHONE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfigurationMode)
                .HasColumnName("CONFIGURATION_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmRegcardPrinter)
                .HasColumnName("CONFIRM_REGCARD_PRINTER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CroCode)
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CrsResort)
                .HasColumnName("CRS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyDecimals)
                .HasColumnName("CURRENCY_DECIMALS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyExgPaidout)
                .HasColumnName("CURRENCY_EXG_PAIDOUT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencySymbol)
                .HasColumnName("CURRENCY_SYMBOL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurtainColor)
                .HasColumnName("CURTAIN_COLOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DateForAging)
                .HasColumnName("DATE_FOR_AGING")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DateSeparator)
                .HasColumnName("DATE_SEPARATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DblNum)
                .HasColumnName("DBL_NUM")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DblRate1)
                .HasColumnName("DBL_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DblRate2)
                .HasColumnName("DBL_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DecimalPlaces)
                .HasColumnName("DECIMAL_PLACES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DecimalSeparator)
                .HasColumnName("DECIMAL_SEPARATOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultCommissionPercentage)
                .HasColumnName("DEFAULT_COMMISSION_PERCENTAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultFaxType)
                .HasColumnName("DEFAULT_FAX_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DefaultFolioStyle)
                .HasColumnName("DEFAULT_FOLIO_STYLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultGroupsRateCode)
                .HasColumnName("DEFAULT_GROUPS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultGuestAddress)
                .IsRequired()
                .HasColumnName("DEFAULT_GUEST_ADDRESS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'DEFAULT_GUEST'");

            entity.Property(e => e.DefaultMembershipType)
                .HasColumnName("DEFAULT_MEMBERSHIP_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPostingRoom)
                .HasColumnName("DEFAULT_POSTING_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPrepaidComm)
                .HasColumnName("DEFAULT_PREPAID_COMM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPrinter)
                .HasColumnName("DEFAULT_PRINTER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPropertyAddress)
                .IsRequired()
                .HasColumnName("DEFAULT_PROPERTY_ADDRESS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'DEFAULT_PROPERTY'");

            entity.Property(e => e.DefaultRateCode)
                .HasColumnName("DEFAULT_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRatecodePcr)
                .HasColumnName("DEFAULT_RATECODE_PCR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRatecodeRack)
                .HasColumnName("DEFAULT_RATECODE_RACK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRegistrationCard)
                .HasColumnName("DEFAULT_REGISTRATION_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DefaultReservationType)
                .HasColumnName("DEFAULT_RESERVATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultTrxCommCode)
                .HasColumnName("DEFAULT_TRX_COMM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepositLedTrxCode)
                .HasColumnName("DEPOSIT_LED_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DfltPkgTranCode)
                .HasColumnName("DFLT_PKG_TRAN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DfltTranCodeRateCode)
                .HasColumnName("DFLT_TRAN_CODE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Directions)
                .HasColumnName("DIRECTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Dirsales)
                .HasColumnName("DIRSALES")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DisableLoginYn)
                .HasColumnName("DISABLE_LOGIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DownloadRestYn)
                .HasColumnName("DOWNLOAD_REST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DutyManagerPager)
                .HasColumnName("DUTY_MANAGER_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpHotelCode)
                .HasColumnName("EXP_HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExtExpFileLocation)
                .HasColumnName("EXT_EXP_FILE_LOCATION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ExtPropertyCode)
                .HasColumnName("EXT_PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalScYn)
                .HasColumnName("EXTERNAL_SC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxNoFormat)
                .HasColumnName("FAX_NO_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FileTransferFormat)
                .HasColumnName("FILE_TRANSFER_FORMAT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FiscalEndDate)
                .HasColumnName("FISCAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FiscalPeriodType)
                .HasColumnName("FISCAL_PERIOD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FiscalStartDate)
                .HasColumnName("FISCAL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Flags)
                .HasColumnName("FLAGS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FloorNumExecutiveFloor)
                .HasColumnName("FLOOR_NUM_EXECUTIVE_FLOOR")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.FlowCode)
                .HasColumnName("FLOW_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FnsTier)
                .HasColumnName("FNS_TIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioLanguage1)
                .HasColumnName("FOLIO_LANGUAGE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioLanguage2)
                .HasColumnName("FOLIO_LANGUAGE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioLanguage3)
                .HasColumnName("FOLIO_LANGUAGE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioLanguage4)
                .HasColumnName("FOLIO_LANGUAGE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Font)
                .HasColumnName("FONT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Genmgr)
                .HasColumnName("GENMGR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupRoomWarning)
                .HasColumnName("GROUP_ROOM_WARNING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLookupTimeout).HasColumnName("GUEST_LOOKUP_TIMEOUT");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelFc)
                .HasColumnName("HOTEL_FC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HotelId)
                .HasColumnName("HOTEL_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelType)
                .HasColumnName("HOTEL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImgDirectionId)
                .HasColumnName("IMG_DIRECTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImgHotelId)
                .HasColumnName("IMG_HOTEL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImgMapId)
                .HasColumnName("IMG_MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDaysForGuestProfil).HasColumnName("INACTIVE_DAYS_FOR_GUEST_PROFIL");

            entity.Property(e => e.IndividualAddressType)
                .HasColumnName("INDIVIDUAL_ADDRESS_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IndividualPhoneType)
                .HasColumnName("INDIVIDUAL_PHONE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IndividualRoomWarning)
                .HasColumnName("INDIVIDUAL_ROOM_WARNING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IntTaxIncludedYn)
                .HasColumnName("INT_TAX_INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InventoryYn)
                .HasColumnName("INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.KeepAvailability)
                .HasColumnName("KEEP_AVAILABILITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Latitude)
                .HasColumnName("LATITUDE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Leadsend)
                .HasColumnName("LEADSEND")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LegalOwner)
                .HasColumnName("LEGAL_OWNER")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LicRoomInfo)
                .HasColumnName("LIC_ROOM_INFO")
                .HasMaxLength(240);

            entity.Property(e => e.LicenseCode)
                .HasColumnName("LICENSE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocalCurrencyFormat)
                .HasColumnName("LOCAL_CURRENCY_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LongDateFormat)
                .HasColumnName("LONG_DATE_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongStayControl)
                .HasColumnName("LONG_STAY_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Longitude)
                .HasColumnName("LONGITUDE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAdultsFamilyRoom)
                .HasColumnName("MAX_ADULTS_FAMILY_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxChildrenFamilyRoom)
                .HasColumnName("MAX_CHILDREN_FAMILY_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxCreditDays)
                .HasColumnName("MAX_CREDIT_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxNoNights)
                .HasColumnName("MAX_NO_NIGHTS")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MeetRooms)
                .HasColumnName("MEET_ROOMS")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.MeetSeats).HasColumnName("MEET_SEATS");

            entity.Property(e => e.MeetSpace)
                .HasColumnName("MEET_SPACE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MeetingFc)
                .HasColumnName("MEETING_FC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinDaysBet2ReminderLetter)
                .HasColumnName("MIN_DAYS_BET_2_REMINDER_LETTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameIdLink)
                .HasColumnName("NAME_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightAuditCashierId)
                .HasColumnName("NIGHT_AUDIT_CASHIER_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumberBeds)
                .HasColumnName("NUMBER_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberFloors)
                .HasColumnName("NUMBER_FLOORS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpusCurrencyCode)
                .HasColumnName("OPUS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Ownership)
                .HasColumnName("OWNERSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PackageLoss)
                .HasColumnName("PACKAGE_LOSS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PackageProfit)
                .HasColumnName("PACKAGE_PROFIT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PasserbyMarket)
                .HasColumnName("PASSERBY_MARKET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PasserbySource)
                .HasColumnName("PASSERBY_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Path)
                .HasColumnName("PATH")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PathId)
                .HasColumnName("PATH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("NULL");

            entity.Property(e => e.PerReservationRoomLimit).HasColumnName("PER_RESERVATION_ROOM_LIMIT");

            entity.Property(e => e.PostCode)
                .HasColumnName("POST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PropMapUrl)
                .HasColumnName("PROP_MAP_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropPicUrl)
                .HasColumnName("PROP_PIC_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropinfoUrl)
                .HasColumnName("PROPINFO_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.QtyConnectingRooms)
                .HasColumnName("QTY_CONNECTING_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyDoubleRooms)
                .HasColumnName("QTY_DOUBLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyFamilyRooms)
                .HasColumnName("QTY_FAMILY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyGuestElevators)
                .HasColumnName("QTY_GUEST_ELEVATORS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyGuestRoomFloors)
                .HasColumnName("QTY_GUEST_ROOM_FLOORS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyHandicappedRooms)
                .HasColumnName("QTY_HANDICAPPED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyNonSmokingRooms)
                .HasColumnName("QTY_NON_SMOKING_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtySingleRooms)
                .HasColumnName("QTY_SINGLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtySuites)
                .HasColumnName("QTY_SUITES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QtyTwinRooms)
                .HasColumnName("QTY_TWIN_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuotedCurrency)
                .HasColumnName("QUOTED_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ReconcileDate)
                .HasColumnName("RECONCILE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("NULL");

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Restaurant).HasColumnName("RESTAURANT");

            entity.Property(e => e.RhythmSheets)
                .HasColumnName("RHYTHM_SHEETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RhythmTowels)
                .HasColumnName("RHYTHM_TOWELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAmenity)
                .HasColumnName("ROOM_AMENITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SaveProfiles)
                .HasColumnName("SAVE_PROFILES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScriptId)
                .HasColumnName("SCRIPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Season1)
                .HasColumnName("SEASON1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Season2)
                .HasColumnName("SEASON2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Season3)
                .HasColumnName("SEASON3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Season4)
                .HasColumnName("SEASON4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Season5)
                .HasColumnName("SEASON5")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SendLeadAsBookingYn)
                .HasColumnName("SEND_LEAD_AS_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SglNum)
                .HasColumnName("SGL_NUM")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.SglRate1)
                .HasColumnName("SGL_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SglRate2)
                .HasColumnName("SGL_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShopDescription)
                .HasColumnName("SHOP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShortDateFormat)
                .HasColumnName("SHORT_DATE_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SourceCommission)
                .HasColumnName("SOURCE_COMMISSION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Street)
                .HasColumnName("STREET")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SuiNum)
                .HasColumnName("SUI_NUM")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.SuiRate1)
                .HasColumnName("SUI_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuiRate2)
                .HasColumnName("SUI_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummCurrencyCode)
                .HasColumnName("SUMM_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaCommission)
                .HasColumnName("TA_COMMISSION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Telephone)
                .HasColumnName("TELEPHONE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TelephoneNoFormat)
                .HasColumnName("TELEPHONE_NO_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ThousandSeparator)
                .HasColumnName("THOUSAND_SEPARATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeFormat)
                .HasColumnName("TIME_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TimezoneRegion)
                .HasColumnName("TIMEZONE_REGION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tollfree)
                .HasColumnName("TOLLFREE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotRooms)
                .HasColumnName("TOT_ROOMS")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TouristNumber)
                .HasColumnName("TOURIST_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TplNum)
                .HasColumnName("TPL_NUM")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TplRate1)
                .HasColumnName("TPL_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TplRate2)
                .HasColumnName("TPL_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TranslateMulticharYn)
                .HasColumnName("TRANSLATE_MULTICHAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TurnawayCode)
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VideoCoStart)
                .HasColumnName("VIDEO_CO_START")
                .HasColumnType("DATE");

            entity.Property(e => e.VideoCoStop)
                .HasColumnName("VIDEO_CO_STOP")
                .HasColumnType("DATE");

            entity.Property(e => e.VideocheckoutPrinter)
                .HasColumnName("VIDEOCHECKOUT_PRINTER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WakeUpDelay).HasColumnName("WAKE_UP_DELAY");

            entity.Property(e => e.WarningAmount)
                .HasColumnName("WARNING_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Webaddress)
                .HasColumnName("WEBADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WeekendDays)
                .HasColumnName("WEEKEND_DAYS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XresortNumber)
                .HasColumnName("XRESORT_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZeroInvPurDays)
                .HasColumnName("ZERO_INV_PUR_DAYS")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Country)))
				entity.Ignore(e => e.CountryCodeNavigation);
			else
	            entity.HasOne(d => d.CountryCodeNavigation)
	                .WithMany(p => p.Resort)
	                .HasForeignKey(d => d.CountryCode)
	                .HasConstraintName("RESORT_COUNTRY_FK1");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.NameIdLinkNavigation);
			else
	            entity.HasOne(d => d.NameIdLinkNavigation)
	                .WithMany(p => p.Resort)
	                .HasForeignKey(d => d.NameIdLink)
	                .HasConstraintName("RESORT_NAME_FK");

            if (!types.Contains(typeof(BmResorts)))
                entity.Ignore(e => e.BmResorts);

            if (!types.Contains(typeof(AllotmentDetail)))
				entity.Ignore(e => e.AllotmentDetail);

			if (!types.Contains(typeof(AllotmentRestrictions)))
				entity.Ignore(e => e.AllotmentRestrictions);

			if (!types.Contains(typeof(AlternateResort)))
				entity.Ignore(e => e.AlternateResort);

			if (!types.Contains(typeof(AppTrusteePermission)))
				entity.Ignore(e => e.AppTrusteePermission);

			if (!types.Contains(typeof(AsciiFformat)))
				entity.Ignore(e => e.AsciiFformat);

			if (!types.Contains(typeof(Building)))
				entity.Ignore(e => e.Building);

			if (!types.Contains(typeof(Businessdate)))
				entity.Ignore(e => e.Businessdate);

			if (!types.Contains(typeof(CommissionResvData)))
				entity.Ignore(e => e.CommissionResvData);

			if (!types.Contains(typeof(CroChains)))
				entity.Ignore(e => e.CroChains);

			if (!types.Contains(typeof(CroFeatures)))
				entity.Ignore(e => e.CroFeatures);

			if (!types.Contains(typeof(DailyForecast)))
				entity.Ignore(e => e.DailyForecast);

			if (!types.Contains(typeof(DatabaseResorts)))
				entity.Ignore(e => e.DatabaseResorts);

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);

			if (!types.Contains(typeof(EvForecast)))
				entity.Ignore(e => e.EvForecast);

			if (!types.Contains(typeof(FinTrxTranslation)))
				entity.Ignore(e => e.FinTrxTranslation);

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.GemEvent);

			if (!types.Contains(typeof(HotelAccounts)))
				entity.Ignore(e => e.HotelAccounts);

			if (!types.Contains(typeof(LeadDisplaySetup)))
				entity.Ignore(e => e.LeadDisplaySetup);

			if (!types.Contains(typeof(MeetingRoomImages)))
				entity.Ignore(e => e.MeetingRoomImages);

			if (!types.Contains(typeof(NightAuditProcedures)))
				entity.Ignore(e => e.NightAuditProcedures);

			if (!types.Contains(typeof(OvosContracts)))
				entity.Ignore(e => e.OvosContracts);

			if (!types.Contains(typeof(OvosFees)))
				entity.Ignore(e => e.OvosFees);

			if (!types.Contains(typeof(OvosResortDoc)))
				entity.Ignore(e => e.OvosResortDoc);

			if (!types.Contains(typeof(OvosResortInsurance)))
				entity.Ignore(e => e.OvosResortInsurance);

			if (!types.Contains(typeof(PropertyPriceRange)))
				entity.Ignore(e => e.PropertyPriceRange);

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.RateHeader);

			if (!types.Contains(typeof(RateTranslation)))
				entity.Ignore(e => e.RateTranslation);

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.ReservationName);

			if (!types.Contains(typeof(ReservationRestrictions)))
				entity.Ignore(e => e.ReservationRestrictions);

			if (!types.Contains(typeof(ResortAccess)))
				entity.Ignore(e => e.ResortAccess);

			if (!types.Contains(typeof(ResortAttraction)))
				entity.Ignore(e => e.ResortAttraction);

			if (!types.Contains(typeof(ResortCreditCard)))
				entity.Ignore(e => e.ResortCreditCard);

			if (!types.Contains(typeof(ResortDayLabel)))
				entity.Ignore(e => e.ResortDayLabel);

			if (!types.Contains(typeof(ResortFeature)))
				entity.Ignore(e => e.ResortFeature);

			if (!types.Contains(typeof(ResortFnsRules)))
				entity.Ignore(e => e.ResortFnsRules);

			if (!types.Contains(typeof(ResortGuarantees)))
				entity.Ignore(e => e.ResortGuarantees);

			if (!types.Contains(typeof(ResortNotes)))
				entity.Ignore(e => e.ResortNotes);

			if (!types.Contains(typeof(ResortOutlet)))
				entity.Ignore(e => e.ResortOutlet);

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);

			if (!types.Contains(typeof(ResortRateCategory)))
				entity.Ignore(e => e.ResortRateCategory);

			if (!types.Contains(typeof(ResortRateClasses)))
				entity.Ignore(e => e.ResortRateClasses);

			if (!types.Contains(typeof(ResortRestaurants)))
				entity.Ignore(e => e.ResortRestaurants);

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.ResortRoomCategory);

			if (!types.Contains(typeof(ResortRoomClasses)))
				entity.Ignore(e => e.ResortRoomClasses);

			if (!types.Contains(typeof(ResortSpaceInfo)))
				entity.Ignore(e => e.ResortSpaceInfo);

			if (!types.Contains(typeof(ResortSpaceSetup)))
				entity.Ignore(e => e.ResortSpaceSetup);

			if (!types.Contains(typeof(ResortTransportation)))
				entity.Ignore(e => e.ResortTransportation);

			if (!types.Contains(typeof(ScAttachment)))
				entity.Ignore(e => e.ScAttachment);

			if (!types.Contains(typeof(ScFielddef)))
				entity.Ignore(e => e.ScFielddef);

			if (!types.Contains(typeof(SfaChains)))
				entity.Ignore(e => e.SfaChains);

			if (!types.Contains(typeof(UserCroAccessLink)))
				entity.Ignore(e => e.UserCroAccessLink);
		});
	}
}

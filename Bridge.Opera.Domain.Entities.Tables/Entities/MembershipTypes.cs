namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTypes
{
    public MembershipTypes()
    {
        MembershipAwards = new HashSet<MembershipAwards>();
        MembershipCardReaderFmt = new HashSet<MembershipCardReaderFmt>();
        MembershipLevels = new HashSet<MembershipLevels>();
        MembershipNoAutoGenerate = new HashSet<MembershipNoAutoGenerate>();
        MembershipPoints = new HashSet<MembershipPoints>();
        MembershipResorts = new HashSet<MembershipResorts>();
        Memberships = new HashSet<Memberships>();
    }

    public string MembershipType { get; set; }
    public string Description { get; set; }
    public string MembershipClass { get; set; }
    public string CardPrefix { get; set; }
    public decimal? CardLength { get; set; }
    public string CalculationMethod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? ExpirationMonth { get; set; }
    public string NumericValidation { get; set; }
    public string CurrencyCode { get; set; }
    public string PointsLabel { get; set; }
    public string FolioMessage { get; set; }
    public decimal? CostPerPoint { get; set; }
    public string CentralSetupYn { get; set; }
    public decimal? TransactionMaxPoints { get; set; }
    public string PointsIssuedCentrallyYn { get; set; }
    public string MembershipAction { get; set; }
    public string AllowSharesYn { get; set; }
    public string AllowAdhocMultiplierYn { get; set; }
    public string UdfCardValidationYn { get; set; }
    public string AwardGenerationMethod { get; set; }
    public decimal? BatchDelayPeriod { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? GraceExpirationMonth { get; set; }
    public string CanDeleteYn { get; set; }
    public string ExchangeRateType { get; set; }
    public decimal? YearsToExpire { get; set; }
    public string FulfilmentYn { get; set; }
    public string ExpirationDateRequired { get; set; }
    public string LevelRequired { get; set; }
    public string PrimaryMembershipYn { get; set; }
    public string FolioMessageNonmembers { get; set; }
    public string UdfFormula { get; set; }
    public decimal? CardValidYears { get; set; }
    public decimal? UpgradePeriod { get; set; }
    public decimal? DowngradePeriod { get; set; }
    public string AllowDupCardYn { get; set; }
    public string ExceptionType { get; set; }
    public decimal? MultipleRoomsLimit { get; set; }
    public string BookerProgramYn { get; set; }
    public string AutoCardNoBasedOn { get; set; }
    public string MemberInfoDispSet { get; set; }
    public string ChainCode { get; set; }
    public string DefaultMemStatus { get; set; }
    public string EnrollmentCodeReqYn { get; set; }
    public string TscDateFlag { get; set; }
    public string SendChkoutToIfc { get; set; }
    public string PromptAtCheckin { get; set; }
    public string ValidationByIfc { get; set; }
    public string FolioMessageNq { get; set; }
    public string FolioMessageNonmembersNq { get; set; }
    public decimal? ExternalProcessDays { get; set; }
    public string PromptAtNewReservation { get; set; }
    public string PromptAtUpdateReservation { get; set; }
    public string PromptAtCheckOut { get; set; }
    public string FolioMessageCredits { get; set; }
    public string ExternallyControlledYn { get; set; }
    public string ChipAndPinYn { get; set; }

    public virtual ICollection<MembershipAwards> MembershipAwards { get; set; }
    public virtual ICollection<MembershipCardReaderFmt> MembershipCardReaderFmt { get; set; }
    public virtual ICollection<MembershipLevels> MembershipLevels { get; set; }
    public virtual ICollection<MembershipNoAutoGenerate> MembershipNoAutoGenerate { get; set; }
    public virtual ICollection<MembershipPoints> MembershipPoints { get; set; }
    public virtual ICollection<MembershipResorts> MembershipResorts { get; set; }
    public virtual ICollection<Memberships> Memberships { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTypes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType })
                .HasName("MEMBERSHIP_TYPE_PK");

            entity.ToTable("MEMBERSHIP_TYPES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllowAdhocMultiplierYn)
                .HasColumnName("ALLOW_ADHOC_MULTIPLIER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.AllowDupCardYn)
                .HasColumnName("ALLOW_DUP_CARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllowSharesYn)
                .HasColumnName("ALLOW_SHARES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoCardNoBasedOn)
                .HasColumnName("AUTO_CARD_NO_BASED_ON")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BatchDelayPeriod)
                .HasColumnName("BATCH_DELAY_PERIOD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookerProgramYn)
                .HasColumnName("BOOKER_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalculationMethod)
                .HasColumnName("CALCULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardLength)
                .HasColumnName("CARD_LENGTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardPrefix)
                .HasColumnName("CARD_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardValidYears)
                .HasColumnName("CARD_VALID_YEARS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CentralSetupYn)
                .HasColumnName("CENTRAL_SETUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ChipAndPinYn)
                .HasColumnName("CHIP_AND_PIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CostPerPoint)
                .HasColumnName("COST_PER_POINT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultMemStatus)
                .HasColumnName("DEFAULT_MEM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DowngradePeriod)
                .HasColumnName("DOWNGRADE_PERIOD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnrollmentCodeReqYn)
                .HasColumnName("ENROLLMENT_CODE_REQ_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExceptionType)
                .HasColumnName("EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpirationDateRequired)
                .HasColumnName("EXPIRATION_DATE_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpirationMonth)
                .HasColumnName("EXPIRATION_MONTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalProcessDays)
                .HasColumnName("EXTERNAL_PROCESS_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternallyControlledYn)
                .HasColumnName("EXTERNALLY_CONTROLLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioMessage)
                .HasColumnName("FOLIO_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioMessageCredits)
                .HasColumnName("FOLIO_MESSAGE_CREDITS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FolioMessageNonmembers)
                .HasColumnName("FOLIO_MESSAGE_NONMEMBERS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioMessageNonmembersNq)
                .HasColumnName("FOLIO_MESSAGE_NONMEMBERS_NQ")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FolioMessageNq)
                .HasColumnName("FOLIO_MESSAGE_NQ")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FulfilmentYn)
                .HasColumnName("FULFILMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GraceExpirationMonth)
                .HasColumnName("GRACE_EXPIRATION_MONTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LevelRequired)
                .HasColumnName("LEVEL_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberInfoDispSet)
                .HasColumnName("MEMBER_INFO_DISP_SET")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipAction)
                .HasColumnName("MEMBERSHIP_ACTION")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipClass)
                .HasColumnName("MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultipleRoomsLimit)
                .HasColumnName("MULTIPLE_ROOMS_LIMIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumericValidation)
                .HasColumnName("NUMERIC_VALIDATION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsIssuedCentrallyYn)
                .HasColumnName("POINTS_ISSUED_CENTRALLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PointsLabel)
                .HasColumnName("POINTS_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryMembershipYn)
                .HasColumnName("PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromptAtCheckOut)
                .HasColumnName("PROMPT_AT_CHECK_OUT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromptAtCheckin)
                .HasColumnName("PROMPT_AT_CHECKIN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromptAtNewReservation)
                .HasColumnName("PROMPT_AT_NEW_RESERVATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromptAtUpdateReservation)
                .HasColumnName("PROMPT_AT_UPDATE_RESERVATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendChkoutToIfc)
                .HasColumnName("SEND_CHKOUT_TO_IFC")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransactionMaxPoints)
                .HasColumnName("TRANSACTION_MAX_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TscDateFlag)
                .HasColumnName("TSC_DATE_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfCardValidationYn)
                .HasColumnName("UDF_CARD_VALIDATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UdfFormula)
                .HasColumnName("UDF_FORMULA")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradePeriod)
                .HasColumnName("UPGRADE_PERIOD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ValidationByIfc)
                .HasColumnName("VALIDATION_BY_IFC")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YearsToExpire)
                .HasColumnName("YEARS_TO_EXPIRE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(MembershipAwards)))
				entity.Ignore(e => e.MembershipAwards);

			if (!types.Contains(typeof(MembershipCardReaderFmt)))
				entity.Ignore(e => e.MembershipCardReaderFmt);

			if (!types.Contains(typeof(MembershipLevels)))
				entity.Ignore(e => e.MembershipLevels);

			if (!types.Contains(typeof(MembershipNoAutoGenerate)))
				entity.Ignore(e => e.MembershipNoAutoGenerate);

			if (!types.Contains(typeof(MembershipPoints)))
				entity.Ignore(e => e.MembershipPoints);

			if (!types.Contains(typeof(MembershipResorts)))
				entity.Ignore(e => e.MembershipResorts);

			if (!types.Contains(typeof(Memberships)))
				entity.Ignore(e => e.Memberships);
		});
	}
}

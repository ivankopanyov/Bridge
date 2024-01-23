namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipStatementDetVw
{
    public decimal MemberStatementId { get; set; }
    public decimal StatementBatchId { get; set; }
    public decimal MembershipId { get; set; }
    public string PrintYn { get; set; }
    public string Status { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
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
    public string StatementNotes { get; set; }
    public string ErrorLog { get; set; }
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipStatementDetVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_STATEMENT_DET_VW");

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchDelayPeriod)
                .HasColumnName("BATCH_DELAY_PERIOD")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.CentralSetupYn)
                .HasColumnName("CENTRAL_SETUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ClosingBalance)
                .HasColumnName("CLOSING_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorLog)
                .HasColumnName("ERROR_LOG")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.GracePeriodIndicator)
                .HasColumnName("GRACE_PERIOD_INDICATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LevelRequired)
                .HasColumnName("LEVEL_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberIndicator)
                .HasColumnName("MEMBER_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameOnCard)
                .IsRequired()
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OpeningBalance)
                .HasColumnName("OPENING_BALANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsAvailable)
                .HasColumnName("POINTS_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryMembershipYn)
                .HasColumnName("PRIMARY_MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .IsRequired()
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StAwardsConsumed)
                .HasColumnName("ST_AWARDS_CONSUMED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StCreditPoints)
                .HasColumnName("ST_CREDIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StDebitPoints)
                .HasColumnName("ST_DEBIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StDisplayName)
                .HasColumnName("ST_DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StMembershipCardNo)
                .HasColumnName("ST_MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StMembershipLevel)
                .HasColumnName("ST_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StNameId)
                .HasColumnName("ST_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StNightPoints)
                .HasColumnName("ST_NIGHT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StNoRecords)
                .HasColumnName("ST_NO_RECORDS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StRevenuePoints)
                .HasColumnName("ST_REVENUE_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StStayPoints)
                .HasColumnName("ST_STAY_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatementNotes)
                .HasColumnName("STATEMENT_NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalAwardsConsumed)
                .HasColumnName("TOTAL_AWARDS_CONSUMED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalCreditPoints)
                .HasColumnName("TOTAL_CREDIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalDebitPoints)
                .HasColumnName("TOTAL_DEBIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalNightPoints)
                .HasColumnName("TOTAL_NIGHT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRevenuePoints)
                .HasColumnName("TOTAL_REVENUE_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalStayPoints)
                .HasColumnName("TOTAL_STAY_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(2000)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserKeyword)
                .HasColumnName("USER_KEYWORD")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YearsToExpire)
                .HasColumnName("YEARS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdAwardsConsumed)
                .HasColumnName("YTD_AWARDS_CONSUMED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YtdCreditPoints)
                .HasColumnName("YTD_CREDIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YtdDebitPoints)
                .HasColumnName("YTD_DEBIT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YtdNightPoints)
                .HasColumnName("YTD_NIGHT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YtdRevenuePoints)
                .HasColumnName("YTD_REVENUE_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YtdStayPoints)
                .HasColumnName("YTD_STAY_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}

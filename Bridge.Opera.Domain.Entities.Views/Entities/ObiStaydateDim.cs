namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiStaydateDim
{
    public string AllDates { get; set; }
    public string AllDatesDesc { get; set; }
    public DateTime DayId { get; set; }
    public decimal? DayTimespan { get; set; }
    public DateTime DayEndDate { get; set; }
    public decimal? DayOfYear { get; set; }
    public string DayDesc { get; set; }
    public string MonthId { get; set; }
    public string MonthYrId { get; set; }
    public string MonthDsc { get; set; }
    public decimal? MonthTimespan { get; set; }
    public DateTime? MonthEndDate { get; set; }
    public decimal? MonthOfQuarter { get; set; }
    public decimal? MonthOfYear { get; set; }
    public string QuarterId { get; set; }
    public string QuarterDsc { get; set; }
    public decimal? QuarterTimespan { get; set; }
    public DateTime? QuarterEndDate { get; set; }
    public string QuarterOfYear { get; set; }
    public string YearId { get; set; }
    public string YearDsc { get; set; }
    public decimal? YearTimespan { get; set; }
    public DateTime? YearEndDate { get; set; }
    public string PriorMonthId { get; set; }
    public string PriorYearId { get; set; }
    public string WeekId { get; set; }
    public string WeekDsc { get; set; }
    public string WeekOfYear { get; set; }
    public decimal? WeekTimespan { get; set; }
    public DateTime? WeekEndDate { get; set; }
    public string WeekOfMonth { get; set; }
    public string PriorWeekId { get; set; }
    public string DayNoOfWeek { get; set; }
    public string DayOfWeek { get; set; }
    public string IsoWeekOfYear { get; set; }
    public string JulianDayId { get; set; }
    public string PriorJulianDayId { get; set; }
    public string WeekEndId { get; set; }
    public string WeekEndDsc { get; set; }
    public DateTime? WeekEndMonthEndDate { get; set; }
    public string WeekEndMonthDsc { get; set; }
    public DateTime? PriorYearDayId { get; set; }
    public string PriorYearWeekId { get; set; }
    public string PriorYearQuarterId { get; set; }
    public string PriorYearMonthId { get; set; }
    public DateTime? LastYearDayId { get; set; }
    public string MonthName { get; set; }
    public decimal? EventCount { get; set; }
    public string EventLamp { get; set; }
    public string DayDescEventLamp { get; set; }
    public string EventString { get; set; }
    public string EventHtmlLink { get; set; }
    public string EventUrl { get; set; }
    public string FAllDates { get; set; }
    public string FAllDatesDesc { get; set; }
    public string FDayDesc { get; set; }
    public DateTime FDayEndDate { get; set; }
    public DateTime FDayId { get; set; }
    public string FDayNoOfWeek { get; set; }
    public string FDayOfWeek { get; set; }
    public decimal? FDayOfYear { get; set; }
    public decimal? FDayTimespan { get; set; }
    public string FMonthDsc { get; set; }
    public DateTime? FMonthEndDate { get; set; }
    public string FMonthId { get; set; }
    public string FMonthName { get; set; }
    public decimal? FMonthOfQuarter { get; set; }
    public decimal? FMonthOfYear { get; set; }
    public decimal? FMonthTimespan { get; set; }
    public string FMonthYrId { get; set; }
    public string FQuarterDsc { get; set; }
    public DateTime? FQuarterEndDate { get; set; }
    public string FQuarterId { get; set; }
    public decimal? FQuarterOfYear { get; set; }
    public DateTime? FQuarterStartDate { get; set; }
    public decimal? FQuarterTimespan { get; set; }
    public string FStartMonth { get; set; }
    public string FWeekOfYear { get; set; }
    public string FYearDsc { get; set; }
    public DateTime? FYearEndDate { get; set; }
    public string FYearId { get; set; }
    public DateTime? FYearStartDate { get; set; }
    public decimal? FYearTimespan { get; set; }
    public DateTime? AllEndDate { get; set; }
    public decimal? AllTimeSpan { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiStaydateDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_STAYDATE_DIM");

            entity.Property(e => e.AllDates)
                .HasColumnName("ALL_DATES")
                .IsUnicode(false);

            entity.Property(e => e.AllDatesDesc)
                .HasColumnName("ALL_DATES_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllEndDate)
                .HasColumnName("ALL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllTimeSpan)
                .HasColumnName("ALL_TIME_SPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayDesc)
                .HasColumnName("DAY_DESC")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.DayDescEventLamp)
                .HasColumnName("DAY_DESC_EVENT_LAMP")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.DayEndDate)
                .HasColumnName("DAY_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayId)
                .HasColumnName("DAY_ID")
                .HasColumnType("DATE");

            entity.Property(e => e.DayNoOfWeek)
                .HasColumnName("DAY_NO_OF_WEEK")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DayOfWeek)
                .HasColumnName("DAY_OF_WEEK")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.DayOfYear)
                .HasColumnName("DAY_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayTimespan)
                .HasColumnName("DAY_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventCount)
                .HasColumnName("EVENT_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventHtmlLink)
                .HasColumnName("EVENT_HTML_LINK")
                .IsUnicode(false);

            entity.Property(e => e.EventLamp)
                .HasColumnName("EVENT_LAMP")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.EventString)
                .HasColumnName("EVENT_STRING")
                .IsUnicode(false);

            entity.Property(e => e.EventUrl)
                .HasColumnName("EVENT_URL")
                .IsUnicode(false);

            entity.Property(e => e.FAllDates)
                .HasColumnName("F_ALL_DATES")
                .IsUnicode(false);

            entity.Property(e => e.FAllDatesDesc)
                .HasColumnName("F_ALL_DATES_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FDayDesc)
                .HasColumnName("F_DAY_DESC")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.FDayEndDate)
                .HasColumnName("F_DAY_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FDayId)
                .HasColumnName("F_DAY_ID")
                .HasColumnType("DATE");

            entity.Property(e => e.FDayNoOfWeek)
                .HasColumnName("F_DAY_NO_OF_WEEK")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FDayOfWeek)
                .HasColumnName("F_DAY_OF_WEEK")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.FDayOfYear)
                .HasColumnName("F_DAY_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FDayTimespan)
                .HasColumnName("F_DAY_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FMonthDsc)
                .HasColumnName("F_MONTH_DSC")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.FMonthEndDate)
                .HasColumnName("F_MONTH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FMonthId)
                .HasColumnName("F_MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.FMonthName)
                .HasColumnName("F_MONTH_NAME")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.FMonthOfQuarter)
                .HasColumnName("F_MONTH_OF_QUARTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FMonthOfYear)
                .HasColumnName("F_MONTH_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FMonthTimespan)
                .HasColumnName("F_MONTH_TIMESPAN")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.FMonthYrId)
                .HasColumnName("F_MONTH_YR_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FQuarterDsc)
                .HasColumnName("F_QUARTER_DSC")
                .HasMaxLength(44)
                .IsUnicode(false);

            entity.Property(e => e.FQuarterEndDate)
                .HasColumnName("F_QUARTER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FQuarterId)
                .HasColumnName("F_QUARTER_ID")
                .HasMaxLength(44)
                .IsUnicode(false);

            entity.Property(e => e.FQuarterOfYear)
                .HasColumnName("F_QUARTER_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FQuarterStartDate)
                .HasColumnName("F_QUARTER_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FQuarterTimespan)
                .HasColumnName("F_QUARTER_TIMESPAN")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.FStartMonth)
                .HasColumnName("F_START_MONTH")
                .IsUnicode(false);

            entity.Property(e => e.FWeekOfYear)
                .HasColumnName("F_WEEK_OF_YEAR")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.FYearDsc)
                .HasColumnName("F_YEAR_DSC")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.FYearEndDate)
                .HasColumnName("F_YEAR_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FYearId)
                .HasColumnName("F_YEAR_ID")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.FYearStartDate)
                .HasColumnName("F_YEAR_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FYearTimespan)
                .HasColumnName("F_YEAR_TIMESPAN")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.IsoWeekOfYear)
                .HasColumnName("ISO_WEEK_OF_YEAR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.JulianDayId)
                .HasColumnName("JULIAN_DAY_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.LastYearDayId)
                .HasColumnName("LAST_YEAR_DAY_ID")
                .HasColumnType("DATE");

            entity.Property(e => e.MonthDsc)
                .HasColumnName("MONTH_DSC")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.MonthEndDate)
                .HasColumnName("MONTH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MonthId)
                .HasColumnName("MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.MonthName)
                .HasColumnName("MONTH_NAME")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.MonthOfQuarter)
                .HasColumnName("MONTH_OF_QUARTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthOfYear)
                .HasColumnName("MONTH_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthTimespan)
                .HasColumnName("MONTH_TIMESPAN")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MonthYrId)
                .HasColumnName("MONTH_YR_ID")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.PriorJulianDayId)
                .HasColumnName("PRIOR_JULIAN_DAY_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PriorMonthId)
                .HasColumnName("PRIOR_MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PriorWeekId)
                .HasColumnName("PRIOR_WEEK_ID")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.PriorYearDayId)
                .HasColumnName("PRIOR_YEAR_DAY_ID")
                .HasColumnType("DATE");

            entity.Property(e => e.PriorYearId)
                .HasColumnName("PRIOR_YEAR_ID")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.PriorYearMonthId)
                .HasColumnName("PRIOR_YEAR_MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PriorYearQuarterId)
                .HasColumnName("PRIOR_YEAR_QUARTER_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.PriorYearWeekId)
                .HasColumnName("PRIOR_YEAR_WEEK_ID")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.QuarterDsc)
                .HasColumnName("QUARTER_DSC")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.QuarterEndDate)
                .HasColumnName("QUARTER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QuarterId)
                .HasColumnName("QUARTER_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.QuarterOfYear)
                .HasColumnName("QUARTER_OF_YEAR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.QuarterTimespan)
                .HasColumnName("QUARTER_TIMESPAN")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.WeekDsc)
                .HasColumnName("WEEK_DSC")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndDate)
                .HasColumnName("WEEK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WeekEndDsc)
                .HasColumnName("WEEK_END_DSC")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndId)
                .HasColumnName("WEEK_END_ID")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndMonthDsc)
                .HasColumnName("WEEK_END_MONTH_DSC")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndMonthEndDate)
                .HasColumnName("WEEK_END_MONTH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WeekId)
                .HasColumnName("WEEK_ID")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.WeekOfMonth)
                .HasColumnName("WEEK_OF_MONTH")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WeekOfYear)
                .HasColumnName("WEEK_OF_YEAR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.WeekTimespan)
                .HasColumnName("WEEK_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearDsc)
                .HasColumnName("YEAR_DSC")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.YearEndDate)
                .HasColumnName("YEAR_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.YearTimespan)
                .HasColumnName("YEAR_TIMESPAN")
                .HasColumnType("NUMBER(38)");
        });
	}
}

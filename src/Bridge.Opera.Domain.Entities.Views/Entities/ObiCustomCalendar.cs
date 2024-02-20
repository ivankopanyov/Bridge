namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCustomCalendar
{
    public DateTime? DateId { get; set; }
    public string? AllDates { get; set; }
    public string? AllDatesDesc { get; set; }
    public DateTime? AllEndDate { get; set; }
    public decimal? AllTimeSpan { get; set; }
    public string? YearId { get; set; }
    public string? YearDsc { get; set; }
    public DateTime? YearStartDate { get; set; }
    public DateTime? YearEndDate { get; set; }
    public decimal? YearTimespan { get; set; }
    public string? QuarterId { get; set; }
    public string? QuarterDsc { get; set; }
    public DateTime? QuarterStartDate { get; set; }
    public DateTime? QuarterEndDate { get; set; }
    public decimal? QuarterTimespan { get; set; }
    public string? MonthId { get; set; }
    public string? MonthDsc { get; set; }
    public DateTime? MonthStartDate { get; set; }
    public DateTime? MonthEndDate { get; set; }
    public decimal? MonthTimespan { get; set; }
    public string? MonthName { get; set; }
    public string? WeekEndId { get; set; }
    public string? WeekId { get; set; }
    public string? WeekDesc { get; set; }
    public DateTime? WeekStartDate { get; set; }
    public DateTime? WeekEndDate { get; set; }
    public decimal? WeekTimespan { get; set; }
    public string? DayId { get; set; }
    public string? DayDesc { get; set; }
    public DateTime? DayEndDate { get; set; }
    public decimal? DayTimespan { get; set; }
    public string? Calendar { get; set; }
    public string? CalendarDesc { get; set; }
    public string? Resort { get; set; }
    public decimal? YearIdSeq { get; set; }
    public string? YearType { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Year { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? DayOfYear { get; set; }
    public decimal? DayNoOfQuarter { get; set; }
    public decimal? DayNoOfMonth { get; set; }
    public decimal? WeekOfYear { get; set; }
    public decimal? WeekOfMonth { get; set; }
    public decimal? MonthOfYear { get; set; }
    public decimal? MonthOfQuarter { get; set; }
    public decimal? QuarterOfYear { get; set; }
    public string? MonthYrId { get; set; }
    public string? WeekEndDateDesc { get; set; }
    public decimal? DayNoOfWeek { get; set; }
    public DateTime? WeekEndMonthEndDate { get; set; }
    public string? WeekEndMonthDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCustomCalendar>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CUSTOM_CALENDAR");

            entity.Property(e => e.AllDates)
                .IsRequired()
                .HasColumnName("ALL_DATES")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AllDatesDesc)
                .HasColumnName("ALL_DATES_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AllEndDate)
                .HasColumnName("ALL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllTimeSpan)
                .HasColumnName("ALL_TIME_SPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Calendar)
                .IsRequired()
                .HasColumnName("CALENDAR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CalendarDesc)
                .HasColumnName("CALENDAR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DateId)
                .HasColumnName("DATE_ID")
                .HasColumnType("DATE");

            entity.Property(e => e.DayDesc)
                .HasColumnName("DAY_DESC")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.DayEndDate)
                .HasColumnName("DAY_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayId)
                .HasColumnName("DAY_ID")
                .HasMaxLength(56)
                .IsUnicode(false);

            entity.Property(e => e.DayNoOfMonth)
                .HasColumnName("DAY_NO_OF_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayNoOfQuarter)
                .HasColumnName("DAY_NO_OF_QUARTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayNoOfWeek)
                .HasColumnName("DAY_NO_OF_WEEK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayOfYear)
                .HasColumnName("DAY_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayTimespan)
                .HasColumnName("DAY_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MonthDsc)
                .HasColumnName("MONTH_DSC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MonthEndDate)
                .HasColumnName("MONTH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MonthId)
                .HasColumnName("MONTH_ID")
                .HasMaxLength(93)
                .IsUnicode(false);

            entity.Property(e => e.MonthName)
                .HasColumnName("MONTH_NAME")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MonthOfQuarter)
                .HasColumnName("MONTH_OF_QUARTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthOfYear)
                .HasColumnName("MONTH_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthStartDate)
                .HasColumnName("MONTH_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MonthTimespan)
                .HasColumnName("MONTH_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthYrId)
                .HasColumnName("MONTH_YR_ID")
                .HasMaxLength(93)
                .IsUnicode(false);

            entity.Property(e => e.QuarterDsc)
                .HasColumnName("QUARTER_DSC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.QuarterEndDate)
                .HasColumnName("QUARTER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QuarterId)
                .HasColumnName("QUARTER_ID")
                .HasMaxLength(93)
                .IsUnicode(false);

            entity.Property(e => e.QuarterOfYear)
                .HasColumnName("QUARTER_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuarterStartDate)
                .HasColumnName("QUARTER_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QuarterTimespan)
                .HasColumnName("QUARTER_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekDesc)
                .HasColumnName("WEEK_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndDate)
                .HasColumnName("WEEK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WeekEndDateDesc)
                .HasColumnName("WEEK_END_DATE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndId)
                .HasColumnName("WEEK_END_ID")
                .HasMaxLength(93)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndMonthDesc)
                .HasColumnName("WEEK_END_MONTH_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WeekEndMonthEndDate)
                .HasColumnName("WEEK_END_MONTH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WeekId)
                .HasColumnName("WEEK_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.WeekOfMonth)
                .HasColumnName("WEEK_OF_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekOfYear)
                .HasColumnName("WEEK_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekStartDate)
                .HasColumnName("WEEK_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WeekTimespan)
                .HasColumnName("WEEK_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearDsc)
                .HasColumnName("YEAR_DSC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.YearEndDate)
                .HasColumnName("YEAR_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.YearIdSeq)
                .HasColumnName("YEAR_ID_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearStartDate)
                .HasColumnName("YEAR_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YearTimespan)
                .HasColumnName("YEAR_TIMESPAN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearType)
                .IsRequired()
                .HasColumnName("YEAR_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

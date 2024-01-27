namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRpmSnapshotDim
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
    public DateTime? AllEndDate { get; set; }
    public decimal? AllTimeSpan { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRpmSnapshotDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RPM_SNAPSHOT_DIM");

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

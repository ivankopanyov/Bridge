namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiTimeMonthsDim
{
    public string AllDates { get; set; }
    public string AllDatesDesc { get; set; }
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
    public string PriorYearQuarterId { get; set; }
    public string PriorYearMonthId { get; set; }
    public decimal? YearLagPriorYear { get; set; }
    public decimal? QuarterLagPriorYear { get; set; }
    public decimal? MonthLagPriorYear { get; set; }
    public string ParentQuarter { get; set; }
    public string ParentYear { get; set; }
    public string MonthName { get; set; }
    public string FAllDates { get; set; }
    public string FAllDatesDesc { get; set; }
    public string FYearId { get; set; }
    public DateTime? FYearEndDate { get; set; }
    public decimal? FYearTimespan { get; set; }
    public string FYearDsc { get; set; }
    public DateTime? FYearStartDate { get; set; }
    public string FQuarterId { get; set; }
    public DateTime? FQuarterEndDate { get; set; }
    public decimal? FQuarterTimespan { get; set; }
    public string FQuarterDsc { get; set; }
    public DateTime? FQuarterStartDate { get; set; }
    public decimal? FQuarterOfYear { get; set; }
    public string FMonthId { get; set; }
    public DateTime? FMonthEndDate { get; set; }
    public decimal? FMonthTimespan { get; set; }
    public string FMonthDsc { get; set; }
    public decimal? FMonthOfYear { get; set; }
    public string FMonthName { get; set; }
    public decimal? FMonthOfQuarter { get; set; }
    public string FMonthYrId { get; set; }
    public DateTime? AllEndDate { get; set; }
    public decimal? AllTimeSpan { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiTimeMonthsDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_TIME_MONTHS_DIM");

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

            entity.Property(e => e.FAllDates)
                .HasColumnName("F_ALL_DATES")
                .IsUnicode(false);

            entity.Property(e => e.FAllDatesDesc)
                .HasColumnName("F_ALL_DATES_DESC")
                .IsUnicode(false);

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

            entity.Property(e => e.MonthLagPriorYear)
                .HasColumnName("MONTH_LAG_PRIOR_YEAR")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ParentQuarter)
                .HasColumnName("PARENT_QUARTER")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ParentYear)
                .HasColumnName("PARENT_YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.PriorMonthId)
                .HasColumnName("PRIOR_MONTH_ID")
                .HasMaxLength(7)
                .IsUnicode(false);

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

            entity.Property(e => e.QuarterLagPriorYear)
                .HasColumnName("QUARTER_LAG_PRIOR_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuarterOfYear)
                .HasColumnName("QUARTER_OF_YEAR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.QuarterTimespan)
                .HasColumnName("QUARTER_TIMESPAN")
                .HasColumnType("NUMBER(38)");

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

            entity.Property(e => e.YearLagPriorYear)
                .HasColumnName("YEAR_LAG_PRIOR_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearTimespan)
                .HasColumnName("YEAR_TIMESPAN")
                .HasColumnType("NUMBER(38)");
        });
	}
}

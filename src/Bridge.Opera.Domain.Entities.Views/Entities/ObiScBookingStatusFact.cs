namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScBookingStatusFact
{
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public string? PriorStatus { get; set; }
    public string? CurrentStatus { get; set; }
    public DateTime? ChangeDate { get; set; }
    public DateTime? ChangeDateTime { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalNetRoomsRevenue { get; set; }
    public decimal? TotalGrossRoomsRevenue { get; set; }
    public string? AllDates { get; set; }
    public string? DayDesc { get; set; }
    public string? DayNoOfWeek { get; set; }
    public decimal? DayNoOfMonth { get; set; }
    public decimal? DayNoOfQuarter { get; set; }
    public string? DayOfWeek { get; set; }
    public decimal? DayOfYear { get; set; }
    public string? IsoWeekOfYear { get; set; }
    public string? MonthDsc { get; set; }
    public string? MonthName { get; set; }
    public decimal? MonthOfYear { get; set; }
    public string? QuarterDsc { get; set; }
    public string? WeekDsc { get; set; }
    public string? YearDsc { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? CatRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? CatRevenueAudioVisual { get; set; }
    public decimal? CatRevenueBeverage { get; set; }
    public decimal? CatRevenueFood { get; set; }
    public decimal? CatRevenueOther { get; set; }
    public decimal? CatRevenueRental { get; set; }
    public decimal? CatRevenueGroup1 { get; set; }
    public decimal? CatRevenueGroup2 { get; set; }
    public decimal? CatRevenueGroup3 { get; set; }
    public decimal? CatRevenueGroup4 { get; set; }
    public decimal? CatRevenueGroup5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScBookingStatusFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_BOOKING_STATUS_FACT");

            entity.Property(e => e.AllDates)
                .HasColumnName("ALL_DATES")
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenue)
                .HasColumnName("CAT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueAudioVisual)
                .HasColumnName("CAT_REVENUE_AUDIO_VISUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueBeverage)
                .HasColumnName("CAT_REVENUE_BEVERAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueFood)
                .HasColumnName("CAT_REVENUE_FOOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueGroup1)
                .HasColumnName("CAT_REVENUE_GROUP1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueGroup2)
                .HasColumnName("CAT_REVENUE_GROUP2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueGroup3)
                .HasColumnName("CAT_REVENUE_GROUP3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueGroup4)
                .HasColumnName("CAT_REVENUE_GROUP4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueGroup5)
                .HasColumnName("CAT_REVENUE_GROUP5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueOther)
                .HasColumnName("CAT_REVENUE_OTHER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatRevenueRental)
                .HasColumnName("CAT_REVENUE_RENTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeDateTime)
                .HasColumnName("CHANGE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.DayDesc)
                .HasColumnName("DAY_DESC")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.DayNoOfMonth)
                .HasColumnName("DAY_NO_OF_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayNoOfQuarter)
                .HasColumnName("DAY_NO_OF_QUARTER")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsoWeekOfYear)
                .HasColumnName("ISO_WEEK_OF_YEAR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.MonthDsc)
                .HasColumnName("MONTH_DSC")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.MonthName)
                .HasColumnName("MONTH_NAME")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.MonthOfYear)
                .HasColumnName("MONTH_OF_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.QuarterDsc)
                .HasColumnName("QUARTER_DSC")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalGrossRoomsRevenue)
                .HasColumnName("TOTAL_GROSS_ROOMS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetRoomsRevenue)
                .HasColumnName("TOTAL_NET_ROOMS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekDsc)
                .HasColumnName("WEEK_DSC")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.YearDsc)
                .HasColumnName("YEAR_DSC")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}

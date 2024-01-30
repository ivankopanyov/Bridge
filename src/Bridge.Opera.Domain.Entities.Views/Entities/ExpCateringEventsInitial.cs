namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpCateringEventsInitial
{
    public decimal? RecordType { get; set; }
    public string? SourceSystem { get; set; }
    public string? PropertyCode { get; set; }
    public string? TransactionType { get; set; }
    public decimal? BookId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? EventId { get; set; }
    public string? EvStatus { get; set; }
    public string? EvType { get; set; }
    public decimal? TotalCateringRevenue { get; set; }
    public decimal? CurrRevGroup1Revenue { get; set; }
    public decimal? CurrRevGroup2Revenue { get; set; }
    public decimal? CurrRevGroup3Revenue { get; set; }
    public decimal? CurrRevGroup4Revenue { get; set; }
    public decimal? CurrRevGroup5Revenue { get; set; }
    public decimal? CurrRevGroup6Revenue { get; set; }
    public decimal? TotalCateringRevenueNet { get; set; }
    public decimal? CurrRevGroup1RevenueNet { get; set; }
    public decimal? CurrRevGroup2RevenueNet { get; set; }
    public decimal? CurrRevGroup3RevenueNet { get; set; }
    public decimal? CurrRevGroup4RevenueNet { get; set; }
    public decimal? CurrRevGroup5RevenueNet { get; set; }
    public decimal? CurrRevGroup6RevenueNet { get; set; }
    public string? MealPeriod { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Room { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string? RoomSetup { get; set; }
    public decimal? MasterEventId { get; set; }
    public string? EventLinkType { get; set; }
    public decimal? EventLinkId { get; set; }
    public DateTime? EventStartDate { get; set; }
    public string? ForecastYn { get; set; }
    public string? EvName { get; set; }
    public string? Udfc06 { get; set; }
    public string? MasterEvent { get; set; }
    public decimal? CurrRentalAmount { get; set; }
    public string? Doorcard { get; set; }
    public string? ProblemYn { get; set; }
    public string? DontMoveYn { get; set; }
    public string? SpaceName { get; set; }
    public string? RoomSetupDesc { get; set; }
    public decimal? SetAttendees { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public decimal? UpdateUserId { get; set; }
    public DateTime? StatusDate { get; set; }
    public DateTime? InsertDateTime { get; set; }
    public decimal? InsertUserId { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string? ExcludeFromForecastYn { get; set; }
    public decimal? CurrRevFood { get; set; }
    public decimal? CurrRevFoodNet { get; set; }
    public decimal? CurrRevBev { get; set; }
    public decimal? CurrRevBevNet { get; set; }
    public string? ExtEventId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCateringEventsInitial>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CATERING_EVENTS_INITIAL");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRentalAmount)
                .HasColumnName("CURR_RENTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevBev)
                .HasColumnName("CURR_REV_BEV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevBevNet)
                .HasColumnName("CURR_REV_BEV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevFood)
                .HasColumnName("CURR_REV_FOOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevFoodNet)
                .HasColumnName("CURR_REV_FOOD_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup1Revenue)
                .HasColumnName("CURR_REV_GROUP_1_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup1RevenueNet)
                .HasColumnName("CURR_REV_GROUP_1_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup2Revenue)
                .HasColumnName("CURR_REV_GROUP_2_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup2RevenueNet)
                .HasColumnName("CURR_REV_GROUP_2_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup3Revenue)
                .HasColumnName("CURR_REV_GROUP_3_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup3RevenueNet)
                .HasColumnName("CURR_REV_GROUP_3_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup4Revenue)
                .HasColumnName("CURR_REV_GROUP_4_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup4RevenueNet)
                .HasColumnName("CURR_REV_GROUP_4_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup5Revenue)
                .HasColumnName("CURR_REV_GROUP_5_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup5RevenueNet)
                .HasColumnName("CURR_REV_GROUP_5_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup6Revenue)
                .HasColumnName("CURR_REV_GROUP_6_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrRevGroup6RevenueNet)
                .HasColumnName("CURR_REV_GROUP_6_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Doorcard)
                .HasColumnName("DOORCARD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EvName)
                .IsRequired()
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EvStatus)
                .IsRequired()
                .HasColumnName("EV_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventLinkId)
                .HasColumnName("EVENT_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventLinkType)
                .HasColumnName("EVENT_LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExcludeFromForecastYn)
                .HasColumnName("EXCLUDE_FROM_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtEventId)
                .HasColumnName("EXT_EVENT_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ForecastYn)
                .HasColumnName("FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDateTime)
                .HasColumnName("INSERT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUserId)
                .HasColumnName("INSERT_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterEvent)
                .HasColumnName("MASTER_EVENT")
                .IsUnicode(false);

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealPeriod)
                .HasColumnName("MEAL_PERIOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProblemYn)
                .HasColumnName("PROBLEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetupDesc)
                .HasColumnName("ROOM_SETUP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SetAttendees)
                .HasColumnName("SET_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.SpaceName)
                .HasColumnName("SPACE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusDate)
                .HasColumnName("STATUS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalCateringRevenue)
                .HasColumnName("TOTAL_CATERING_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCateringRevenueNet)
                .HasColumnName("TOTAL_CATERING_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDateTime)
                .HasColumnName("UPDATE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUserId)
                .HasColumnName("UPDATE_USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}

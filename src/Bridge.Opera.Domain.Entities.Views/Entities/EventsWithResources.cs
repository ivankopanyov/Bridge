namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventsWithResources
{
    public string? Resort { get; set; }
    public decimal? EventId { get; set; }
    public decimal? BookId { get; set; }
    public string? EvType { get; set; }
    public string? EvStatus { get; set; }
    public string? EvName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public string? Doorcard { get; set; }
    public string? ProblemYn { get; set; }
    public string? WlIgnoreYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Tracecode { get; set; }
    public decimal? MasterEventId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? EventLinkId { get; set; }
    public string? MasterYn { get; set; }
    public DateTime? Blockstart { get; set; }
    public DateTime? Blockend { get; set; }
    public string? Room { get; set; }
    public string? RoomSetup { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string? DontMoveYn { get; set; }
    public string? TurntoStatus { get; set; }
    public string? WaitlistYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? PkgId { get; set; }
    public string? PkgEventYn { get; set; }
    public string? EvResort { get; set; }
    public string? AttendeesType { get; set; }
    public string? DoorcardYn { get; set; }
    public string? StatusType { get; set; }
    public string? Program { get; set; }
    public string? EventDay { get; set; }
    public string? ForecastRevenueOnlyYn { get; set; }
    public string? PkgName { get; set; }
    public string? EventLinkType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventsWithResources>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENTS_WITH_RESOURCES");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesType)
                .HasColumnName("ATTENDEES_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Blockend)
                .HasColumnName("BLOCKEND")
                .HasColumnType("DATE");

            entity.Property(e => e.Blockstart)
                .HasColumnName("BLOCKSTART")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Doorcard)
                .HasColumnName("DOORCARD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DoorcardYn)
                .HasColumnName("DOORCARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvName)
                .IsRequired()
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EvResort)
                .IsRequired()
                .HasColumnName("EV_RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.EventDay)
                .HasColumnName("EVENT_DAY")
                .HasMaxLength(9)
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

            entity.Property(e => e.ForecastRevenueOnlyYn)
                .HasColumnName("FORECAST_REVENUE_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterYn)
                .HasColumnName("MASTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgEventYn)
                .HasColumnName("PKG_EVENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProblemYn)
                .HasColumnName("PROBLEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Program)
                .HasColumnName("PROGRAM")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusType)
                .HasColumnName("STATUS_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TurntoStatus)
                .HasColumnName("TURNTO_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitlistYn)
                .HasColumnName("WAITLIST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WlIgnoreYn)
                .HasColumnName("WL_IGNORE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}

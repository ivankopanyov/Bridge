namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSceventView
{
    public decimal? BookId { get; set; }
    public string? EvResort { get; set; }
    public decimal? PkgId { get; set; }
    public string? EventId { get; set; }
    public string? EventType { get; set; }
    public string? EventName { get; set; }
    public string? Room { get; set; }
    public string? RoomName { get; set; }
    public string? Doorcard { get; set; }
    public string? RoomSetup { get; set; }
    public string? EventStartDate { get; set; }
    public string? EventEndDate { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? EventStartTime { get; set; }
    public string? EventEndTime { get; set; }
    public string? EventTime { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public string? EventStatus { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? MasterEventId { get; set; }
    public string? Ratecode { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public decimal? RateAmount { get; set; }
    public string? SetupSetdwnTime { get; set; }
    public string? PkgCode { get; set; }
    public string? PkgName { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? BilledRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSceventView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SCEVENT_VIEW");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenue)
                .HasColumnName("BILLED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.EvResort)
                .IsRequired()
                .HasColumnName("EV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventEndDate)
                .HasColumnName("EVENT_END_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventEndTime)
                .HasColumnName("EVENT_END_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EventName)
                .IsRequired()
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventStartTime)
                .HasColumnName("EVENT_START_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventStatus)
                .IsRequired()
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventTime)
                .HasColumnName("EVENT_TIME")
                .HasMaxLength(153)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ratecode)
                .HasColumnName("RATECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomName)
                .HasColumnName("ROOM_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupSetdwnTime)
                .HasColumnName("SETUP_SETDWN_TIME")
                .HasMaxLength(176)
                .IsUnicode(false);

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");
        });
	}
}

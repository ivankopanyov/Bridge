namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventBookingAccountView
{
    public string Accountname { get; set; }
    public decimal? Accountnameid { get; set; }
    public string Bookingname { get; set; }
    public string Resort { get; set; }
    public decimal Allotmentheaderid { get; set; }
    public string Bookstatus { get; set; }
    public string Catstatus { get; set; }
    public DateTime Startdate { get; set; }
    public DateTime Enddate { get; set; }
    public decimal Eventid { get; set; }
    public string Roomsetup { get; set; }
    public string Eventname { get; set; }
    public string Eventstatus { get; set; }
    public string Eventroom { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? ExpectedAttendees { get; set; }
    public decimal? GuaranteedAttendees { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string Eventtype { get; set; }
    public decimal? Setuptime { get; set; }
    public decimal? Setdowntime { get; set; }
    public string EventResort { get; set; }
    public decimal? Guaranteed { get; set; }
    public decimal? EventLinkId { get; set; }
    public string EventLinkType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventBookingAccountView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_BOOKING_ACCOUNT_VIEW");

            entity.Property(e => e.Accountname)
                .HasColumnName("ACCOUNTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accountnameid)
                .HasColumnName("ACCOUNTNAMEID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Allotmentheaderid)
                .HasColumnName("ALLOTMENTHEADERID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bookingname)
                .IsRequired()
                .HasColumnName("BOOKINGNAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Bookstatus)
                .IsRequired()
                .HasColumnName("BOOKSTATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Catstatus)
                .HasColumnName("CATSTATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Enddate)
                .HasColumnName("ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventLinkId)
                .HasColumnName("EVENT_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventLinkType)
                .HasColumnName("EVENT_LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventResort)
                .IsRequired()
                .HasColumnName("EVENT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Eventid)
                .HasColumnName("EVENTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Eventname)
                .IsRequired()
                .HasColumnName("EVENTNAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Eventroom)
                .HasColumnName("EVENTROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Eventstatus)
                .IsRequired()
                .HasColumnName("EVENTSTATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Eventtype)
                .IsRequired()
                .HasColumnName("EVENTTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpectedAttendees)
                .HasColumnName("EXPECTED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedAttendees)
                .HasColumnName("GUARANTEED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Roomsetup)
                .HasColumnName("ROOMSETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Setdowntime)
                .HasColumnName("SETDOWNTIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Setuptime)
                .HasColumnName("SETUPTIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Startdate)
                .HasColumnName("STARTDATE")
                .HasColumnType("DATE");
        });
	}
}

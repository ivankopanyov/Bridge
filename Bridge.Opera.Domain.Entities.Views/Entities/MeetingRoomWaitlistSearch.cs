namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MeetingRoomWaitlistSearch
{
    public decimal? Attendees { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal BookId { get; set; }
    public string CateringYn { get; set; }
    public string CatStatus { get; set; }
    public string BookingStatus { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal EventId { get; set; }
    public string EventType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal Priority { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public string TurntoStatus { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime WaitlistDate { get; set; }
    public decimal WaitlistId { get; set; }
    public decimal? EventRev { get; set; }
    public decimal? TotblkRev { get; set; }
    public decimal? TotalRev { get; set; }
    public string BookName { get; set; }
    public string AccountName { get; set; }
    public decimal? AccId { get; set; }
    public string RoomResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomWaitlistSearch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEETING_ROOM_WAITLIST_SEARCH");

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookName)
                .IsRequired()
                .HasColumnName("BOOK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringYn)
                .HasColumnName("CATERING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventRev)
                .HasColumnName("EVENT_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRev)
                .HasColumnName("TOTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotblkRev)
                .HasColumnName("TOTBLK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TurntoStatus)
                .IsRequired()
                .HasColumnName("TURNTO_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitlistDate)
                .HasColumnName("WAITLIST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WaitlistId)
                .HasColumnName("WAITLIST_ID")
                .HasColumnType("NUMBER");
        });
	}
}

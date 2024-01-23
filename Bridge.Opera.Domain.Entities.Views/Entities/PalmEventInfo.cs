namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PalmEventInfo
{
    public decimal EventId { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public string EvType { get; set; }
    public string EvStatus { get; set; }
    public string EvName { get; set; }
    public string AccountName { get; set; }
    public string ContactName { get; set; }
    public string CatSrepCode { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public DateTime? Blockstart { get; set; }
    public DateTime? Blockend { get; set; }
    public string BlockstartTime { get; set; }
    public string BlockendTime { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public string Doorcard { get; set; }
    public string ProblemYn { get; set; }
    public decimal? MasterEventId { get; set; }
    public string MasterEventName { get; set; }
    public string SubeventYn { get; set; }
    public string RoomResort { get; set; }
    public string Room { get; set; }
    public string RoomName { get; set; }
    public string RoomSetup { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string WaitlistYn { get; set; }
    public string NotesYn { get; set; }
    public string InspectedYn { get; set; }
    public DateTime? InspectedDate { get; set; }
    public decimal? InspectedUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PalmEventInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PALM_EVENT_INFO");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Blockend)
                .HasColumnName("BLOCKEND")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockendTime)
                .HasColumnName("BLOCKEND_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Blockstart)
                .HasColumnName("BLOCKSTART")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockstartTime)
                .HasColumnName("BLOCKSTART_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrepCode)
                .HasColumnName("CAT_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
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
                .HasMaxLength(75)
                .IsUnicode(false);

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

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InspectedDate)
                .HasColumnName("INSPECTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InspectedUser)
                .HasColumnName("INSPECTED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InspectedYn)
                .HasColumnName("INSPECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterEventName)
                .HasColumnName("MASTER_EVENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NotesYn)
                .HasColumnName("NOTES_YN")
                .IsUnicode(false);

            entity.Property(e => e.ProblemYn)
                .HasColumnName("PROBLEM_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.RoomName)
                .HasColumnName("ROOM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
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

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.SubeventYn)
                .HasColumnName("SUBEVENT_YN")
                .HasMaxLength(1)
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
        });
	}
}

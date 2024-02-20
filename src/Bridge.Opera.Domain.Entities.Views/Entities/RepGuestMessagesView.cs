namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepGuestMessagesView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Msgid { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? MsgDate { get; set; }
    public string? MsgTime { get; set; }
    public string? ResvStatus { get; set; }
    public decimal? CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string? Arrival { get; set; }
    public string? GuestName { get; set; }
    public string? Departure { get; set; }
    public string? Operator { get; set; }
    public string? StatusFlag { get; set; }
    public string? Description { get; set; }
    public string? MessageText { get; set; }
    public string? Room { get; set; }
    public string? RoomNo { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public string? Sname { get; set; }
    public string? ShortResvStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepGuestMessagesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_GUEST_MESSAGES_VIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.MessageText)
                .IsRequired()
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MsgDate)
                .HasColumnName("MSG_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.MsgTime)
                .HasColumnName("MSG_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.ShortResvStatus)
                .HasColumnName("SHORT_RESV_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.StatusFlag)
                .IsRequired()
                .HasColumnName("STATUS_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");
        });
	}
}

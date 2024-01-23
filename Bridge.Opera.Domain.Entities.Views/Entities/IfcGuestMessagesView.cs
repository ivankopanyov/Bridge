namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcGuestMessagesView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal GuestNameId { get; set; }
    public decimal Msgid { get; set; }
    public DateTime Msgdate { get; set; }
    public string Msgtime { get; set; }
    public string Room { get; set; }
    public string ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? GroupId { get; set; }
    public string Recipient { get; set; }
    public string RecipientSearch { get; set; }
    public string Operator { get; set; }
    public string ReceivedBy { get; set; }
    public string MsgType { get; set; }
    public string MsgStatus { get; set; }
    public string StatusDescription { get; set; }
    public string PrintedStatus { get; set; }
    public string MessageText { get; set; }
    public string RoomResort { get; set; }
    public string RgvResort { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcGuestMessagesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_GUEST_MESSAGES_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageText)
                .IsRequired()
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MsgStatus)
                .IsRequired()
                .HasColumnName("MSG_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.MsgType)
                .HasColumnName("MSG_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Msgdate)
                .HasColumnName("MSGDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Msgtime)
                .HasColumnName("MSGTIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrintedStatus)
                .HasColumnName("PRINTED_STATUS")
                .HasMaxLength(159)
                .IsUnicode(false);

            entity.Property(e => e.ReceivedBy)
                .HasColumnName("RECEIVED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Recipient)
                .HasColumnName("RECIPIENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RecipientSearch)
                .HasColumnName("RECIPIENT_SEARCH")
                .HasMaxLength(80)
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

            entity.Property(e => e.RgvResort)
                .IsRequired()
                .HasColumnName("RGV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusDescription)
                .HasColumnName("STATUS_DESCRIPTION")
                .HasMaxLength(202)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}

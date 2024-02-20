namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GuestMessagesView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? Msgid { get; set; }
    public DateTime? Msgdate { get; set; }
    public string? Msgtime { get; set; }
    public string? Room { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? GroupId { get; set; }
    public string? Recipient { get; set; }
    public string? RecipientSearch { get; set; }
    public string? GuestNameDisp { get; set; }
    public string? Operator { get; set; }
    public string? ReceivedBy { get; set; }
    public string? MsgType { get; set; }
    public string? MsgStatus { get; set; }
    public string? StatusDescription { get; set; }
    public string? PrintedStatus { get; set; }
    public string? MessageText { get; set; }
    public string? RoomResort { get; set; }
    public string? RgvResort { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? SfirstGuestName { get; set; }
    public string? XguestName { get; set; }
    public string? Sxname { get; set; }
    public string? SxfirstName { get; set; }
    public string? XlastName { get; set; }
    public string? XfirstName { get; set; }
    public string? XcompanyName { get; set; }
    public string? Xtitle { get; set; }
    public string? Xsalutation { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? GroupName { get; set; }
    public string? BlockCode { get; set; }
    public string? CompanyName { get; set; }
    public string? SourceName { get; set; }
    public string? PartyCode { get; set; }
    public DateTime? StatusDate { get; set; }
    public DateTime? PrintedDate { get; set; }
    public string? Description { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? TravelAgentName { get; set; }
    public decimal? RgvResvNameId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? RdenReservationDate { get; set; }
    public string? GuestTitle { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestName { get; set; }
    public DateTime? SmsSentOn { get; set; }
    public string? SmsSentBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestMessagesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GUEST_MESSAGES_VIEW");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestNameDisp)
                .HasColumnName("GUEST_NAME_DISP")
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

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

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PrintedDate)
                .HasColumnName("PRINTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintedStatus)
                .HasColumnName("PRINTED_STATUS")
                .HasMaxLength(159)
                .IsUnicode(false);

            entity.Property(e => e.RdenReservationDate)
                .HasColumnName("RDEN_RESERVATION_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.RgvResvNameId)
                .HasColumnName("RGV_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentBy)
                .HasColumnName("SMS_SENT_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentOn)
                .HasColumnName("SMS_SENT_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.StatusDate)
                .HasColumnName("STATUS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusDescription)
                .HasColumnName("STATUS_DESCRIPTION")
                .HasMaxLength(202)
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.XcompanyName)
                .HasColumnName("XCOMPANY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XguestName)
                .HasColumnName("XGUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

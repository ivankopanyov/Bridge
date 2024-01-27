namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QroomsView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string QueueStartTime { get; set; }
    public string QueueEndTime { get; set; }
    public decimal? QueueDuration { get; set; }
    public decimal? QueuePriority { get; set; }
    public DateTime? QueueStart { get; set; }
    public DateTime? QueueEnd { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string Room { get; set; }
    public string RoomClass { get; set; }
    public string RoomCategory { get; set; }
    public string ResvStatus { get; set; }
    public string SharedYn { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string Vip { get; set; }
    public string MessageYn { get; set; }
    public string AccompanyingYn { get; set; }
    public string RoutingYn { get; set; }
    public string FolioYn { get; set; }
    public string TraceYn { get; set; }
    public string AuthorisedBillingYn { get; set; }
    public string LocatorYn { get; set; }
    public decimal GuestNameId { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? FixedCharge { get; set; }
    public string MasterShare { get; set; }
    public decimal? Nights { get; set; }
    public string MultipleYn { get; set; }
    public string NameType { get; set; }
    public string SguestName { get; set; }
    public string SfirstGuestName { get; set; }
    public string ExtnNumber { get; set; }
    public string GuestTitle { get; set; }
    public DateTime? SmsSentOn { get; set; }
    public string SmsSentBy { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string GuaranteeCode { get; set; }
    public string FullName { get; set; }
    public string XdisplayName { get; set; }
    public string CTSName { get; set; }
    public string ExternalReference { get; set; }
    public string DisplayColor { get; set; }
    public string MarketCode { get; set; }
    public string BlockCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QroomsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QROOMS_VIEW");

            entity.Property(e => e.AccompanyingYn)
                .HasColumnName("ACCOMPANYING_YN")
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.AuthorisedBillingYn)
                .HasColumnName("AUTHORISED_BILLING_YN")
                .IsUnicode(false);

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CTSName)
                .HasColumnName("C_T_S_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.ExtnNumber)
                .HasColumnName("EXTN_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.FixedCharge)
                .HasColumnName("FIXED_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioYn)
                .HasColumnName("FOLIO_YN")
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
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
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LocatorYn)
                .HasColumnName("LOCATOR_YN")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MessageYn)
                .HasColumnName("MESSAGE_YN")
                .IsUnicode(false);

            entity.Property(e => e.MultipleYn)
                .HasColumnName("MULTIPLE_YN")
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueDuration)
                .HasColumnName("QUEUE_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueEnd)
                .HasColumnName("QUEUE_END")
                .HasColumnType("DATE");

            entity.Property(e => e.QueueEndTime)
                .HasColumnName("QUEUE_END_TIME")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.QueuePriority)
                .HasColumnName("QUEUE_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueStart)
                .HasColumnName("QUEUE_START")
                .HasColumnType("DATE");

            entity.Property(e => e.QueueStartTime)
                .HasColumnName("QUEUE_START_TIME")
                .HasMaxLength(8)
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

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingYn)
                .HasColumnName("ROUTING_YN")
                .IsUnicode(false);

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.SmsSentBy)
                .HasColumnName("SMS_SENT_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentOn)
                .HasColumnName("SMS_SENT_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceYn)
                .HasColumnName("TRACE_YN")
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);
        });
	}
}

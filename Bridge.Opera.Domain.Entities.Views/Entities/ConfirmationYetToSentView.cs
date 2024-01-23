namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ConfirmationYetToSentView
{
    public string Name { get; set; }
    public string Arrival { get; set; }
    public string Departure { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string Room { get; set; }
    public string Rt { get; set; }
    public string ResvDate { get; set; }
    public string ConfirmationLetter { get; set; }
    public string ConfirmTo { get; set; }
    public string CompanyName { get; set; }
    public decimal? CompanyId { get; set; }
    public string TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public decimal ResvNameId { get; set; }
    public string Resort { get; set; }
    public decimal GuestNameId { get; set; }
    public string SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public DateTime? ResvConfLetterLta { get; set; }
    public string ResvConfLetterStatus { get; set; }
    public decimal? ResvConfLetterId { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? AddressId { get; set; }
    public string Address { get; set; }
    public decimal? FaxId { get; set; }
    public string Fax { get; set; }
    public decimal? EmailId { get; set; }
    public string Email { get; set; }
    public string FaxLastStatus { get; set; }
    public DateTime? FaxLastAttempted { get; set; }
    public string EmailLastStatus { get; set; }
    public DateTime? EmailLastAttempted { get; set; }
    public string CustomizeYn { get; set; }
    public string ConfSentYn { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string Sfullname { get; set; }
    public string Xfullname { get; set; }
    public string Sxfullname { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string CallerName { get; set; }
    public string CallerPhone { get; set; }
    public string CallerFax { get; set; }
    public string CallerEmail { get; set; }
    public decimal? CallNameId { get; set; }
    public DateTime? BusinessDateCreated { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmationYetToSentView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONFIRMATION_YET_TO_SENT_VIEW");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CallNameId)
                .HasColumnName("CALL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CallerEmail)
                .HasColumnName("CALLER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.CallerFax)
                .HasColumnName("CALLER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.CallerName)
                .HasColumnName("CALLER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CallerPhone)
                .HasColumnName("CALLER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConfSentYn)
                .HasColumnName("CONF_SENT_YN")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmTo)
                .HasColumnName("CONFIRM_TO")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationLetter)
                .HasColumnName("CONFIRMATION_LETTER")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomizeYn)
                .HasColumnName("CUSTOMIZE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailLastAttempted)
                .HasColumnName("EMAIL_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.EmailLastStatus)
                .HasColumnName("EMAIL_LAST_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxLastAttempted)
                .HasColumnName("FAX_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.FaxLastStatus)
                .HasColumnName("FAX_LAST_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvConfLetterId)
                .HasColumnName("RESV_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvConfLetterLta)
                .HasColumnName("RESV_CONF_LETTER_LTA")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvConfLetterStatus)
                .HasColumnName("RESV_CONF_LETTER_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ResvDate)
                .HasColumnName("RESV_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.Rt)
                .HasColumnName("RT")
                .IsUnicode(false);

            entity.Property(e => e.Sfullname)
                .HasColumnName("SFULLNAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxfullname)
                .HasColumnName("SXFULLNAME")
                .HasMaxLength(162)
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

            entity.Property(e => e.Xfullname)
                .HasColumnName("XFULLNAME")
                .HasMaxLength(82)
                .IsUnicode(false);
        });
	}
}

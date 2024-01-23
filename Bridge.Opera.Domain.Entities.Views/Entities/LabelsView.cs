namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LabelsView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal GuestNameId { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string SguestName { get; set; }
    public string GuestLanguage { get; set; }
    public decimal? Nights { get; set; }
    public string CompanyName { get; set; }
    public string SourceName { get; set; }
    public string GroupName { get; set; }
    public string TravelAgentName { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string MarketCode { get; set; }
    public string VipStatus { get; set; }
    public string MailList { get; set; }
    public string MailType { get; set; }
    public DateTime? BirthDate { get; set; }
    public string CountryCode { get; set; }
    public string RoomDetail { get; set; }
    public string ZipCode { get; set; }
    public string BlockCode { get; set; }
    public string RoomClass { get; set; }
    public string Room { get; set; }
    public string XlastName { get; set; }
    public string XfirstName { get; set; }
    public string XcompanyName { get; set; }
    public string XtravelAgentName { get; set; }
    public string XgroupName { get; set; }
    public string XsourceName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LabelsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LABELS_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguage)
                .HasColumnName("GUEST_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MailType)
                .HasColumnName("MAIL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomDetail)
                .HasColumnName("ROOM_DETAIL")
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XcompanyName)
                .HasColumnName("XCOMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XgroupName)
                .HasColumnName("XGROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XsourceName)
                .HasColumnName("XSOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.XtravelAgentName)
                .HasColumnName("XTRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}

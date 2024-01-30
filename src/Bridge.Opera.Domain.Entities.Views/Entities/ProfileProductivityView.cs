namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileProductivityView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomResort { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public string? GuestName { get; set; }
    public string? GuestCountry { get; set; }
    public string? GuestCountryDesc { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? AddressId { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public DateTime? TruncActualCheckOutDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? TravelAgentName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string? SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? Room { get; set; }
    public DateTime? ReservationDate { get; set; }
    public DateTime? RoomReservationDate { get; set; }
    public decimal? ShareId { get; set; }
    public decimal? ResvNo { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? SguestName { get; set; }
    public decimal? PrimaryYn { get; set; }
    public string? BlockCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileProductivityView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_PRODUCTIVITY_VIEW");

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

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
                .HasColumnType("DATE");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountryDesc)
                .HasColumnName("GUEST_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
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

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomReservationDate)
                .HasColumnName("ROOM_RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckOutDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}

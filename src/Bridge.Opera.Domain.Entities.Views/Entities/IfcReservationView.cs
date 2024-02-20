namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcReservationView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomResort { get; set; }
    public string? ResvStatus { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? BlockCode { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? Room { get; set; }
    public string? SguestName { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? SfirstGuestName { get; set; }
    public string? Vip { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? SharedYn { get; set; }
    public string? GuestTitle { get; set; }
    public string? Sxname { get; set; }
    public string? XlastName { get; set; }
    public string? XfirstName { get; set; }
    public string? XcompanyName { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? MasterShare { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcReservationView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_RESERVATION_VIEW");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
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

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
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

            entity.Property(e => e.MasterShare)
                .HasColumnName("MASTER_SHARE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
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

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XcompanyName)
                .HasColumnName("XCOMPANY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}

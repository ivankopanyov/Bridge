namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcWakeView
{
    public string? RoomNo { get; set; }
    public string? RoomClass { get; set; }
    public string? GuestName { get; set; }
    public string? GroupName { get; set; }
    public DateTime? WakeDate { get; set; }
    public string? WakeTime { get; set; }
    public string? Status { get; set; }
    public DateTime? SetDate { get; set; }
    public string? SetTime { get; set; }
    public string? SetBy { get; set; }
    public DateTime? ResDate { get; set; }
    public string? ResTime { get; set; }
    public string? FirstName { get; set; }
    public string? GroupCode { get; set; }
    public string? SguestName { get; set; }
    public string? SfirstName { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? Resort { get; set; }
    public string? RoomResort { get; set; }
    public string? ResvStatus { get; set; }
    public string? RoomNumber { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Result { get; set; }
    public string? ResortW { get; set; }
    public DateTime? WakeTimeDate { get; set; }
    public string? ExtnNum { get; set; }
    public string? BlockCode { get; set; }
    public string? Vip { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? SharedYn { get; set; }
    public string? GuestTitle { get; set; }
    public string? Sxname { get; set; }
    public string? XlastName { get; set; }
    public string? XfirstName { get; set; }
    public string? XcompanyName { get; set; }
    public string? SpecialInstructions { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? MasterShare { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? DisplayStatus { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? WakeupCallId { get; set; }
    public string? FollowUpCallYn { get; set; }
    public decimal? ParentCallId { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcWakeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_WAKE_VIEW");

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

            entity.Property(e => e.DisplayStatus)
                .HasColumnName("DISPLAY_STATUS")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.ExtnNum)
                .HasColumnName("EXTN_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FollowUpCallYn)
                .HasColumnName("FOLLOW_UP_CALL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
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

            entity.Property(e => e.ParentCallId)
                .HasColumnName("PARENT_CALL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDate)
                .HasColumnName("RES_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResTime)
                .HasColumnName("RES_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortW)
                .HasColumnName("RESORT_W")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Result)
                .HasColumnName("RESULT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
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

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetBy)
                .HasColumnName("SET_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SetDate)
                .HasColumnName("SET_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SetTime)
                .HasColumnName("SET_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.SfirstName)
                .HasColumnName("SFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.SpecialInstructions)
                .HasColumnName("SPECIAL_INSTRUCTIONS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
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

            entity.Property(e => e.WakeDate)
                .HasColumnName("WAKE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WakeTime)
                .HasColumnName("WAKE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.WakeTimeDate)
                .HasColumnName("WAKE_TIME_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WakeupCallId)
                .HasColumnName("WAKEUP_CALL_ID")
                .HasColumnType("NUMBER");

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

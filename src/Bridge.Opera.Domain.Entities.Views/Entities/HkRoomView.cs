namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkRoomView
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? Description { get; set; }
    public string? RoomCategory { get; set; }
    public string? SuiteType { get; set; }
    public string? RoomStatus { get; set; }
    public DateTime? RmStatusFromDate { get; set; }
    public DateTime? RmStatusToDate { get; set; }
    public string? RmStatusReason { get; set; }
    public string? ReturnStatus { get; set; }
    public decimal? FoPers { get; set; }
    public string? FoStatus { get; set; }
    public string? Floor { get; set; }
    public string? Building { get; set; }
    public string? AssignType { get; set; }
    public string? AssignReason { get; set; }
    public string? AssignStatus { get; set; }
    public string? OccupancyCondition { get; set; }
    public string? HkStatus { get; set; }
    public decimal? HkPers { get; set; }
    public string? HkInspFlag { get; set; }
    public DateTime? HkInspDate { get; set; }
    public string? HkInspEmpId { get; set; }
    public string? HkSectionCode { get; set; }
    public decimal? Credits { get; set; }
    public string? Class { get; set; }
    public string? Type { get; set; }
    public string? RoomStatusDesc { get; set; }
    public string? Features { get; set; }
    public decimal? ReservationStatus { get; set; }
    public decimal? OccupantDiscrepancy { get; set; }
    public decimal? PersonDiscrepancy { get; set; }
    public string? SmokingPreference { get; set; }
    public string? HkEveningSection { get; set; }
    public string? PseudoYn { get; set; }
    public string? MeetingroomYn { get; set; }
    public string? ServiceStatus { get; set; }
    public decimal? CreditsTurndown { get; set; }
    public string? ComboYn { get; set; }
    public DateTime? HoldDateTime { get; set; }
    public decimal? HoldUser { get; set; }
    public string? Comments { get; set; }
    public decimal? NoOfBeds { get; set; }
    public DateTime? LastCheckOutDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkRoomView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_ROOM_VIEW");

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignStatus)
                .HasColumnName("ASSIGN_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Class)
                .IsRequired()
                .HasColumnName("CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComboYn)
                .HasColumnName("COMBO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsTurndown)
                .HasColumnName("CREDITS_TURNDOWN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Features)
                .HasColumnName("FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .IsUnicode(false);

            entity.Property(e => e.FoPers)
                .HasColumnName("FO_PERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkEveningSection)
                .HasColumnName("HK_EVENING_SECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkInspDate)
                .HasColumnName("HK_INSP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HkInspEmpId)
                .HasColumnName("HK_INSP_EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkInspFlag)
                .IsRequired()
                .HasColumnName("HK_INSP_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HkPers)
                .HasColumnName("HK_PERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HkSectionCode)
                .HasColumnName("HK_SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkStatus)
                .IsRequired()
                .HasColumnName("HK_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoldDateTime)
                .HasColumnName("HOLD_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.HoldUser)
                .HasColumnName("HOLD_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastCheckOutDate)
                .HasColumnName("LAST_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MeetingroomYn)
                .HasColumnName("MEETINGROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoOfBeds)
                .HasColumnName("NO_OF_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupancyCondition)
                .HasColumnName("OCCUPANCY_CONDITION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OccupantDiscrepancy)
                .HasColumnName("OCCUPANT_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PersonDiscrepancy)
                .HasColumnName("PERSON_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnStatus)
                .HasColumnName("RETURN_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusFromDate)
                .HasColumnName("RM_STATUS_FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RmStatusReason)
                .HasColumnName("RM_STATUS_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusToDate)
                .HasColumnName("RM_STATUS_TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatusDesc)
                .HasColumnName("ROOM_STATUS_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ServiceStatus)
                .HasColumnName("SERVICE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SmokingPreference)
                .HasColumnName("SMOKING_PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SuiteType)
                .HasColumnName("SUITE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

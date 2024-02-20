namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepHkAllRoomView
{
    public string? Resort { get; set; }
    public string? RoomNo { get; set; }
    public string? Room { get; set; }
    public string? Description { get; set; }
    public string? RoomCategory { get; set; }
    public string? SuiteType { get; set; }
    public string? RoomStatus { get; set; }
    public DateTime? RmStatusFromDate { get; set; }
    public DateTime? RmStatusToDate { get; set; }
    public string? RmStatusReason { get; set; }
    public string? ReturnStatus { get; set; }
    public string? FoPers { get; set; }
    public string? FoStatus { get; set; }
    public string? Floor { get; set; }
    public string? Building { get; set; }
    public string? AssignType { get; set; }
    public string? AssignReason { get; set; }
    public string? AssignStatus { get; set; }
    public string? AssignDesc { get; set; }
    public string? AssignUser { get; set; }
    public string? AssignDate { get; set; }
    public string? AssignTime { get; set; }
    public string? OccupancyCondition { get; set; }
    public string? HkStatus { get; set; }
    public decimal? HkPers { get; set; }
    public string? HkInspFlag { get; set; }
    public DateTime? HkInspDate { get; set; }
    public string? HkInspEmpId { get; set; }
    public string? HkSectionCode { get; set; }
    public string? Class { get; set; }
    public string? RoomType { get; set; }
    public string? RoomStatusDesc { get; set; }
    public string? Features { get; set; }
    public decimal? OccupantDiscrepancy { get; set; }
    public string? OccDicrepancyDesc { get; set; }
    public decimal? PersonDiscrepancy { get; set; }
    public string? PersonDiscrepancyDesc { get; set; }
    public string? Housekeeping { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepHkAllRoomView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_HK_ALL_ROOM_VIEW");

            entity.Property(e => e.AssignDate)
                .HasColumnName("ASSIGN_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.AssignDesc)
                .HasColumnName("ASSIGN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignStatus)
                .HasColumnName("ASSIGN_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AssignTime)
                .HasColumnName("ASSIGN_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignUser)
                .HasColumnName("ASSIGN_USER")
                .IsUnicode(false);

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Class)
                .HasColumnName("CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Features)
                .HasColumnName("FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoPers)
                .HasColumnName("FO_PERS")
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
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

            entity.Property(e => e.Housekeeping)
                .HasColumnName("HOUSEKEEPING")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OccDicrepancyDesc)
                .HasColumnName("OCC_DICREPANCY_DESC")
                .HasMaxLength(18)
                .IsUnicode(false);

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

            entity.Property(e => e.PersonDiscrepancyDesc)
                .HasColumnName("PERSON_DISCREPANCY_DESC")
                .HasMaxLength(16)
                .IsUnicode(false);

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

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.RoomStatusDesc)
                .HasColumnName("ROOM_STATUS_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuiteType)
                .HasColumnName("SUITE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}

namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class WorkOrdersView
{
    public decimal? WoNumber { get; set; }
    public DateTime? CreatedDate { get; set; }
    public decimal? CreatedBy { get; set; }
    public string? ProblemDesc { get; set; }
    public decimal? AssignedBy { get; set; }
    public DateTime? AssignedOnDate { get; set; }
    public decimal? AssignedTo { get; set; }
    public decimal? TakenBy { get; set; }
    public DateTime? TakenDate { get; set; }
    public decimal? ReleasedBy { get; set; }
    public DateTime? ReleasedDate { get; set; }
    public decimal? CompletedBy { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? DueDate { get; set; }
    public decimal? TotalLaborCost { get; set; }
    public decimal? TotalPartsCost { get; set; }
    public string? UserExt { get; set; }
    public string? DeptOfAction { get; set; }
    public string? GuestRoomYn { get; set; }
    public string? GuestOriginatedYn { get; set; }
    public string? PriorityChangedYn { get; set; }
    public decimal? EstTimeToComplete { get; set; }
    public string? Resort { get; set; }
    public string? CategoryCode { get; set; }
    public string? ReasonCode { get; set; }
    public string? LocationCode { get; set; }
    public string? PriorityCode { get; set; }
    public decimal? ParentWoNumber { get; set; }
    public string? StatusCode { get; set; }
    public decimal? TaskCode { get; set; }
    public decimal? TaskitemNumber { get; set; }
    public string? TypeCode { get; set; }
    public string? PlantItemCode { get; set; }
    public string? EstUotCode { get; set; }
    public decimal? DependingOnWoNumber { get; set; }
    public string? MasterSub { get; set; }
    public string? Room { get; set; }
    public string? Notes { get; set; }
    public string? LocationDesc { get; set; }
    public string? PriorityDesc { get; set; }
    public string? WorkCategoryDesc { get; set; }
    public string? PlantItemDesc { get; set; }
    public string? StatusDesc { get; set; }
    public string? ReasonDesc { get; set; }
    public string? TaskDesc { get; set; }
    public string? EstUotDesc { get; set; }
    public string? CreatedByUser { get; set; }
    public string? TakenByUser { get; set; }
    public string? AssignedByUser { get; set; }
    public string? AssignedToUser { get; set; }
    public string? ReleasedByUser { get; set; }
    public string? CompletedByUser { get; set; }
    public decimal? DurationWorked { get; set; }
    public string? DurationWorkedUot { get; set; }
    public string? DurationWorkedUotDesc { get; set; }
    public string? ColorCode { get; set; }
    public decimal? LatestUserId { get; set; }
    public string? LatestUser { get; set; }
    public DateTime? LatestDate { get; set; }
    public decimal? Age { get; set; }
    public decimal? PrioritySeqNumber { get; set; }
    public decimal? PpStatusCode { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PrivateYn { get; set; }
    public string? FoRoomStatus { get; set; }
    public string? GuestInRoomYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? ShowOn { get; set; }
    public string? TypeDisplay { get; set; }
    public string? FoStatusDisplay { get; set; }
    public decimal? OntimeColorCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkOrdersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("WORK_ORDERS_VIEW");

            entity.Property(e => e.Age)
                .HasColumnName("AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssignedBy)
                .HasColumnName("ASSIGNED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignedByUser)
                .HasColumnName("ASSIGNED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.AssignedOnDate)
                .HasColumnName("ASSIGNED_ON_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignedTo)
                .HasColumnName("ASSIGNED_TO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignedToUser)
                .HasColumnName("ASSIGNED_TO_USER")
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColorCode)
                .HasColumnName("COLOR_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompletedBy)
                .HasColumnName("COMPLETED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedByUser)
                .HasColumnName("COMPLETED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedByUser)
                .HasColumnName("CREATED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DependingOnWoNumber)
                .HasColumnName("DEPENDING_ON_WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptOfAction)
                .HasColumnName("DEPT_OF_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DurationWorked)
                .HasColumnName("DURATION_WORKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationWorkedUot)
                .HasColumnName("DURATION_WORKED_UOT")
                .IsUnicode(false);

            entity.Property(e => e.DurationWorkedUotDesc)
                .HasColumnName("DURATION_WORKED_UOT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EstTimeToComplete)
                .HasColumnName("EST_TIME_TO_COMPLETE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstUotCode)
                .HasColumnName("EST_UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstUotDesc)
                .HasColumnName("EST_UOT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FoRoomStatus)
                .HasColumnName("FO_ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FoStatusDisplay)
                .HasColumnName("FO_STATUS_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.GuestInRoomYn)
                .HasColumnName("GUEST_IN_ROOM_YN")
                .IsUnicode(false);

            entity.Property(e => e.GuestOriginatedYn)
                .HasColumnName("GUEST_ORIGINATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestRoomYn)
                .HasColumnName("GUEST_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LatestDate)
                .HasColumnName("LATEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LatestUser)
                .HasColumnName("LATEST_USER")
                .IsUnicode(false);

            entity.Property(e => e.LatestUserId)
                .HasColumnName("LATEST_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MasterSub)
                .HasColumnName("MASTER_SUB")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OntimeColorCode)
                .HasColumnName("ONTIME_COLOR_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentWoNumber)
                .HasColumnName("PARENT_WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PlantItemDesc)
                .HasColumnName("PLANT_ITEM_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PpStatusCode)
                .HasColumnName("PP_STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorityChangedYn)
                .HasColumnName("PRIORITY_CHANGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriorityDesc)
                .HasColumnName("PRIORITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PrioritySeqNumber)
                .HasColumnName("PRIORITY_SEQ_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrivateYn)
                .HasColumnName("PRIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProblemDesc)
                .HasColumnName("PROBLEM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReasonDesc)
                .HasColumnName("REASON_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ReleasedBy)
                .HasColumnName("RELEASED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReleasedByUser)
                .HasColumnName("RELEASED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.ReleasedDate)
                .HasColumnName("RELEASED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowOn)
                .HasColumnName("SHOW_ON")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatusDesc)
                .HasColumnName("STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TakenBy)
                .HasColumnName("TAKEN_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TakenByUser)
                .HasColumnName("TAKEN_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.TakenDate)
                .HasColumnName("TAKEN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskDesc)
                .HasColumnName("TASK_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalLaborCost)
                .HasColumnName("TOTAL_LABOR_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalPartsCost)
                .HasColumnName("TOTAL_PARTS_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeDisplay)
                .HasColumnName("TYPE_DISPLAY")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserExt)
                .HasColumnName("USER_EXT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WorkCategoryDesc)
                .HasColumnName("WORK_CATEGORY_DESC")
                .IsUnicode(false);
        });
	}
}
